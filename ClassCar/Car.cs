using System;

namespace ClassCar
{
    public class Car
    {
        private int count;
        private string brand;
        private string model;
        private int manufactYear;
        private double engVolume;
        private string color;
        private static int id;
        public readonly static string category;

        static Car()
        {
            id = 0;
            category = "Cars";
        }

        public Car()
        {
            id++;
            count = id;
            Console.Write("Input brand of car: ");
            Brand = Console.ReadLine();
            Console.Write("Input car's model: ");
            Model = Console.ReadLine();
            Console.Write("Car's manufacturing year: ");
            ManufactYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Engine volume of the car: ");
            EngVolume = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input color of the car: ");
            Color = Console.ReadLine();
        }

        public Car(string brand, string model, int manufactYear, double engVolume, string color)
        {
            id++;
            count = id;
            Brand = brand;
            Model = model;
            ManufactYear = manufactYear;
            EngVolume = engVolume;
            Color = color;
        }

        private string Check(ref string value, string field)
        {
            if (!String.IsNullOrWhiteSpace(value))
                return value;
            else return $"No {field}";
        }

        public int Count
        {
            get => count;
            set { count = value; }
        }
        public string Brand
        {
            get => brand;
            set { brand = Check(ref value, "brand"); }
        }
        public string Model
        {
            get => model;
            set { model = Check(ref value, "model"); }
        }
        public int ManufactYear
        {
            get => manufactYear;
            set
            {
                if (value > 1900 & value < 2022)
                    manufactYear = value;
                else
                    manufactYear = 1900;
            }
        }
        public double EngVolume
        {
            get => engVolume;
            set
            {
                if (value > 1.0)
                    engVolume = value;
                else
                    engVolume = 1.0;
            }
        }
        public string Color
        {
            get => color;
            set { color = Check(ref value, "color"); }
        }

    public void Print()
        {
            Console.WriteLine($"ID: {Count}\tBrand: {Brand}\t\tModel: {Model}");
            Console.WriteLine($"Manufacturing year: {ManufactYear}\tEngine volume: {EngVolume}");
            Console.WriteLine($"Color: {Color}\n");
        }
    }
}
