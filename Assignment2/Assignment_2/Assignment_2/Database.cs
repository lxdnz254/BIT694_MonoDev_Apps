using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public class Database
    {
        private NewWordsDataSet nwDataSet; // An instance variable pointing at the DataSet

        // Constructor for Database class, requires a NewWordsDataSet to be passed as an argument
        public Database(NewWordsDataSet dataSet)
        {
            this.nwDataSet = dataSet; // instantiates the passed dataSet for the class methods to use
        }


        public void AddEntry(string word, string synonyms)
        {
            try
            {
                DataRow newRow = nwDataSet.Tables["Words"].NewRow();
                // ToLower() ensures the new entry is inserted in lower case
                newRow["Word"] = word.ToLower();
                newRow["Synonyms"] = synonyms.ToLower();
                
                // Add the newRow
                nwDataSet.Tables["Words"].Rows.Add(newRow);
                MessageBox.Show("New entry added to the database!");
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured: " + error);
            }
        }

        public void DeleteEntry(string word)
        {
            try
            {
                NewWordsDataSet.WordsRow wordsRow = nwDataSet.Words.FindByWord(word.ToLower());
                wordsRow.Delete();
                MessageBox.Show("Deleted entry!");
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured: " + error);
            }
        }

        public void UpdateEntry(string word, string synonyms)
        {
            try
            {
                NewWordsDataSet.WordsRow wordsRow = nwDataSet.Words.FindByWord(word.ToLower());
                wordsRow.Synonyms = synonyms.ToLower();
                MessageBox.Show("Updated entry!");
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured: " + error);
            }
        }

        public string QueryEntry(string term)
        {
            string str;

            List<string> queryList = GetSynonyms(term);

            if (queryList != null)
            {
                str = "";
                foreach (string s in queryList)
                {
                    str += s + "\r\n";
                }
                
            }
            else
            {
                str = "No results returned.";
            }

            return str;

        }

        // seperate method to call list of synonyms from a word (can be used by any class that has a Database class object)
        public List<string> GetSynonyms(string term)
        {
            List<string> list = new List<string>();
            
            try
            {
                NewWordsDataSet.WordsRow wordsRow = nwDataSet.Words.FindByWord(term);

                if (wordsRow != null)
                {
                    string[] strList = wordsRow.Synonyms.ToString().Split(',');
                    foreach (string s in strList)
                    {
                        list.Add(s);
                    }
                }
                else
                {
                    list = null;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("An error has occured: " + error);
            }
           
            return list;
        }
    }
}
