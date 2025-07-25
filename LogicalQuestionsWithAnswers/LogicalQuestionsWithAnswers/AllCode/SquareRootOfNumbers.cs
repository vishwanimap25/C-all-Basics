namespace LogicalQuestionsWithAnswers.AllCode
{
    internal class SquareRootOfNumbers
    {
        public static void Squareroot()
        {
            int n = 64;
            for(int i = 1; i <= n /2; i++)
            {
                if(i * i == n)
                {
                    Console.WriteLine($"(12)Square root of {n}: "+i);
                }
            }
        }
    }
}
