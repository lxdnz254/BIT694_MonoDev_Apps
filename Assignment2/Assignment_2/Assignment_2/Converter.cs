using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Converter
    {
        private int counter; // could be changed to long
        private Hashtable paths; // =new Hashtable();
        private ArrayList ids;

        public Converter()
        {
            counter = 0;
            paths = new Hashtable();
            ids = new ArrayList();
        } // end of constructor

        public int GetID(String path) // return the ID for this file
        {
            return ((int)paths[path]);
        }

        public string GetPath(int id) // return the path for this id
        {
            return ((string)ids[id]);
        }

        public int AssignId(String path) // Assign id to this new file
        {
            int id = counter;
            counter++;
            paths[path] = id;
            ids.Add(path);
            return (id);
        } // end of AssignId
    }
}
