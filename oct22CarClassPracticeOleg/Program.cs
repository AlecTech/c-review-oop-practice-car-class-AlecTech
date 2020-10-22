using System;

namespace oct22CarClassPracticeOleg
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Chevy", "Camaro", "Red", "MaxOccupancy", "FuelEffeciency", new Odometer(101), new FuelTank(50));

            Console.WriteLine(myCar.gasTank);

            myCar.Drive();


        }
    }
}
