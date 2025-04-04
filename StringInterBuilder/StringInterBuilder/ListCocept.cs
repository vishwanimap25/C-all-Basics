using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterBuilder
{
    internal class ListCocept
    {
        public static void ListExamples()
        {
            List<int> numabers = new List<int>();
            numabers.Add(11);
            numabers.Add(12);
            numabers.Add(22);
            numabers.Add(23);
            numabers.Add(24);
            Console.WriteLine(numabers.Capacity);
            Console.WriteLine(numabers.Count);

            Employee emp1 = new Employee()
            {
                Name = "Vishwajeet",
                Age = 22,
                Designition = ".Net Developer"

            };
            Employee emp2 = new Employee()
            {
                Name = "Kartik",
                Age = 22,
                Designition = "Dish Washer"

            };
            Employee emp3 = new Employee()
            {
                Name = "Himanshu",
                Age = 21,
                Designition = "Floor Cleaner"

            };


            List <Employee> EmployeList = new List<Employee>();
            EmployeList.Add(emp1);
            EmployeList.Add(emp2);
            EmployeList.Add(emp3);
            foreach(Employee emplo in EmployeList)
            {
                Console.WriteLine($"The name of emplyee is {emplo.Name} and the age is {emplo.Age} and the profession is {emplo.Designition}");
            }
        }
    }
}
