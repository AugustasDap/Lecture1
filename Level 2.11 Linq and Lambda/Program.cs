namespace Level_2._11_Linq_and_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1.1
            /*
            TaskNumber("Task 1.1");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            List<int> squaredNumbers = numbers.Select(x => x * x).ToList();

            Console.WriteLine("Original Numbers:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\nSquared Numbers:");
            foreach (var squaredNumber in squaredNumbers)
            {
                Console.Write(squaredNumber + " ");
            }
            Console.WriteLine();
            BrakeLine();
            */

            //Task 1.2
            /*
            TaskNumber("Task 1.2");
            List<int> numbers = new List<int> { -2, 5, -7, 10, -1, 8, -3 };
            List<int> positiveNumbers = numbers.Where(x => x > 0).ToList();
            Console.WriteLine("Original Numbers:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\nPositive Numbers:");
            foreach (var positiveNumber in positiveNumbers)
            {
                Console.Write(positiveNumber + " ");
            }
            Console.WriteLine();
            BrakeLine();
            */

            //Task 1.3
            /*
            TaskNumber("Task 1.3");
            List<int> numbers = new List<int> { -2, 5, -7, 10, -1, 8, -3 };
            List<int> positiveNumbersNotGreaterThan10 = numbers.Where(x => x > 0 && x <= 10).ToList();
            Console.WriteLine("Original Numbers:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\nPositive Numbers (not greater than 10):");
            foreach (var positiveNumber in positiveNumbersNotGreaterThan10)
            {
                Console.Write(positiveNumber + " ");
            }
            Console.WriteLine();
            BrakeLine();
            */

            //Task 1.4+1.5
            /*
            TaskNumber("Task 1.4+1.5");
            List<int> numbers = new List<int> { 5, 2, 8, 1, 7, 3, 6, 4 };
            List<int> sortedNumbers = numbers.OrderBy(x => x).ToList();
            List<int> sortedDescending = numbers.OrderByDescending(x => x).ToList();
            Console.WriteLine("Original Numbers:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\nSorted Numbers (Ascending Order):");
            foreach (var sortedNumber in sortedNumbers)
            {
                Console.Write(sortedNumber + " ");
            }
            Console.WriteLine("\nSorted Numbers (Descending Order):");
            foreach (var sortedNumber in sortedDescending)
            {
                Console.Write(sortedNumber + " ");
            }
            Console.WriteLine();
            BrakeLine();
            */

            //Task 1.6 largest item
            /*
            TaskNumber("Task 1.6");
            List<int> numbers = new List<int> { 5, 2, 8, 1, 7, 3, 6, 4 };
            int largestNumber = numbers.Max();
            Console.WriteLine("Original numbers:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number + " ");
            }
            Console.WriteLine("\nLargest number: " + largestNumber);
            */

            //Task 1.7 largest item
            /*
            TaskNumber("Task 1.7");

            List<Person> people = new List<Person>
            {
            new Person("DPerson1", 25),
            new Person("CPerson2", 30),
            new Person("APerson3", 45),
            new Person("CPerson4", 30),
            new Person("APerson5", 45),
            new Person("BPerson6", 60)
            };
            Console.WriteLine("Original list:");
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
            List<string> namesList = people.Select(p => p.Name).ToList();
            List<int> agesList = people.Select(p => p.Age).ToList();
            Console.WriteLine("\nList with only names:");
            foreach (var name in namesList)
            {
                Console.WriteLine($"Name: {name}");
            }
            Console.WriteLine("\nList with only ages:");
            foreach (var age in agesList)
            {
                Console.WriteLine($"Name: {age}");
            }
            List<Person> descendingAgeList = people.OrderByDescending(p => p.Age).ToList();
            Console.WriteLine("\nList Sorted in Descending Order of Age:");
            foreach (var person in descendingAgeList)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
            List<Person> namesStartWithAList = people.Where(p => p.Name.StartsWith("A")).ToList();
            Console.WriteLine("\nList of People Whose Names Start with A:");
            foreach (var person in namesStartWithAList)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
            List<Person> age40PlusSortedByNameList = people.Where(p => p.Age >= 40).OrderBy(p => p.Name).ToList();
            Console.WriteLine("\nList of People Ages 40+ Sorted by Name:");
            foreach (var person in age40PlusSortedByNameList)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }

            BrakeLine();
            */

            //Task 2.1
            /*
            TaskNumber("Task 1.7");
            BrakeLine();
            */

        }
        static List<int> SquareNumbers(List<int> numbers)
        {
            List<int> numbersList = new List<int>();
            foreach (var x in numbers)
            {
                int squared = x * x;
                numbersList.Add(squared);
            }
            return numbersList;
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