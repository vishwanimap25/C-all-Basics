//Swap Values without using any variable a = 10, b = 12.
namespace LogicalQuestionsWithAnswers.AllCode
{
    internal class SwapNumbers
    {
        public static void Swapno()
        {
            int a = 10;
            int b = 12;

            a = a + b;
            a = a - b;
            b = a - b;
            Console.Write($"a = {a}, b = {b} \t");

            a = a * b;
            a = a / b;
            b = a / b;
            Console.Write($"a = {a}, b = {b} \t");

            a = a ^ b;
            a ^= b;
            b ^= b;
            Console.Write($"a = {a}, b = {b} \t");

            (a, b) = (b, a);
            Console.WriteLine($"a = {a}, b = {b} \t");
        }
    }
}
