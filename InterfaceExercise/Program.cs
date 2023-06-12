using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces







            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var suv = new SUV();
            var Car = new Car();
            var Truck = new Truck();
            var Vehicles = new List<IVehicle>() { Car, Truck, suv };
                foreach (var vehicle in Vehicles)
            {
                vehicle.Drive();
                vehicle.Reverse();
                vehicle.Park();
                vehicle.ChangeGears();
            }


        }
    }
}
