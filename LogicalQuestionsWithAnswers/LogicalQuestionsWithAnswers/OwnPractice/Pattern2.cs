//N = 17
//1 2 3 4 5 * ****
//11 12 13 14 15 * *

namespace LogicalQuestionsWithAnswers.OwnPractice
{
    internal class Pattern2
    {
        public static void Patterntwo()
        {
            int n = 18;

            for (int i = 1; i <= n; i += 10)
            {
                //number
                for (int j = 0; j < 5 && (i + j) <= n; j++)
                {
                    Console.Write((i + j) + " ");
                }
                //star
                for (int j = 0; j < 5; j++)
                {
                    int star = i + j + 5;
                    if (star <= n)
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
