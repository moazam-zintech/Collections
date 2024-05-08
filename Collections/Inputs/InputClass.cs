using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Collections.Model;
using Collections.System.Collection;
using Collections.System.Collection.Generic;

namespace Collections.Inputs
{
    public class InputsClass
    {
        public void InputFunction()
        {
            Console.WriteLine("\n........................................................");
            Console.WriteLine("Enter Number from 1 to 7:");
            bool okay = int.TryParse(Console.ReadLine(), out int choise);
            if (okay)
            {
                switch (choise)
                {
                    case 1:
                        ArrayLists arrays = new ArrayLists();
                        arrays.Function();
                        InputFunction();
                        break;
                    case 2:
                        HashTables ht=new HashTables();
                        ht.Function();
                        InputFunction();
                        break;
                    case 3:
                        Dictionaries dictionaries = new Dictionaries();
                        dictionaries.Function();
                        InputFunction();
                        break;
                    case 4:
                        HashSets hashSets = new HashSets();
                        hashSets.Function();
                        InputFunction();
                        break;
                    case 5:
                        LinkedListClass linkedListClass = new LinkedListClass();
                        linkedListClass.Function();
                        InputFunction();
                        break;
                    case 6:
                        List list=new List();
                        list.Function();
                        InputFunction();
                        break;
                    case 7:
                        Queues queueSets = new Queues();
                        queueSets.Function();
                        InputFunction();
                        break;
                    case 8:
                        Stacks stacks = new Stacks();
                        stacks.Function();
                        InputFunction();
                        break;
                }
            }

        }
    }
}
