using System;

namespace myFirst
{
    // Base class
    class Vehicle
    {
        public string Brand;
        public int Speed;

        public void ShowVehicle()
        {
            Console.WriteLine($"Brand : {Brand}, Speed : {Speed} km/h");
        }
    }

    // Derived class 1
    class Car : Vehicle
    {
        public string SeatingCapacity;

        public void ShowCar()
        {
            Console.WriteLine($"Seating Capacity : {SeatingCapacity}");
        }
    }

    // Derived class 2 (multilevel)
    class SportCar : Car
    {
        public string FuelType;

        public void ShowSportCar()
        {
            Console.WriteLine($"Fuel Type : {FuelType}");
        }
    }

    // Another derived class from Car
    class NormalCar1 : Car
    {
        public string TyreCompany;

        public void ShowNormalCar1()
        {
            Console.WriteLine($"Tyre Company : {TyreCompany}");
        }
    }

    internal class InheritanceMultilevel
    {
        static void Main(string[] args)
        {
            // SportCar object
            SportCar sc = new SportCar();
            sc.Brand = "Mahindra";
            sc.Speed = 110;
            sc.SeatingCapacity = "8";
            sc.FuelType = "Diesel";

            // Display SportCar details
            sc.ShowVehicle();
            sc.ShowCar();
            sc.ShowSportCar();

            Console.WriteLine("------------------");

            // NormalCar1 object
            NormalCar1 nc = new NormalCar1();
            nc.Brand = "Hyundai";
            nc.Speed = 100;
            nc.SeatingCapacity = "5";
            nc.TyreCompany = "Ceat";

            // Display NormalCar1 details
            nc.ShowVehicle();
            nc.ShowCar();
            nc.ShowNormalCar1();
        }
    }
}
