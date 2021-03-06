﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class SearchUtilities
    {
        private Database db; // A reference to the Database class.
        private PorterStemmer stemmer;

        // Constructor for SearchUtitlies objects
        public SearchUtilities()
        {

        }

        /*
         * Returns the list of files inside folder that contains the search terms or synonyms (if it is checked)
         * Iterating by the terms given
         */ 
        public List<string> GetFilesContainingTermsByTerms(string folder, string[] terms, Boolean synonymsOn, NewWordsDataSet dataSet)
        {
            //List<string> folders = GetFolders(folder);
            List<string> files = IndexingFolders(folder);
            return ScanFilesByTerms(files, terms, synonymsOn, dataSet);
        }

        /*
         * Returns the list of files inside folder that contains the search terms or synonyms (if it is checked)
         * Iterating by the files in the folder
         */
        public List<string> GetFilesContainingTermsByFiles(string folder, string[] terms, Boolean synonymsOn, NewWordsDataSet dataSet)
        {
           // List<string> folders = GetFolders(folder);
            List<string> files = IndexingFolders(folder);
            return ScanFilesByFile(files, terms, synonymsOn, dataSet);
        }

        /*
         * Returns an array of all the words in the collection (folder)
         */
        public string[] GetWordCollection(string folder)
        {
            List<string> folders = GetFolders(folder);
            List<string> files = GetFiles(folders);
            return ScanFilesForWords(files);
        }

        /// <summary>
        /// Returns an array of the stemmed collection
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public string[] GetStemmedCollection(string folder)
        {
            stemmer = new PorterStemmer();
            string[] collection = GetWordCollection(folder);
            List<string> stemmedCollection = new List<string>();
            foreach(string word in collection)
            {
                if (word.Length>2) { stemmedCollection.Add(stemmer.StemWord(word)); }
            }

            return stemmedCollection.ToArray();
        }


        /*
         * Returns a list of folders inside the main folder & the main folder
         */
        public List<string> GetFolders(string folder)
        {
            List<string> folders = new List<string> { folder };
            // Add the folders inside the folder
            string[] subFolders = Directory.GetDirectories(folder);
            foreach (string sub in subFolders)
            {
                folders.Add(sub);
            }
            return folders;
        }

        /*
         * Returns the list of files in the collection (folders) 
         */ 
        public List<string> GetFiles(List<string> folders)
        {
            List<string> files = new List<string>(); // list of files

            foreach (string folder in folders)
            {
                string[] folderFiles = Directory.GetFiles(folder);
                
                foreach (string file in folderFiles)
                {
                    files.Add(file);
                }
            }
            return files;
        }

        /// <summary>
        /// Returns all files (including hidden ones, and files with no .ext) from
        /// all directories under the given folder path
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public List<string> IndexingFolders(string folder)
        {
            return Directory.GetFiles(folder, "*", SearchOption.AllDirectories).ToList();
        }

        // Private methods below here -  only available within the SearchUtilities class.

        /*
         * Scans files and searches for terms/synonyms in each file.
         * Marks files true if all terms are found in file
         * Returns tyhe list of files that are true
         */
        private List<string> ScanFilesByFile(List<string> files, string[] searchTerms,
                                        Boolean synonymsOn, NewWordsDataSet dataSet)
        {
            db = new Database(dataSet);
            stemmer = new PorterStemmer();
            List<string> fileContainsTerm = new List<string>();

            foreach (string file in files)
            {
                bool[] isInFile = new bool[searchTerms.Length]; // array for true/false search terms
                List<string> fileWords = ReadFromFile.GetWords(file); // Read the file and return list of words

                foreach (string word in fileWords)
                {
                    // Search word over terms
                    int counter = 0; // counter for boolean array

                    foreach (string term in searchTerms)
                    {
                        if (synonymsOn)
                        {
                            List<string> checkList = new List<string> { term.ToLower() };
                            // get list of synonyms
                            List<string> synonyms = db.GetSynonyms(term);
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

                        if (stemmer.StemWord(word).Equals(stemmer.StemWord(term.ToLower())))
                        {
                            isInFile[counter] = true; // mark this term as true
                        }

                        counter++;
                    }
                }

                if (isInFile.All(x => x)) // tests if ALL search terms are true
                {
                    fileContainsTerm.Add(file); // add file "string" to the List if true
                }
            }
            return fileContainsTerm;
        }


        /// <summary>
        /// Scans each file in collection by terms
        /// </summary>
        /// <param name="files">The list of files</param>
        /// <param name="searchTerms">the array of search terms</param>
        /// <param name="synonymsOn">check if synonym checking is on</param>
        /// <param name="dataSet">The dataset to retrieve synonyms from</param>
        /// <returns></returns>
        private List<string> ScanFilesByTerms(List<string> files, string[] searchTerms,
                                            Boolean synonymsOn, NewWordsDataSet dataSet)
        {
            db = new Database(dataSet);
            stemmer = new PorterStemmer();
            List<string> searchFileList = files;
            
            for (int i=0; i < searchTerms.Length; i++)
            {
                List<string> fileHasTerm = new List<string>();

                foreach (string file in searchFileList)
                {
                    bool hasTerm = false;
                    List<string> fileWords = ReadFromFile.GetWords(file);
                    
                    foreach (string word in fileWords)
                    {
                        if (synonymsOn)
                        {
                            List<string> synonyms = db.GetSynonyms(searchTerms[i]);

                            if (synonyms != null)
                            {
                                foreach (string s in synonyms)
                                {
                                    if (word.Equals(s))
                                    {
                                        hasTerm = true;
                                    }
                                }
                            }
                        }

                        if (stemmer.StemWord(word).Equals(stemmer.StemWord(searchTerms[i])))
                        {
                            hasTerm = true;
                        }
                    }

                    if (hasTerm)
                    {
                        fileHasTerm.Add(file);
                    }
                }
                searchFileList = fileHasTerm;
                
            }
            return searchFileList;
        }

        /*
         * Scans files in collection and returns all words into an array
         */ 
        private string[] ScanFilesForWords(List<string> files)
        {
            List<string> words = new List<string>(); 

            foreach(string file in files)
            {
                List<string> fileWords = ReadFromFile.GetWords(file);
                foreach(string word in fileWords)
                {
                    words.Add(word);
                }
            }

            return words.ToArray();
        }
    }
}
