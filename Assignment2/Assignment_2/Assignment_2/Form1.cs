using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        private int searchCount; // counts the number of searches performed
        private int fileCount; // the number of files containing all queries found in a search
        private double totalSearchTime; // a running total of time spent searching
        private Database db; // a reference to the Database class
        private IndexUtilities indexUtils; // a reference to the IndexUtilities class
        private SearchUtilities searchUtil; // a reference to the SearchUtilities class
        //private Dictionary<string, Dictionary<int, double>> invertedIndex; // a reference to the invertedIndex
        private bool isIndexCreated; // a pointer for inverted index creation
        private Thread thread;
        private ThreadStart tStart;

        public Form1()
        {
            InitializeComponent(); // Auto-created methods .. do not alter anything in this method

            // Initialize or instantiate class objects or private variables for use in the form
            FileOutput.MouseDoubleClick += new MouseEventHandler(FileOutput_DoubleClick);
            db = new Database(newWordsDataSet);
            indexUtils = new IndexUtilities();
            searchUtil = new SearchUtilities();
            tStart = new ThreadStart(BuildIndex);
            thread = new Thread(tStart);
            searchCount = 0;
            totalSearchTime = 0;
            isIndexCreated = false;
        }

        /*
         * The search query section, select collection folder, 
         * search for terms in collection, output files with terms
         * or synonyms of terms, allow file to be openable.
         */ 

        /*
         * Select collection Folder
         */ 
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

        /*
         *  Search collection for ALL query terms using the terms to iterate over
         */
        private void Search_Click(object sender, EventArgs e)
        {
            string folderPath = FolderOutput.Text; // get the folderPath from output TextBox 
            string[] searchTerms = SearchTerms.Text.Split(' '); // Get the search terms
            
            
            // check a folderPath is inputted and check a search query is inputted
            if (folderPath != "" && !(searchTerms.Length < 2 && searchTerms[0] == ""))
            {
                FileOutput.Items.Clear(); // clear the file ListBox
                FrequencyBox.Clear(); // clear the frequency TextBox

                // start the timer on a search, this timer includes generating Hashtable,
                // searching the collection, and querying Hashtable for query frequencies
                var watch = System.Diagnostics.Stopwatch.StartNew();
                // increase searchCount
                searchCount++;
                // reset fileCount
                fileCount = 0;
                
                /*
                 * Modularised methods to get querys
                 */

                Hashtable wf = indexUtils.GetHashtable(folderPath); //the Hashtable generated on search.

                // Get the files containing the search terms using iterating over terms method and output
                List<string> containFiles = searchUtil.GetFilesContainingTermsByTerms(folderPath, searchTerms, 
                                                                    CheckSynonyms.Checked, newWordsDataSet);
                foreach(string file in containFiles)
                {
                    FileOutput.Items.Add(file);
                    fileCount++;
                }

                /*
                 *  Output from the Hashtable - query terms and their frequency, plus the
                 *  word in the entire collection with the highest frequency
                 */

                // output the maximum frequency word
                MostFrequentBox.Text = indexUtils.GetMax(wf);
                // output the query terms frequency (if they exist)
                FrequencyBox.Text = indexUtils.QueryFrequency(wf, searchTerms);
                
                // end of the search process
                watch.Stop();
                // get the results of stopWatch.
                var elapsedTime = watch.ElapsedMilliseconds;
                totalSearchTime += elapsedTime;
                // Output search times and number of found files to the Form
                SearchTime.Text = "Search Time: " + elapsedTime.ToString() + "ms";
                AverageTime.Text = "Average Time: " + (totalSearchTime / searchCount).ToString("0") + "ms";
                FoundFiles.Text = "Files Found: " + fileCount;

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
         * Search collection for ALL the query terms iterating over the files
         * This is now searching the Inverted Index
         */
        private void SearchByFiles_Click(object sender, EventArgs e)
        {
            string folderPath = FolderOutput.Text; // get the folderPath from output TextBox 
            string[] searchTerms = SearchTerms.Text.Split(' '); // Get the search terms
            List<string> containFiles = new List<string>();

            // check a folderPath is inputted and check a search query is inputted
            if (folderPath != "" && !(searchTerms.Length < 2 && searchTerms[0] == ""))
            {
                // checks if thread building index is running
                if (thread.IsAlive)
                {
                    MessageBox.Show("The index is currently rebuilding. Try again later");
                }
                else
                {
                    FileOutput.Items.Clear(); // clear the file ListBox
                    FrequencyBox.Clear(); // clear the frequency TextBox



                    // start the timer on a search, this timer includes generating Hashtable,
                    // searching the collection, and querying Hashtable for query frequencies
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    // increase searchCount
                    searchCount++;
                    // reset fileCount
                    fileCount = 0;

                    /*
                     * Modularised methods to get querys
                     */

                    // Hashtable wf = hashUtil.GetHashtable(folderPath); //the Hashtable generated on search.

                    //Check the inverted index is created
                    if (!isIndexCreated) { CreateInvertedIndex_Click(sender, e); }

                    // Get the files containing the search terms by reading the inverted index
                    if (CheckSynonyms.Checked)
                    {
                        containFiles = indexUtils.GetFilesFromIndexWithSynonyms(searchTerms, newWordsDataSet);
                    }
                    else
                    {
                        containFiles = indexUtils.GetFilesFromIndex(searchTerms);
                    }

                    if (containFiles != null)
                    {
                        foreach (string file in containFiles)
                        {
                            FileOutput.Items.Add(file);
                            fileCount++;
                        }
                    }
                    else
                    {
                        FileOutput.Items.Add("No search results found");
                    }


                    /*
                     *  Output from the Hashtable - query terms and their frequency, plus the
                     *  word in the entire collection with the highest frequency
                     */

                    // output the maximum frequency word
                    MostFrequentBox.Text = indexUtils.GetInvertedIndexMax();
                    // output the query terms frequency (if they exist)
                    FrequencyBox.Text = indexUtils.GetQueryFrequencyFromIndex(searchTerms);

                    // end of the search process
                    watch.Stop();
                    // get the results of stopWatch.
                    var elapsedTime = watch.ElapsedMilliseconds;
                    totalSearchTime += elapsedTime;
                    // Output search times and number of found files to the Form
                    SearchTime.Text = "Search Time: " + elapsedTime.ToString() + "ms";
                    AverageTime.Text = "Average Time: " + (totalSearchTime / searchCount).ToString("0") + "ms";
                    FoundFiles.Text = "Files Found: " + fileCount;
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

        // Open the file on a mouse double click
        private void FileOutput_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = FileOutput.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                if (!FileOutput.SelectedItem.ToString().Equals("No search results found"))
                {
                    System.Diagnostics.Process.Start(FileOutput.SelectedItem.ToString());
                }
                
            }
        }

        private void FileOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void CreateInvertedIndex_Click(object sender, EventArgs e)
        {
            if (thread.IsAlive)
            {
                MessageBox.Show("The index is currently busy. Please try again later");
            }
            else
            {
                thread = new Thread(tStart); // re-instantiates the thread if it already exists
                thread.Start(); // calls buildIndex on a new Thread
                isIndexCreated = true;
                CreateInvertedIndex.Text = "Refresh Index";
            } 
        }

        private void BuildIndex()
        {          
            indexUtils.internalIndex = indexUtils.InvertedIndex(FolderOutput.Text);
            ShowIndexLength();
        }

        internal void ShowIndexLength()
        {
            // outputs the number of terms in the invertedIndex if it exists
            if (indexUtils.internalIndex != null)
            {
                Action action = () => IndexLength.Text = "Index Size: " + indexUtils.indexCount;
                this.Invoke(action);
            }
        }

        /* 
         * The CRUD section of the Form methods start here.
         */

        // CREATE
        private void AddEntry_Click(object sender, EventArgs e)
        {
            db.AddEntry(AddEntryWord.Text, AddEntrySynonyms.Text);
            // Clear the entries
            AddEntryWord.Text = "";
            AddEntrySynonyms.Text = "";
            // Update the Table adapter
            wordsTableAdapter.Update(newWordsDataSet);
        }

        // READ
        private void QueryEntry_Click(object sender, EventArgs e)
        {
            QueryEntrySynonyms.Text = db.QueryEntry(QueryEntryWord.Text);
        }

        // UPDATE
        private void UpdateEntry_Click(object sender, EventArgs e)
        {
            db.UpdateEntry(UpdateEntryWord.Text, UpdateEntrySynonyms.Text);
            // clear the entries
            UpdateEntryWord.Text = "";
            UpdateEntrySynonyms.Text = "";
        }

        // DELETE
        private void DeleteEntry_Click(object sender, EventArgs e)
        {
            db.DeleteEntry(DeleteEntryWord.Text);
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
