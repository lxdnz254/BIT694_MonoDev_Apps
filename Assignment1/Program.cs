using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	class MainClass
	{
		const String fileLocation = "../../input_assignment1.txt";
		const int fileLines = 20;
		const String titleLines = "----------------------------";

		static void displayTitle(String title)
		{
			Console.Clear ();
			Console.WriteLine (titleLines);
			Console.WriteLine ("      "+title);
			Console.WriteLine (titleLines + "\n");
		}

		static void waitForKey()
		{
			Console.WriteLine ("\nPress any key to continue ...");
			Console.ReadKey ();
		}

		static int displayMenu()
		{
			displayTitle ("Banking System");
			String[] options = {	"Exit", 
									"Deposit", 
									"Withdraw", 
									"Check Max Balance", 
									"Check Most Active Account", 
									"Check Youngest Customer",
									"Show Customers Born on Leap year"
			};

			for (int i = 0; i < options.Length; i++) {
				Console.WriteLine (i + ". " + options [i]);
			}

			Console.Write ("\nEnter Option (0-6) >> ");
			String key = Console.ReadLine ();
			int result;
			if (int.TryParse (key, out result)) {
				if (result >= 0 && result <= 6) {
					 
				} else {
					Console.WriteLine ("\nIncorrect number");
					waitForKey ();
					displayMenu ();
				}
			} else {
				Console.WriteLine ("\nIncorrect input format");
				waitForKey ();
				displayMenu ();
			}
			return result;
		}

		static void makeDeposit(Customer[] array)
		{
			displayTitle ("Deposit");

			waitForKey ();
		}

		static void makeWithdrawl(Customer[] array)
		{
			displayTitle ("Withdrawl");

			waitForKey ();
		}

		static void getMaximumBalance(Customer[] array)
		{
			displayTitle ("Max Balance Customer");

			waitForKey ();
		}

		static void getMostActive(Customer[] array)
		{
			displayTitle ("Most Active Customer");

			waitForKey ();
		}

		static void getYoungest(Customer[] array)
		{
			displayTitle ("Youngest Customer");
			array [DateUtilities.getYoungest (array)].displayInfo ();
			waitForKey ();
		}

		static void getLeapYearCustomers(Customer[] array)
		{
			displayTitle ("Leap Years and Zodiac Signs");

			waitForKey ();
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			/*
			Test t = new Test ();
			t.testCustomers ();
			t.testReadFile (fileLocation, fileLines);
			t.testDateUtilities ();
			*/

			Customer[] customerArray = ReadFromFile.customerList (fileLocation, fileLines);

			// Menu loop
			bool running = true;

			while (running) {
				int option = displayMenu();	

				switch (option) {
				case 0:
					running = false;
					break;
				case 1:
					makeDeposit (customerArray);
					break;
				case 2:
					makeWithdrawl (customerArray);
					break;
				case 3:
					getMaximumBalance (customerArray);
					break;
				case 4:
					getMostActive (customerArray);
					break;
				case 5:
					getYoungest (customerArray);
					break;
				case 6:
					getLeapYearCustomers (customerArray);
					break;
				}
			}

			Console.WriteLine ("End of program, press any key to continue ...");
			Console.ReadKey ();
		}


			
	}
}
