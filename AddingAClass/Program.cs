using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingAClass
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("Welcome to the first program with classes and ojects");
			Person p = new Person("John", "Key", "9-August-1961", 111); //Creating the first object
				Person q = new Person("Brain", " Adam", 2222);
				Person r = new Person();
				p.displayInfo(); //Calling the display method in person
				p.myTwin.displayInfo();
				q.displayInfo ();
				r.displayInfo ();
				Console.WriteLine("Press any key to continue.....");

		}
	}
}
