using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ArrayList - Example 1");
            ArrayList A = new ArrayList();
            A.Add(5);
            A.Add(10);
            A.Add(15);
            A.Add(25);
            A.Add("abc");
            A.Add(2.5);
            A.Add("abc");
            A.Add("abc");
            int sum = (int)A[1] + (int)A[2];
            Console.WriteLine("The sum of " + A[1] + " and " + A[2] + " = " + sum);
            String str = (String)A[6] + (String)A[7];
            Console.WriteLine("The two strings: " + str);
            foreach (object obj in A)
            {
                if (obj.GetType().Equals(typeof(int)))
                {
                    Console.WriteLine("Hello - This is an integer:" + obj);
                }
                else if (obj.GetType().Equals(typeof(string)))
                {
                    Console.WriteLine("Hello - This is a string:" + obj);
                }
                else if (obj.GetType().Equals(typeof(double)))
                {
                    Console.WriteLine("Hello - This is a double:" + obj);
                }
                else
                {
                    Console.WriteLine("This is not an interger, not a string and not a double: " + obj);
                }
            }

            Console.WriteLine("Press any Key...");
            Console.ReadKey();
        }
    }
}
