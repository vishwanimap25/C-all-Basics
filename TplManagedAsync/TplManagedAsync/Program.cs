using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TplManagedAsync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread o1 = new Thread(TplExamples.RunMillionIteration);
            //o1.Start();

            //The below called methods works on single thread
            //MultiThreading.CountDown();
            //MultiThreading.CountUp();


            //for doing MultiThreading, we can do like this ->
            Thread timer1 = new Thread(MultiThreading.CountDown);
            Thread timer2 = new Thread(MultiThreading.CountUp);
            timer1.Start();
            timer2.Start(); //by doing this -> it will do Multithreading

            //if there is a paramerter passed, use lamda expression like below
            Thread countAgain = new Thread(() => MultiThreading.CountAgain("This is for parameter"));
            countAgain.Start(); 
        }
    }
}
