using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedManipObjClassPointers
{
	public class Person
	{
		private String firstName;
		private String lastName;
		private String dob; // date of birth
		private int id;
		public Bag myBag;

		public Person (String firstName, String lastName, String dob, int id)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.dob = dob;
			this.id = id;
			myBag = new Bag ("Kmart", 9.99, 20.5, 15.5, this);
		}

		public String AccessFirstName // AccessFirstName is just a name!
		{
			set { this.firstName = value; }
			get { return this.firstName; }
		} //end of setter and getter for firstName

		public void displayInfo()
		{
			Console.WriteLine("The information related to this person:");
			Console.WriteLine("First name: " + firstName);
			Console.WriteLine("Last name: " + lastName);
			Console.WriteLine("Date of Birth: " + dob);
			Console.WriteLine("ID: " + id);
		}// end of displayInfo method
	}
}

