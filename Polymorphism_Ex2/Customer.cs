using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Ex2
{
	class Customer: Person
	{
		public double balance;
		public Customer (String name, double balance) : base(name)
		{
			this.balance = balance;
		}
		public void displayInfo()
		{
			Console.WriteLine ("Balance: " + balance);
		}
	}
}

