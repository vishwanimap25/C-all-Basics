//WAP to reverse an integer without converting it to a string
//without using any built-in methods.

namespace LogicalQuestionsWithAnswers.AllCode
{
    internal class IntergerReverse
    {
        public static void Reverseint()
        {
            int num = 253658;

            int reverse = 0;

            while(num > 0)
            {
                int digit = num % 10;

                reverse = reverse * 10 + digit;
                
                num /= 10;
            }

            Console.WriteLine(reverse);
        }
    }
}
