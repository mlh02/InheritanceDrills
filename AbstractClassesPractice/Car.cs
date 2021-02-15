using System;
namespace AbstractClassesPractice
{
    public class Car : Vehicle
    {
        public Car()
        {
        }
        public bool HasTrunk { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine($"{this.Make} {this.Model} {this.Year}. Has a trunk? {this.HasTrunk} ");
        }
    }
}
