// See https://aka.ms/new-console-template for more information

//lesson material

/*
int i = 1;
while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
*/

/*
int i = 1;
int j = 1;

while (i <= 3)
{
    Console.Write("Outer loop: " + i);

    while (j <=3 )
    {
        Console.WriteLine("Inner loop: " + j);
        j++;
    }
    j = 1;
    i++;
}
/*
/**/
//Task 1.1 & 1.2
/*
    int  i = 1;
    int j = 5;

while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
Console.WriteLine("**");
while (j >= 1)
{
    Console.WriteLine(j);
    j--;
}
*/

//Task 1.3 & 1.4

//int i = 2;
//int j = 1;
//while (i <= 10)
//{
//    Console.WriteLine(i);
//    i = i + 2;
//}
//Console.WriteLine("**");
//while (j <= 10)
//{
//    Console.WriteLine(j);
//    j = j + 2;
//}



//Task 1.5 & 1.6

//int i = 0;
//int j= -1;
//while (i <= 100)
//{
//    Console.WriteLine("Enter number");
//    i = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Input: " + i);

//}
 
//Console.WriteLine("Great, out of the loop");

//while (j <= 0)
//{
//    Console.WriteLine("Enter negative number");
//    j = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Input: " + j);

//}

//Console.WriteLine("What was tricky, out of the loop");


//Task 2.1 & 2.2

//int i = 1;
//int j = 1;
//while (j != 0)
//{
//    Console.WriteLine("Add number");
//    i = int.Parse(Console.ReadLine());
//    j = 1;
//    while (i != 1)
//    {
//        j = j * i;
//        i--;
//    }
//    Console.WriteLine($"Factorial is: {j}");
//}
//Console.WriteLine("Error");


//Task  2.3

//Console.WriteLine("Enter number (123 or similar)");
//int i = int.Parse(Console.ReadLine());
//char[] input = i.ToString().ToCharArray();
//int j = input.Length;
//int k = 0;
////Console.WriteLine(j);
//while (j != 0)
//{
//    Console.WriteLine(input[k]);
//    j--;
//    k++;
//}


//Task 2.4

Console.WriteLine("Enter number");
int n = int.Parse(Console.ReadLine());
int i = 0;
while (i != n)
{
    int k = 0;
    while (k <= n-1)
    {
        Console.Write("*");        
       k++;
    }
    Console.WriteLine();
    n++;
}


