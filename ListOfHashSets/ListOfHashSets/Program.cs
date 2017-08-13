using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ListOfHashSets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of list of Hashsets");
            List<HashSet<String>> lst = new List<HashSet<string>>();
            HashSet<String> s1 = new HashSet<String>
            {
                "Car",
                "Automobile",
                "Vehicle"
            };
            lst.Add(s1);
            s1 = new HashSet<String>
            {
                "Lecturer",
                "Tutor",
                "Teacher",
                "Facilitator"
            };
            lst.Add(s1);
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine("Synonyms:");
                foreach (String str in lst[i])
                {
                    Console.Write(str + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue .....");
            Console.ReadKey();
        }
    }
}
