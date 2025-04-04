
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DiamLAMserial
{
   class Program
    {
        static void Main(string[] args)
        {

            //interface examples
            Deer deer = new Deer();
            deer.Flee();

            Hwak hwak = new Hwak();
            hwak.Hunt();

            Fish fish = new Fish();
            fish.Hunt();
            fish.Flee();

            //diamond problem
            Example example = new Example();
            example.show();

            //for serialzation
            //string path = @"C:\Users\Nimap\Downloads\New folder\sample.exe";  
            //we can print any -> smaple.txt, .docx, .ppt, .png, .exe, .jpeg

            //Employee emp = new Employee(2531, "vishwajeet");

            //FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(stream, emp );
            //stream.Close();

            //Console.WriteLine("file created succesfully->" + path);


            //for deserilization
            string path = @"C:\Users\Nimap\Downloads\New folder\sample.exe";
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            Employee emp = (Employee)bf.Deserialize(stream);
            Console.WriteLine("EMp id: " + emp.Id);
            Console.WriteLine("Emp name:" + emp.Name);
            stream.Close();
        }
    }
}
