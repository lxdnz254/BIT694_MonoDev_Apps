using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortedList_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sorted List - Example 1");
            SortedList sl = new SortedList(); //Sorted list
            sl.Add(3, "First item added");
            sl.Add(2, "Second Item added");
            sl.Add(4, "Third Item added");
            sl.Add(14, "Fourth Item added");
            for (int i =0; i < sl.Count; i++)
            {
                Console.WriteLine("The key is: " + sl.GetKey(i) + " and the value is: " + sl.GetByIndex(i));
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
