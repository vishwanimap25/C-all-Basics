using System;

namespace LogicalQuestionsWithAnswers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(1)
            Console.Write("(1)find 2nd max. : ");
            SecondMaximumNumber.SecondMax();
            //(2)
            Console.Write("(2)Integer Reverse: ");
            IntergerReverse.Reverseint();
            //(3)
            Console.Write("(3)swap a and b: ");
            SwapNumbers.Swapno();
            //(4)
            Console.Write("(4)Anagram check: ");
            CheckAnagramOrNot.Anagramcheck();
            //(05)
            Console.Write("(5)String Reverse: ");
            StringReverse.ReverseStr();
            //(06)
            Console.Write("(6)Missing No. ");
            MissingElements.ElementMiss();
            Console.WriteLine();
            //(07)
            Console.Write("(7)Palindrome: ");
            PalindromeOrNot.Palind();
            
        }

    }
}