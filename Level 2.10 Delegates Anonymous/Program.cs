namespace Level_2._10_Delegates_Anonymous
{
    internal class Program
    {
        //Task 1.1 points method
        delegate string MyStringDelegate(string firstName, string lastName, int age);
        //Task 1.2 int
        delegate int MyIntDelegate(int number1, int number2);
        //Task 1.3 List
        delegate List<int> MyListDelegate(List<int> numbers, int step);
        //task 1.4 get type
        delegate string GetTypeDelegate<T>(T element);
        //task BIG3 
        public delegate bool Filter(Person person);

        static void Main(string[] args)
        {
            //Task 1 points method
            /*
            TaskNumber("Task 1");
            MyStringDelegate delegateMethod = new MyStringDelegate(MyStringMethod);
            string result = delegateMethod("Petras", "Petrinskas", 30);
            Console.WriteLine(result);
            BrakeLine();
            */

            //Task 2 int point
            /*
            MyIntDelegate myIntDelegate = new MyIntDelegate(MyIntMethod);
            int result2 = myIntDelegate(1, 2);
            Console.WriteLine("The sum is: " + result2);
            BrakeLine();
            */

            //Task 3 list
            /*
            List<int> numberList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            MyListDelegate myListDelegate = new MyListDelegate(GetNextElements);
            List<int> result3 = myListDelegate(numberList, 2); // Step is set to 2
            Console.WriteLine("Next elements with a step of 2:");
            foreach (int num in result3)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            BrakeLine();
            */

            //Task 4 type
            /*
            GetTypeDelegate<object> getTypeDelegate = new GetTypeDelegate<object>(GetType);
            string typeOfInt = getTypeDelegate(5);
            string typeOfString = getTypeDelegate("Hello");
            Console.WriteLine("Type of integer: " + typeOfInt);
            Console.WriteLine("Type of string: " + typeOfString);
            */

            //Task 2.1 anonymous
            TaskNumber("Task 2.1 anonymous");
            MyStringDelegate delegateMethod = delegate (string firstName, string lastName, int age)
            {
                return $"Hello, {firstName} {lastName}. You are {age} years old";
            };
            string result = delegateMethod("Petras", "Petrinskas", 30);
            Console.WriteLine(result);
            BrakeLine();

            //Task 2.2 anonymous
            TaskNumber("Task 2.2 anonymous");
            MyIntDelegate myIntDelegate = delegate (int number1, int number2)
            {
                return number1 + number2;
            };
            int result2 = myIntDelegate(1, 2);
            Console.WriteLine("The sum is: " + result2);
            BrakeLine();

            //Task 2.3 anonymous
            TaskNumber("Task 2.3 anonymous");
            List<int> numberList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            MyListDelegate myListDelegate = delegate (List<int> numbers, int step)
            {
                List<int> nextElements = new List<int>();
                int currentIndex = 0;
                while (currentIndex < numbers.Count)
                {
                    nextElements.Add(numbers[currentIndex]);
                    currentIndex += step;
                }
                return nextElements;
            };
            List<int> result3 = myListDelegate(numberList, 2); // Step is set to 2
            Console.WriteLine("Next elements with a step of 2:");
            foreach (int num in result3)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            BrakeLine();

            //Task 2.4 anonymous
            TaskNumber("Task 2.4 anonymous");
            GetTypeDelegate<object> getTypeDelegate = delegate (object element)
            {
                return element.GetType().ToString();
            };
            string typeOfInt = getTypeDelegate(5);
            string typeOfString = getTypeDelegate("Hello");
            Console.WriteLine("Type of integer: " + typeOfInt);
            Console.WriteLine("Type of string: " + typeOfString);
            BrakeLine();

            //Task 3
            TaskNumber("Task 3");
            List<Person> people = new List<Person>
        {
            new Person("John", 16),
            new Person("Emily", 30),
            new Person("Michael", 70),
            new Person("Sophia", 28),
            new Person("William", 35)
        };
            Filter isChild = p => p.Age < 18;
            Filter isAdult = p => p.Age >= 18 && p.Age < 65;
            Filter isSenior = p => p.Age > 65;
            List<Person> children = FilterPeople(people, isChild);
            List<Person> adults = FilterPeople(people, isAdult);
            List<Person> seniors = FilterPeople(people, isSenior);
            Console.WriteLine();
            DisplayPeople("Children:", people, isChild);

            BrakeLine();
        }

        static string MyStringMethod(string firstName, string lastName, int age)
        {
            return $"Hello, {firstName} {lastName}. You are {age} years old";
        }

        static int MyIntMethod(int number1, int number2)
        {
            return number1 + number2;
        }

        static List<int> GetNextElements(List<int> numbers, int step)
        {
            List<int> nextElements = new List<int>();
            int currentIndex = 0;
            while (currentIndex < numbers.Count)
            {
                nextElements.Add(numbers[currentIndex]);
                currentIndex += step;
            }
            return nextElements;
        }

        static string GetType<T>(T element)
        {
            return element.GetType().ToString();
        }

        static List<Person> FilterPeople(List<Person> people, Filter condition)
        {
            List<Person> filteredList = new List<Person>();

            foreach (Person person in people)
            {
                if (condition(person))
                {
                    filteredList.Add(person);
                }
            }

            return filteredList;
        }

        static void DisplayPeople(string title, List<Person> people, Filter condition)
        {
            Console.WriteLine(title);
            foreach (Person person in people)
            {
                if (condition(person))
                {
                    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                }
            }
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