using System;

namespace AddingAClass
{
	public class Person
	{
		private String firstName;
		private String lastName;
		private String dob; // date of birth
		private int id;
		public Person myTwin;

		public Person (String firstName, String lastName, String dob, int id)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.dob = dob;
			this.id = id;
			myTwin = new Person ("myTwin", lastName, id);
		}

		public Person() {}

		public Person(String firstName, String lastName, int id)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = id;
		}

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

