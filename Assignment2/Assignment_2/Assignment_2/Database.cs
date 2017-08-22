using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public static class Database
    {
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
