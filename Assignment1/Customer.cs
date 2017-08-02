using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	public class Customer
	{
		private String firstName; //the first name of a customer object
		private String lastName;  //the last name of a customer object
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

		public virtual Boolean deposit(double amount)
		{
			double bal = AccessBalance;
			bal = bal + amount - 3;
			if (bal < 0) {
				Console.WriteLine (" Transaction Cancelled! \n The deposit is not enough to cover the transaction fee");
                return false;
			} else {
				activityCounter++;
				balance = bal;
                return true;
			}
		}

		public virtual Boolean withdraw(double amount)
		{
			double bal = AccessBalance;
			bal = bal - amount - 3;
			if (bal < 0) {
				Console.WriteLine (" Transaction Cancelled!\n Not enough money in account to make withdrawl");
                return false;
			} else {
				activityCounter++;
				balance = bal;
                return true;
			}
		}

		public virtual void displayInfo()
		{
			String format = "{0,-15} {1}"; // used to set the layout of the display
			Console.WriteLine (String.Format(format, "ID:", accountID));
			Console.WriteLine (String.Format(format, "Name:", firstName + " " + lastName));
			// Format date of birth .. using the DateUtilities Class methods
			Console.WriteLine (String.Format(format, "Birth Date:", DateUtilities.dateFormat(dob)));
			// Format money using "{0:C}" which formats a number into currency ( e.g $1.00 ) 
			Console.WriteLine (String.Format(format, "Balance:", String.Format ("{0:C}", balance)));
		}

		// Setters and getters used by other Classes to access Customer attributes

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

		public int AccessID {
			get { return this.accountID; }
		}

		public String AccessFullName {
			get { return this.firstName + " " + this.lastName; }
		}
	}
}

