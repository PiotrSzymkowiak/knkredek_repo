using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrSzymkowiakLab2
{
    class Program
    {
        static void Main(string[] args)
        {

            Child child = new Child("Jan", "Jankowski", 56);
            child.Hello();
            child.SetName("Piotr");
            child.SetSurname("Szymkowiak");
            child.Age = 22;
            System.Console.WriteLine(child.WhoAmI());
            child.Hello();
            System.Console.WriteLine(Child.WeekDays.Friday);
            System.Console.ReadLine();
        }
    }
}
