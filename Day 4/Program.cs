//Day 4. Task 1.1

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


//Day 4. Task 2.3