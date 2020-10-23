using System;

namespace oct22CarClassPracticeOleg
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Chevy", "Camaro", "Red", 5, 7.8, new Odometer(100), new FuelTank(50, 60));

            Console.WriteLine(myCar.ToString());

            Console.ReadLine();
            
        }
    }
}
