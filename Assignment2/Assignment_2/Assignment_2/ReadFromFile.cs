using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    // This class is static as it not manipulating objects, only returning messages.
    public static class ReadFromFile
    {
        
        public static List<string> GetWords(string file)
        {
            List<string> fileWords = new List<string>(); // the list of words from the file to return
            String myLine; // reading the file line by line
            String[] words; // the list of words

            try
            {
                TextReader tr = new StreamReader(file); // make sure you added "using System IO"

                while ((myLine = tr.ReadLine()) != null)

                {
                    // remove punctuation from each line and make lower case
                    string newLine = Regex.Replace(myLine, "[\\p{P}+]", "");
                    newLine = newLine.ToLower();

                    words = newLine.Split(' '); //Splitting a line into an array of words

                    foreach (string word in words)
                    {
                        if (word != "")
                        {
                            fileWords.Add(word);
                        }
                       
                    }

                } // end of reading the file
            }
            catch (FileNotFoundException error)
            {
                MessageBox.Show("File not found: " + error);
            }
            

            return fileWords;
        }
    }
}
