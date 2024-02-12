// See https://aka.ms/new-console-template for more information

//lesson material
/*
int i = 1;
do
{
    Console.WriteLine("Number: " + i);
    i++;
} while (i <= 5);

string input;
do
{
    Console.WriteLine("Type 'exit' to stop:");
    input = Console.ReadLine();
} while (input != "exit");
*/

//Task 5.1
/*
string input;
string upper;
int result = 0;
int sum = 0;

do
{
    Console.WriteLine("Enter number or 'Finish' to stop:");
    input = Console.ReadLine();
    if (int.TryParse(input, out result))
        sum = sum + result;

    upper = input.ToUpper();
} while (upper != "FINISH");
Console.WriteLine("sum: " + sum);
Console.ReadLine();
Console.WriteLine("The end..");
*/

//Task 5.2
/*
string input;

do
{
    Console.WriteLine("Enter password: ");
    input = Console.ReadLine();
    
} while (input != "CoAc7");
Console.WriteLine("Welcome");
Console.WriteLine("The end..");
*/

//Task 5.3
/*
Random i = new Random();
int rand = i.Next(0, 10);
int input = 0;

do
{
    Console.WriteLine("Quess number");
    input = int.Parse(Console.ReadLine());
    if (input > rand) Console.WriteLine("nope.. go lower");
    if (input < rand) Console.WriteLine("nope.. go upper");

} while (input != rand);
Console.WriteLine("Yup, number was " + input);
*/

//Project

Console.WriteLine("Enter your nickname");
string username = Console.ReadLine();
Random i = new Random();    
int rand = i.Next(0, 100); //player life points
Random j = new Random();
int ogre = j.Next(0, 100); //ogre life points
Console.WriteLine($"{username}, you have {rand} life points. Let's start the game");
Console.WriteLine($"Story starts in swamp. {username} encountered Ogre. Fight!");
Console.WriteLine("Press s to shoot");

do
{
    Random p1 = new Random();
    Random p2 = new Random();
    int shoot1 = p1.Next(0, 10); //player shoot points
    int shoot2 = p2.Next(0, 10); //ogre shoot points
    Console.WriteLine($"{username}, shoot");
    string player = Console.ReadLine();
    Console.WriteLine($"{username} shoot points: {shoot1}");
    Console.WriteLine($"Ogre shoot points: {shoot2}");
    rand = rand - shoot2;
    ogre = ogre - shoot1;
    Console.WriteLine($"{username} was hit {shoot2} shoot points. You have {rand} life points left. Ogre was hit {shoot1} shot points, he still have {ogre} life points");


} while(rand >= 0 && ogre >= 0);
Console.WriteLine();
if (rand > 0)
{
    Console.WriteLine($"{username}, you are hero!");
}
else Console.WriteLine($"{username}, you are dead..");


