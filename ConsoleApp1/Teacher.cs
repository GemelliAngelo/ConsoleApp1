using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Teacher: Person
    {
        string subject;

        public Teacher(string name, string surname, int age, string subject): base(name, surname, age)
        {
            this.subject = subject;
        }

        public void Teach()
        {
            Console.WriteLine($"Io insegno {subject}");
        }

        public override string Hello()
        {
            return "Buongiorno Ragazzi";
        }
    }
}
