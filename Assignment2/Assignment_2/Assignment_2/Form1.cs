using System;
using System.Collections;
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

        /*
         * The search query section, select collection folder 
         * & search for terms in collection
         */ 

        // Select collection Folder
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


        // Search collection for terms
        private void Search_Click(object sender, EventArgs e)
        {
            string folderPath = FolderOutput.Text; // get the folderPath from output TextBox 
            string[] searchTerms = SearchTerms.Text.Split(' '); // Get the search terms
            
            
            // check a folderPath is inputted and check a search query is inputted
            if (folderPath != "" && !(searchTerms.Length < 2 && searchTerms[0] == ""))
            {
                FileOutput.Items.Clear(); // clear the file ListBox
                FrequencyBox.Clear(); // clear the frequency TextBox

                /*
                 * Modularised methods to get querys
                 */

                Hashtable wf = HashtableOutput.GetHashtable(folderPath); //the Hashtable generated on search.

                // Get the files containing the search terms and output
                List<string> containFiles = ScanFolder.GetFilesContainingTerms(folderPath, searchTerms, 
                                                                    CheckSynonyms.Checked, newWordsDataSet);
                foreach(string file in containFiles)
                {
                    FileOutput.Items.Add(file);
                }

                /*  Output from the Hashtable - query terms and their frequency, plus the 
                    word in the entire collection with the highest frequency                        
                */
             
                // output the maximum frequency word
                MostFrequentBox.Text = HashtableOutput.GetMax(wf);
                // output the query terms frequency (if they exist)
                FrequencyBox.Text = HashtableOutput.QueryFrequency(wf, searchTerms);
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

        /* 
         * The CRUD section of the Form methods start here.
         */ 

        // CREATE
        private void AddEntry_Click(object sender, EventArgs e)
        {
            Database.AddEntry(AddEntryWord.Text, AddEntrySynonyms.Text, newWordsDataSet);
            // Clear the entries
            AddEntryWord.Text = "";
            AddEntrySynonyms.Text = "";
            // Update the Table adapter
            wordsTableAdapter.Update(newWordsDataSet);
        }

        // READ
        private void QueryEntry_Click(object sender, EventArgs e)
        {
            QueryEntrySynonyms.Text = Database.QueryEntry(QueryEntryWord.Text, newWordsDataSet);
        }

        // UPDATE
        private void UpdateEntry_Click(object sender, EventArgs e)
        {
            Database.UpdateEntry(UpdateEntryWord.Text, UpdateEntrySynonyms.Text, newWordsDataSet);
            // clear the entries
            UpdateEntryWord.Text = "";
            UpdateEntrySynonyms.Text = "";
        }

        // DELETE
        private void DeleteEntry_Click(object sender, EventArgs e)
        {
            Database.DeleteEntry(DeleteEntryWord.Text, newWordsDataSet);
            // Clear the entry
            DeleteEntryWord.Text = "";          
        }

        // Automatically installed by Visual Studio
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
    }
}
