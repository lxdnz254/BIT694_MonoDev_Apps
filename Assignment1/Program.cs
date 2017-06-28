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
		const String fileLocation = "../../input_assignment1.txt";
		const int fileLines = 20;
		const String titleLines = "----------------------------";

		// Displays the main menu and returns an int, selected by user
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
					result = displayMenu ();
				}
			} else {
				Console.WriteLine ("\nIncorrect input format");
				waitForKey ();
				result = displayMenu ();
			}
			return result;
		}

		// Formats the title display for each option
		static void displayTitle(String title)
		{
			Console.Clear ();
			Console.WriteLine (titleLines);
			Console.WriteLine ("      "+title);
			Console.WriteLine (titleLines + "\n");
		}

		// method for waiting for a key press.
		static void waitForKey()
		{
			Console.WriteLine ("\nPress any key to continue ...");
			Console.ReadKey ();
		}

		// Method to make a deposit for a Customer
		static void makeDeposit(Customer[] array)
		{
			displayTitle ("Deposit");

			waitForKey ();
		}

		// Method to make a withdrawl for a Customer
		static void makeWithdrawl(Customer[] array)
		{
			displayTitle ("Withdrawl");

			waitForKey ();
		}

		// Method to display the Customer with largest balance and display
		static void getMaximumBalance(Customer[] array)
		{
			displayTitle ("Max Balance Customer");

			waitForKey ();
		}

		// Method to display the most active Customer
		static void getMostActive(Customer[] array)
		{
			displayTitle ("Most Active Customer");

			waitForKey ();
		}

		// Method to display the Youngest customer
		static void getYoungest(Customer[] array)
		{
			displayTitle ("Youngest Customer");
			array [DateUtilities.getYoungest (array)].displayInfo ();
			waitForKey ();
		}

		// Method to display all customers born in a leap year and their zodiac signs
		static void getLeapYearCustomers(Customer[] array)
		{
			displayTitle ("Leap Years and Zodiac Signs");
			foreach (Customer customer in array)
			{
				if (DateUtilities.isLeapYear(customer.AccessDob))
				{
					customer.displayInfo ();
					Console.WriteLine(String.Format("{0,-15} {1}", "Zodiac:",DateUtilities.getZodiac(customer.AccessDob)) + "\n");
				}
			}
			waitForKey ();
		}

		public static void Main (string[] args)
		{
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
			} // end of Menu loop

			Console.WriteLine ("End of program, press any key to continue ...");
			Console.ReadKey ();
		} // end of Main method
	} // end of MainClass
} // end of namespace