using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ArrayList - Example 2");
            ArrayList A = new ArrayList();
            A.Add(5);
            A.Add(10);
            A.Add(15);
            A.Add(25);
            A.Add(30);
            A.Add(35);
            Console.WriteLine("The size of the array A: " + A.Count);
            Console.WriteLine("The index of 10 is: " + A.IndexOf(10));
            A.Remove(10);
            Console.WriteLine("The index of 15 is: " + A.IndexOf(15));
            A.Add(10);
            Console.WriteLine("The index of 15 is: " + A.IndexOf(15));
            Console.WriteLine("The capacity of A is: " + A.Capacity);
            Console.WriteLine("Does A contain 25 " + A.Contains(25));
            Console.WriteLine("Does A contain 45 " + A.Contains(45));
            A.Add(40);
            A.Add(45);
            A.Add(45);
            A.Add(45);
            Console.WriteLine("The capacity of A is: " + A.Capacity);
            Console.WriteLine("The index of 45 is: " + A.IndexOf(45));
            Console.WriteLine("The size of the array A: " + A.Count);
            Console.WriteLine("Press any key to continue .....");
            Console.ReadKey();
        }
    }
}
