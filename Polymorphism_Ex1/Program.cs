using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Polymorphism_Ex1
{
	class MainClass
	{
		public static int add(int a, int b, int c) {
			return (a + b + c);
		}
		public static int add(int a, int b) {
			return (a + b);
		}
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome to polymorphism - Example 1");
			Console.WriteLine ("The sum of 1 and 2 is: " + add (1, 2));
			Console.WriteLine ("The sum of 1,2 and 3 is: " + add (1, 2, 3));
			Console.WriteLine ("Press any key to continue ...");
			Console.ReadKey ();
		}
	}
}
