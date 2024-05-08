using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Collections.System.Collection.Concurrent
{
    internal class ConcurrentDictionary
    {
        public void Function()
        {
            ConcurrentDictionary<int,string> concurrentDictionary = new ConcurrentDictionary<int,string>();
            Parallel.For(0, 10, i =>
            {
                concurrentDictionary.TryAdd(i, $"Value{i}");
            });

            foreach( var key in concurrentDictionary )
            {
                Console.WriteLine( key.Key+", "+key.Value);
            }
        }
    }
}
 