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

		static int displayMenu()
		{
			Console.Write ("Enter Option (0-6) >> ");
			String key = Console.ReadLine ();
			int result;
			if (int.TryParse (key, out result)) {
				if (result >= 0 && result <= 6) {
					 
				} else {
					Console.WriteLine ("\nIncorrect number");
					displayMenu ();
					return result;
				}
			} else {
				Console.WriteLine ("\nIncorrect input format");
				displayMenu ();
			}
			return result;
		}

		static void makeDeposit(Customer[] array)
		{
			Console.WriteLine ("In makeDeposit");
		}

		static void makeWithdrawl(Customer[] array)
		{
			Console.WriteLine ("In makeWithdrawl");
		}

		static void getMaximumBalance(Customer[] array)
		{
			Console.WriteLine ("In getMaximumBalance");
		}

		static void getMostActive(Customer[] array)
		{
			Console.WriteLine ("In getMostActive");
		}

		static void getYoungest(Customer[] array)
		{
			array [DateUtilities.getYoungest (array)].displayInfo ();
		}

		static void getLeapYearCustomers(Customer[] array)
		{
			Console.WriteLine ("In getLeapYearCustomers");
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
