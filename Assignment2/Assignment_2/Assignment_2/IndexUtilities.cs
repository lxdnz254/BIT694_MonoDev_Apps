using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public class IndexUtilities
    {
        private SearchUtilities searchUtil; // A reference to the SearchUtilities class
        private PorterStemmer stemmer; // A reference to the PorterStemmer class
        private MyComponent.Converter converter; // A reference to the MyComponent.Converter class
        internal Dictionary<string, Dictionary<int, double>> internalIndex; // A reference to the invertedIndex available in all classes in the assembly
        internal int indexCount;

        // Constructor for the HashTableUtilities class
        public IndexUtilities()
        {
            converter = new MyComponent.Converter();
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

        ///<summary>
        ///Creates an Hashtable that is an Inverted index oif the collection
        ///</summary>
        ///<param name="folder">The folder containing the collection</param>
        ///<returns>
        ///A Hashtable of the collection
        ///</returns>
        public Dictionary<string, Dictionary<int, double>> InvertedIndex(string folder)
        {
            if (internalIndex != null) { internalIndex.Clear(); } // clears the memory usage of exisitng Index
            internalIndex = new Dictionary<string, Dictionary<int, double>>(); // the invertedIndex to be returned
            searchUtil = new SearchUtilities(); // instantiate SearchUtilities class object
            dynamic form1 = Application.OpenForms[0]; // will create a reference to the Main Form object
            indexCount = 0; // a counter for how large the inverted index is.
            
            Dictionary<int, double> fileList = new Dictionary<int, double>(); // a list to populate the files that match a term
            stemmer = new PorterStemmer(); // instantiate a PorterStemmer object to stem words from files

            foreach (string file in searchUtil.IndexingFolders(folder))
            {
                int fileID = converter.AssignId(file); // create an Id from the string of the file and store in HashMap Converter.paths
                
                foreach (string word in ReadFromFile.GetWords(file))
                {
                    // stem the word
                    string stemmedWord = stemmer.StemWord(word);
                    // create the Dictionary for the collection
                    if (internalIndex.ContainsKey(stemmedWord))
                    {
                        fileList = internalIndex[stemmedWord];
                        // check if the file is already in the list or not
                        if (fileList.ContainsKey(fileID))
                        {
                            fileList[fileID] = double.Parse(fileList[fileID].ToString()) + 1;
                        }
                        else
                        {
                            fileList.Add(fileID, 1.0);
                        }
                        
                        internalIndex[stemmedWord] = fileList;
                    }
                    else
                    {
                        // create a new key and start new List of files for the key
                        fileList = new Dictionary<int, double>
                        {
                            { fileID, 1.0 }
                        };
                        internalIndex.Add(stemmedWord, fileList);
                        indexCount++;
                    }
                }
                form1.ShowIndexLength(false); // cross thread method to keep a running total of the index size on the Main form.
            }
            return internalIndex;
        }

        ///<summary>Search the InvertedIndex and return the files</summary>
        ///<param name="dictionary">Recieve the inverted index</param>
        ///<param name="querys">The query list</param>
        ///<return>A List of files</return>
        public List<string> GetFilesFromIndex(string[] querys)
        {
            List<string> files = new List<string>();
            stemmer = new PorterStemmer();
            
            Dictionary<string, double>[] lists = new Dictionary<string, double>[querys.Length];
            int counter = 0;

            foreach(string query in querys)
            {
                string stemmedQuery = stemmer.StemWord(query);
                lists[counter] = new Dictionary<string, double>();
                if (internalIndex.ContainsKey(stemmedQuery))
                {
                    var innerKeysAndValues = from inner in internalIndex[stemmedQuery]
                                            select new
                                            {
                                                NewKey = inner.Key,
                                                NewValue = inner.Value
                                            };
                    foreach (var innerKeyAndValue in innerKeysAndValues)
                    {
                        int fileID = innerKeyAndValue.NewKey;
                        lists[counter].Add(converter.GetPath(fileID), innerKeyAndValue.NewValue);
                    }
                }
                counter++;
            }

            if (querys.Length > 1)
            {
                for (int i = querys.Length - 1; i > 0; i--)
                {
                    var dict = lists[i];
                    var nextDict = lists[i - 1];
                    var result = dict
                        .Where(x => nextDict.ContainsKey(x.Key))
                        .ToDictionary(x => x.Key, x => x.Value);
                    lists[i] = result;
                }
                files = lists[1].OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value)
                    .Keys.ToList();
            }
            else
            {
                files = lists[0].OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value)
                    .Keys.ToList();
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
        public List<string> GetFilesFromIndexWithSynonyms (string[] querys, NewWordsDataSet dataSet)
        {
            List<string> files = new List<string>();
            stemmer = new PorterStemmer();
            
            Database database = new Database(dataSet);
            Dictionary<string, double>[] lists = new Dictionary<string, double>[querys.Length];
            int counter = 0;

            foreach (string query in querys)
            {
                string stemmedQuery = stemmer.StemWord(query);
                lists[counter] = new Dictionary<string, double>();
                if (internalIndex.ContainsKey(stemmedQuery))
                {
                    var innerKeysAndValues = from inner in internalIndex[stemmedQuery]
                                             select new
                                             {
                                                 NewKey = inner.Key,
                                                 NewValue = inner.Value
                                             };
                    foreach (var innerKeyAndValue in innerKeysAndValues)
                    {
                        int fileID = innerKeyAndValue.NewKey;
                        lists[counter].Add(converter.GetPath(fileID), innerKeyAndValue.NewValue);
                    }
                }
                List<string> synonmys = database.GetSynonyms(query);
                if (synonmys != null)
                {
                    foreach (string synonym in synonmys)
                    {
                        string stemmedSynonym = stemmer.StemWord(synonym);
                        if (internalIndex.ContainsKey(stemmedSynonym))
                        {
                            var innerKeysAndValues = from inner in internalIndex[stemmedSynonym]
                                                     select new
                                                     {
                                                         NewKey = inner.Key,
                                                         NewValue = inner.Value
                                                     };
                            foreach (var innerKeyAndValue in innerKeysAndValues)
                            {
                                string path = converter.GetPath(innerKeyAndValue.NewKey);
                                if (!lists[counter].ContainsKey(path))
                                {
                                    lists[counter].Add(path, innerKeyAndValue.NewValue);
                                }                               
                            }
                        }
                    }
                }
                
                counter++;
            }

            if (querys.Length > 1)
            {
                for (int i = querys.Length - 1; i > 0; i--)
                {
                    var dict = lists[i];
                    var nextDict = lists[i - 1];
                    var result = dict
                        .Where(x => nextDict.ContainsKey(x.Key))
                        .ToDictionary(x => x.Key, x => x.Value);
                    lists[i] = result;
                }
                files = lists[1].OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value)
                    .Keys.ToList();
            }
            else
            {
                files = lists[0].OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value)
                    .Keys.ToList();
            }

            return files;
        }

        /// <summary>
        /// Scans the inverted index (internalIndex) and returns the term with largest count,
        /// in the scanned folder
        /// </summary>
        /// <returns></returns>
        public string GetInvertedIndexMax()
        {
            double max = 0;
            string maxWord = "";

            foreach (string term in internalIndex.Keys)
            {
                double wordCount = 0;
                var totalValues = from inner in internalIndex[term]
                                  select new
                                  {
                                      NewKey = inner.Key,
                                      NewValue = inner.Value
                                  };
                foreach (var sumTotalValues in totalValues)
                {
                    wordCount += sumTotalValues.NewValue;
                }
                if (wordCount > max)
                {
                    max = wordCount;
                    maxWord = term;
                }
            }
            return maxWord + ": " + max;
        }

        /// <summary>
        /// Returns the frequency of search terms from the index.
        /// </summary>
        /// <param name="terms"></param>
        /// <returns></returns>
        public string GetQueryFrequencyFromIndex(string[] terms)
        {
            string result = "";
            stemmer = new PorterStemmer();

            foreach (string word in internalIndex.Keys)
            {
                for (int i = 0; i< terms.Length; i++)
                {
                    if(word.Equals(stemmer.StemWord(terms[i]))) {

                        double freqCount = 0;
                        var frequency = from inner in internalIndex[word]
                                        select new
                                        {
                                            NewKey = inner.Key, NewValue = inner.Value
                                        };
                        foreach (var count in frequency)
                        {
                            freqCount += count.NewValue;
                        }
                        result += terms[i].ToLower() + ": " + freqCount + "\r\n";
                    }
                }
            }
            return result;
        }
    }
}
