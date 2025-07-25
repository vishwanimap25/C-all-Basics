//WAP to find missing elements from the array?
namespace LogicalQuestionsWithAnswers.AllCode
{
    internal class MissingElements
    {
        public static void ElementMiss()
        {

            int[] arr = { 2, 4, 5, 12, 11, 8, 6 };

            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = arr[i] + 1; j < arr[i + 1]; j++)
                {
                    Console.Write(j + "  ");
                }
            }
        }
    }
}
