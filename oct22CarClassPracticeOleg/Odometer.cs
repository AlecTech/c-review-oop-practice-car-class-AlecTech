using System;
using System.Collections.Generic;
using System.Text;

namespace oct22CarClassPracticeOleg
{
    public class Odometer
    {
        public int Counter { get; set; }

        public Odometer(int km)
        {
            Counter = km;
        }
    }
}
