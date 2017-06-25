using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hi and welcome to this example which will show a demonstration of a static class");
			Console.WriteLine ("Enter a number");
			String line = Console.ReadLine ();
			int n = int.Parse (line);
			if (Utilities.isPrime (n)) {
				Console.WriteLine ("Hi, the number you entered was " + n + " and it is a prime number");
			} else {
				Console.WriteLine ("Hi, the number you entered was " + n + " and is not a prime number");
			}
			Console.WriteLine (Utilities.pi);

		} // end of main
	} // end of the class
} // end of namespace
