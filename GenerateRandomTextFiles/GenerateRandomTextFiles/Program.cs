using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRandomTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Text File Generator - version 2 (using parallel async writing)\r\nPress any key to start");
            Console.ReadKey();

            var dbWatch = System.Diagnostics.Stopwatch.StartNew();          
            
            List<String> wordList = new List<String>();

            // Import the NewWords database into the project firs "Project -> Add New Data Source"
            // Set Access connection and select strings.
            // The path to NewWords.MDB must be changed if you build 
            // the sample from the command line:
#if USINGPROJECTSYSTEM
            string strAccessConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\NewWords.MDB";
#else
            string strAccessConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=NewWords.MDB";
#endif
            string strAccessSelect = "SELECT * FROM Words";

            // Create the dataset and add the Words table to it:
            DataSet myDataSet = new DataSet();
            OleDbConnection myAccessConn = null;
            try
            {
                myAccessConn = new OleDbConnection(strAccessConn);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to create a database connection. \n{0}", ex.Message);
                return;
            }

            try
            {

                OleDbCommand myAccessCommand = new OleDbCommand(strAccessSelect, myAccessConn);
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);

                myAccessConn.Open();
                myDataAdapter.Fill(myDataSet, "Words");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to retrieve the required data from the DataBase.\n{0}", ex.Message);
                return;
            }
            finally
            {
                myAccessConn.Close();
            }

            
            /**
             * This is the main part of the program
             */
            DataTableCollection dta = myDataSet.Tables;
            DataTable dtt = dta["Words"];
            // get all words from column "Word"
            var words = from row in dtt.AsEnumerable()
                        select row.Field<string>("Word");
            wordList = words.ToList();
            // get the synonyms from column "Synonyms"
            var synonyms = from row in dtt.AsEnumerable()
                           select row.Field<string>("Synonyms").Split(',');

            foreach (string[] split in synonyms)
            {
                foreach (string syn in split)
                {
                    wordList.Add(syn);
                }
            }
            dbWatch.Stop();

            var watch = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here

            ProcessWriteMulti(wordList).Wait();
            
            // end the timer
            watch.Stop();
            var dbElapsed = dbWatch.ElapsedMilliseconds;
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("\r\nSpeed of initialisation: " + dbElapsed.ToString() + "ms");
            Console.WriteLine("Speed of file writing: " + elapsedMs.ToString()+"ms");
            Console.WriteLine("Total Time: " + (elapsedMs + dbElapsed).ToString() + "ms");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        
        }

        static async Task ProcessWriteMulti(List<String> wordList)
        {
            Random random = new Random();
            string script;
            int folderNo;
            int wordCount;
            int databaseWordID;
            List<Task> tasks = new List<Task>();
            List<FileStream> sourceStreams = new List<FileStream>();

            try
            {
                // Generate 1000 text files
                for (int k = 1; k <= 1000; k++)
                {
                    // random folder number
                    folderNo = random.Next(7);
                    // random word count min/max
                    wordCount = random.Next(9, 31);

                    string[] text = new string[wordCount];
                    script = "";

                    for (int j = 0; j < text.Length; j++)
                    {
                        // random word from database
                        databaseWordID = random.Next(wordList.Count);
                        text[j] = wordList[databaseWordID];
                        script += text[j] + " ";
                    }

                    // Create folders and file string
                    string folderOutput = "C:\\TestFolder\\folder" + folderNo;
                    Directory.CreateDirectory(folderOutput);
                    string fileOutput = folderOutput + "\\test_file" + k + ".txt";

                    byte[] encodeText = Encoding.Unicode.GetBytes(script);

                    //How to write to a file. When writing to a file, if the file does not exist, the program creates it.
                    FileStream fs = new FileStream(fileOutput, FileMode.Create, FileAccess.Write, FileShare.ReadWrite, bufferSize: 4096, useAsync: true); // FileMode.Create overwites an existing file

                    Task theTask = fs.WriteAsync(encodeText, 0, encodeText.Length);
                    sourceStreams.Add(fs);

                    tasks.Add(theTask);

                    /* Outputs the files so you know its working, this can be commented out
                    Console.WriteLine("Folder:" + folderNo + ", Word Count: " + wordCount);
                    Console.WriteLine("Text:" + script);
                    */

                }
                await Task.WhenAll(tasks);
            }
            finally
            {
                foreach (FileStream sourceStream in sourceStreams)
                {
                    sourceStream.Flush();
                }
            }

            
            
        }
    }
}
