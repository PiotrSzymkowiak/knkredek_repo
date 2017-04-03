using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrSzymkowiakLab2
{
    class Child : Base
    {
        private string name;
        private string surname;

        public int Height { get; set; }
        public int Age { get; set; }

        public enum WeekDays { Friday, Sunday, Saturday };
        public enum Months { January, February, March};

        public Child(string name, string surname, int age)
        {
            SetName(name);
            SetSurname(surname);
            Age = age;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public void SetSurname(string value)
        {
            surname = value;
        }

        public string WhoAmI()
        {
            return name;
        }

        public void Hello()
        {
            System.Console.WriteLine($"Hello, my name is {name} {surname} and im {Age} years old.");
        }
    }
}
