using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public static class Database
    {

        public static void AddEntry(string word, string synonyms, NewWordsDataSet dataSet)
        {
            try
            {
                DataRow newRow = dataSet.Tables["Words"].NewRow();
                // ToLower() ensures the new entry is inserted in lower case
                newRow["Word"] = word.ToLower();
                newRow["Synonyms"] = synonyms.ToLower();
                
                // Add the newRow
                dataSet.Tables["Words"].Rows.Add(newRow);
                MessageBox.Show("New entry added to the database!");
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured: " + error);
            }
        }

        public static void DeleteEntry(string word, NewWordsDataSet dataSet)
        {
            try
            {
                NewWordsDataSet.WordsRow wordsRow = dataSet.Words.FindByWord(word.ToLower());
                wordsRow.Delete();
                MessageBox.Show("Deleted entry!");
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured: " + error);
            }
        }

        public static void UpdateEntry(string word, string synonyms, NewWordsDataSet dataSet)
        {
            try
            {
                NewWordsDataSet.WordsRow wordsRow = dataSet.Words.FindByWord(word.ToLower());
                wordsRow.Synonyms = synonyms.ToLower();
                MessageBox.Show("Updated entry!");
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured: " + error);
            }
        }

        public static string QueryEntry(string term, NewWordsDataSet dataSet)
        {
            string str;

            List<string> queryList = Database.GetSynonyms(term, dataSet);

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

        public static List<string> GetSynonyms(string term, NewWordsDataSet dataSet)
        {
            List<string> list = new List<string>();
            
            try
            {
                NewWordsDataSet.WordsRow wordsRow = dataSet.Words.FindByWord(term);

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
