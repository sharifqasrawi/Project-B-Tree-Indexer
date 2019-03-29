using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace IR_Btree_Indexer.Presentation
{
    public partial class AddNewDocumentForm : Form
    {
        BTree<String, String> btree;
        dbEntities dbContext;
        int treeDegree = 15;
        public AddNewDocumentForm()
        {
            InitializeComponent();
            dbContext = new dbEntities();
        }

        private void BuildBTreeFromDB()
        {
            btree = null;
            btree = new BTree<string, string>(treeDegree);

            var words = dbContext.Words.Include("DocsWords").ToList();
            foreach (Word word in words)
            {
                Entry<string, string> entry = null;
                foreach (var docWord in word.DocsWords.ToList())
                {
                    if (entry == null)
                    {
                        btree.Insert(word.Word1, "" + docWord.DocId);
                        entry = btree.Search(word.Word1);
                    }
                    else
                    {
                        entry.Pointer += " " + docWord.DocId;
                    }
                }
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            fd.Filter = "Text Files|*.txt";
            fd.Title = "Add new document";
            DialogResult dr = fd.ShowDialog();

            results2Text.Clear();
            string fileName, fileContents;

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                fileName = fd.SafeFileName;
                try
                {
                    // read all text file into fileContents
                    fileContents = File.ReadAllText(fd.FileName);
                    results2Text.AppendText("File loaded: " + fileName + "\n");
                    results2Text.AppendText("---------------------------------------\n\n");
                    if (!string.IsNullOrEmpty(fileContents))
                    {
                        String[] words = Regex.Split(fileContents, @"[^a-zA-Z]+");
                        results2Text.AppendText("There are " + words.Length + " words in the file.\n");
                        results2Text.AppendText("---------------------------------------\n\n");

                        Doc doc = new Doc();
                        doc.Name = words[0].ToLower();
                        doc.File = fileName;
                        dbContext.Docs.Add(doc);
                        dbContext.SaveChanges();

                        results2Text.AppendText("Document " + doc.Name + " is saved with the Id : " + doc.Id + "\n");

                        //define a list of <word, positions> composition
                        List<WordOccurrences> fileIndex = new List<WordOccurrences>();

                        //pass throughout all words in document
                        for (int pos = 1; pos < words.Length; pos++)
                        {
                            string w = words[pos - 1].ToLower();
                            bool found = false;
                            foreach (var wo in fileIndex)
                            {
                                if (w.Equals(wo.Word, StringComparison.InvariantCultureIgnoreCase))
                                {
                                    wo.Locations.Add(pos);
                                    found = true;
                                    break;
                                }
                            }

                            //Check if the word previously added to words list
                            if (!found)
                            {
                                WordOccurrences wo = new WordOccurrences(w);
                                wo.Locations.Add(pos);
                                fileIndex.Add(wo);
                            }
                        }

                        foreach (WordOccurrences wo in fileIndex)
                        {
                            Word word = dbContext.Words.SingleOrDefault(w => w.Word1.Equals(wo.Word, StringComparison.InvariantCultureIgnoreCase));
                            if (word == null)
                            {
                                word = new Word();
                                word.Word1 = wo.Word;
                                dbContext.Words.Add(word);
                                dbContext.SaveChanges();
                            }

                            int count = wo.Locations.Count;
                            string locations = String.Join(",", wo.Locations);
                            dbContext.DocsWords1.Add(new DocsWords
                            {
                                DocId = doc.Id,
                                WordId = word.Id,
                                Locations = locations
                            });
                        }
                        dbContext.SaveChanges();

                        BuildBTreeFromDB();

                    }
                    else
                        results2Text.AppendText("File is empty...\n");

                }
                catch (Exception ex)
                {
                    results2Text.AppendText("Error:\n" + ex.Message + "\n");
                }
            }
            else
                results2Text.AppendText("No file selected...\n");
        }
    }
}
