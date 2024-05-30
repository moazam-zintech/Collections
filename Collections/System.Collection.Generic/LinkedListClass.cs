using Collections.Model;

namespace Collections.System.Collection.Generic
{
    internal class LinkedListClass
    {
        public void Function()
        {


            /*Linked lists in C# are linear data structures where elements (nodes) are not stored 
             * in contiguous memory locations. Instead, each node contains data and a reference (pointer) 
             * to the next node in the sequence. This allows for dynamic insertion and removal of
             * elements at any position without affecting the rest of the list.*/

            /*Key Concepts (using LinkedList<T>):

            Genericity: LinkedList<T> is generic, allowing you to specify the data type (T) stored in each node.


            Nodes: Each element in the list is a node. A node typically consists of two parts: data (Value) and 
            a reference (Next) to the next node in the sequence. The first node (First) and the last node (Last) 
            are maintained by the LinkedList<T> class.



            Doubly Linked List: The LinkedList<T> class in C# implements a doubly linked list. This means that each
            node has a reference not only to the next node but also to the previous node, enabling traversal in
            both directions.*/

            Product product = new Product();

            LinkedList<Product> linkList = new LinkedList<Product>();

            product.Name = "Ali";
            product.Id = 12;

            //Add Values in the List at Last position
            linkList.AddLast(product);
            //Add First in the List at Last position
            linkList.AddFirst(product);

            // Retrive List 

            foreach (Product link in linkList)
            {
                Console.WriteLine(link.Name + " " + link.Id);
            }

        }
    }
}
