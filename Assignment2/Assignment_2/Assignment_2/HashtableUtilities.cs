using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class HashtableUtilities
    {
        private SearchUtilities searchUtil; // A reference to the SearchUtilities class
        private PorterStemmer stemmer; // A reference to the PorterStemmer class

        // Constructor for the HashTableUtilities class
        public HashtableUtilities()
        {
            
        }
        
        /*
         * Returns a Hashtable of the collection
         */ 
        public Hashtable GetHashtable(string folder)
        {
            Hashtable wf = new Hashtable();
            searchUtil = new SearchUtilities(); // instantiated in this method, as its the only method requiring SearchUtilites.

            string[] words = searchUtil.GetWordCollection(folder);

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

        /*
         * Returns a string of the Key with the maxiumum frequency in Hashtable 
         */
        public string GetMax(Hashtable h)
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

        /// <summary>
        /// Returns a string of all terms in a Hashtable with their frequency
        /// </summary>
        /// <param name="h">The Hashtable</param>
        /// <param name="terms">The array of terms</param>
        /// <returns></returns>
        public string QueryFrequency(Hashtable h, string[] terms)
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

        ///<summary>Creates an Hashtable that is an Inverted index oif the collection</summary>
        ///<param name="folder">The folder containing the collection</param>
        ///<returns>A Hashtable of the collection</returns>
        public Dictionary<string, List<string>> InvertedIndex(string folder)
        {
            Dictionary<string, List<string>> index = new Dictionary<string, List<string>>();
            searchUtil = new SearchUtilities();
            List<string> fileList = new List<string>();
            stemmer = new PorterStemmer();

            foreach (string file in searchUtil.GetFiles(searchUtil.GetFolders(folder)))
            {
                foreach (string word in ReadFromFile.GetWords(file))
                {
                    // stem the word
                    string stemmedWord = stemmer.StemWord(word);
                    // create the Dictionary for the collection
                    if (index.ContainsKey(stemmedWord))
                    {
                        fileList = index[stemmedWord].ToList();
                        // check if the file is already in the list or not
                        if (!fileList.Contains(file))
                        {
                            fileList.Add(file);
                        }
                        
                        index[stemmedWord] = fileList;
                    }
                    else
                    {
                        // create a new key and start new List of files for the key
                        fileList = new List<string>() { file };
                        index.Add(stemmedWord, fileList);
                    }
                }
            }


            return index;
        }

        ///<summary>Search the InvertedIndex and return the files</summary>
        ///<param name="dictionary">Recieve the inverted index</param>
        ///<param name="querys">The query list</param>
        ///<return>A List of files</return>
        public List<string> GetFilesFromIndex(Dictionary<string, List<string>> dictionary, string[] querys)
        {
            List<string> files = new List<string>();
            stemmer = new PorterStemmer();
            List<string>[] lists = new List<string>[querys.Length];
            int counter = 0;

            foreach(string query in querys)
            {
                string stemmedQuery = stemmer.StemWord(query);
                lists[counter] = new List<string>();
                if (dictionary.ContainsKey(stemmedQuery))
                {
                    foreach (string file in dictionary[stemmedQuery])
                    { 
                        lists[counter].Add(file);
                    }
                }
                counter++;
            }

            if (querys.Length > 1)
            {
                for (int i = querys.Length - 1; i > 0; i--)
                { 
                    lists[i] = lists[i].Intersect(lists[i - 1]).ToList(); 
                }
                files = lists[1];
            }
            else
            {
                files = lists[0];
            }
            return files;
        }

        /// <summary>
        /// Gets the files from the inverted index that contain the querys
        /// and their synonyms.
        /// </summary>
        /// <param name="dictionary">The inverted index</param>
        /// <param name="querys">The array of querys</param>
        /// <param name="dataSet">The dataset to draw synoyms from</param>
        /// <returns></returns>
        public List<string> GetFilesFromIndexWithSynonyms (Dictionary<string, List<string>> dictionary,
                                                            string[] querys, NewWordsDataSet dataSet)
        {
            List<string> files = new List<string>();
            stemmer = new PorterStemmer();
            Database database = new Database(dataSet);
            List<string>[] lists = new List<string>[querys.Length];
            int counter = 0;

            foreach (string query in querys)
            {
                string stemmedQuery = stemmer.StemWord(query);
                lists[counter] = new List<string>();
                if (dictionary.ContainsKey(stemmedQuery))
                {
                    foreach (string file in dictionary[stemmedQuery])
                    {
                        lists[counter].Add(file);
                    }
                }
                List<string> synonmys = database.GetSynonyms(query);
                foreach (string synonym in synonmys)
                {
                    string stemmedSynonym = stemmer.StemWord(synonym);
                    if (dictionary.ContainsKey(stemmedSynonym))
                    {
                        foreach (string file in dictionary[stemmedSynonym])
                        {
                            lists[counter].Add(file);
                        }
                    }
                }
                counter++;
            }

            if (querys.Length > 1)
            {
                for (int i = querys.Length - 1; i > 0; i--)
                {
                    lists[i] = lists[i].Intersect(lists[i - 1]).ToList();
                }
                files = lists[1];
            }
            else
            {
                files = lists[0];
            }

            return files;
        }

    }
}
