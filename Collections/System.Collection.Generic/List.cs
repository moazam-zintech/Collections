using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collection.Generic
{
    internal class List
    {
        public void Function()
        {
            Console.WriteLine("....................List...................\n");

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(list.Count);
            list.Insert(6, 8080);


            //Add from index 4 to onward
            list.InsertRange(4, list);


            //Adding Array Collection to List
            int[] arr = { 12, 34, 45, 56, 67 };

            list.InsertRange(5, arr);


            //Remove at specfic index
            list.RemoveAt(6);

            //Remove 3 Items from index 6 to onward including index 6
            list.RemoveRange(6, 3);

            Console.WriteLine(list.Count);
            //Remove specific Item 
            list.Remove(8080);

            list.Count();

            list.Sort();

            list.Max();

            //Adding All the elements of Array to List

            Console.WriteLine("..........Adding All the elements of Array to List......\n");
            string[] cities = { "Lahore", "karachi", "London" };

            List<string> citiesList = new List<string>(cities);
            //citiesList.AddRange(cities);

            foreach (string city in citiesList)
            {
                Console.WriteLine($"{city}");
            }
        }

    }
}
