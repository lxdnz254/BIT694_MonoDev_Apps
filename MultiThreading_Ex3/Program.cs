using System;
using System.Collections.Generic;

using System.ComponentModel;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading_Ex3
{
	class MainClass
	{
		public static int counter;

		static readonly object _object = new object();



		public static void add()

		{

			for (int i = 0; i <= 1000000; i++)

			{

				counter++;

			}

		}

		static void Main(String[] args)
		{

			Console.WriteLine ("Welcome to multi threading - Example 3");

			counter = 0;

			ThreadStart TS = new ThreadStart (add);

			Thread T1 = new Thread (TS);

			T1.Start (); // Start running the thread

			add ();

			while (T1.IsAlive) {

				Thread.Sleep (10);

			}

			Console.WriteLine ("The ValueType of counter is: " + counter);

			Console.WriteLine ("Press any key to continue .....");

			Console.ReadKey ();
		}
	}
}
