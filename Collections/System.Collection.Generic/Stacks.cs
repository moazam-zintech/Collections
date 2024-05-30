using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collection.Generic
{
    internal class Stacks
    {
        public void Function()
        {
            Stack<string> stack = new Stack<string>();
            //Inserting Data
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Push("d");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            //Pop Data
            //stack.Pop();

            stack.Count();
            stack.Reverse();


            Console.WriteLine(stack.Peek());
        


            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //Array Collection can be converted to stack Collection
            char[] arr = { 'a', 'b', 'c', 'd' };

            Stack<char> alphabit = new Stack<char>(arr);
        }
    }
}
