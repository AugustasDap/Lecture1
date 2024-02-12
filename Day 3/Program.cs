
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


//Day 3. Task 8.1