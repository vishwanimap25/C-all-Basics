using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalQuestionsWithAnswers.OwnPractice
{
    internal class ManyPatternProblems2
    {
        public static void newpattern2()
        {
            //(1)Reverse the string
            //   string str = "vishwajeet";
            //   string newstr = "";
            //   for(int i = str.Length - 1; i >= 0 ; i--)
            //   {
            //       newstr += str[i];
            //   }
            //   Console.WriteLine(newstr);



            //(2) swap without 3rd vairable.
            // int a = 10;
            // int b = 12;
            // a = a + b;
            // b = a - b;
            // a = a - b;
            // Console.WriteLine($"a: {a}, b: {b}");
            // a = a * b;
            // b = a / b;
            // a = a / b;
            // Console.WriteLine($"a: {a}, b: {b}");
            // a = a ^ b;
            // b = a ^ b;
            // a = a ^ b;
            // Console.WriteLine($"a: {a}, b: {b}");
            // (a, b) = (b, a);
            // Console.WriteLine($"a: {a}, b: {b}");


            //(3) count vowels
            // int vowels = 0;
            // string str = "vishwajeet";
            // string str1 = str.ToLower();
            // foreach(char ch in str1){
            //     if(ch == 'a' || ch ==  'e' || ch == 'i' || ch == 'o' || ch == 'u')vowels++;
            // }
            // Console.WriteLine($"vowels: {vowels}");



            //(4)check if prime or not.
            // int num = 43;
            // bool IsPrime = false;
            // for(int i = 2; i < num/2; i++){
            //     if(num % i != 0){
            //         IsPrime = true;
            //     }else{
            //         IsPrime =  false;
            //     }
            // }
            // if(IsPrime){
            //     Console.WriteLine("Its Prime");
            // }else{
            //     Console.WriteLine("not Prime");
            // }



            //(5)find the prime no. of a range
            // int nums = 100;
            // for(int i = 2; i <= nums; i++){
            //     bool isprime = true;
            //     for(int j = 2; j <= i / 2; j++){
            //         if(i % j == 0){
            //             isprime = false;
            //             break;
            //         }
            //     }
            //     if(isprime){
            //         Console.Write($"{i}, ");
            //     }
            // }


            //(6)Fibonacci numbers
            // int a = 0; 
            // int b = 1;
            // for(int i = 0; i < 20; i++){
            //     Console.Write(a + "  ");
            //     int temp = a + b;
            //     a = b;
            //     b = temp;
            // }


            //(7)Palindrome 
            // string str = "mcadacm";
            // string reverse = "";
            // for(int i = str.Length - 1; i >= 0; i--){
            //     reverse += str[i];
            // }
            // if(str == reverse){
            //     Console.WriteLine("Its Palindrome");
            // }else{
            //     Console.WriteLine("no palindrome");
            // }



            //(8)odd number in the list
            // var newlist = new List<int>{1, 12, 5, 413, 54, 78, 90, 223, 56, 7};
            // foreach(var a in newlist){
            //     if(a % 2 != 0){
            //         Console.WriteLine(a);
            //     }
            // }



            //(9)Remove spaces in string
            // string str = "vis h  wa     jee t";
            // string str1 = str.Replace((" "), (""));

            // Console.WriteLine(str1);


            //(10)Remove leading and trailing spaces
            // string str = "    abc  def\t";
            // str = str.Trim();
            // Console.WriteLine(str);


            //(11)sorting an array
            // int[] arr = {12, 6, 43, 1, 7, 4, 3, 10, 11, 5, 13, 2, 8, 9};
            // ////->with inbuild method
            // // Array.Sort(arr);  
            // ////->without inbuild method
            // for(int i = 0; i < arr.Length - 1; i++){
            //     for(int j = 0; j < arr.Length - i - 1; j++){
            //         if(arr[j] > arr[j+1]){
            //             int temp = arr[j];
            //             arr[j] = arr[j + 1];
            //             arr[j + 1] = temp;
            //         }
            //     }
            // }
            // // foreach(var a in arr){
            // //     Console.Write(a + "  ");
            // // }
            // Console.WriteLine(string.Join(", ", arr));


            //(12)create a pyramid of characters
            int num = 0;
            for (int i = 1; i <= 6; i++)
            {
                for (int k = 6; k > i; k--)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j < i; j++)
                {
                    char ch = (char)(num + 96);
                    // char ch = (char)('A' + a - 1);
                    Console.Write(ch + "   ");

                }
                Console.WriteLine();
                num++;
            }


            // (13) count lowercase and uppercase
            //     input = "Hello world!"
            //     output = uppercase = 1, lowercase = 9
            // string str = "Hello world!";
            // int uppercase = 0;
            // int lowercase = 0;
            // foreach(char ch in str){
            //     if(ch >= 'a' || ch <= 'z')lowercase++;
            //     if(ch >= 'A' || ch <= 'Z')uppercase++;
            // }
            // Console.WriteLine($"uppercase: {uppercase} \nlowercase: {lowercase}");



            //(14) Sum of squares of first n prime numbers
            // Input = 4, Answer = 87
            // Explanation: 2*2+3*3+5*5+7*7 = 87
            // List<int> newlist = new List<int>();
            // int input = 4; 
            // for(int i = 2; i <= input + 2; i++){
            //     for(int j = 2; j <= i/2; j++){
            //         if(i % j != 0){
            //             newlist.Add(i);
            //         }
            //     }

            // }
            // Console.WriteLine(string.Join(", ", newlist));


        }
    }
}
