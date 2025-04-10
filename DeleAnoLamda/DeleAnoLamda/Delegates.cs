using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleAnoLamda
{
    public delegate void MyNewDelegate(int num);
    public delegate void OurNewDelegate(int num1, int num2);



    public class Delegates
    {
        MyNewDelegate obj = new MyNewDelegate(LetsSeeExamples.NewMethod);

        public void Invokedel()
        {
            obj(10);
        }

        //anonymous function
        OurNewDelegate vishwa = delegate ( int b, int c)
        {
            int a  = b + c;
            Console.WriteLine(a);
        };

        //lamda expression
        OurNewDelegate vish = (b, c) => { int a = b - c; };
        

    }

    public class LetsSeeExamples
    {
        public static void NewMethod(int a)
        {
            a += 23;
            Console.WriteLine(a);
        }
    }
}
