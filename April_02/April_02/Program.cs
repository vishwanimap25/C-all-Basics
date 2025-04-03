using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April_02
{
    //using for lamda expression
    public delegate int MyNewDelegates(int num1, int num2);
    
    public delegate void MyDelegate(int num);

    delegate void NewDelegate(string name);
    internal class Program
    {

        public static void MyMethod(MyDelegate del, int a)
        {
            a += 30; //35
            del.Invoke(a);  //invoke -> assing a value or giving a value
        }
        //Anonymous Function
        public void newFunction(NewDelegate vishwa, string a)
        {
            a = "newVishwa";
            vishwa.Invoke(a);
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            //start of anynmous function
            //MyDelegate obj = delegate (int a)
            //{
            //    a += 10;
            //    Console.WriteLine(a);
            //};
            //end of anonymous function
            //obj.Invoke(4);

            Program.MyMethod(delegate (int b) { b += 10; Console.WriteLine(b); }, 5);

            //45


            //lamda expression
            //there are two types -> expression and statement

            //statement 
            //MyNewDelegates obje = (a, b) =>
            //{
            //    a += 3;
            //    Console.WriteLine(a)
            //}

            //expression
            MyNewDelegates obje = (a, b) => a + b;
            Console.WriteLine(obje.Invoke(10,20));
            

        }
    }
}
