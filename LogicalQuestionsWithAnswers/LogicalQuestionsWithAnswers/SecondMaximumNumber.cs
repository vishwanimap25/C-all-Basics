//WAP to find Second largest element in an array : arr[] = [12, 35, 1, 10, 34, 1, 35], without
//sorting, without using any built-in methods and without deleting duplicate elements. What will be
//the time complexity?

namespace LogicalQuestionsWithAnswers
{
    internal class SecondMaximumNumber
    {
        public static void SecondMax()
        {
            int[] arr = { 2, 5, 1, 64, 32, 53, 12 };

            int first = 0;
            int second = 0;

            foreach (int a in arr)
            {
                if(a > first)
                {
                    second = first;
                    first = a;
                }
                else if(a > second && a != first)
                {
                    second = a;
                }
            }

            Console.WriteLine(second);
        }
    }
}
