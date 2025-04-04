using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamLAMserial
{
    internal class OutAndRef
    {
        public static void AddNum(int num)
        {
            num += 10;
        }
        public static void AddNumber(ref int num)
        {
            num += 10;
        }

        public static void Rectangle(int length, int bredth, out int area, out int parameter)
        {
            area = length * bredth;

            parameter = 2 * (length * bredth);
        }
    }
}
