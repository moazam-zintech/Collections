using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collection
{
    internal class ArrayLists
    {
        public void Function()
        {
            Console.WriteLine("..........Non-Generic Array List......\n");
            /*   Its Same as array, the diffrence is its size increase dynamicaly 
              */


            Console.WriteLine("..........Create An Array, Add items in Array List......\n");
            //Create An Array
            var array = new ArrayList()
            {
                1,2,3,4,"ali",4.3
            };
            array.Add(10);

            foreach (var item in array)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine("\n\n\n..........Adding Entire Array into ArrayList......\n");
            char[] vovels = { 'a', 'e', 'i', 'u' };

            array.AddRange(vovels);

            foreach (var item in array)
            {
                Console.Write(item + ",");
            }

            Console.Write("\n\n\n..........Update Array using index......\n");
            array[array.Count - 1] = "Last digit get updated";
            foreach (var item in array)
            {
                Console.Write(item + ",");
            }

            Console.Write("\n\n\n..........Remove Element from Array.....\n");
            //Delete Item from Array
            array.RemoveAt(array.Count - 1);
            array.RemoveRange(array.Count - 4, 3);

            Console.Write("\n\n\n....................................\n");

            // Retrive List
            foreach (var item in array)
            {
                Console.Write(item + ",");
            }

            //Search Item from List
            array.Contains("e");

            //check Index
            array.IndexOf("a");

        }
    }
}
