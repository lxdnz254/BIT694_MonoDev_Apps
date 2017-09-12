using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//pdf parser files
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace Assignment_3
{
    // This class is static as it not manipulating objects, only returning messages.
    public static class ReadFromFile
    {
        
        public static List<string> GetWords(string file) //main entry point for Reading files
        {
            List<string> fileWords = new List<string>(); // List of words to return
            string ext = System.IO.Path.GetExtension(file); // determine the extension of a file

            if (ext.Equals(".txt")) { fileWords = ReadTxtFile(file); }       
            if (ext.Equals(".pdf")) { fileWords = ReadPDFFile(file); }
            if (ext.Equals(".doc")) { fileWords = ReadDocFile(file); }
            if (ext.Equals(".xls")) { fileWords = ReadXlsFile(file); }

            return fileWords;
        }

        // Read a .txt file
        static List<string> ReadTxtFile(string file)
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

        // read a .pdf file
        static List<string> ReadPDFFile(string file)
        {
            List<string> fileWords = new List<string>();
            String[] words;

            StringBuilder text = new StringBuilder();
            using (PdfReader reader = new PdfReader(file))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }

            string newText = Regex.Replace(text.ToString(), "[\\p{P}+]", "");
            newText = newText.ToLower();

            words = newText.Split(' ');

            foreach (string word in words)
            {
                if (word != "")
                {
                    fileWords.Add(word);
                }

            }

            return fileWords;
        }


        // read a .doc file
        static List<string> ReadDocFile(string file)
        {
            List<string> fileWords = new List<string>();


            return fileWords;
        }


        // read a .xls file
        static List<string> ReadXlsFile(string file)
        {
            List<string> fileWords = new List<string>();


            return fileWords;
        }
    }
}
