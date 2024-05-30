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

            /*Key-Value Pairs: Dictionaries store data as key-value pairs. Each key must be unique and acts as an identifier for its corresponding value.
            Genericity: Unlike hashtables, dictionaries are generic. You specify the data types for keys (TKey) and values (TValue) when creating a dictionary instance. 
            This ensures type safety and avoids the need for explicit casting.*/

            /*Creating Dictionary using collection-initializer*/
            Dictionary<int, string> dictionary = new Dictionary<int, string>() {
                { 1,"a"},
                { 2,"ab"},
                { 3,"ac" },
                { 4,"ad"}

            };



            /*Common Operations on Dictionaries*/
            /*Insertion*/
            dictionary.Add(123, "ali");
            dictionary.Add(1232, "moazam");
            dictionary.Add(12433, "ahmad");

            /*Updating value using key*/

            dictionary[2] = "updated";

            //searching
            dictionary.ContainsValue("ali");
            dictionary.ContainsKey(123);

            //Removing items
            dictionary.Remove(123);
            //Remove All
            dictionary.Clear();

/*Iterating through Keyvalue pair*/
            foreach(KeyValuePair<int,string> key in dictionary)
            {
                Console.WriteLine($"({key.Key},{key.Value})");
            }


            /*Advantages of Dictionaries:

Type Safety: Generics ensure type safety for both keys and values, preventing potential errors and improving code maintainability.
Performance: Dictionaries are generally faster than hashtables, especially for frequent lookups, due to the efficiency of the underlying data structures.
IntelliSense Support: When using generics, you get better IntelliSense support in development environments, making coding more intuitive.*/

        }
    }
}
