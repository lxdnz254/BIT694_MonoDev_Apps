using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	class MainClass
	{
		const String fileLocation = "../../input_assignment1.txt";
		const int fileLines = 20;

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Test t = new Test ();
			t.testCustomers ();
			t.testReadFile (fileLocation, fileLines);
			Console.WriteLine ("End of program, press any key to continue ...");
			Console.ReadKey ();
		}
			
	}
}
