using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalQuestionsWithAnswers.OwnPractice
{
    public class ManyPatternProblems
    {
        public static void NewPattern()
        {

            // int cnt=2;
            // for(int i=1; i<=4; i++){
            //     for( int j=1; j<=i; j++){
            //         Console.Write(cnt + " ");
            //     }
            //     Console.WriteLine();
            //     cnt+=2;
            // }



            // int n = 17;
            // for(int i = 1; i < n ; i += 10){
            //     for(int j = 0 ; j < 5 && (i + j) <= n; j++)
            //     {
            //         Console.Write((i+j) + "  ");
            //     }
            //     for(int j = 0; j < 5; j++){
            //         int star = i + j + 5;
            //         if(star <= n){
            //             Console.Write("*  ");
            //         }
            //     }
            //     Console.WriteLine();
            // }



            // for(int i = 0; i < 3; i++){
            //     for(int j = i; j < 0; j--){
            //         Console.Write("  ");
            //     }
            //     for(int k = 1; k < 3 ; k++){
            //         Console.Write("*");
            //         for(int j = 0 ; j < i; j++){
            //             Console.Write("  ");
            //         }
            //     }
            //     Console.WriteLine();
            // }




            // for(int i = 0 ; i < 4; i++){
            //     for(int k = 0 ; k < i; k++){
            //         Console.Write("  ");
            //     }
            //     for(int j = 4 ; j > i ; j--){
            //         Console.Write("*   ");
            //     }
            //     Console.WriteLine();
            // }




            // for(int i = 5; i >= 1; i--){
            //     for(int j =i ; j > 0 ; j--){
            //         if(i % 2 == 0){
            //             int offect = 96; //65->upper
            //           char ch = (char)(j + offect);
            //           Console.Write(ch + " ");
            //         }
            //         else
            //         {
            //             Console.Write(j + " ");
            //         }
            //     }
            //     Console.WriteLine();
            // }




            // for(int i = 5; i > 0 ; i--)
            // {
            //     for(int j = 1 ; j <= i ; j++)
            //     {
            //         if(i % 2 == 0)
            //         {
            //             char ch = (char)('a' + j - 1);
            //             Console.Write(ch + " ");
            //         }
            //         else
            //         {
            //             Console.Write(j + " ");
            //         }
            //     }
            //     Console.WriteLine();
            // }



            for (int i = 6; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        char ch = (char)('A' + j - 1);
                        Console.Write(ch + "  ");
                    }
                }
                else
                {
                    for (int j = i; j >= 1; j--)
                    {
                        Console.Write(j + "  ");
                    }
                }
                Console.WriteLine();
            }



            // for(int i = 4 ; i > 0; i--){
            //     for(int j = i - 1 ; j > 0 ; j--){
            //         Console.Write("*");
            //     }
            //     Console.WriteLine();
            // }





            // int cnt=1;
            // for(int i=1; i<=4; i++){
            //     for(int j=1; j<=i; j++){
            //         Console.Write(cnt + "  ");
            //     }
            //     Console.WriteLine();
            //     cnt+=2;
            // }
        }
    }
}
