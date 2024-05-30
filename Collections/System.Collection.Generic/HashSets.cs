using System.Collections;
namespace Collections.System.Collection.Generic
{
    internal class HashSets
    {
        public void Function()
        {

            /*HashSet<T> is a collection that represents an unordered set of unique elements. 
             * It's designed for scenarios where you need to efficiently:


            Store unique elements: No duplicate values are allowed within a HashSet.
            Check for element existence: Quickly determine if an element is present in the set.*/

            HashSet<string> keys = new HashSet<string>()
            {
                "c",
                "c++",
                "c#",
                "Python"
            };

            //Duplicate will not be added
            keys.Add("c");

            foreach (string key in keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("......................HashTables...............");

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
