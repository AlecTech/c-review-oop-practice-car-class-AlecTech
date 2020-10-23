using System;
using System.Collections.Generic;
using System.Text;

namespace oct22CarClassPracticeOleg
{
    public class FuelTank
    {
        private double _level;

        public double Capacity { get; set; } 

        public double Level
        {
            get
            {
                return _level;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Not enough fuel!");
                }
                if(value > Capacity)
                {
                    _level = Capacity;
                }
                else
                {
                    _level = value;
                }
            }
        }

        public FuelTank()
        {
            Capacity = 50;
            Level = 50;
        }

        public FuelTank(int FuelLevel, int FuelCapacity)
        {
            Capacity = FuelCapacity;
            Level = FuelLevel;
        }

        public void BurnFuel(double burnAmount)
        {
            Level -= burnAmount;
        }

        public void Fill(double fillAmount)
        {
            Level += fillAmount;
        }
    }
}
