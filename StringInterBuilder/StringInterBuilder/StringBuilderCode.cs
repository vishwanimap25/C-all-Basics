using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterBuilder
{
    internal class StringBuilderCode
    {
        public static void BuldersExample()
        {
            string str = "himanshu";
            Stopwatch newWatch = new Stopwatch();
            newWatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                str += i;
                //Console.WriteLine(str + i);
            }
            newWatch.Stop();

            //stringBuilder makes only one space for saving value
            //hence takes less space and quiker to make
            //where we will change data continueslyNB

            StringBuilder str2 = new StringBuilder("Himanshu ");
            Stopwatch stopwatch = new Stopwatch();  
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                var strview = str2.Append(i);
                //Console.WriteLine(strview);
            }
            stopwatch.Stop();

            Console.WriteLine($"time taken for strin: {newWatch.ElapsedMilliseconds} ");
            Console.WriteLine($"time taken by stringbuilder : {stopwatch.ElapsedMilliseconds}");
        }
    }
}
