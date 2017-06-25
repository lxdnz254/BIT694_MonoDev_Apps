using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Ex2
{
	class Person
	{
		public String name;
		public Person (String name) {
			this.name = name;
		}
		public void displayInfo() {
			Console.WriteLine ("Name: " + name);
		}
	}
}

