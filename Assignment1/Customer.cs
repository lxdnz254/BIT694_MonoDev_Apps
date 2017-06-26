using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	public class Customer
	{
		private String firstName;
		private String lastName;
		private String dob; //date of birth
		private int accountID; // bank account ID
		private double balance; // bank account balance
		private int activityCounter; // keeps count of transactions

		public Customer (String firstName, String lastName, String dob, int id, double balance)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.dob = dob;
			this.accountID = id;
			this.balance = balance;
			this.activityCounter = 0;
		}

		public virtual void deposit(double amount)
		{
			double bal = AccessBalance;
			bal = bal + amount - 3;
			if (bal < 0) {
				Console.WriteLine (" Transaction Cancelled! \n The deposit is not enough to cover the transaction fee");
			} else {
				activityCounter++;
				AccessBalance = bal;
			}
		}

		public virtual void withdraw(double amount)
		{
			double bal = AccessBalance;
			bal = bal - amount - 3;
			if (bal < 0) {
				Console.WriteLine (" Transaction Cancelled!\n Not enough money in account to make withdrawl");
			} else {
				activityCounter++;
				AccessBalance = bal;
			}
		}

		public virtual void displayInfo()
		{
			String format = "{0,-15} {1}";
			Console.WriteLine (String.Format(format, "ID:", accountID));
			Console.WriteLine (String.Format(format, "Name:", firstName + " " + lastName));
			// Format date of birth .. a helper method here could be useful!
			String[] dates = dob.Split('-');
			Console.WriteLine (String.Format(format, "Birth Date:", dates [0] + "/" + dates [1] + "/" + dates [2]));
			Console.WriteLine (String.Format(format, "Balance:", String.Format ("{0:$0.00}", balance)));

		}

		public double AccessBalance {
			set { this.balance = value; }
			get { return this.balance; }
		}

		public int AccessActivityCounter {
			set { this.activityCounter = value; }
			get { return this.activityCounter; }
		}
	}
}

