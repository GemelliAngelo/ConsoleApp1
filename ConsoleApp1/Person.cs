using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        string name;
        string surname;
        int age;

       public string Hello()
        {
            return $"Ciao mi chiamo {this.name}";
        }

        public Person(string name,string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetSurname()
        {
            return this.surname;
        }
        public int GetAge()
        {
            return this.age;
        }
    }
}
