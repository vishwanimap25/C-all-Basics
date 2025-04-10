using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleAnoLamda
{
    internal class IEumableAndIEumarator
    {

        public static void IEumeratorEx()
        {
            List<int> NewYearsList = new List<int>();
            NewYearsList.Add(1999);
            NewYearsList.Add(2001);
            NewYearsList.Add(2002);
            NewYearsList.Add(2003);
            NewYearsList.Add(2004);
            NewYearsList.Add(2005);
            NewYearsList.Add(2006);

            IEnumerable<int> yearss = (IEnumerable<int>)NewYearsList;
            foreach (int year in yearss)
            {
                Console.WriteLine(year);
            }

        }
    }
}
