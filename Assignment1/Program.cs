using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	class MainClass
	{
		// Constants for the main program
        internal const String fileLocation = "../../input_assignment1.txt";
        internal const int fileLines = 20;
        internal const String titleLines = "----------------------------";

        public static void Main(string[] args)
        {
            
            Test t = new Test ();
            t.TestCustomers ();
            t.TestReadFile (fileLocation, fileLines);
            t.TestDateUtilities ();
            

            Customer[] customerArray = ReadFromFile.CustomerList(fileLocation, fileLines);

            // Menu loop
            bool running = true;

            while (running)
            {
                int option = Menu.DisplayMenu();

                switch (option)
                {
                    case 0:
                        running = false;
                        break;
                    case 1:
                        Menu.MakeDeposit(customerArray);
                        break;
                    case 2:
                        Menu.MakeWithdrawl(customerArray);
                        break;
                    case 3:
                        Menu.GetMaximumBalance(customerArray);
                        break;
                    case 4:
                        Menu.GetMostActive(customerArray);
                        break;
                    case 5:
                        Menu.GetYoungest(customerArray);
                        break;
                    case 6:
                        Menu.GetLeapYearCustomers(customerArray);
                        break;
                }
            } // end of Menu loop

            Console.WriteLine("\nEnd of program, press any key to continue ...");
            Console.ReadKey();
		} // end of Main method
	} // end of MainClass
} // end of namespace