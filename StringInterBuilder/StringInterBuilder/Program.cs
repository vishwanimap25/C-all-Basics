using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string interpolation
           StringInterpolation str = new StringInterpolation(); //for non-static and instance
            str.AnotherExample();

            StringInterpolation.Examples();  //for static

            StringBuilderCode.BuldersExample();  //String Builer
           
        }
    }
}
