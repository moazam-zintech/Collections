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
            /*A hashtable is a non-generic collection that stores key-value pairs.*/
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

         /* Key Uniqueness: Keys in a hashtable must be unique. If you attempt to add a duplicate key, 
         * an exception is typically thrown.
         * 
         * 
         * 
         * Non-Generic: Hashtables are non-generic, meaning they can store any type of object as keys
         * and values. 
         * However, for type safety and better performance, consider using the generic
         * Dictionary<TKey, TValue> class from the System.Collections.Generic namespace in modern C# development.*/
    }
}
