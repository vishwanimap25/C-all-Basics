//Logic for anagram program with its time complexity. (for large strings).
namespace LogicalQuestionsWithAnswers.AllCode
{
    internal class CheckAnagramOrNot
    {
        public static void Anagramcheck()
        {
            string str1 = "listen";
            string str2 = "silent";

            char[] ch1 = str1.Replace(" ","").ToLower().ToCharArray();
            char[] ch2 = str2.Replace(" ", "").ToLower().ToCharArray();

            if (ch1.Length != ch2.Length) { Console.WriteLine("Not a Anagram"); }

            Array.Sort(ch1);
            Array.Sort(ch2);

            bool IsAnagram = true;

            for (int i = 0; i <= ch1.Length -1; i++)
            {
                if (ch1[i] != ch2[i]) { Console.WriteLine("no anagram"); }
            }

            if (IsAnagram)
                Console.WriteLine("It is Anagram");
            else
                Console.WriteLine("Not A anagram");
        }
    }
}
