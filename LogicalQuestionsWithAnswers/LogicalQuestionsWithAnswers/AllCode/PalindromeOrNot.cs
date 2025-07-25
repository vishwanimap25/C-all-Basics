namespace LogicalQuestionsWithAnswers.AllCode
{
    internal class PalindromeOrNot
    {
        public static void Palind()
        {
            string str = "madam";
            string reveerse = "";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                reveerse += str[i]; 
            }
            if(str == reveerse)
            {
                Console.WriteLine("It is palindrome");
            }
            else
            {
                Console.WriteLine("It's not ");
            }
        }

    }
}
