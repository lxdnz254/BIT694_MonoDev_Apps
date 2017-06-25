using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance_Example_1
{
	class Customer : Person
	{
		private double balance; // bank account balance
		private int accountID; // bank account id

		public Customer (String firstName, String lastName, String dob, double balance, int accountID) // constructor
			: base(firstName, lastName, dob)
		{
			this.balance = balance;
			this.accountID = accountID;
		}

		// public method to display more information
		public void displayMoreInfo()
		{
			Console.WriteLine (" Information: ");
			Console.WriteLine (" Account ID: " + accountID);
			Console.WriteLine (" Balance: " + balance);
			Console.WriteLine (" Test the DOB: " + this.dob);
			this.displayInfo (); // calling the public method inside Person
		} // end of displayMoreInfo
	} // end of Class
} // end of namespace

