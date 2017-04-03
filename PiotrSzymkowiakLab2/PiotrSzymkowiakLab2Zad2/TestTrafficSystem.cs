using System;
using System.Collections.Generic;

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
            foreach( Vehicle vehicle in Vehicles)
            {
                vehicle.Crashed += new CrashedEventHandler(VehicleOnCrash);
            }
        }

        private void AddRepairEvent()
        {
            foreach (Vehicle vehicle in Vehicles)
            {
                vehicle.Repaired += new RepairedEventHandler(VehicleOnRepair);
            }
        }

        private void VehicleOnCrash(object sender, EventArgs e)
        {
            Console.WriteLine($"{sender.ToString()} has crashed");
        }

        private void VehicleOnRepair(object sender, EventArgs e)
        {
            Vehicle senderVehicle = (Vehicle)sender;
            if (senderVehicle.Quality > 0)
            {
                Console.WriteLine($"{senderVehicle.ToString()} is being repaired. It's quality is now {senderVehicle.Quality}");
            }
            else
            { 
                Console.WriteLine($"{senderVehicle.ToString()} can not be repaired. It's quality is now {senderVehicle.Quality}");
            }
        }

        public void Simulation()
        {
            foreach (Vehicle vehicle in Vehicles)
            {                
                for (int i = 0; i < NumberOfSimulationIterations; i++)
                {                   
                    vehicle.SpeedUp();
                    vehicle.Move();
                    if (vehicle.Quality == 0)
                    {
                        break;
                    }
                    if (vehicle.Speed == vehicle.MaxSpeed)
                    {
                        vehicle.Crash();
                        vehicle.Repair();
                    }
                }
            }
        }


    }
   
}
