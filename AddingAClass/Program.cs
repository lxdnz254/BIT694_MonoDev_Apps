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
			Console.WriteLine ("Hi, This is the monodev adding a new class app");
			Person p = new Person ("John", "Key", "9-August-1961", 111);
			Person q = p;
			Console.WriteLine ("Created an object with two pointers p & q");
		}
	}
}
