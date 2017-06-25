using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance_Example_1
{
	class Employee : Person
	{
		private double wage; // wage
		private String position; // position

		public Employee (String firstName, String lastName, String dob, double wage, String position):
			base(firstName, lastName, dob)
		{
			this.wage = wage;
			this.position = position;
		} // end of constructor

		public void displayMoreInfo()
		{
			Console.WriteLine (" Information: ");
			Console.WriteLine (" Position: " + position);
			Console.WriteLine (" Wage: " + wage);
			this.displayInfo (); // display the information from the base class
		} // end of display information
	} // end of class
}

