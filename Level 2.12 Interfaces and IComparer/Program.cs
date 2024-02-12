using Level_2._12_Interfaces_and_IComparer;

namespace Level_2._11_Linq_and_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1+2 IVehicle

            TaskNumber("Task 1+2");
            //Car myCar = new Car("Subaru", 30);
            //myCar.Drive();
            //myCar.Refuel(20);
            //myCar.Refuel(-20);
            //myCar.Drive();
            BmwCar bmwCar = new BmwCar("X5", 50, true);
            bmwCar.Drive();
            AudiCar audiCar = new AudiCar("A6", 60, true);
            audiCar.Drive();
            List<Car> cars = new List<Car> { bmwCar, audiCar };
            cars.Sort(new CarComparer());
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} - Fuel Level: {car.Fuel}");
            }
            BrakeLine();


            //Task 2.1 Animals

            TaskNumber("Task 2.1");
            List<IAnimal> animals = new List<IAnimal>
        {
            new Dog(),
            new Cat(),
            new Bass(),
            new Carp()
        };

            List<IMammal> mammals = new List<IMammal>
        {
            new Dog(),
            new Cat()
        };

            List<IFish> fishes = new List<IFish>
        {
            new Bass(),
            new Carp()
        };

            Console.WriteLine("Iterating through IAnimal list:");
            foreach (var animal in animals)
            {
                animal.Eat();
            }

            Console.WriteLine("\nIterating through IMammal list:");
            foreach (var mammal in mammals)
            {
                mammal.GiveBirth();
            }

            Console.WriteLine("\nIterating through IFish list:");
            foreach (var fish in fishes)
            {
                fish.Swim();
            }
            BrakeLine();
            var dog1 = new Dog { Size = 20 };
            var dog2 = new Dog { Size = 15 };
            if (dog1.CompareTo(dog2) > 0)
            {
                Console.WriteLine("Dog 1 is larger than Dog 2");
            }
            else if (dog1.CompareTo(dog2) < 0)
            {
                Console.WriteLine("Dog1 is smaller than Dog 2");
            }
            else
            {
                Console.WriteLine("Dog 1 and Dog 2 are the same size");
            }

            BrakeLine();

        }


        static void BrakeLine()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("*********");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("*********");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*********");
            Console.ResetColor();
        }

        static void TaskNumber(string task)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(task);
            Console.ResetColor();
        }
    }
}