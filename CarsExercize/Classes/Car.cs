using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Classes
{
    internal class Car
    {

        public string name;
        public string model;
        public string color;
        public DateTime yearOfProduction;

        public Car(string name, string model,string color, DateTime yearOfProduction)
        {
            this.name = name;
            this.model = model;
            this.color= color;
            this.yearOfProduction = yearOfProduction;
        }
    }
}
