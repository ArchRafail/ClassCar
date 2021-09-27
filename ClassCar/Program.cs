using System;

namespace ClassCar
{
    class Program
    {
        public static bool Answer()
        {
            Console.WriteLine("\nDo you want to add a car to the list? y/n");
            if (Console.ReadKey().KeyChar == 'y')
                return true;
            else
                return false;
        }

        static void Add(ref Car[] car)
        {
            Car[] newcars = new Car[car.Length + 1];
            for (int i = 0; i < car.Length; i++)
                newcars[i] = car[i];
            newcars[newcars.Length - 1] = new Car();
            car = newcars;
        }

        static void Main(string[] args)
        {
            bool changes = false;
            Car[] car = new Car[] {
                new Car("Mercedes", "AGL", 2020, 4.5, "Black"),
                new Car("Audi", "A8", 2018, 3.0, "Red"),
                new Car("Chrysler", "M300", 2016, 4.0, "Dark green"),
                new Car("BMW", "X7", 2019, 3.8, "White"),
                new Car("Bugatti", "Chiron", 2017, 8.0, "Metallic blue")};
            
            for (int i = 0; i < car.Length; i++)
                car[i].Print();

            while (Answer())
            {
                Console.WriteLine("\n");
                Add(ref car);
                changes = true;
            }

            if (!changes)
            {
                Console.WriteLine("\n");
                for (int i = 0; i < car.Length; i++)
                    car[i].Print();
            }
        }
    }
}
