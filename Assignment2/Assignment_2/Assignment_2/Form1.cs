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
            Hashtable wf = new Hashtable(); // The Hashtable generated on search.
            
            // check a folderPath is inputted and check a search query is inputted
            if (folderPath != "" && !(searchTerms.Length < 2 && searchTerms[0] == ""))
            {
                FileOutput.Items.Clear(); // clear the file ListBox
                FrequencyBox.Clear(); // clear the frequency TextBox

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
                            // create the Hashtable for the collection
                            if (wf.ContainsKey(word))
                            {
                                wf[word] = double.Parse(wf[word].ToString()) + 1;
                            }
                            else
                            {
                                wf.Add(word, 1.0);
                            }

                            // Search word over terms
                            int counter = 0; // counter for boolean array

                            foreach (string term in searchTerms)
                            {
                                if (CheckSynonyms.Checked)
                                {
                                    List<string> checkList = new List<string> { term.ToLower() };
                                    // get list of synonyms
                                    List<string> synonyms = Database.GetSynonyms(term, newWordsDataSet);
                                    if (synonyms != null)
                                    {
                                        foreach (string s in synonyms)
                                        {
                                            checkList.Add(s);
                                        }
                                    }
                                        
                                    // iterate over list
                                    foreach (string s in checkList)
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
            Database.AddEntry(AddEntryWord.Text, AddEntrySynonyms.Text, newWordsDataSet);
            // Clear the entries
            AddEntryWord.Text = "";
            AddEntrySynonyms.Text = "";
            // Update the Table adapter
            wordsTableAdapter.Update(newWordsDataSet);
        }

        private void DeleteEntry_Click(object sender, EventArgs e)
        {
            Database.DeleteEntry(DeleteEntryWord.Text, newWordsDataSet);
            // Clear the entry
            DeleteEntryWord.Text = "";          
        }

        private void UpdateEntry_Click(object sender, EventArgs e)
        {
            Database.UpdateEntry(UpdateEntryWord.Text, UpdateEntrySynonyms.Text, newWordsDataSet);
            // clear the entries
            UpdateEntryWord.Text = "";
            UpdateEntrySynonyms.Text = "";  
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
