using System;

namespace OOP.Classes
{
    class Car
    {
        private string brand, model;
        private uint driveunit; // 0-havn't info 1-front, 2-back, 3-full        
        private int quantitydoor;
        private double maxspeed, timeto100;
        public Car()
        {
            brand = "no brand";
            model = "no model";
            driveunit = 0;
            quantitydoor = 3;
            maxspeed = 100;
            timeto100 = 10;
        }
        public Car(string brand, string model, int quantitydoor, double maxspeed, double timeto100)
        {
            this.brand = brand;
            this.model = model;
            this.quantitydoor = quantitydoor;
            this.maxspeed = maxspeed;
            this.timeto100 = timeto100;
        }
        public void GetFullInfo()
        {
            Console.Write($"Brand: {brand}\tModel: {model}\nMax speed: {maxspeed} km\t" +
                $"Time to 100km: {timeto100} s\nQuantity doors: {quantitydoor}\tDrive unit: ");
            ShowDriveUnit(driveunit);
        }
        public void SetDriveUnit(uint driveunit)
        {
            if (driveunit >= 0 && driveunit <= 3)
            {
                this.driveunit = driveunit;
            }
        }
        public void ShowDriveUnit(uint driveunit)
        {
            switch (driveunit)
            {
                case 0:
                    Console.WriteLine("Havn't info");
                    break;
                case 1: Console.WriteLine("Front");
                    break;
                case 2: Console.WriteLine("Back");
                    break;
                case 3: Console.WriteLine("Full");
                    break;
                default:
                    break;
            }
        }
        public double GetMaxSpeed()
        {
            return maxspeed;
        }
        public double TimeTo100 {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Tesla", "S", 5, 209, 4);
            car.SetDriveUnit(3);
            car.TimeTo100 = 5.5;
            car.GetFullInfo();


            Console.ReadKey();
        }
    }
}
