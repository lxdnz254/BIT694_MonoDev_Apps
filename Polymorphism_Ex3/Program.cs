using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Ex3
{
	class MainClass
	{
		class Animal
		{
			public Animal(){
			}
			public virtual void getFood() {
				Console.WriteLine ("Get generic food");
			}
		}
		class Dog: Animal
		{
			public Dog() {}
			public override void getFood ()
			{
				Console.WriteLine ("Give me meat - I am a dog");
			}
		}

		class Cow: Animal
		{
			public Cow() {}
			public override void getFood()
			{
				Console.WriteLine ("Give me grass - I am a cow");
			}
		}
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome to polymorphism - Example 3");
			Animal[] animals = new Animal[10]; // array of 10 pointers to Animal
			for (int i = 0; i < 10; i++) {
				if ((i % 2) == 0) {
					animals [i] = new Cow (); // a Cow is created
				} else {
					animals [i] = new Dog (); // or a Dog is created
				}
			}

			for (int i = 0; i < 10; i++) {
				animals [i].getFood ();
			}
			Console.WriteLine ("Press any key to continue ... ");
			Console.ReadKey ();
		}
	}
}
