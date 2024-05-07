using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collections.Collections;
using Collections.Model;

namespace Collections.Inputs
{
    public class Inputs1
    {
        LinkedListClass linkedListClass = new LinkedListClass();
        Product product = new Product();
        public Inputs1()
        {
        }
        public void InputFunction()
        {


            Console.WriteLine(".........input........");

            void InputMethod()
            {
                Console.WriteLine("Enter Name:");
                product.Name = Console.ReadLine();
                Console.WriteLine("Enter ID:");
                product.Id = int.Parse(Console.ReadLine());
            }

            InputMethod();
             linkedListClass.Function();
            bool okay = int.TryParse(Console.ReadLine(), out int choise);
            switch (choise)
            {
                case 1:

                    InputMethod();
                    linkedListClass.Function();
                    break;
                case 2:
                    HashSets hashSets = new HashSets();
                    hashSets.Function();

                    break;
                case 3:

                    Dictionaries dictionaries = new Dictionaries();
                    Console.WriteLine("Please Enter number:");
                    int search=int.Parse(Console.ReadLine());
                    dictionaries.Function();
                    break;
                case 4:
                    break;
            }

        }
    }
}
