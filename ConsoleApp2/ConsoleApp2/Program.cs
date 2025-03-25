using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.Driver;
using static ConsoleApp2.Car;

namespace ConsoleApp2
{
    class Program
    {
        
     //ok prvoto neso sto pravam e classite posle gi dodavam gore linija 8 i 9
     
            static void Main()
            {
                //gi pisuvam vozacite i nivniot skill
                List<Driver> drivers = new List<Driver>
        {
            new Driver("Bob", 3),
            new Driver("Greg", 4),
            new Driver("Jill", 5),
            new Driver("Anne", 2)
        };

             //pisuvam koli i brzina    
                List<Car> cars = new List<Car>
                {
               new Car("Hyundai", 150),
               new Car("Mazda", 160),
            new Car("Ferrari", 200),
            new Car("Porsche", 220)
        };

              //biranje na kolite i driversot
                Console.WriteLine("Choose a car no.1:");
                Car car1 = SelectCar(cars);

                Console.WriteLine("Choose a driver for car no.1:");
                Driver driver1 = SelectDriver(drivers);
                car1.AddDriver(driver1);

                Console.WriteLine("Choose a car no.2:");
                Car car2 = SelectCar(cars);

                Console.WriteLine("Choose a driver for car no.2:");
                Driver driver2 = SelectDriver(drivers);
                car2.AddDriver(driver2);

                
                RaceCars(car1, car2);
            }
              //gi listam kolite sto mozes da gi dobies i koj kje odberes
            static Car SelectCar(List<Car> cars)
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {cars[i].Model}");
                }

                int choice;
                while (true)
                {
                    Console.Write("Enter car number: ");
                    if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= cars.Count)
                    {
                        return cars[choice - 1];
                    }
                    Console.WriteLine("Invalid choice. Please select again.");
                }
            }
        //gi listam driversot i koj mozes da gi dobies i koj kje oberes
            static Driver SelectDriver(List<Driver> drivers)
            {
                for (int i = 0; i < drivers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {drivers[i].Name}");
                }

                int choice;
                while (true)
                {
                    Console.Write("Enter driver number: ");
                    if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= drivers.Count)
                    {
                        return drivers[choice - 1];
                    }
                    Console.WriteLine("Invalid choice. Please select again.");
                }
            }
         // calculiram speed i koj e pobrz kazuvam 
            static void RaceCars(Car car1, Car car2)
            {
                int speed1 = car1.CalculateSpeed();
                int speed2 = car2.CalculateSpeed();

                Console.WriteLine($"\nRace Results:");
                Console.WriteLine($"{car1.Model} driven by {car1.Driver.Name} has a calculated speed of {speed1}");
                Console.WriteLine($"{car2.Model} driven by {car2.Driver.Name} has a calculated speed of {speed2}");

                if (speed1 > speed2)
                {
                    Console.WriteLine($"Car no. 1 ({car1.Model}) was faster!");
                }
                else if (speed2 > speed1)
                {
                    Console.WriteLine($"Car no. 2 ({car2.Model}) was faster!");
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }
            }
        
    }
}
    

