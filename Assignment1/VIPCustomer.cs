using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	public class VIPCustomer : Customer
	{
		

		public VIPCustomer (String firstName, String lastName, String dob, int id, double balance) :
			base(firstName, lastName, dob, id, balance)
		{		}

		public override void deposit (double amount)
		{
			balance = balance + amount;
			activityCounter++;
		}

		public override void withdraw (double amount)
		{
			balance = balance - amount;
			activityCounter++;
		}

		public override void displayInfo ()
		{
			Console.WriteLine ("VIP Customer");
			base.displayInfo ();
		}
	}
}

