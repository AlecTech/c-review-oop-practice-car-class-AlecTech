using System;
using System.Collections.Generic;
using System.Text;

namespace oct22CarClassPracticeOleg
{
    public class FuelTank
    {
        private double _capacity;
        private double _level;

        public double Capacity 
        {
            get
            {
                return _level;
            }
            set
            {
                if (value < 0)
                {            
                    throw new Exception("Not enough fuel!");
                }
                if (value > _capacity)
                {
                    _level = _capacity;
                }
                /*
                else if (value > 50)
                {
                    _level = 50;
                }
                else
                */
                _level = value;
            }

        }

        public FuelTank()
        {
            _capacity = 50;
            _level = 50;    
        }

        public void BurnFuel()
        {
            //Subtract “litres” from the “Level” property.
        }

        public void Fill()
        {
            //Add “litres” to the “Level” property.
        }

        /*
        public int FuelLeft { get; private set; }

        public FuelTank(int liters)
        {
            FuelLeft = liters;
        }
        */
    }
}
