using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash table - Example 1");
            String myLine; // reading the file line by line
            String[] words; //
            Hashtable wf = new Hashtable(); // The hash table
            TextReader tr = new StreamReader("C:/Temp/dara.txt"); // make sure you added "using System IO"
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
              // output the words with the associated frequencies
            foreach (String word in wf.Keys)
            {
                Console.WriteLine(word + "  " + wf[word]);
            }
            Console.WriteLine("Press any key to continue ......");
            Console.ReadKey();
            return;
        }
    }
}
