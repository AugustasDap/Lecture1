namespace Level_2._9_Extension_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 bool positive or negative
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Task 1:");
            Console.ResetColor();

            int positiveNumber = 10;
            int negativeNumber = -20;
            int zero = 0;
            Console.WriteLine($"{positiveNumber} is positive: {positiveNumber.IsPositive()}");
            Console.WriteLine($"{negativeNumber} is negative: {negativeNumber.IsNegative()}");
            Console.WriteLine($"{zero} is positive: {zero.IsPositive()}");
            Console.WriteLine($"{zero} is negative: {zero.IsNegative()}");

            BrakeLine();

            //Task 2 even or not
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Task 2:");
            Console.ResetColor();

            int evenNumber = 10;
            int oddNumber = 5;
            Console.WriteLine($"{evenNumber} is even: {evenNumber.IsEven()}");
            Console.WriteLine($"{oddNumber} is even: {oddNumber.IsEven()}");

            BrakeLine();

            //Task 3 compare numbers
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Task 3:");
            Console.ResetColor();

            int num = 10;
            int compareTo = 5;
            Console.WriteLine($"{num} is greater than {compareTo}: {num.IsGreaterThan(compareTo)}");
            int anotherNum = 3;
            Console.WriteLine($"{anotherNum} is greater than {compareTo}: {anotherNum.IsGreaterThan(compareTo)}");

            BrakeLine();

            //Task 4 contain spaces or not
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Task 4:");
            Console.ResetColor();

            string sentenceWithSpaces = "This is a sentence with spaces.";
            string sentenceWithoutSpaces = "ThisIsASentenceWithoutSpaces";
            Console.WriteLine($"Does '{sentenceWithSpaces}' contain spaces? {sentenceWithSpaces.ContainsSpaces()}");
            Console.WriteLine($"Does '{sentenceWithoutSpaces}' contain spaces? {sentenceWithoutSpaces.ContainsSpaces()}");

            BrakeLine();

            //Task 5 email
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Task 5:");
            Console.ResetColor();

            string fullName = "Vardenis Pavardenis";
            int yearOfBirth = 2003;
            string domain = "gmail.com";
            string emailAddress = fullName.GenerateEmailAddress(yearOfBirth, domain);
            Console.WriteLine($"Generated Email Address: {emailAddress}");

            BrakeLine();

            //Task 6 find and return if equal
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Task 6:");
            Console.ResetColor();

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int numberToFind = 3;
            int foundNumber = numbers.FindAndReturnIfEqual(numberToFind);
            if (foundNumber != default(int))
            {
                Console.WriteLine($"Found: {foundNumber}");
            }
            else
            {
                Console.WriteLine("Number not found in the list.");
            }
            BrakeLine();

            //Task 7 return every second element
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Task 7:");
            Console.ResetColor();

            List<string> words = new List<string> { "apple", "banana", "cherry", "date", "berry", "fig" };
            List<string> everyOtherWordList = words.EveryOtherWord();
            Console.WriteLine("Every Other Word:");
            foreach (var word in everyOtherWordList)
            {
                Console.WriteLine(word);
            }
            BrakeLine();

            //Task 8 read file
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Task 8:");
            Console.ResetColor();

            string filePath = "C:\\Users\\Augustas\\source\\repos\\First\\Level 2.9 Extension Methods\\ExtensionTxt.txt";
            List<string> everySecondLine = filePath.ReadEverySecondLine();
            Console.WriteLine("Every Second Line:");
            foreach (var line in everySecondLine)
            {
                Console.WriteLine(line);
            }
            //List<string> allButSecondLine = filePath.ReadAllButSecondLine();
            //Console.WriteLine("\nAll Lines Except Second:");
            //foreach (var line in allButSecondLine)
            //{
            //    Console.WriteLine(line);
            //}

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
    }
}