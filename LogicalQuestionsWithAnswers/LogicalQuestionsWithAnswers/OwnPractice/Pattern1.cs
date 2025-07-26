//2
//44
//666
//8888

namespace LogicalQuestionsWithAnswers.OwnPractice
{
    internal class Pattern1
    {
        public static void Patternone()
        {
            //int n = int.Parse(Console.ReadLine());

            int n = 10;

            for (int i = 2; i < n; i+=2)
            {
                for (int j = 1; j < i; j += 2)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
