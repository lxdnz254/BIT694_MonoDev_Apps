using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingAMethod
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("Welcome to the first program with classes and ojects");
			Person p = new Person("John", "Key", "9-August-1996", 111); //Creating the first object
			Person q = new Person("Brain", "Adam", 2222);
			Person r = new Person ();
			p.displayInfo(); //Calling the display method in person
			p.AccessFirstName = "Johnson";
			Console.WriteLine ("To get the value of the first name us: " + p.AccessFirstName);
			Console.WriteLine (q.AccessFirstName);
			Console.WriteLine ("Is born in a leap year? : " + p.isLeapYear ());

			Console.WriteLine("Hello, welcome to adding a new class example");
		}
	}
}
