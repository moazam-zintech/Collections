using System.Collections;
namespace Collections.System.Collection.Generic
{
    internal class HashSets
    {
        public void Function()
        {
            HashSet<string> keys = new HashSet<string>()
            {
                "c",
                "c++",
                "c#",
                "Python"
            };
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
