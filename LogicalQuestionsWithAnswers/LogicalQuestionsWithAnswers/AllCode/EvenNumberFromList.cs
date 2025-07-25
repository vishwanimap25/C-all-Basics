//Code to find even numbers in a list
namespace LogicalQuestionsWithAnswers.AllCode
{
    internal class EvenNumberFromList
    {
        public static void EveninList()
        {
            List<int> numbers = new List<int> { 12, 42, 51, 5, 67, 9, 60, 11 };

            foreach(int num in  numbers)
            {
                if(num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
