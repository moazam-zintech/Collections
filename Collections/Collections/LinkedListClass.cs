using Collections.Model;

namespace Collections.Collections
{
    internal class LinkedListClass
    {
        public void Function()
        {
            LinkedList<Product> linkList = new LinkedList<Product>();
            Product product = new Product();

            product.Name = "Ali";

            product.Id = 12;

            //Add Values in the List at Last position
            linkList.AddLast(product);

            //Update List


            //Delete Item from List


            // linkList.RemoveLast();

            // Retrive List 

            foreach (Product link in linkList)
            {
                Console.WriteLine(link.Name + " " + link.Id);
            }

            //Search Item from List

            //Sort List

            //Adding All the elements of Array to List
            /*
                        string[] cities = { "Lahore", "karachi", "London" };

                        List<string> citiesList= new List<string>();
                        citiesList.AddRange(cities);

                        foreach (string city in citiesList)
                        {
                            Console.WriteLine($"{city}");
                        }*/

            //Inserting Element in List

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
        }
    }
}
