using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collections.Model;
using Collections.System.Collection;
using Collections.System.Collection.Generic;

namespace Collections.Inputs
{
    public class Inputs1
    {
        public void InputFunction()
        {
            Console.WriteLine("Enter Number from 1 to 7:");
            bool okay = int.TryParse(Console.ReadLine(), out int choise);
            if (okay)
            {
                switch (choise)
                {
                    case 1:
                        ArrayLists arrays = new ArrayLists();
                        arrays.Function();
                        break;
                    case 2:
                        Dictionaries dictionaries = new Dictionaries();
                        dictionaries.Function();

                        break;
                    case 3:
                        HashSets hashSets = new HashSets();
                        hashSets.Function();
                        break;
                    case 4:
                        LinkedListClass linkedListClass = new LinkedListClass();
                        linkedListClass.Function();
                        break;
                    case 5:
                        Queues queueSets = new Queues();
                        queueSets.Function();
                        break;
                    case 6:
                        Stacks stacks = new Stacks();
                        stacks.Function();
                        break;
                    case 7:
                        System.Environment.Exit(0);
                        break;
                }
            }

        }
    }
}
