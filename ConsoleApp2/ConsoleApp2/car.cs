using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.Driver;

namespace ConsoleApp2
{
    class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        //driver zimas od driver kaj sto on zima od program
        public Driver Driver { get; set; }
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public void AddDriver(Driver driver)
        {
            Driver = driver;
        }

        public int CalculateSpeed()
        {
            return Speed * (Driver != null ? Driver.Skill : 0);
        }

    }

}
