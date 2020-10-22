using System;
using System.Collections.Generic;
using System.Text;

namespace oct22CarClassPracticeOleg
{
    class Odometer
    {
        public int FuelAmount { get; set; }

        public Odometer(int km)
        {
            FuelAmount = km;
        }
    }
}
