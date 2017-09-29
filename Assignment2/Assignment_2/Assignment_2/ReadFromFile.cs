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

// doc parser file
using Code7248.word_reader;

// xls parser file
using ExcelDataReader;

namespace Assignment_3
{
    // This class is static as it not manipulating objects, only returning messages.
    public static class ReadFromFile
    {
        
        public static List<string> GetWords(string file) //main entry point for Reading files
        {
            List<string> fileWords = new List<string>(); // List of words to return
            string ext = System.IO.Path.GetExtension(file); // determine the extension of a file

            if (ext.Equals(".txt") || ext.Equals(""))  { fileWords = ReadTxtFile(file); }       
            if (ext.Equals(".pdf")) { fileWords = ReadPDFFile(file); }
            if (ext.Equals(".doc") || ext.Equals(".docx")) { fileWords = ReadDocFile(file); }
            if (ext.Equals(".xls") || ext.Equals(".xlsx")) { fileWords = ReadXlsFile(file); }

            return fileWords;
        }

        // Read a .txt file
        static List<string> ReadTxtFile(string file)
        {
            string fileWords = ""; // the list of words from the file to return
            String myLine; // reading the file line by line
          

            try
            {
                TextReader tr = new StreamReader(file); // make sure you added "using System IO"

                while ((myLine = tr.ReadLine()) != null)

                {
                    fileWords += myLine + " ";

                } // end of reading the file
            }
            catch (FileNotFoundException error)
            {
                MessageBox.Show("File not found: " + error);
            }


            return AddTextToList(fileWords);
        }

        // read a .pdf file
        static List<string> ReadPDFFile(string file)
        {  
            StringBuilder text = new StringBuilder();
            using (PdfReader reader = new PdfReader(file))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }

            return AddTextToList(text.ToString());
        }


        // read a .doc file
        static List<string> ReadDocFile(string file)
        {
            TextExtractor extractor = new TextExtractor(file);
            string text = extractor.ExtractText(); //The string 'text' is now loaded with the text from the Word Document

            return AddTextToList(text);
        }


        // read a .xls file
        static List<string> ReadXlsFile(string file)
        {
            string text = "";

            using (var stream = File.Open(file, FileMode.Open, FileAccess.Read))
            {

                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

                    // 1. Use the reader methods
                    do
                    {
                        while (reader.Read())
                        {
                            // reader.GetDouble(0);
                            Type type = reader.GetFieldType(0);
                            if (type != null)
                            {
                                if (type.Name.Equals("String"))
                                {
                                    text += reader.GetString(0) + " ";
                                }
                            }
                            
                           
                        }
                    } while (reader.NextResult());

                   

                    // The result of each spreadsheet is in result.Tables
                }
            }

            return AddTextToList(text) ;
        }

        private static List<string> AddTextToList(string text)
        {
            List<string> fileWords = new List<string>();
            
            // clean the files first

            //replace carriage returns "\r \n etc" with a space
            text.Replace(Environment.NewLine, " ");

            // remove stopwords
            text = StopWords.RemoveStopwords(text);

            // remove numbers, punctuation & special characters from each line and make lower case
            string newText = Regex.Replace(text, "[^a-zA-Z\\s+]", "");
            newText = newText.ToLower();

            String[] words = newText.Split(' '); //Splitting a line into an array of words

            foreach (string word in words)
            {
                if (word != "")
                {
                    fileWords.Add(word);
                }

            }

            return fileWords;
        }
    }
}
