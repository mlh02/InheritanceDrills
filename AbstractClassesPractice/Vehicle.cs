using System;
namespace AbstractClassesPractice
{
    public abstract class Vehicle
    {
        public Vehicle()
        {
        }
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "default Make" ;
        public string Model { get; set; } = "Defauly model";
        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("This is Virtual Vehicle Method");
        }

    }
}
