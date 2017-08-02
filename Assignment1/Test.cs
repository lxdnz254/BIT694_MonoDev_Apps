using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	// A test class for use in development to make sure methods are working as expected.
	public class Test
	{
		public Test ()
		{
		}

		public void testCustomers()
		{
			Console.WriteLine ("\nTesting Customer class methods\n");
			// Create some Customer Classes and test methods
			Customer c = new Customer ("John", "Key", "09-08-1961", 1111, 200.50);
			VIPCustomer v = new VIPCustomer ("The", "Pope", "06-06-1950", 333, 12.00);
			// Test displayInfo()
			c.displayInfo();
			// check customer deposit and activity counter
			c.deposit (100);
			Console.WriteLine ("Customer deposited $100.00, the balance is now >> " + c.AccessBalance);
			Console.WriteLine ("Customer activity count is now >> " + c.AccessActivityCounter);
			// check customer withdraws and activity counter
			c.withdraw (10);
			Console.WriteLine ("Customer withdrew $10.00, the balance is now >> " + c.AccessBalance);
			Console.WriteLine ("Customer activity count is now >> " + c.AccessActivityCounter);
			// check customer can go below zero and transactions dont take place
			c.withdraw (350);
			Console.WriteLine ("Customer balance is >> " + c.AccessBalance);
			Console.WriteLine ("Customer activity count is >> " + c.AccessActivityCounter);
			// Check VIP transactions
			v.displayInfo();
			v.deposit(10);
			Console.WriteLine ("VIP deposited $10.00, balance is now >> " + v.AccessBalance);
			Console.WriteLine ("VIP activity count is >> " + v.AccessActivityCounter);
			// check VIP withdraw (and below zero)
			v.withdraw(100);
			Console.WriteLine ("VIP withdrew $100.00, balance is now >> " + v.AccessBalance);
			Console.WriteLine ("VIP activity count is >> " + v.AccessActivityCounter);

			//end of tests
			Console.WriteLine("\nEnd of testing customers, press any key to continue ...\n");
			Console.ReadKey ();
		}

		public void testReadFile(String fileLocation, int fileLines)
		{
			Console.WriteLine ("Testing Read From File\n");
			Customer[] customerArray = ReadFromFile.customerList (fileLocation, fileLines);
			customerArray [0].displayInfo ();
			customerArray [fileLines - 1].displayInfo ();

			// end of test
			Console.WriteLine("\nEnd of testing read file, press any key to continue ....\n");
			Console.ReadKey ();
		}

		public void testDateUtilities()
		{
			Console.WriteLine ("Testing Date Utilities\nDate Formats\n");
			// tests different forms of date inputs and makes sure they all convert to standard format "dd/mm/yyyy"
			String[] testQuery = { 	"12-08-2003", 
									"12th August 2003",
									"2003-8-12",
									"August 12 2003",
									"2003/08/12",
									"12/8/2003",
									"August 12th 2003",
									"12th, August, 2003",
									"12-Aug-2003",
									"12-Aug-03",
									"Aug-12-03",
									"12-8-03",
									"12/08/03" };
			for (int i = 0; i < testQuery.Length; i++) {
				Console.Write (testQuery[i] + " >> " + DateUtilities.dateFormat (testQuery[i]));
				if (DateUtilities.dateFormat (testQuery[i]).Equals ("12/08/2003")) {
					Console.Write (" >> OK\n");
				} else {
					Console.Write (" >> ERROR\n");
				}
			}
			Console.WriteLine ("\nLeap Years\n");
			// Test different date formats and different years for leap years
			String[] leapQuery = { "12-08-2000", "1900/08/12", "12-Aug-04", "12-08-1975" };
			for (int i = 0; i < leapQuery.Length; i++)
			{
				Console.WriteLine (leapQuery [i] + " >> " + DateUtilities.isLeapYear(leapQuery[i]));
			}
			Console.WriteLine ("\nBirthdays\n");
			// Test the birthday utility isBirthday
			DateTime today = DateTime.Now;
			String[] birthdayQuery = {	today.Day + "/" + today.Month + "/" + today.Year,
										today.Day + "/" + today.Month + "/2008",
										today.Day + "/01/" + today.Year,
										"1/" + today.Month + "/09" 	};
			for (int i = 0; i < birthdayQuery.Length; i++) {
				Console.WriteLine (birthdayQuery [i] + " >> " + DateUtilities.isBirthday (birthdayQuery [i]));
			}
			Console.WriteLine ("\nZodiac Signs\n");
			// Tests different date formats and the getZodiac method
			String[] zodiacQuery = { "01/01/2000", "01-02-1967", "23rd March 1952", "12-Sep-07" };
			for (int i = 0; i < zodiacQuery.Length; i++) {
				Console.WriteLine (zodiacQuery [i] + " >> " + DateUtilities.getZodiac (zodiacQuery [i]));
			}
		}
	}
}

