﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //string make=Console.ReadLine();
            //string model=Console.ReadLine();
            //int year=int.Parse(Console.ReadLine());
            //double fuelConsumption=double.Parse(Console.ReadLine());
            //double fuelQuantity=double.Parse(Console.ReadLine());

            //Car firstcar = new Car();
            //Car secondCar = new Car(make, model, year);
            //Car thirdCar=new Car(make,model, year,fuelQuantity,fuelConsumption); 

            var tires = new Tire[4]
            {
                new Tire(1,2.5),
                new Tire(1,2.1),
                new Tire(2,0.5),
                new Tire(2,2.3),
            };

            Engine engine = new Engine(560, 6300);

            Car car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

            
        }
    }
}
