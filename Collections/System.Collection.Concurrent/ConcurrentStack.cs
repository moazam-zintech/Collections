using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Reflection.Metadata.Ecma335;

namespace Collections.System.Collection.Concurrent
{
    internal class ConcurrentStack
    {
        public void Function()
        {

            //Built in functions which allow multiple thread to push and pop data
            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            bool success = stack.TryPop(out int item);

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
