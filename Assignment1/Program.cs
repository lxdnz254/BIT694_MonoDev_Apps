using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Test t = new Test ();
			t.testCustomers ();
			Console.WriteLine ("End of program, press any key to continue ...");
			Console.ReadKey ();
		}
	}
}
