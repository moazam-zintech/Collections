namespace Collections
{
    public class ListClass
    {
        public void Function()
        {

            List<Customer> list = new List<Customer>()
            {
                new Customer{Name="Ali",Age=14},
                new Customer{Name="Ahmad",Age=23},
                new Customer{Name="Ahmaddd",Age=12}
            };

            //With Normal Function
            foreach (var cust in list)
            {
                Console.WriteLine(cust.Name + "\n" + cust.Age);
            }

            //With Lambda Function
            list.ForEach(x => Console.WriteLine(x.Name));


            var teenAger = list.Where(x => x.Age < 20 && x.Age > 10);

            foreach (var item in teenAger)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
