using System;

namespace ConstructPersonsFromFile
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hi, this is the program to parse a list of people");
			Person[] personArray = ReadFromFile.personList (); // get the list of people

			// iterate over array. If person is born in leap year output their first name
			for (int i = 0; i < personArray.Length; i++) {
				if (personArray [i].isLeapYear ()) {
					Console.WriteLine (personArray [i].AccessFirstName + " is born in a leap year.");
				}
			} // end of for loop

			// MonoDev does this automatically so it will repeat
			Console.WriteLine("Press any key to continue ...");
			Console.ReadKey ();
		} // end of main
	} // end of class
} // end of namespace
