using System;
using System.Collections.Generic;
using System.Text;

namespace oct22CarClassPracticeOleg
{
    public class Odometer
    {
        private int _counter;
        private int _amount;


        public int Counter
        {
            get { return _counter; }
            set
            {
                // formula ex: if we drove 4km
                // and counter shows 97km
                // then tillreset we have 100 - 97 = 3km
                // so overlap = 4 - 3 = 1km
                // if statment (97 + 4 > 100 ){  97 = 0; _counter = 0 + 1; }
                int _amount;
                int tillreset = 100 - _counter;
                int overlap = _amount - tillreset;
                if (_counter + _amount > 100)
                {
                    _counter = 0;
                    _counter = _counter + overlap;

                }

                _counter = value;
            }
        }

        public Odometer(int km)
        {
            Counter = km;
        }

        public void Increment()
        {
            
           _amount =+ 10;
        }

        /*
        public int Counter { get; private set; }
        
        public Odometer(int km)
        {
            Counter = km;
        }

        */
    }
}
