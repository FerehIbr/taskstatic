using System;
using System.Collections.Generic;
using System.Text;

namespace TaskStatic2
{
    public class Car:IVehicle
    {
        public string Drive { get; set; }

        internal void Drivee()
        {
            Console.WriteLine("The Car is Driving");
        }

        void IVehicle.Drive()
        {
            Console.WriteLine("The Car is Driving");
        }
    }
}
