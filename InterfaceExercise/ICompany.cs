using System;
namespace InterfaceExercise
{
    //Create 2 Interfaces called IVehicle & ICompany
    //In ICompany

    /*Create 2 members that are specific to each every company
     * regardless of vehicle type.
     *
     *
     * Example: public string Logo { get; set; }
     */
    public interface ICompany : IVehicle
	{
        public string Logo { get; set; }
        public string CEO { get; set; }
    }
}

