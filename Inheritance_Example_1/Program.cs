using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example_1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Introduction to inheritance - Example");
			Person p = new Person ("George", "Adam", "1977-8-2"); // p is the pointer to the newly created Person
			p.displayInfo(); // displaying information related to this person
			Customer pC = new Customer("Elton", "John", "1951-02-02", 211.5, 232323);
			pC.displayMoreInfo (); // displaying information related to this person
			Employee pE = new Employee("David", "Jerald", "02-02-1966", 8000.0, "Manager");
			pE.displayMoreInfo ();
			Console.WriteLine ("Press any key to continue ....");
			Console.ReadKey ();
		} // end of main method
	} // end of class
} // end of namespace
