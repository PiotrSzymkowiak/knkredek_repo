using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrSzymkowiakLab2Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestTrafficSystem testTrafficSystem = new TestTrafficSystem();
            testTrafficSystem.Simulation();

            Console.WriteLine("\n\n\nTesting polymorphism with a Interface.\n");
            Car car = new Car("VW", 100, 10);
            Bicycle bike = new Bicycle("Some random bike", 20, 1);
            TestMove(car);
            TestMove(bike);
            Console.ReadLine(); 
        }


        static void TestMove(IMovable movableObject)
        {
            Console.WriteLine($"In \"static void TestMove(IMovable movableObject)\" method on object {movableObject.ToString()} ");
            movableObject.Move();
        }
    }
}
