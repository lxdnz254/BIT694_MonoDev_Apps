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
		static int DisplayMenu()
		{
			DisplayTitle ("Banking System");
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
			// uses TryParse to only accept numbers 0-6 as a valid input.
			if (int.TryParse (key, out result)) {
				if (result >= 0 && result <= 6) {
					 
				} else {
					Console.WriteLine ("\nIncorrect number");
					WaitForKey ();
					result = DisplayMenu (); // on error return to main display after key press
				}
			} else {
				Console.WriteLine ("\nIncorrect input format");
				WaitForKey ();
				result = DisplayMenu (); // on error return to main display after key press
			}
			return result;
		}

		// Formats the title display for each option
		static void DisplayTitle(String title)
		{
			Console.Clear ();
			Console.WriteLine (titleLines);
			Console.WriteLine ("      "+title);
			Console.WriteLine (titleLines + "\n");
		}

		// method for waiting for a key press.
		static void WaitForKey()
		{
			Console.WriteLine ("\nPress any key to continue ...");
			Console.ReadKey ();
		}

		// Method to make a deposit for a Customer
		static void MakeDeposit(Customer[] array)
		{
			DisplayTitle ("Deposit");

			Console.Write ("Enter account ID: ");
			String id = Console.ReadLine ();
			int result;
			// uses TryParse to get a valid accountID input
			if (int.TryParse (id, out result)) {
				int customerPos = -1;
				for (int i = 0; i < array.Length; i++) {
					if (array [i].AccessID == result) {
						customerPos = i;
					}
				}
				if (customerPos >= 0) {
					Console.Write ("Depositing into account of " + array [customerPos].AccessFullName + ". ");
					Console.WriteLine ("Current balance: " + String.Format ("{0:C}", array [customerPos].AccessBalance));
					Console.Write ("\nEnter the amount to deposit: $");
					double dep;
					String deposit = Console.ReadLine ();
					if (double.TryParse (deposit, out dep)) {
						bool success = array [customerPos].Deposit (dep);
                        if (success)
                        {
                            Console.WriteLine("\nSuccesfully deposited {0:C}. Current Balance is {1:C}", dep, array[customerPos].AccessBalance);
                        } else
                        {
                            Console.WriteLine("\nCurrent Balance is {0:C}", array[customerPos].AccessBalance);
                        }
                    } else {
						Console.WriteLine("\nInvalid input for deposit");
					}
				} else {
					Console.WriteLine ("\nNo ID match in customer array");
				}
			} else {
				Console.WriteLine ("\nNot a valid ID format");
			}
			WaitForKey ();
		}

		// Method to make a withdrawl for a Customer
		static void MakeWithdrawl(Customer[] array)
		{
			DisplayTitle ("Withdrawl");

			Console.Write ("Enter account ID: ");
			String id = Console.ReadLine ();
			int result;
			if (int.TryParse (id, out result)) {
				int customerPos = -1;
				for (int i = 0; i < array.Length; i++) {
					if (array [i].AccessID == result) {
						customerPos = i;
					}
				}
				if (customerPos >= 0) {
					Console.Write ("Withdrawing from account of " + array [customerPos].AccessFullName + ". ");
					Console.WriteLine ("Current balance: " + String.Format ("{0:C}", array [customerPos].AccessBalance));
					Console.Write ("\nEnter the amount to withdraw: $");
					String withdraw = Console.ReadLine ();
					double wdraw;
					if (double.TryParse (withdraw, out wdraw)) {
						bool success = array [customerPos].Withdraw (wdraw);
                        if (success)
                        {
                            Console.WriteLine("\nSuccesfully withdrew {0:C}. Current Balance is {1:C}", wdraw, array[customerPos].AccessBalance);
                        } else
                        {
                            Console.WriteLine("\nCurrent Balance is {0:C}", array[customerPos].AccessBalance);
                        }
					} else {
						Console.WriteLine("\nInvalid input for withdraw");
					}
				} else {
					Console.WriteLine ("\nNo ID match in customer array");
				}
			} else {
				Console.WriteLine ("\nNot a valid ID format");
			}

			WaitForKey ();
		}

		// Method to display the Customer with largest balance and display
		static void GetMaximumBalance(Customer[] array)
		{
			DisplayTitle ("Max Balance Customer");
			// set initial customer position
            double max = array[0].AccessBalance;
            // finds the maximum balance
			for (int i = 1; i < array.Length; i++) {
				if (array [i].AccessBalance >= max) {
                    max = array[i].AccessBalance;
				}
			}
            // iterate over customer array again outputting any customers with equal balance of the max
            for (int i=0; i < array.Length; i++)
            {
                if (array[i].AccessBalance == max)
                {
                    // display the customers with max balance
                    array[i].DisplayInfo();
                    // is it their birthday?
                    if (DateUtilities.IsBirthday(array[i].AccessDob))
                    {
                        Console.WriteLine("\nHappy Birthday!");
                    }
                    Console.WriteLine();
                }
            }
			
			WaitForKey ();
		}

		// Method to display the most active Customer
		static void GetMostActive(Customer[] array)
		{
			DisplayTitle ("Most Active Customer");
			// set initial customer position
            int maxCount = array[0].AccessActivityCounter;
			// iterate over array
			for (int i = 1; i < array.Length; i++) {
				if (array [i].AccessActivityCounter >= maxCount) {
                    maxCount = array[i].AccessActivityCounter;
				}
			}
            // iterate over array again outputting any customers matching the maxCount
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].AccessActivityCounter == maxCount)
                {
                    // display the max Active customer(s)
                    array[i].DisplayInfo();
                    Console.WriteLine();
                }
            }
			
			WaitForKey ();
		}

		// Method to display the Youngest customer
		static void GetYoungest(Customer[] array)
		{
			DisplayTitle ("Youngest Customer");
			array [DateUtilities.GetYoungest (array)].DisplayInfo ();
			WaitForKey ();
		}

		// Method to display all customers born in a leap year and their zodiac signs
		static void GetLeapYearCustomers(Customer[] array)
		{
			DisplayTitle ("Leap Years and Zodiac Signs");
			foreach (Customer customer in array)
			{
				if (DateUtilities.IsLeapYear(customer.AccessDob))
				{
					customer.DisplayInfo ();
					Console.WriteLine(String.Format("{0,-15} {1}", "Zodiac:",DateUtilities.GetZodiac(customer.AccessDob)) + "\n");
				}
			}
			WaitForKey ();
		}

		public static void Main (string[] args)
		{
			/*
             * Some Test methods, uncomment to test
             * 
			    Test t = new Test ();
			    t.TestCustomers ();
			    t.TestReadFile (fileLocation, fileLines);
			    t.TestDateUtilities ();
			*/

			Customer[] customerArray = ReadFromFile.CustomerList (fileLocation, fileLines);

			// Menu loop
			bool running = true;

			while (running) {
				int option = DisplayMenu();	

				switch (option) {
				case 0:
					running = false;
					break;
				case 1:
					MakeDeposit (customerArray);
					break;
				case 2:
					MakeWithdrawl (customerArray);
					break;
				case 3:
					GetMaximumBalance (customerArray);
					break;
				case 4:
					GetMostActive (customerArray);
					break;
				case 5:
					GetYoungest (customerArray);
					break;
				case 6:
					GetLeapYearCustomers (customerArray);
					break;
				}
			} // end of Menu loop

			Console.WriteLine ("\nEnd of program, press any key to continue ...");
			Console.ReadKey ();
		} // end of Main method
	} // end of MainClass
} // end of namespace