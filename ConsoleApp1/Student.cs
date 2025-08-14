using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student: Person
    {
        string classRoom;

        public Student(string name,string surname,int age,string classRoom): base(name, surname, age)
        {
            this.classRoom = classRoom;
        }

        public void Study()
        {
            Console.WriteLine($"Io studio in classe {classRoom}");
        }

        public override string Hello()
        {
            return "Buongiorno Prof";
        }
    }
}
