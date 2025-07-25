//1.WAP to print Fibonacci series with recursion.
//2. WAP to print Fibonacci series without recursion.

namespace LogicalQuestionsWithAnswers.AllCode
{
    internal class FibonaaciNumberSeries
    {
        //without Recursion
        public static void Fibonaacino()
        {
            int num1 = 0;
            int num2 = 1;
            for(int i = 1; i <= 20; i++)
            {
                Console.Write(num1 + " ");
                int next = num1 +  num2;
                num1 = num2;
                num2 = next;
            }
        }

        //With Recursion
        public static int Fibo(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibo(n - 1) + Fibo(n - 2);
        }
    }
}
