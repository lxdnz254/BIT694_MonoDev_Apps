using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example_1
{
	class Person
	{
		public String firstName;
		private String lastName;
		protected String dob; // date of birth

		public Person (String firstName, String lastName, String dob)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.dob = dob;
		}

		public void displayInfo()
		{
			Console.WriteLine (" Name: " + firstName + " " + lastName);
			Console.WriteLine (" Date of Birth: "+ dob);
		}
	}
}

