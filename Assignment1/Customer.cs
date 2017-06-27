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
		protected double balance; // bank account balance
		protected int activityCounter; // keeps count of transactions

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
				balance = bal;
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
				balance = bal;
			}
		}

		public virtual void displayInfo()
		{
			String format = "{0,-15} {1}";
			Console.WriteLine (String.Format(format, "ID:", accountID));
			Console.WriteLine (String.Format(format, "Name:", firstName + " " + lastName));
			// Format date of birth .. a helper method here could be useful!
			Console.WriteLine (String.Format(format, "Birth Date:", DateUtilities.dateFormat(dob)));
			Console.WriteLine (String.Format(format, "Balance:", String.Format ("{0:C}", balance)));
		}

		public double AccessBalance {
			set { this.balance = value; }
			get { return this.balance; }
		}

		public int AccessActivityCounter {
			set { this.activityCounter = value; }
			get { return this.activityCounter; }
		}

		public String AccessDob {
			get { return this.dob; }
				}
	}
}

