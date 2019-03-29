using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IR_Btree_Indexer.Presentation
{
    public partial class BrowseDocumentsForm : Form
    {
        dbEntities dbContext;
        public BrowseDocumentsForm()
        {
            InitializeComponent();
            dbContext = new dbEntities();
        }

        private void BrowseDocumentsForm_Load(object sender, EventArgs e)
        {
            List<Doc> docs = dbContext.Docs.ToList();

            //Clear result text area
            results2Text.Clear();
            if (docs.Count == 0)
            {
                results2Text.AppendText("No documents in database\n");
                return;
            }

            //formatter to write in a table manner
            string formatter = "{0,-6}{1,-20}{2,-20}{3}\n";

            results2Text.AppendText(String.Format(formatter, "Id", "Name", "File", "Words Count"));
            results2Text.AppendText("------------------------------------------------------\n\n");

            //Print each document to result area
            foreach (Doc doc in docs)
            {
                //Get count of the words of the document for statistics info
                int wordsInDocument = doc.DocsWords.Count;

                //Append Doc info to result
                results2Text.AppendText(String.Format(formatter, doc.Id, doc.Name, doc.File, wordsInDocument));
            }
        }
    }
}
