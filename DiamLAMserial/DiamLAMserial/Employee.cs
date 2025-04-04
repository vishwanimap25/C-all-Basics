using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamLAMserial
{
    [Serializable]
    //beacuse of the serialed class, this class can't be inherilized,
    //can't make child class of this .
    internal class Employee
    {
        public int Id;
        public string Name;


        public Employee(int Id, string Name)
        {
            this.Name = Name;
            this.Id = Id;
        }
    }
}
