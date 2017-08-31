using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public static class ScanFolder
    {
        
        public static List<string> GetFilesContainingTerms(string folder, string[] terms, Boolean synonymsOn, NewWordsDataSet dataSet)
        {
            List<string> folders = GetFolders(folder);
            List<string> files = GetFiles(folders);
            return ScanFiles(files, terms, synonymsOn, dataSet);
        }

        public static string[] GetWordCollection(string folder)
        {
            List<string> folders = GetFolders(folder);
            List<string> files = GetFiles(folders);
            return ScanFilesForWords(files);
        }

        static List<string> GetFolders(string folder)
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

        static List<string> GetFiles(List<string> folders)
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

        static List<string> ScanFiles(List<string> files, string[] searchTerms, Boolean synonymsOn, NewWordsDataSet dataSet)
        {
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
                            List<string> synonyms = Database.GetSynonyms(term, dataSet);
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

                if (isInFile.All(x => x)) // tests if ALL search terms are true
                {
                    fileContainsTerm.Add(file); // add file to the listBox if true
                }
            }
            return fileContainsTerm;
        }

        static string[] ScanFilesForWords(List<string> files)
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
