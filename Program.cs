using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//@Author: Antonio Orr
//NOTE: Fragile program. Wrong inputs will lead to error.
namespace CarClassAO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Warning: Failure to input correct variable types, program terminates automatically due to error.
            //insert int of year of car model
            Console.WriteLine("Insert year car was made: ");
            int year_model = Convert.ToInt32(Console.ReadLine());
            //insert string make of car
            Console.WriteLine("Insert make of car: ");
            string make = Console.ReadLine();
            //Car object is instantiated
            Car car = new Car(year_model, make);
            Console.WriteLine("Starting car at 0 miles per hour:");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            //calls the accelerate method 5 times, and displays current speed in each loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Accelerating...");
                Car.accelerate(car);
                Car.current_speed(car);
                Console.ReadLine();
            }
            //calls the brake method 5 times, and displays current speed in each loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Braking...");
                Car.brake(car);
                Car.current_speed(car);
                Console.ReadLine();
            }
            //program doesnt end yet. User may use accelerate or brake methods again until they want to terminate program
            Console.WriteLine("Now you decide what to do next!");
            Car.printCarDecision();
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice == 1 || choice == 2)
            {
                if (choice == 1)
                {
                    Console.WriteLine("Accelerating...");
                    Car.accelerate(car);
                    Car.current_speed(car);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Braking...");
                    Car.brake(car);
                    Car.current_speed(car);
                    Console.ReadLine();
                }
                Car.printCarDecision();
                choice = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You chose to end program. Goodbye.");
            Console.ReadLine();
        }
    }
    //Car class
    public class Car{
        public int year_model;
        public string make;
        public int miles;
        public Car(int y, string m)
        {
            year_model = y;
            make = m;
            miles = 0;
        }
        //accelerate car by 5 miles
        public static void accelerate(Car car)
        {
            car.miles = car.miles + 5;
        }
        //deccelerate car by 5 miles. Car speed cannot be less than 0.
        public static void brake(Car car)
        {
            car.miles = car.miles - 5;
            if (car.miles < 0) {
                car.miles = 0;
                Console.WriteLine("Car is stopped.");
            }
        }
        //prints current speed of car
        public static void current_speed(Car car)
        {
            Console.WriteLine("Current Speed of " + car.year_model + " " + car.make + ": " + car.miles + " mph.");
            Console.WriteLine("Press Enter to continue");
        }
        //prints options user can make
        public static void printCarDecision()
        {
            Console.WriteLine("Options:");
            Console.WriteLine("1 = Accelerate");
            Console.WriteLine("2 = Brake");
            Console.WriteLine("Any other number = Terminate Program");
        }
    }
}
