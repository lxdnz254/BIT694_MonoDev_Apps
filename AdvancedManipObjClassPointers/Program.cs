using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedManipObjClassPointers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine(" Welcome to advanced manipulations of pointers");
			Person p = new Person("John", "Key", "9-August-1961", 1111);
			Console.WriteLine(p.myBag.owner.myBag.owner.myBag.owner.myBag.owner.AccessFirstName);

			p.displayInfo();
			p.myBag.owner.myBag.owner.myBag.owner.myBag.owner.displayInfo(); // easily written as p.displayInfo()
			p.myBag.owner.myBag.owner.myBag.displayInfo(); // better as p.myBag.displayInfo()

			Console.WriteLine("Press any key to continue .....");
			Console.ReadKey();
		}
	}
}
