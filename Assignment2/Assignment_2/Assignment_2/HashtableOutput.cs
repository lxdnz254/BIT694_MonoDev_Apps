using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public static class HashtableOutput
    {
        public static Hashtable GetHashtable(string folder)
        {
            Hashtable wf = new Hashtable();

            string[] words = ScanFolder.GetWordCollection(folder);

            foreach (string word in words)
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
            }

            return wf;
        }

        /**
         * Returns a string of the Key with the maxiumum frequency in Hashtable 
         */
        public static string GetMax(Hashtable h)
        {
            double max = 0;
            string maxWord = "";

            foreach (string word in h.Keys)
            {
                if (double.Parse(h[word].ToString()) > max)
                {
                    maxWord = word;
                    max = double.Parse(h[word].ToString());
                }
            }
            return maxWord + ": " + max;
        }

        /*
         * Returns a string of all terms in the Hashtable with their frequency
         */ 

        public static string QueryFrequency(Hashtable h, string[] terms)
        {
            string result = "";

            foreach (string word in h.Keys)
            {
                for (int i = 0; i < terms.Length; i++)
                {
                    if (word.Equals(terms[i].ToLower()))
                    {
                        result += terms[i].ToLower() + ": " 
                            + double.Parse(h[word].ToString()) + "\r\n";
                    }
                }
            }
            return result;
        }
    }
}
