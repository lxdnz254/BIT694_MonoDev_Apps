using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading_Ex1
{
	class MainClass
	{
		public static void method2()
		{
			Console.WriteLine ("Hello - I am method2 and I am going to print numbers from 1 to 20");
			for (int i = 1; i <= 20; i++) {
				Console.WriteLine ("Method 2: " + i);
				Thread.Sleep (5);
			}
		}

		public void method1()
		{
			Console.WriteLine ("Hello - I am method1 and I am going to print numbers from 1 to 20");
			for (int i = 1; i <= 20; i++) {
				Console.WriteLine ("Method 1: " + i);
				Thread.Sleep (100);
			}
		}

		static void Main (string[] args)
		{
			Console.WriteLine("Welcome to multi threading - Example 1");
			ThreadStart TS = new ThreadStart(new MainClass().method1);
			Thread T1 = new Thread(TS);
			T1.Start(); // Start running the threading
			method2(); // The main function is also a thread
			Console.WriteLine("Press any key to continue .....");
			Console.ReadKey();
		}
	}
}
