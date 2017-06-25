using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
	class MainClass
	{
		interface InterfaceExample
		{
			int add(int a, int b); //This interface does not include real code
		}

		class ClassExample: InterfaceExample
		{
			public int add(int a, int b) {return (a+b);} // An implemenation of the interface
		}
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome to an Interface Example in C#");
			ClassExample ex = new ClassExample ();
			Console.WriteLine ("The sum of 5 and 6 is: " + ex.add (5, 6));
			Console.WriteLine ("Press any key to continue ....");
			Console.ReadKey ();
		}
	}
}
