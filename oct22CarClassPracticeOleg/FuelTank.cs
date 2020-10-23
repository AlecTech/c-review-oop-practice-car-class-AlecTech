using System;
using System.Collections.Generic;
using System.Text;

namespace oct22CarClassPracticeOleg
{
    public class FuelTank
    {
        public int FuelLeft { get; private set; }

        public FuelTank(int liters)
        {
            FuelLeft = liters;
        }
    }
}
