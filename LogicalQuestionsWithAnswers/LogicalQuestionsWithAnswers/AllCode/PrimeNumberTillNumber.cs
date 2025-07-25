namespace LogicalQuestionsWithAnswers.AllCode
{
    internal class PrimeNumberTillNumber
    {
        public static void Primenumbers()
        {
           
            for(int i = 2; i <= 20; i++)
            {
                bool IsPrime = true;
                for (int j = 2; j < i /2; j++)
                {
                    if(i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if(IsPrime)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
