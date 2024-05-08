using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collection
{
    internal class HashTables
    {
        public void Function()
        {
            Hashtable ht = new Hashtable()
            {
                { 1,"a"},
                { 2,"ab"},
                { 3,"ac" },
                { 4,"ad"}
            };
            ht.Add(5, "e");

            //Updating Hashtables
            ht[4] = "I got updated";

            //Deleting
            ht.Remove(5);

            //REtriving 
            foreach (int key in ht.Keys)
            {
                Console.WriteLine(ht[key]);
            }
        }
    }
}
