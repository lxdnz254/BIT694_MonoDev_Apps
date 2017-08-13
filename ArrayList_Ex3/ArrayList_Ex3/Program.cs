using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Ex3
{
    class Program
    {
        class Person
        {
            public String name;
            public Person(String name) { this.name = name; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ArrayList - Example 3");
            ArrayList A = new ArrayList();
            Person p = new Person("John");
            A.Add(p);
            
            p = new Person("Matt");
            A.Add(p);
            
            int count = A.Count;
            for (int i = 0; i < count; i++)
            {
                p = new Person("David");
                A.Add(p);
                
            }
            int count2 = A.Count;
            for (int i = 0; i < count2; i++)
            {
                Person q = (Person)A[i];
                Console.WriteLine("The name is: " + q.name);
            }
            Console.WriteLine(A.IndexOf(p));
            Console.WriteLine("Press any key to continue .....");
            Console.ReadKey();
        }
    }
}
