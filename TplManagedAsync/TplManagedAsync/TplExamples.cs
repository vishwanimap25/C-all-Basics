using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TPL - Task Prallel Library
namespace TplManagedAsync
{
    internal class TplExamples
    {
        public static void RunMillionIteration()
        {
            string x = "";
            for (int i = 0; i < 10; i++)
            {
                x += "v";
            }
            Console.WriteLine(x);
        }
    }
    

}
