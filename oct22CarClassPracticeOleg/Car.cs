using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace oct22CarClassPracticeOleg
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int MaximumOccupancy { get; set; }
        public double FuelEfficiency { get; set; }

        //single obj references
        public Odometer Kms { get; set; }
        public FuelTank Liters { get; set; }

        public Car()
        {
            Make = "Chevy";
            Model = "Camero";
            Color = "Red";
            MaximumOccupancy = 5;
            FuelEfficiency = 8.7;

            Kms = new Odometer(100);
            Liters = new FuelTank(50, 70);
        }
        public Car(string make, string model, string color, int maxOccupancy, double fuelEff, Odometer kms, FuelTank liters)
        {
            Make = make;
            Model = model;
            Color = color;
            MaximumOccupancy = maxOccupancy;
            FuelEfficiency = fuelEff;

            Kms = kms;
            Liters = liters;
        }

        public override string ToString()
        {
            // Formula for kms remaing = Level *(100/FuelEfficiency)
            string kmsRemaining = (Liters.Level * (100 / FuelEfficiency)).ToString();
            return $"A {Color} {Make} {Model} with {Kms} on the odometer, that has enough fuel to travel {kmsRemaining} KM.";
        }

        public void Drive()
        {
            //drive it should lower Level in FuelTank Class
            //BurnFuel()

        }

        public void Drive(int kmsPassed)
        {
            double fuelSpent = (FuelEfficiency / 100) * kmsPassed;
            Liters.BurnFuel(fuelSpent);
            Kms.Increment(kmsPassed);
        }


    }
}