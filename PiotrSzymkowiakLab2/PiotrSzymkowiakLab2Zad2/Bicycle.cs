
namespace PiotrSzymkowiakLab2Zad2
{
    class Bicycle : Vehicle
    {
        public string BikeType { get; private set; }

        public Bicycle()
        {
            BikeType = "Normal Bike";
            numberOfWheels = 2;
            MaxSpeed = 30;
        }

        public Bicycle(string bikeType, float maxSpeed, float acceleration)  : base(maxSpeed, acceleration)
        {
            BikeType = bikeType;         
            numberOfWheels = 2;
        }

        public override string ToString()
        {
            return $"{BikeType}";
        }
     
    }
}
