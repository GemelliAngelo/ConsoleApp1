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
        public ArrayList getPersonData()
        {
            ArrayList arrayData = new ArrayList()
            {
                this.name,
                this.surname,
                this.age,
            };

            return arrayData;
        }
    }
}
