// See https://aka.ms/new-console-template for more information
using System;
using System.Formats.Asn1;
using System.Text;
using System.Threading.Tasks.Sources;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 5. Task 1.1
            /*
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            char[] textarray = text.ToCharArray();
            textarray[0] = char.ToUpper(textarray[0]);
            Console.WriteLine(textarray);
            */

            //Day 5. Task 1.2
            /*
            Console.WriteLine("Enter long text");
            string text = Console.ReadLine();
            char[] textarray = text.ToCharArray();
            textarray[2] = 'g';
            textarray[4] = 'b';
            textarray[6] = '*';
            textarray[8] = 'x';
            textarray[10] = 'w';
            //string pakeistas = new string(textarray);
            Console.WriteLine(textarray);
            */

            
            //Day 5. Task 1.3
            
            Console.WriteLine("Enter 5 letters text");
            string text = Console.ReadLine();
            char[] textarray = text.ToCharArray();
            if (text.Length == 5) 
            {
             /*
                Console.WriteLine("Let's encode. Change 1st letter to number:");
                string change0 = Console.ReadLine();
                textarray[0] = char.Parse(change0);
                Console.WriteLine("Change 2nd letter to number:");
                string change1 = Console.ReadLine();
                textarray[1] = char.Parse(change1);
                Console.WriteLine("Change 3rd letter to number:");
                string change2 = Console.ReadLine();
                textarray[2] = char.Parse(change2);
                Console.WriteLine("Change 4th letter to number:");
                string change3 = Console.ReadLine();
                textarray[3] = char.Parse(change3);
                Console.WriteLine("Change 5th letter to number:");
                string change4 = Console.ReadLine();
                textarray[4] = char.Parse(change4);
                string encode = new string(textarray);
             */
                char encoding = '!';
                Console.WriteLine((char)textarray[0] + encoding);
                Console.WriteLine((char)textarray[1] + encoding);
                Console.WriteLine((char)textarray[2] + encoding);
                Console.WriteLine((char)textarray[3] + encoding);
                Console.WriteLine((char)textarray[4] + encoding);
                                
            }
            else 
            {
                Console.WriteLine("Error.. Too much or too few characters");
            } 
            


            //Day 5. Task 2.1



            //Day 4. Task 1.1
            /*
            Console.WriteLine("Enter week day");
            int day = Convert.ToInt32(Console.ReadLine());
            var result = day switch
            {
                1 => "Pirmadienis",
                2 => "Antradienis",
                3 => "Treciadienis",
                4 => "Ketvirtadienis",
                5 => "Penktadienis",
                6 => "Sestadienis",
                7 => "Sekmadienis",
                _ => "Ups, week contains 7 days"
            };
            Console.WriteLine(result);
            */

            /*
            //Day 4. Task 1.2
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            string result = age switch
            {
                >= 7 and <= 18 => "child",
                >= 19 and <= 25 => "student",
                >= 26 and <= 65 => "employee",
                > 65 => "retired",
                _ => "error.."
            };
            Console.WriteLine(result);
            */

            /*
             //Day 4. Task 1.1 + 1.3
             Console.WriteLine("Enter week (w) or month (m)");
             string option = Console.ReadLine();
             if (option == "w")
             {
                 Console.WriteLine("Enter week day");
                 int day = Convert.ToInt32(Console.ReadLine());
                 var result = day switch
                 {
                     1 => "Pirmadienis",
                     2 => "Antradienis",
                     3 => "Treciadienis",
                     4 => "Ketvirtadienis",
                     5 => "Penktadienis",
                     6 => "Sestadienis",
                     7 => "Sekmadienis",
                     _ => "Ups, week contains 7 days"
                 };
                 Console.WriteLine(result);
             }
             else if (option == "m")
             {
                 Console.WriteLine("Enter month");
                 int month = Convert.ToInt32(Console.ReadLine());
                 var result = month switch
                 {
                     1 => "Sausis",
                     2 => "Vasaris",
                     3 => "Kovas",
                     4 => "Balandis",
                     5 => "Geguze",
                     6 => "Birzelis",
                     7 => "Liepa",
                     8 => "Rugpjutis",
                     9 => "Rugsejis",
                     10 => "Spalis",
                     11 => "Lapkritis",
                     12 => "Gruodis",
                     _ => "Ups, year contains 12 months"
                 };
                 Console.WriteLine(result);
             }
             else { Console.WriteLine("error.."); }



             //Day 4. Task 2.1
             Console.WriteLine("Enter figure (square, circle)");
             string figure = Console.ReadLine();

             switch (figure)
             {
                 case "square":
                     Console.WriteLine("Enter side of the square");
                     int side = 0;
                     side = Convert.ToInt32(Console.ReadLine());
                     int area = side * side;
                     Console.WriteLine($"Area of square with side {side} is {area}");
                     break;
                 case "circle":
                     Console.WriteLine("Enter radius of the circle");
                     int rad = 0;
                     rad = Convert.ToInt32(Console.ReadLine());
                     double area2 = Math.PI * rad * rad;
                     Console.WriteLine($"Area of circle with radius {rad} is {area2:0.00}"); //area2:0.00 apvalinimas du skaiciai po kablelio
                     break;
                 default:
                     Console.WriteLine("error..");
                     break;

             }




             //Day 4. Task 2.2
             Console.WriteLine("Enter element (fire, water, air, earth, ether)");
             string element = Console.ReadLine();
             var result = element switch
             {
                 "fire" => "it burns",
                 "water" => "it calms",
                 "air" => "just breath",
                 "earth" => "you know...",
                 "ether" => "it's spiritual",
                 _ => "Ups, mistake..."
             };
             Console.WriteLine(result);
             */

            //Day 4. Task 2.3


            /*
            //Day 3. Task 1.1

            Console.WriteLine("Enter number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number >100 )
            {
                Console.WriteLine("The number is greater than 100");
            }
            else if (number ==100)
            {
                Console.WriteLine("This number is 100");
            }
            else 
            {
                Console.WriteLine("The number is less than 100");
            }
            //Console.WriteLine("This is the end of application");

            //Day 3. Task 1.2

            Console.WriteLine("Enter number");
            weekday = Convert.ToInt32(Console.ReadLine());
            if (weekday == 1)
            {
                Console.WriteLine("1 - Monday");
            }
            else if (weekday == 2)
            {
                Console.WriteLine("2 - Tuesday");
            }
            else if (weekday == 3)
            {
                Console.WriteLine("3 - Wednesday");
            }
            else if (weekday == 4)
            {
                Console.WriteLine("4 - Thursday");
            }
            else if (weekday == 5)
            {
                Console.WriteLine("5 - Friday");
            }
            else if (weekday == 6)
            {
                Console.WriteLine("6 - Saturday");
            }
            else
            {
                Console.WriteLine("7 - Sunday");
            }
            Console.WriteLine("This is the end of application");

            //Day 3. Task 2.1

            Console.WriteLine("Enter number");
            numb = Convert.ToInt32(Console.ReadLine());
            if (numb %2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else if (numb %5 == 0)
            {
                Console.WriteLine("This number is divisible by 5");
            }
            else
            {
                Console.WriteLine("The number does not meet any conditions");
            }
            
            //Day 3. Task 2.2

            Console.WriteLine("Enter temperature");
            temp = Convert.ToInt32(Console.ReadLine());
            if (temp < 0)
            {
                Console.WriteLine("Cold");
            }
            else if (temp >= 0 && temp <= 20)
            {
                Console.WriteLine("Cool");
            }
            else
            {
                Console.WriteLine("Hot");
            }
            
            //Day 3. Task 3.1

            Console.WriteLine("Enter time in 24h format");
            time = Convert.ToInt32(Console.ReadLine());
            if (time < 12)
            {
                Console.WriteLine("Good day!");
            }
            else if (time >= 12 && time <= 18)
            {
                Console.WriteLine("Good afternoon!");
            }
            else if (time > 18 && time <= 24)
            {
                Console.WriteLine("Good evening!");
            }
            else
            {
                Console.WriteLine("Good day!");
            }
            
            //Day 3. Task 3.2
            string pass = "labas";
            string pass2 = "Mellon";
            string pass3 = "01101001 01101110";
            Console.WriteLine("Enter password");
            pass = Console.ReadLine();

            if (pass == "labas" || pass == pass2)
            {
                Console.WriteLine("You have succesfully logged in");
            }
            else if (pass == pass3)
            {
                Console.WriteLine("Hacked..");
            }
            else
            {
                Console.WriteLine("Password is incorrect, please try again..");
            }
            

            //Day 3. Task 4

            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            
            if (age < 18)
            {
                Console.WriteLine("You are a minor");
            }
            else if (age >=18 && age <=65)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are eligible for the Senior Citizen promotion");
            }
            
            //Day 3. Task 5

            Console.WriteLine("Enter year");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0  && !(year % 100 == 0 || year % 400 == 0))
            {
                Console.WriteLine("This is a leap year");
            }
            else
            {
                Console.WriteLine("This is not a leap year");
            }
            

            //Day 3. Task 6

            Console.WriteLine("Enter number");
            skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius % 3 == 0 && skaicius % 5 == 0)
            {
                Console.WriteLine("BazingaPop");
            }
            else if (skaicius % 3 == 0)
            {
                Console.WriteLine("Bazinga");
            }
            else if (skaicius % 5 == 0)
            {
                Console.WriteLine("Pop");
            }
            else
            {
                Console.WriteLine(skaicius);
            }
            

            //Day 3. Task 7.1

            Console.WriteLine("Enter 1st number");
            numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            numb2 = Convert.ToInt32(Console.ReadLine());

            if (numb >= 0 && numb2 >= 0)
            {
                Console.WriteLine("Both numbers are postive");
            }
            else if (numb >= 0 || numb2 >= 0)
            {
                Console.WriteLine("Only one number is postive");
            }
            else if (numb < 0 || numb2 < 0)
            {
                Console.WriteLine("Neither number is positive");
            }
            

            //Day 3. Task 7.2
            Console.WriteLine("Enter number a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number c");
            c = Convert.ToInt32(Console.ReadLine());

            if (a == b && a == c) 
            {
                Console.WriteLine("All numbers are equal");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Two numbers are equal");
            }
            else 
            {
                Console.WriteLine("None of the numbers are equal");
            }
            */

            //Day 3. Task 8.1



            /* DAY 2
             *
            // Day 2, 1st task
            Console.WriteLine("Day 2, task 1:");
            // pick any letter from word
            string word = "World";
            Console.WriteLine(word[2]);
            // count word lenght
            Console.WriteLine(word.Length);
            // mew word from array of letters
            char[] letters = { 's', 't', 'a', 'l', 'a', 's' };
            string word2 = new string(letters);
            Console.WriteLine(word2);

            // Day 2, 2st task
            Console.WriteLine("Day 2, task 2:");
            // substring
            string s = "My name is Augustas Dapkevicius ";
            // Cut out name
            Console.WriteLine("Only name: " + s.Substring(11));
            // Cut out only My
            Console.WriteLine("Only first word: " + s.Substring(0, 2));

            // Day 2, 3rd task
            Console.WriteLine("Day 2, task 3:");
            // replace
            string zodis = "namas";
            string zodis2 = zodis.Replace('n', 'r');
            Console.WriteLine("Change letter n in namas " + zodis2);

            // method IndexOf (find first one)
            string company = "CodeAcademy";
            Console.WriteLine("C index of CodeAcademy " + company.IndexOf("C"));

            // method Trim()
            string s2 = s.Trim();
            Console.WriteLine("Trimm empty spaces: " + s2);

            // method ToLowerInvariant
            string strA = "WelcOme To heLL";
            string strB = strA.ToLowerInvariant();
            Console.WriteLine("All to lower case: " + strB);

            // method ToUpperInvariant
            string strC = strA.ToUpperInvariant();
            Console.WriteLine("All to upper case: " + strC);

            // method for joining lines

            // translate number into text

            */



            /* 1st task - triangle
            Console.WriteLine("Hello, World!");
            Console.WriteLine("1:");
            Console.WriteLine("   /\\");
            Console.WriteLine("  /  \\");
            Console.WriteLine(" /    \\");
            Console.WriteLine("/______\\");
            
            // Version with brake lines
            Console.WriteLine("1.1:");
            Console.WriteLine("\n   /\\\n  /  \\\n /    \\\n/______\\\n");
            
            // 2nd task - circle
            Console.WriteLine("2:");
            Console.WriteLine("     *****");
            Console.WriteLine("   **     **");
            Console.WriteLine(" **         **");
            Console.WriteLine("**   Hello   **");
            Console.WriteLine("**    from   **");
            Console.WriteLine(" **   C#    **");
            Console.WriteLine("   **     **");
            Console.WriteLine("     *****");

            // 3rd task - pyramid in colors
            Console.WriteLine("3:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   /\\");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  /  \\");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" /    \\");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("/______\\");
            Console.ForegroundColor = ConsoleColor.White;

            // 4th task - color heart shape
            Console.WriteLine("4:");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" / \\     / \\");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("/   \\   /   \\");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\\    \\ /    /");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" \\         /");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("  \\       /");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("   \\     /");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("    \\   /");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("     \\ /");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("      V");
            Console.ForegroundColor = ConsoleColor.White;

            // 5th task - apple
            Console.WriteLine("5:");
            string fruit = "obuolys";
            int quantity = 5;
            int price = 2;
            Console.WriteLine("Prekė: " + fruit);
            Console.WriteLine("Kiekis: " + quantity);
            Console.WriteLine("Kaina: " + price + " eur");

            // 6th task - card
            Console.WriteLine("6:");
            string name = "Augustas Dapkevicius";
            int age = 44;
            string occupation = "Software Developer";
            string email = "augustas@augustas.lt";
            string phone = "+370 611 31959";
            Console.WriteLine("==========VIZITINE==============");
            Console.WriteLine("Vardas: " + name + "\n" + "Amzius: " + age + "\n" + "Pareigos: " + occupation + "\n" + "El. pastas: " + email + "\n" + "Tel.:" + phone);
            Console.WriteLine("================================");*/
        }

    }
}

