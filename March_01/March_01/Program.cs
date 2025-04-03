using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March_01
{

    class person
    {
        private string name;
        int age; //if there is no access modifier, it default becomes private

        public void setName(string Name)
        {
            Name = Console.ReadLine();
            if (string.IsNullOrEmpty(Name) == true)
            {
                Console.WriteLine("Name can't be empty!");
            }
            else
            {
                this.name = Name;
            }
              
        }
        public void getName()
        {
            if(string.IsNullOrEmpty(name ) == true)
            { }
            else
            {
                Console.WriteLine("your name is : {0}", this.name);
            }
        }


        public void setAge(int Age)
        {
            if(this.age < 0)
            {
                Console.WriteLine("enter proper age");
            }else
            {
                this.age = Age;
            }
        }
        public void getAge()
        {
            Console.WriteLine("your name is : {0}", this.age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           person p = new person();

            p.setName("vishwajeet");
            p.getName();
            p.setAge(18);
            p.getAge();

            //Console.ReadLine();


            // 01
            //newArrayBubble();

            // 02
            string howto;
            // do{
            Console.Write("Enter the Number: ");
            int newVariable = int.Parse(Console.ReadLine());
            linearSearching(newVariable);
            // howto = Console.ReadLine();
            // }while(howto != "no");


            //square/multidimentional array
            int[,] arr2 = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //jagged array
            int[][] arr3 = new int[3][];
            arr3[0] = new int[4] { 13, 14, 15, 16 };
            arr3[1] = new int[2] { 17, 18 };
            arr3[2] = new int[3] { 21, 22, 23 };
            foreach (int[] arr in arr3)
            {
                foreach (int item in arr)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }
        }

        // 01
        public static void newArrayBubble()
        {
            //bubble sort
            int[] arr = new int[] { 34, 7, 12, 9, 1, 87, 44 };

            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    // for decneding-> arr[j] < arr[j + 1]
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            foreach (var inArr in arr)
            {
                Console.Write(inArr + "\t");
            }
            Console.WriteLine();


        }


        // 01
        //public static void newArrayBubble()
        //{
        //    //bubble sort
        //    int[] arr = new int[] { 34, 7, 12, 9, 1, 87, 44 };

        //    int temp;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = 0; j < arr.Length - 1; j++)
        //        {
        //            // for decneding-> arr[j] < arr[j + 1]
        //            if (arr[j] > arr[j + 1])
        //            {
        //                temp = arr[j];
        //                arr[j] = arr[j + 1];
        //                arr[j + 1] = temp;
        //            }
        //        }
        //    }
        //    foreach (var inArr in arr)
        //    {
        //        Console.Write(inArr + "\t");
        //    }
        //    Console.WriteLine();
        //}

        //for binary search 1st we have to sort an array and then search

        //  02-> linear search
        public static int linearSearching(int newInt)
        {
            bool found = false;
            int[] arr = new int[] { 34, 7, 12, 9, 1, 87, 44 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (newInt == arr[i])
                {
                    found = true;
                    break;
                }
            }
            if (found == true)
            {
                Console.WriteLine("The entered no. is present in array");
            }
            else
            {
                Console.WriteLine("Number is not present in array");
            }
            return newInt;
        }
    }
}
