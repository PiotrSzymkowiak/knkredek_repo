using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrSzymkowiakLab2Zad2
{
    class TestTrafficSystem
    {
        private List<Vehicle> Vehicles = new List<Vehicle>();
        public int NumberOfSimulationIterations { get; set; }
        public TestTrafficSystem()
        {            
            Vehicles.Add(new Car("Audi", 160, 25));
            Vehicles.Add(new Car("Porsche", 220, 35));
            Vehicles.Add(new Bicycle("Mountain bike", 40, 5));
            AddCrashEvent();
            AddRepairEvent();
            NumberOfSimulationIterations = 100;                   
        }

        private void AddCrashEvent()
        {
            for (int i = 0; i < Vehicles.Count; i++)
            {
                Vehicles.ElementAt(i).Crashed += new CrashedEventHandler(VehicleOnCrash);
            }
        }

        private void AddRepairEvent()
        {
            for (int i = 0; i < Vehicles.Count; i++)
            {
                Vehicles.ElementAt(i).Repaired += new RepairedEventHandler(VehicleOnRepair);
            }
        }

        private void VehicleOnCrash(object sender, EventArgs e)
        {
            Console.WriteLine($"{sender.ToString()} has crashed");
        }

        private void VehicleOnRepair(object sender, EventArgs e)
        {
            Vehicle senderVehicle = (Vehicle)sender;
            if(senderVehicle.Quality > 0)
                Console.WriteLine($"{senderVehicle.ToString()} is being repaired. It's quality is now {senderVehicle.Quality}");
            else
                Console.WriteLine($"{senderVehicle.ToString()} can not be repaired. It's quality is now {senderVehicle.Quality}");
        }

        public void Simulation()
        {
            for (int j = 0; j < Vehicles.Count; j++)
            {
                for (int i = 0; i < NumberOfSimulationIterations; i++)
                {                
                    Vehicle currentVehicle = Vehicles.ElementAt(j);                   
                    currentVehicle.SpeedUp();
                    currentVehicle.Move();
                    if (currentVehicle.Quality == 0) break;
                    if (currentVehicle.Speed == currentVehicle.MaxSpeed)
                    {
                        currentVehicle.Crash();
                        currentVehicle.Repair();
                    }
                }
            }
        }


    }
   
}
