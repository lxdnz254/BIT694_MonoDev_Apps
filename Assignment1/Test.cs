using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	public class Test
	{
		public Test ()
		{
		}

		public void testCustomers()
		{
			Console.WriteLine ("Testing Customer class methods");
			// Create some Customer Classes and test methods
			Customer c = new Customer ("John", "Key", "09-08-1961", 1111, 200.50);
			VIPCustomer v = new VIPCustomer ("The", "Pope", "06-06-1950", 333, 12.00);
			// Test displayInfo()
			c.displayInfo();
			v.displayInfo();
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
			v.deposit(10);
			Console.WriteLine ("VIP deposited $10.00, balance is now >> " + v.AccessBalance);
			Console.WriteLine ("VIP activity count is >> " + v.AccessActivityCounter);
			// check VIP withdraw (and below zero)
			v.withdraw(100);
			Console.WriteLine ("VIP withdrew $100.00, balance is now >> " + v.AccessBalance);
			Console.WriteLine ("VIP activity count is >> " + v.AccessActivityCounter);

			//end of tests
			Console.WriteLine("End of testing customers, press any key to continue ...");
			Console.ReadKey ();
		}

		public void testReadFile(String fileLocation, int fileLines)
		{
			Console.WriteLine ("Testing Read From File");
			Customer[] customerArray = ReadFromFile.customerList (fileLocation, fileLines);
			customerArray [0].displayInfo ();
			customerArray [fileLines - 1].displayInfo ();

			// end of test
			Console.WriteLine("End of testing read file, press any key to continue ....");
			Console.ReadKey ();
		}
	}
}

