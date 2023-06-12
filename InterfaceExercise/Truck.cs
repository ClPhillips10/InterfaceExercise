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
    public class Truck: ICompany
	{
		public Truck()
		{
		}
        public int NumDoors { get; set; } = 4;
        public string Logo { get; set; } = "FORD";
        public string CEO { get; set; } = "Boss guy";
        public bool CanDrive { get; set; } = true;
        public int NumWheels { get; set; } = 6;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F350";
        public bool HasChangedGears { get; set; } = true; 
        public bool HasFourWheelDrive { get; set; } = true;
        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 Wheel drive {GetType().Name} now driving forward");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward");
            }
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing");
                HasChangedGears = false;

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

