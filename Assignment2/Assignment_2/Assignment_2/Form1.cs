using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Select the folder
                string folderPath = folderBrowserDialog1.SelectedPath;
                FolderOutput.Clear();
                FolderOutput.Text += folderPath; // output folder to textBox
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string folderPath = FolderOutput.Text; // get the folderPath from output TextBox 
            string[] searchTerms = SearchTerms.Text.Split(' '); // Get the search terms

            // check a folderPath is inputted and check a search query is inputted
            if (folderPath != "" && !(searchTerms.Length < 2 && searchTerms[0] == ""))
            {
                FileOutput.Items.Clear(); // clear the file ListBox

                // Add the main folder
                List<string> folders = new List<string>
                {
                    folderPath // in case there are files inside the folder
                };

                // Add the folders inside the folder
                string[] subFolders = Directory.GetDirectories(folderPath);
                foreach (string sub in subFolders)
                {
                    folders.Add(sub);
                }

                // iterate over each folder
                foreach (string folder in folders)
                {
                    // get the list of files from each folder
                    string[] files = Directory.GetFiles(folder);

                    foreach (string file in files)
                    {                       
                        bool[] isInFile = new bool[searchTerms.Length]; // array for true/false search terms
                        List<string> fileWords = ReadFromFile.GetWords(file); // Read the file and return list of words

                        foreach (string word in fileWords)
                        {
                            int counter = 0; // counter for boolean array

                            foreach (string term in searchTerms)
                            {
                                if (CheckSynonyms.Checked)
                                {
                                    // get list of synonyms
                                    List<string> synonyms = Database.GetSynonyms(term, newWordsDataSet);
                                    synonyms.Add(term.ToLower()); //add query term to list
                                    // iterate over list
                                    foreach (string s in synonyms)
                                    {
                                        if (word.Equals(s))
                                        {
                                            isInFile[counter] = true; //mark this term or synonyms as true
                                        }
                                    }
                                } 
                                else
                                {
                                    if (word.Equals(term.ToLower()))
                                    {
                                        isInFile[counter] = true; // mark this term as true
                                    }
                                }
                                counter++;
                            }
                        }

                        if(isInFile.All(x => x)) // tests if ALL search terms are true
                        {
                            FileOutput.Items.Add(file); // add file to the listBox if true
                        }
                        
                    }
                }
            }
            else
            {
                if (folderPath == "")
                {
                    MessageBox.Show("No folder has been selected!");
                }
                else
                {
                    MessageBox.Show("No search query entered");
                }
                
            }
            
        }

        private void wordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.newWordsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newWordsDataSet.Words' table. You can move, or remove it, as needed.
            this.wordsTableAdapter.Fill(this.newWordsDataSet.Words);

        }

        private void AddEntry_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = newWordsDataSet.Tables["Words"].NewRow();
                // ToLower() ensures the new entry is inserted in lower case
                newRow["Word"] = AddEntryWord.Text.ToLower();
                newRow["Synonyms"] = AddEntrySynonyms.Text.ToLower();
                // Clear the entries
                AddEntryWord.Text = "";
                AddEntrySynonyms.Text = "";
                // Add the newRow
                newWordsDataSet.Tables["Words"].Rows.Add(newRow);
                wordsTableAdapter.Update(newWordsDataSet);
                MessageBox.Show("New entry added to the database!");
            }
            catch(Exception error)
            {
                MessageBox.Show("An error occured: " + error);
            }
        }

        private void DeleteEntry_Click(object sender, EventArgs e)
        {
            try
            {
                NewWordsDataSet.WordsRow wordsRow = newWordsDataSet.Words.FindByWord(DeleteEntryWord.Text);
                wordsRow.Delete();
                MessageBox.Show("Deleted entry!");
                DeleteEntryWord.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured: " + error);
            }
        }

        private void UpdateEntry_Click(object sender, EventArgs e)
        {
            try
            {
                NewWordsDataSet.WordsRow wordsRow = newWordsDataSet.Words.FindByWord(UpdateEntryWord.Text);
                wordsRow.Synonyms = UpdateEntrySynonyms.Text;
                MessageBox.Show("Updated entry!");
                UpdateEntryWord.Text = "";
                UpdateEntrySynonyms.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured: " + error);
            }
        }

        private void QueryEntry_Click(object sender, EventArgs e)
        {
            List<string> queryList = Database.GetSynonyms(QueryEntryWord.Text, newWordsDataSet);

            if (queryList != null)
            {
                string str = "";
                foreach (string s in queryList)
                {
                    str += s + "\r\n";
                }
                QueryEntrySynonyms.Text = str;
            }
            else
            {
                QueryEntrySynonyms.Text = "No results returned.";
            }
        }
    }
}
