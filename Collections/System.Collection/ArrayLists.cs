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

            /*ArrayList is a non-generic collection that represents a resizable array of objects. 
             * It offers a dynamic way to store elements of various data types, unlike traditional arrays with fixed sizes.*/


            /*Create An Array, Add items in Array List.*/

        
            var array = new ArrayList()
            {
                1,2,3,4,"ali",4.3
            };
            array.Add(10);

            foreach (var item in array)
            {
                Console.Write(item + ",");
            }

            /*Adding Entire Array into ArrayList*/
            char[] vovels = { 'a', 'e', 'i', 'u' };

            array.AddRange(vovels);

            foreach (var item in array)
            {
                Console.Write(item + ",");
            }

            /*Update Array using index*/
            array[array.Count - 1] = "Last digit get updated";
            foreach (var item in array)
            {
                Console.Write(item + ",");
            }

            /*Remove Element from Array*/
         
            array.RemoveAt(array.Count - 1);
            array.RemoveRange(array.Count - 4, 3);

            /*Retrive List*/
            foreach (var item in array)
            {
                Console.Write(item + ",");
            }

            /*Search Item from List*/
            array.Contains("e");

            /*check Index*/
            array.IndexOf("a");

        }
    }
}
