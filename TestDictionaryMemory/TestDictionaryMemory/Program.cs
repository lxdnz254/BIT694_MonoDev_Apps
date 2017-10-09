using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDictionaryMemory
{
    class Program
    {
        static Dictionary<string, Dictionary<int, double>> _d;
        static Dictionary<int, double> _e;
        static void Main(string[] args)
        {

            long m1 = GC.GetTotalMemory(true);
            {
                _e = new Dictionary<int, double>();
                _d = new Dictionary<string, Dictionary<int, double>>();
                _d.Add("0", _e);
            }
            long m2 = GC.GetTotalMemory(true);
            {
                _e = new Dictionary<int, double>(100);
                _d = new Dictionary<string, Dictionary<int, double>>(8000);
                for (int i=0; i <8000; i++)
                {
                    _d.Add(i.ToString(), _e);
                }
            }
            long m3 = GC.GetTotalMemory(true);
            {
                _e = new Dictionary<int, double>(3000);
                _d = new Dictionary<string, Dictionary<int, double>>(100000);
                for (int i=0;i<100000; i++)
                {
                    _d.Add(i.ToString(), _e);
                }
            }
            long m4 = GC.GetTotalMemory(true);

            // Display results.
            Console.WriteLine("Capacity: {0}, Memory: {1}", 0, m2 - m1);
            Console.WriteLine("Capacity: {0}, Memory: {1}", 8000, m3 - m2);
            Console.WriteLine("Capacity: {0}, Memory: {1}", 100000, m4 - m3);
            Console.WriteLine("End of program.. Press any key");
            Console.ReadKey();
        }
    }
}
