using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleAnoLamda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Delegates
            Delegates newObj = new Delegates();
            newObj.Invokedel();


            //Anonymous Function -> used for statements
            MyNewDelegate objec = delegate (int c)
            {
                c += 90;
                Console.WriteLine(c);
            };
            objec(10);

            //OurNewDelegate vishwa = new OurNewDelegate(Delegate.vishwa);


            //lamda Expression 
            MyNewDelegate objec1 = (b) => { b += 10; Console.WriteLine(b);};
            objec1.Invoke(10);

                
        }
    }
}
