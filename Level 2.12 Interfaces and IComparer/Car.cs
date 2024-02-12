using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._12_Interfaces_and_IComparer
{
    public abstract class Car : IVehicle //task one without abstract
    {
        //public string Model { get; set; } //for task 1
        public abstract string Model { get; set; } //for task 2
        public int Fuel { get; set; }

        public Car(int fuel) //string model task 1
        {
            //Model = model; //task 1
            Fuel = fuel;
        }
        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine($"The {Model} is ready to drive.");
            }
            else
            {
                Console.WriteLine($"The {Model} does not have enough fuel to drive.");
            }
        }

        public void Refuel(int amount)
        {
            if (amount >= 0)
            {
                Fuel += amount;
                Console.WriteLine($"The {Model} has been refueled. Current fuel level: {Fuel}");
            }
            else
            {
                Console.WriteLine("Invalid amount for refueling. Amount must not be negative.");
            }
        }
    }
}
