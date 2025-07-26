//WAP with 2 different logic, to find all duplicate numbers in an array.
namespace LogicalQuestionsWithAnswers.AllCode
{
    internal class DuplicateNumbersInArray
    {
        public static void Duplicateno()
        {
            int[] arr = { 1, 4, 54, 6, 1, 12, 5, 4, 32, 40, 54, 3, 1 };
            Console.Write("(13)Duplicate no. in array: ");
            //(01)1st Logic
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i + 1; j < arr.Length - 1; j++)
                {
                    bool IsDuplicate = false;
                    
                    if(arr[i] == arr[j]) { IsDuplicate = true; break; }
                    if (IsDuplicate) { Console.Write(arr[i] + " "); }
                }
                
            }

            Console.WriteLine();

        }
    }
}
