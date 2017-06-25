using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
	public static class Utilities
	{
		public static double pi = 3.14159265;
		public static Boolean isPrime(int n)
		{
			Boolean res = true;
			for (int i = 2; i < Math.Sqrt (n); i++) 
			{
				if ((n % i) == 0) 
				{
					res = false;
					break;
				}
			} // end of for loop
			return (res);
		} // end of isPrime method
	} // end of Utilities class
} // end of namespace

