using System;
namespace InterfaceExercise
{
	public class SUV : ICompany
	{
		public SUV()
		{
		}
        public int NumDoors { get; set; } = 4;
        public string Logo { get; set; } = "GMC";
        public string CEO { get; set; } = "Boss guy";
        public bool CanDrive { get; set; } = true;
        public int NumWheels { get; set; } = 6;
        public string Make { get; set; } = "GMC";
        public string Model { get; set; } = "YUKON";
        public bool HasChangedGears { get; set; } = true;
        public bool HasThirdRow { get; set; } = true;
        public bool GoodForSoccer { get; set; } = true;

        public void Drive()
        {
            if (GoodForSoccer == true)
            {
                Console.WriteLine($"{GetType().Name} now driving forward to practice");
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

