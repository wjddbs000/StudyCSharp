﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInfInheritance
{
    class Program
    {
        interface IRunnable
        {
            void Run();
        }
        interface IFlyable
        {
            void Fly();

        }
        public class Vehicle
        {
            public string Year;
            public string Company;
            public float HorsePower;
        }
        class FlyingCar : Vehicle, IRunnable, IFlyable
        {
            public void Fly()
            {
                Console.WriteLine("FLY!");
            }
            public void Run()
            {
                Console.WriteLine("RUN!");
            }
        }

        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();
            car.Company = "현대";

            IRunnable runnable = car; // as IRunnable; 생략 가능
            runnable.Run();

            IFlyable flyable = car; // as IFlyable; 생략 가능
            flyable.Fly();

        }
    }
}
