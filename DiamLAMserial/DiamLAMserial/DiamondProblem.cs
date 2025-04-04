using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamLAMserial
{
    //INTERFACE CAN TAKE 2 MORE AS INHERITANCE -> if they both contains same method/function
    //BUT THIS CAN'T BE APPLICABLE TO "CLASS" -> we can only inheit one class in c#
    interface IA
    {
        void show();
    }
    interface IB : IA
    {
        void show();
    }
    interface IC : IA
    {
        void show();
    }

    class Example : IB, IC
    {
        public void show()
        {
            Console.WriteLine("this is class d");
        }
    }

    //in case of class we can not inherit 2 or more C# does not al
    class A
    {

    }
    class B : A
    {

    }
    class C : A
    {

    }
    // class D : B, C //class does not allow inheritance of 2 or more no matter what.
    
}
