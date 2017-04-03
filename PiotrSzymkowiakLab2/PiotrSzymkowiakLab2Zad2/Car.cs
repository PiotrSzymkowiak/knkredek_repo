using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrSzymkowiakLab2Zad2
{
    class Car : Vehicle
    {
        public string Brand { get; private set; }

        public Car()
        {
            Brand = "unknown";          
        }

        public Car(string brand, float maxSpeed, float acceleration)
        {
            Brand = brand;
            MaxSpeed = maxSpeed;
            Speed = 0;
            Acceleration = acceleration;
            _numberOfWheels = 4;
            _isBroken = false;                        
        }

        public override string ToString()
        {
            return $"{Brand}";
        }
    }
}
