using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "Alan",
                Salary = 5900
            };
            Customer customer2 = new Customer()
            {
                Id = 102,
                Name = "Bob",
                Salary = 12400
            };
            Customer customer3 = new Customer()
            {
                Id = 103,
                Name = "Carter",
                Salary = 6200
            };

            Dictionary<int, Customer> CustomerValues = new Dictionary<int, Customer>();
            CustomerValues.Add(customer1.Id, customer1);
            CustomerValues.Add(customer2.Id, customer2);
            CustomerValues.Add(customer3.Id, customer3);

            Customer customer101 = CustomerValues[101];

            Console.WriteLine($"\tId = {customer101.Id} \n\tName = {customer101.Name} \n\tSalary = {customer101.Salary}");


            foreach (KeyValuePair<int, Customer> kvp in CustomerValues)
            {
                Console.WriteLine("key = {0}", kvp.Key );
                Customer cust = kvp.Value;
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
                Console.WriteLine("--------------------------------------------------------------------");

            }

            foreach (var kvp in CustomerValues.Keys)
            {
                Console.WriteLine(kvp);
            }
            foreach (var cust in CustomerValues.Values)
            {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
                Console.WriteLine("--------------------------------------------------------------------");
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public int Salary { get; set; }
    }
}
