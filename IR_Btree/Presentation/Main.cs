using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IR_Btree_Indexer
{
    public partial class Main : Form
    {
        BTree<String, String> btree;
        dbEntities dbContext;
        int treeDegree = 15;
        public Main()
        {
            InitializeComponent();
            dbContext = new dbEntities();
            BuildBTreeFromDB();

            toolStripStatusPcName.Text = System.Environment.MachineName.ToString();
            toolStripStatusDateTime.Text = DateTime.Now.ToLongDateString() + " | "+DateTime.Now.ToShortTimeString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
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

        //This method to search for a prefix word like (ww*).
        void WildCardSearch(string prefix)
        {
            List<Word> foundList = dbContext.Words.Where(w => w.Word1.StartsWith(prefix)).ToList();

            resultsText.Clear();
            if (prefix.Length == 0)
            {
                resultsText.AppendText("Empty string to search.\n");
                return;
            }

            if (foundList != null && foundList.Count > 0d)
            {


                resultsText.AppendText("Wild card (" + prefix + "*) is found in indexes:\n\n");
                string formatter = "{0,-15}{1,-20}{2,-50}\n";

                resultsText.AppendText(String.Format(formatter, "Word", "Documents IDs", "Documents Names"));
                resultsText.AppendText("-----------------------------------------------------------------\n\n");
                foreach (var word in foundList)
                {
                    string docNames = "", docIds = "";
                    foreach (var docsWord in word.DocsWords)
                    {
                        docIds += docsWord.DocId.ToString() + " ";
                        docNames += docsWord.Doc.Name + " ";
                    }

                    resultsText.AppendText(String.Format(formatter, word.Word1, docIds, docNames));

                    wildText.Clear();
                    wildText.Focus();
                }
            }
            else
                resultsText.AppendText("Wild card (" + prefix + "*) is not found.\n");
        }

        private void wordBtn_Click(object sender, EventArgs e)
        {
            string word = wordText.Text.Trim().ToLower();
            resultsText.Clear();
            if (word.Length == 0)
            {
                resultsText.AppendText("Empty string to search.\n");
                return;
            }

            Entry<string, string> result = btree.Search(word);
            if (result != null)
            {
                string[] docIds = result.Pointer.Split(' ');

                resultsText.AppendText("Word(" + word + ") is found in " + result.Pointer + " indexes:\n\n");
                string formatter = "{0,-6}{1,-20}{2,-20}\n";

                resultsText.AppendText(String.Format(formatter, "Id", "Name", "Locations"));
                resultsText.AppendText("-------------------------------------------------------------\n\n");
                foreach (var id in docIds)
                {
                    int id1 = int.Parse(id);
                    Doc doc = dbContext.Docs.SingleOrDefault(d => d.Id == id1);
                    DocsWords docWords = doc.DocsWords.SingleOrDefault(dw => dw.Word.Word1.Equals(word));
                    resultsText.AppendText(String.Format(formatter, doc.Id, doc.Name, docWords.Locations));
                }
                wordText.Clear();
                wordText.Focus();
            }
            else
                resultsText.AppendText("Word(" + word + ") is not found.\n");
        }

        private void wildBtn_Click(object sender, EventArgs e)
        {
            string prefix = wildText.Text.Trim().ToLower();
            prefix = prefix.Split('*')[0].Trim();

            WildCardSearch(prefix);
        }

        private void addADocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR_Btree_Indexer.Presentation.AddNewDocumentForm frm = new Presentation.AddNewDocumentForm();
            frm.ShowDialog();
        }

        private void browseDocumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR_Btree_Indexer.Presentation.BrowseDocumentsForm frm = new Presentation.BrowseDocumentsForm();
            frm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR_Btree_Indexer.Presentation.About frm = new Presentation.About();
            frm.ShowDialog();
        }

        private void btnClearRes_Click(object sender, EventArgs e)
        {
            resultsText.Clear();
        }
    }
}
