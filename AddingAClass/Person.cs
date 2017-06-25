using System;

namespace AddingAClass
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
		}
	}
}

