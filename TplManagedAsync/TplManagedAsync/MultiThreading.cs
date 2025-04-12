using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TplManagedAsync
{
    internal class MultiThreading
    {
        public static void CountDown()
        {
            for(int i = 10; i >= 0 ; i--)
            {
                Console.WriteLine("Time #1:  " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 Ended");
        }

        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2:  " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 Ended");
        }


        public static void CountAgain(string name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(name +" :   " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer COUNT AGAIN Ended");
        }
    }
}
