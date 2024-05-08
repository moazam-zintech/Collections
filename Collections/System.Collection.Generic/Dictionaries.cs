using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collection.Generic
{
    internal class Dictionaries
    {
        public void Function()
        {
            /*Dictioary is Genraic Collection that store key value
             * pair*/

            int search = 123;
            //Creating Dictionary using collection-initializer
            Dictionary<int, string> dictionary = new Dictionary<int, string>() {
                { 1,"a"},
                { 2,"ab"},
                { 3,"ac" },
                { 4,"ad"}

            };

            //Insertion
            dictionary.Add(123, "ali");
            dictionary.Add(1232, "moazam");
            dictionary.Add(12433, "ahmad");
            //Updating value using key

            dictionary[2] = "updated";

            //searching
            dictionary.ContainsValue("ali");
            //Removing items
            dictionary.Remove(123);
            //Remove All
            dictionary.Clear();

        }
    }
}
