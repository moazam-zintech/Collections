using Collections.Model;

namespace Collections.System.Collection.Generic
{
    internal class LinkedListClass
    {
        public void Function()
        {
            Product product = new Product();
            Console.WriteLine(".................Inserting Element in Linked List......................\n");

            Console.WriteLine("..........Create A Linked List of Product......\n");

            LinkedList<Product> linkList = new LinkedList<Product>();

            product.Name = "Ali";
            product.Id = 12;

            //Add Values in the List at Last position
            linkList.AddLast(product);

            // Retrive List 

            foreach (Product link in linkList)
            {
                Console.WriteLine(link.Name + " " + link.Id);
            }

        }
    }
}
