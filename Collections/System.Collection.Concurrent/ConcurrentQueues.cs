using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Collections.System.Collection.Concurrent
{
    internal class ConcurrentQueues
    {
        public void Function()
        {
            ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();

            Parallel.For(0, 10, i =>
            {
                concurrentQueue.Enqueue(i);
            });

            Parallel.ForEach(concurrentQueue, item =>
            {
                Console.WriteLine($"Dequeued: {item}");
            });
        }
    }
}
