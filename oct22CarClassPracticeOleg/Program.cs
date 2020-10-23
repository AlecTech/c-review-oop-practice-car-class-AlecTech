using System;

namespace oct22CarClassPracticeOleg
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Chevy", "Camaro", "Red", 5, 7.8, new Odometer(100), new FuelTank(50, 60));

            Console.WriteLine(myCar.ToString());

            myCar.Drive(30);

            Console.WriteLine(myCar.ToString());

            myCar.Drive(100);

            Console.WriteLine(myCar.ToString());

            myCar.Drive(500);

            Console.WriteLine(myCar.ToString());

            //in next 20 km we will runout of fuel(throw and exception)
            //myCar.Drive(20);

            //Console.WriteLine(myCar.ToString());

            //this Car2 will runover 1000000 and reset its counter to 0
            Car myCar2 = new Car("Ford", "Focus", "Red", 5, 7.8, new Odometer(999980), new FuelTank(50, 40));

            Console.WriteLine(myCar2.ToString());

            myCar2.Drive(30);

            Console.WriteLine(myCar2.ToString());

            myCar2.Drive(100);

            Console.WriteLine(myCar2.ToString());
            //this car3 will test if default constructor works for the fuelTank
            Car myCar3 = new Car("Toyota", "Highlander", "White", 7, 12.3, new Odometer(200000), new FuelTank());

            Console.WriteLine(myCar3.ToString());

            myCar3.Drive(30);

            Console.ReadLine();
            
        }
    }
}
