using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	public class VIPCustomer : Customer
	{
		
		// VIPCustomer is sub-class of Customer and inherits Customers attributes by using ":base()"
		public VIPCustomer (String firstName, String lastName, String dob, int id, double balance) :
			base(firstName, lastName, dob, id, balance)
		{		}

		// The VIPCustomer deposit method overrides the deposit method from Customer class
		// A VIPCustomer is not charged a fee for a transaction
		public override Boolean Deposit (double amount)
		{
			balance = balance + amount;
			activityCounter++;
            return true;
		}

		// The VIPCustomer withdraw method overrides the withdraw method from Customer class
		// A VIPCustomer is not charged a fee for a transaction
		public override Boolean Withdraw (double amount)
		{
			balance = balance - amount;
			activityCounter++;
            return true;
		}

		// The VIPCustomer displayInfo method inherits the displayInfo method from Customer class
		// The string "VIP Customer" is also displayed
		public override void DisplayInfo ()
		{
			Console.WriteLine ("VIP Customer");
			base.DisplayInfo ();
		}
	}
}

