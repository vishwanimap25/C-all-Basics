using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StringInterBuilder
{
    internal class StringInterpolation
    {
        public static void Examples()
        {
            int a = 10;
            int b = 20;

            //Concatination
            Console.WriteLine("the sum of " + a + " and " + b + " is " + (a + b));
            //place holder
            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, a + b);

            //Interpolation -> it is more easy to use;
            Console.WriteLine($"THE SUM of {a} and {b} is {a + b}");


            //Asseing values is also easier -> while using string interpolation
            string s;

            s = "the sum of " + a + " and " + b + " is " + (a + b);
            s = string.Format("The sum of {0} and {1} is {2}", a, b, a + b);

            //->
            s = $"THE SUM of {a} and {b} is {a + b}";


        }
        internal void AnotherExample()
        {

            //for checking there is data in string or not
            //always use -> string.IsNullOrEmpty(< name of string >);

            string v = null;
            string f = "  ";
            Console.WriteLine(string.IsNullOrEmpty(v)); //true
            Console.WriteLine(string.IsNullOrEmpty(f)); // false -> space also takes space
        }

    }
}
