using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace List_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to list data strucutre - Example 1");
            List<string> lstString = new List<string>();
            lstString.Add("John");
            lstString.Add("Adam");
            lstString.Add("Joe");
            lstString.Remove("Adam");
            foreach (string line in lstString)
            {
                Console.WriteLine(line);
            }
            
            List<int> lstInts = new List<int>();
            lstInts.Add(5);
            lstInts.Add(4);
            lstInts.Add(3);
            lstInts.RemoveAt(0);
            foreach (int lineInt in lstInts)
            {
                Console.WriteLine("" + lineInt);
            }
            Console.WriteLine("the index of 4 is: " + lstInts.IndexOf(4));
            Console.WriteLine("the index of 17 is: " + lstInts.IndexOf(17));
            Console.WriteLine("Please press any key to continue .....");
            Console.ReadKey();
        }
    }
}
