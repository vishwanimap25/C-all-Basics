using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace March_29_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program newfile = new Program();
            newfile.CheckFiveNums();

            //exercise q.03
            Console.WriteLine("the no, are: ");


            int[] arr = { 32, 4, 55, 6, 17, 78 };

            Console.WriteLine("the second largest no: " + GetArray(arr));
            Console.WriteLine("the second largest no: " + GetwithoutSort(arr));


            var number = new[] { 32, 4, 55, 6, 17, 78 };

            //length
            Console.WriteLine("length: " + number.Length);

            //indexOf
            Console.WriteLine("index: " + Array.IndexOf(number, 2));

            //clear
            //Array.Clear(number, 0, 4);
            Console.Write("CLEARED: ");
            foreach (var n in number)
            {
                Console.Write(n + " ");

            }
            Console.WriteLine();
            //cpoy
            int[] another = new int[3];
            Array.Copy(number, another, 3);
            Console.WriteLine("copied array: ");
            foreach (var a in another)
            {
                Console.WriteLine(a + " ");
            }

            //sort
            Array.Sort(number);
            Console.Write("Sorted array : ");
            foreach (var s in number)
            {
                Console.WriteLine(s + " ");
            }

            //Reverse
            Array.Reverse(another);
            foreach (var n in another)
            {
                Console.Write(n + " ");
            }

            int[] example = { 3, 62, 62 };

            string[] place = new string[] { "japan", "india" };


            //2 - Write a program and ask the user to enter their name. 
            //    Use an array to reverse the name and then store the result in a new string.
            //    Display the reversed name on the console.

            //string[] strings = new string[] { Console.ReadLine() };

        }
        public static int GetArray(int[] arr)
        {
            int n = arr.Length;

            Array.Sort(arr);

            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] != arr[n - 1])
                {
                    return arr[i];
                }

            }
            return -1;
        }
        //WAP to find the second largest number in an array without sorting.
        public static int GetwithoutSort(int[] arr)
        {
            int n = arr.Length;

            int max = int.MinValue;
            int sec = int.MaxValue;
            foreach (int i in arr)
            {
                if (i > max)
                {
                    sec = max;
                    max = i;
                }
                else if (i > sec && i != max)
                {

                    sec = i;
                }

            }
            return sec;

        }


        //3- Write a program and ask the user to enter 5 numbers.
        //    If a number has been previously entered, 
        //    display an error message and ask the user to re-try. 
        //    Once the user successfully enters 5 unique numbers, 
        //    sort them and display the result on the console.

        public void CheckFiveNums()
        {
            var newNums = new List<int>();

            while (newNums.Count < 5)
            {
                Console.WriteLine("enter the number: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if (newNums.Contains(number))
                {
                    Console.WriteLine(number + " -> this no. already exits choose another one!");
                    continue;
                }
                newNums.Add(number);

                newNums.Sort();

            }
            foreach (var i in newNums)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
        }

    }
}
