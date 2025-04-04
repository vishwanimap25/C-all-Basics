using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamLAMserial
{
    interface IPray
    {
        void Flee();
    }
    interface IHunt
    {
        void Hunt();
    }
    class Deer: IPray
    {
        public void Flee()
        {
            Console.WriteLine("deer flee from the predator");
        }
    }
    class Hwak
    {
        public void Hunt()
        {
            Console.WriteLine("Hawk attaks");
        }
    }
    class Fish : IPray, IHunt
    {
        public void Flee()
        {
            Console.WriteLine("Fish flee");
        }
        public void Hunt()
        {
            Console.WriteLine("Fish attacks smaller fish");
        }
    }
}
