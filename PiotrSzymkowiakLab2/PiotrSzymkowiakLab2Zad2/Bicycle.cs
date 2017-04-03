using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrSzymkowiakLab2Zad2
{
    class Bicycle : Vehicle
    {
        public string BikeType { get; private set; }

        public Bicycle()
        {
            BikeType = "Normal Bike";
            _numberOfWheels = 2;
            MaxSpeed = 30;
        }

        public Bicycle(string bikeType, float maxSpeed, float acceleration)
        {
            BikeType = bikeType;
            MaxSpeed = maxSpeed;           
            Acceleration = acceleration;
            Speed = 0;
            _numberOfWheels = 4;
            _isBroken = false;
        }

        public override string ToString()
        {
            return $"{BikeType}";
        }
     
    }
}
