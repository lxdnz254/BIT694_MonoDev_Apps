using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	public class VIPCustomer : Customer
	{
		private int activityCounter;

		public VIPCustomer (String firstName, String lastName, String dob, int id, double balance) :
			base(firstName, lastName, dob, id, balance)
		{
			this.activityCounter = 0;
		}

		public override void deposit (double amount)
		{
			AccessBalance = AccessBalance + amount;
			AccessActivityCounter++;
		}

		public override void withdraw (double amount)
		{
			AccessBalance = AccessBalance - amount;
			AccessActivityCounter++;
		}
	}
}

