using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Item
    {
        public int Key { get; }
        public double Value { get; set; }
        public Item(int key, double value) { Key = key; Value = value; }
    }
}
