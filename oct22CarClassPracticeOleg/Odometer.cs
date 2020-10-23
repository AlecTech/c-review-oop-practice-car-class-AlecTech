using System;
using System.Collections.Generic;
using System.Text;

namespace oct22CarClassPracticeOleg
{
    public class Odometer
    {
        public override string ToString()
        {   //https://stackoverflow.com/questions/7856799/in-c-sharp-how-to-use-string-format-for-a-number-and-pad-left-with-zeros-so-its
            return String.Format("{0:000000}", _counter);
        }
        private int _counter;
        const int threshold = 1000000;

        public int Counter
        {
            get { return _counter; }
            //https://stackoverflow.com/questions/6082551/is-a-public-getter-and-a-private-setter-with-same-name-possible-in-c
            private set
            {
                if (value > threshold)
                {
                    _counter = value - threshold;
                }
                else
                {
                    _counter = value;
                }
             
            }
        }

        public Odometer()
        {
            _counter = 0;
        }
        public Odometer(int km)
        {
            Counter = km;
        }

        public void Increment(int passedKms)
        {
            Counter += passedKms;
        }
    }
}
// formula ex: if we drove 4km
// and counter shows 97km
// then tillreset we have 100 - 97 = 3km
// so overlap = 4 - 3 = 1km
// if statment (97 + 4 > 100 ){  97 = 0; _counter = 0 + 1; }

