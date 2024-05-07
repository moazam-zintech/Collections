using System.Collections;

namespace Collections.Collections
{
    internal class HashSets
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



            
        }
    }
}
