using System;
namespace InterfaceExercise
{
    //DONE -- Create 3 classes called Car , Truck , & SUV
    //In each of your car, truck, and suv classes

    /*Create 2 members that are specific to each class
     * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     * 
     */
    public class Car : ICompany
    {
        public Car()
        {
            
        }
        public int NumDoors { get; set; } = 2;
        public string Logo { get; set; } = "T";
        public string CEO { get; set; } = "I dont know";
        public bool CanDrive { get; set; } = true;
        public int NumWheels { get; set; } = 4;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Corolla";
        public bool HasChangedGears { get; set; } = false;

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing");
            }
            else
            {
                Console.WriteLine("Must change gears before reversing");
            }
        }
        public void Park()
        {
            Console.WriteLine($"{GetType().Name} now parked");
        }
        public void ChangeGears()
        {

        }


    }
}


