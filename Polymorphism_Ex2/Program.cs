using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Ex2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome to polymorphism - Example 2");
			Person p = new Person ("John");
			Customer pC = new Customer ("Jimmy", 2.5);
			p.displayInfo (); // the displayInfo method in Person will be called
			pC.displayInfo(); // the displayInfo method in Customer will be called
			Person q = new Customer("Brain", 3.3);
			q.displayInfo (); // which method from which class will be called?
			p = pC;
			p.displayInfo (); // which method will be executed??
			Console.WriteLine("Press any key to continue ....");
			Console.ReadKey ();
		}
	}
}
