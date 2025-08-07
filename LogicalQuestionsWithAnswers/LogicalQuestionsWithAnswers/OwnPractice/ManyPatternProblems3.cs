using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalQuestionsWithAnswers.OwnPractice
{
    internal class ManyPatternProblems3
    {
        //(1)
        public static void pyramid(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write("   ");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*  ");
                }
                Console.WriteLine();
            }
        }
        public static void inverted(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("   ");
                }
                for (int j = 0; j < 2 * n - (2 * i + 1); j++)
                {
                    Console.Write("*  ");
                }
                Console.WriteLine();
            }
        }


        //(2)
        public static void newpyramid(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = n; i > 0; i--)
            {
                for (int j = i; j > 1; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }


        //(3)
        public static void number1(int n)
        {
            int start = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0) start = 1;
                else start = 0;

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(start);
                    start = 1 - start;
                }
                Console.WriteLine();
            }
        }



        //(04)
        public static void pattern1(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j);
                }
                for (int j = n; j > i; j--)
                {
                    Console.Write("  ");
                }
                for (int j = i - 1; j > 0; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
        }

        //(05)
        public static void pattern2()
        {
            int n = 5;

            int num = 1;
            for (int i = 0; i <= n; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    if (num < 10)
                    {
                        Console.Write("0" + num + "   ");
                    }
                    else
                    {
                        Console.Write(num + "   ");
                    }
                    num++;
                }
                Console.WriteLine();

            }
        }

        //(06)
        public static void pattern3()
        {
            for(int i = 0; i < 5; i++)
            {
                //for(int j = 0; j < 5-i- 1; j++) //or//both are correct
                for(int j = 1; j < 5 - i; j++) 
                {
                    Console.Write("   ");
                }

                int breakpoint = (2 * i + 1) / 2;
                char ch = 'A';

                for(int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write(ch + "  ");
                    if (j < breakpoint) ch++;
                    else ch--;
                }
                Console.WriteLine();
            }
        }

        //(07)
        public static void pattern4()
        {
            for (int i = 5 ; i > 0 ; i--)
            {
                
                for (int j = i; j <= 5 ; j++)
                {
                    //char ch = (char)('A' + j - 1);
                    char ch = (char)(j + 64);  //asci : A-> 97, a -> 65
                    Console.Write(ch + " ");
                }
                Console.WriteLine();
            }
        }

        //(08)


    }
}
