using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotApp
{
    class Database
    {
       
        
        /// <summary>
        /// Checks the synonym Database for a the term provided
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        internal static String CheckDB(String word)
        {
            // Initialise some user objects
            OleDbConnection conn = new OleDbConnection();
            String wordsArray = "";
            DataSet myDataSet = new DataSet();

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
            try
            {
                // Open the connection
                conn.ConnectionString = strAccessConn;
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {

                    try
                    {
                        // Fill the table with all the dataSet
                        OleDbCommand cmd = new OleDbCommand(strAccessSelect, conn);
                        OleDbDataAdapter ada = new OleDbDataAdapter(cmd);
                        ada.Fill(myDataSet, "Words");
                    }
                    catch (Exception ex)
                    {
                        wordsArray = "Dataset error: " + ex.Message;
                        return wordsArray;
                    }

                    /**
                     * This is the main part of the database check
                     */

                    DataTableCollection dta = myDataSet.Tables;
                    DataTable dtt = dta["Words"];

                    // Set primary keys
                    DataColumn[] primaryKeys = new DataColumn[1];
                    primaryKeys[0] = dtt.Columns[0];
                    dtt.PrimaryKey = primaryKeys;

                    // Find the row
                    DataRow row = dtt.Rows.Find(word);

                    if (row != null)
                    {
                        var synonyms = row.Field<string>(1).Split(',');
                    
                        wordsArray += string.Join(", ", synonyms);
                    }
                    else
                    {
                        wordsArray = "No available synonyms";
                    }
                }
                else
                {
                    wordsArray = "Disconnected:";
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                wordsArray = "not connected: " + ex.Message;
                return wordsArray;
            }
            
            finally
            {
                conn.Close();
            }
            // return the string
            return wordsArray;       
        }

    }
}
