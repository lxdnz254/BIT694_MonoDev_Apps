using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateDBConnectGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.small_NewWordsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'small_NewWordsDataSet.Words' table. You can move, or remove it, as needed.
            this.wordsTableAdapter.Fill(this.small_NewWordsDataSet.Words);

        }

        private void SynonymText_Click(object sender, EventArgs e)
        {

        }

        private void AddEntry_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = small_NewWordsDataSet.Tables["Words"].NewRow();
                newRow["Word"] = AddWord.Text;
                newRow["Synonyms"] = AddSynonym.Text;
                AddWord.Text = "";
                AddSynonym.Text = "";

                small_NewWordsDataSet.Tables["Words"].Rows.Add(newRow);
                wordsTableAdapter.Update(small_NewWordsDataSet);
                MessageBox.Show("New entry added to database!");
            }
            catch (Exception error)
            {
                MessageBox.Show("An error has occured: " + error);
            }
        }

        private void UpdateEntry_Click(object sender, EventArgs e)
        {
            try
            {
                Small_NewWordsDataSet.WordsRow wordsRow = small_NewWordsDataSet.Words.FindByWord(UpdateWord.Text);

                wordsRow.Synonyms = UpdateSynonyms.Text;
                MessageBox.Show("Updated row!");
            }
            catch (Exception error)
            {
                MessageBox.Show("An error has occured: " + error);
            }
        }

        private void DeleteEntry_Click(object sender, EventArgs e)
        {
            try
            {
                Small_NewWordsDataSet.WordsRow wordsRow = small_NewWordsDataSet.Words.FindByWord(DeleteWord.Text);
                wordsRow.Delete();
                MessageBox.Show("Deleted row!");
            }
            catch (Exception error)
            {
                MessageBox.Show("An error has occured: " + error);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Small_NewWordsDataSet.WordsRow wordsRow = small_NewWordsDataSet.Words.FindByWord(SearchWord.Text);
            if (wordsRow != null)
            {
                string[] strList = wordsRow.Synonyms.ToString().Split(',');
                string str = "";
                foreach (string s in strList)
                {
                    str += s + "\r\n";
                }
                SearchSynonyms.Text = str;
            }
            else
            {
                SearchSynonyms.Text = "No results";
            }
        }
    }
}
