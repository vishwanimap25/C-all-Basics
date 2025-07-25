namespace LogicalQuestionsWithAnswers.AllCode
{
    internal class StringReverse
    {
        public static void ReverseStr()
        {
            string str = "vishwajeet";

            string reverse = "";

            for(int i = str.Length-1; i >= 0;  i--)
            {
                reverse += str[i];

            }
            Console.WriteLine(reverse.ToUpper());
        }
    }
}
