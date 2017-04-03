
namespace PiotrSzymkowiakLab2Zad2
{
    class Car : Vehicle
    {
        public string Brand { get; private set; }

        public Car()
        {
            Brand = "unknown";          
        }

        public Car(string brand, float maxSpeed, float acceleration) : base(maxSpeed, acceleration)
        {           
            Brand = brand;                 
            numberOfWheels = 4;                       
        }

        public override string ToString()
        {
            return $"{Brand}";
        }
    }
}
