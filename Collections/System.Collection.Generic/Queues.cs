﻿namespace Collections.System.Collection.Generic
{
    internal class Queues
    {
        public void Function()
        {
            Queue<string> queue = new Queue<string>();
            //Inserting Data Queue(FIFO)
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Enqueue("d");

            //Removing Data 
            queue.Dequeue();

            //Searching Data
            bool check = queue.Contains("a");

            //Display the Data
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
