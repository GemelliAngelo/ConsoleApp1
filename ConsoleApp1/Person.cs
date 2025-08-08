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

        // Dichiarazione variabili classe Person
        string name;
        string surname;
        int age;

        // Metodo Hello della classe Person
       public string Hello()
        {
            return $"Ciao mi chiamo {this.name}";
        }
        
        // Dichiarazione metodo Constructor
        public Person(string name,string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        // Dichiarazione metodi Getters
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

        // Dichiarazione metodi Setters
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public void SetAge(int age)
        {
            if (age > 0 && age <=100) this.age = age;
            else Console.WriteLine("Inserisci un'età valida");
        }
    }
}
