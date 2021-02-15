using System;
namespace AbstractClassesPractice
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }
        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine($"{this.Make} {this.Model} {this.Year}. Has a Side Carts? {this.HasSideCart} ");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"Override virtual method for motorcycle");
        }
    }
}
