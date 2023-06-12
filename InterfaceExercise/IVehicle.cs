using System;
namespace InterfaceExercise
{
    //DONE Create 2 Interfaces called IVehicle & ICompany
    //In your IVehicle

    /* Create 4 members that Car, Truck, & SUV all have in common.
     * Example: All vehicles have a number of wheels... for now..
     */
    public interface IVehicle
    {
        public bool CanDrive { get; set; }
        public int NumWheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool HasChangedGears { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears();

        

    }

    
}

