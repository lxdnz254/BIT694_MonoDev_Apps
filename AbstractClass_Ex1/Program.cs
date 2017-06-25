using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Ex1
{
	abstract class AbstractClass
	{
		public int n = 17;
		public int add(int a, int b) {
			return (a + b + n);
		} // default implementation
	}

	class RegularClass: AbstractClass
	{
		public RegularClass() {
		}
	//	public int add(int a, int b) {
	//		return (a + b + 6);
	//	} // the "real" implementation
	}

	class MainClass
	{
		static void Main (string[] args)
		{
			Console.WriteLine ("Welcome to a simple example of abstract classes");
				RegularClass ex = new RegularClass ();
				Console.WriteLine ("The sum of 1 and 2 is: " + ex.add (1, 2));
				Console.WriteLine ("Press any key to continue ....");
				Console.ReadKey ();
		}
	}
}
