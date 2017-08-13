using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace SynonymTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Synonym checker Task");
            bool synonym1 = false;
            bool synonym2 = false;
            String synonymLine;
            String[] synonyms;
            List<HashSet<String>> synonymList = new List<HashSet<String>>();
            HashSet<String> s1 = new HashSet<String>();
            TextReader synonymTr = new StreamReader("C:/Temp/synonyms.txt");
            while((synonymLine = synonymTr.ReadLine()) != null)
            {
                synonyms = synonymLine.Split(' ');
                s1 = new HashSet<String>();
                for (int i=0; i < synonyms.Length; i++)
                {
                    s1.Add(synonyms[i]);
                }
                synonymList.Add(s1);
            }
            synonymTr.Close();

            String myLine; // reading the file line by line
            String[] words; //
            Hashtable wf = new Hashtable(); // The hash table
            TextReader tr = new StreamReader("C:/Temp/input.txt"); // make sure you added "using System IO"
            while ((myLine = tr.ReadLine()) != null)
            {
                words = myLine.Split(' '); //Splitting a line into an array of words
                for (int i = 0; i < words.Length; i++)
                {
                    if (wf.ContainsKey(words[i]))
                    {
                        wf[words[i]] = double.Parse(wf[words[i]].ToString()) + 1; // adding 1 to the frequency
                    }
                    else
                    {
                        wf.Add(words[i], 1.0); //first time this word is read
                    }
                } // end of looping the array of words
            } // end of reading the file
            tr.Close();

              // check for the synonyms
            foreach (String word in wf.Keys)
            {
                if (synonymList[0].Contains(word)) synonym1 = true;
                if (synonymList[1].Contains(word)) synonym2 = true;
            }

            if (synonym1 && synonym2)
            {
                Console.WriteLine("input.txt contains one of each of the synonym lines");
            }
            else
            {
                Console.WriteLine("input.txt does not contain one of each of the synonym lines");
            }
            Console.WriteLine("Press any key to continue ......");
            Console.ReadKey();
        }
    }
}
