using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Collections
{
    internal class Dictionaries
    {
        public void Function()
        {
            int search = 123;
            //Creating Dictionary using collection-initializer
            Dictionary<int, string> dic = new Dictionary<int, string>() {
                { 1,"a"},
                { 2,"ab"},
                { 3,"ac" },
                { 4,"ad"}

            };

            //Insertion
            dic.Add(123, "ali");
            dic.Add(1232, "moazam");
            dic.Add(12433, "ali moazma");



            //Updating 

            dic[2] = "Hello I am 2";

            //searching
            foreach (int i in dic.Keys)
            {
                if (dic.ContainsKey(search))
                {
                }
            }
            //Removing items
            dic.Remove(123);

            //Remove All
            dic.Clear();

        }
    }
}
