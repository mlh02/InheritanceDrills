using System;
using System.Collections.Generic;

namespace AbstractClassesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // List for Vehicles
            List<Vehicle> carLot = new List<Vehicle>();
            // Car Objects
            Car carObject = new Car();
            carObject.Model = "Model X";
            carObject.Make = "Tesla";
            carObject.Year = 2020;
            carObject.HasTrunk = true;

            Car carObject2 = new Car();
            carObject2.Model = "Roadster";
            carObject2.Make = "Tesla";
            carObject2.Year = 2025;
            carObject2.HasTrunk = false;

            //Add Car Objects To List
            carLot.Add(carObject);
            carLot.Add(carObject2);


            // Motorcycle Objects
            Motorcycle motorcycle1 = new Motorcycle();
            motorcycle1.Model = "S1000RR.";
            motorcycle1.Make = "BMW";
            motorcycle1.Year = 2022;
            motorcycle1.HasSideCart = false;

            Motorcycle motorcycle2 = new Motorcycle();
            motorcycle1.Model = "Fireblade";
            motorcycle1.Make = "Honda";
            motorcycle1.Year = 2019;
            motorcycle1.HasSideCart = true;

            //Add Car Objects To List
            carLot.Add(motorcycle1);
            carLot.Add(motorcycle2);

            foreach(var x in carLot)
            {
                x.DriveAbstract();
            }

        }
    }
}
