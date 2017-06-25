using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingAMethod
{
	public class Person
	{
		private String firstName;
		private String lastName;
		private String dob; // date of birth
		private int id;

		public Person (String firstName, String lastName, String dob, int id)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.dob = dob;
			this.id = id;
		} // end of constructor

		public void displayInfo()
		{
			Console.WriteLine ("The information related to this person:");
			Console.WriteLine ("First name: " + firstName);
			Console.WriteLine ("Last name: " + lastName);
			Console.WriteLine ("Date of Birth: " + dob);
			Console.WriteLine ("ID: " + id);
		} // end of displayInfo method

		public String AccessFirstName {
			set { this.firstName = value; }
			get { return this.firstName; }
		} // end of setter and getter for firstName

		public bool isLeapYear()
		{
			String[] date = dob.Split ('-');
			int year = int.Parse (date [2]);

			if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))) 
			{
				return true;
			}
			return false;
		}
	} // end of class
} // end of namespace

