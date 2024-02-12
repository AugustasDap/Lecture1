
//Task 1.1

Console.WriteLine("Enter text");
string text = Console.ReadLine();
char[] textarray = text.ToCharArray();
textarray[0] = char.ToUpper(textarray[0]);
Console.WriteLine(textarray);


//Task 1.2
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


//Task 1.3
/*
Console.WriteLine("Enter 5 letters text");
string text = Console.ReadLine();
char[] textarray = text.ToCharArray();
if (text.Length == 5)
{

       //Console.WriteLine("Let's encode. Give me number:");
       //int encoding = Convert.ToInt32(Console.ReadLine());

       //textarray[0] = char.Parse(change0);
       //Console.WriteLine("Change 2nd letter to number:");
       //string change1 = Console.ReadLine();
       //textarray[1] = char.Parse(change1);
       //Console.WriteLine("Change 3rd letter to number:");
       //string change2 = Console.ReadLine();
       //textarray[2] = char.Parse(change2);
       //Console.WriteLine("Change 4th letter to number:");
       //string change3 = Console.ReadLine();
       //textarray[3] = char.Parse(change3);
       //Console.WriteLine("Change 5th letter to number:");
       //string change4 = Console.ReadLine();
       //textarray[4] = char.Parse(change4);
       //string encode = new string(textarray);

    //char encoding = '!';

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
*/


//Task 2.1
/*
Console.WriteLine("Please write a sentence:");
string text2 = Console.ReadLine();
string replace = text2.Replace("a", "uo");
string replace2 = replace.Replace('i', 'e');
Console.WriteLine("a>>uo: " + replace);
Console.WriteLine("i>>e: " + replace2);
*/


//Task 2.2
/*
Console.WriteLine("Please enter lyrics");
string text = Console.ReadLine();
Console.WriteLine("What needs to be replaced?");
string replace = Console.ReadLine();
Console.WriteLine("Replace to what?");
string replaceto = Console.ReadLine();
if (text.Contains(replace+" "))
{
    string replaced = text.Replace(replace + " ", replaceto + " ");
    Console.WriteLine(replaced);
}
else 
{
    Console.WriteLine("Nothing to replace");
}
*/


//Task 2.3
/*
Console.WriteLine("Enter birth date YYYY MM DD");
string dataInput = Console.ReadLine();
var parsedate = DateOnly.Parse(dataInput);
Console.WriteLine("Enter today date YYYY MM DD");
string dataInput2 = Console.ReadLine();
var parsedate2 = DateOnly.Parse(dataInput2);
var older = parsedate.AddYears(90);
var countYear = older.Year - parsedate2.Year;
var countMonth = older.Month - parsedate2.Month;
var countDay = older.Day - parsedate2.Day;
var countWeek = (countYear * 53) + (countMonth * 1) + (countDay / 7);

Console.WriteLine("Till yours 90 left: " + countYear.ToString() + " years, " + countMonth.ToString() + " months, " + countDay.ToString() + " days");
Console.WriteLine(countWeek.ToString() + " weeks in total");
*/

//Task 3.1
/*
Console.WriteLine("Write word");
string text = Console.ReadLine();
char[] textarray = text.ToCharArray();
if (char.IsUpper(textarray[0]))
{
    string textToUpper = text.ToUpper();
    Console.WriteLine(textToUpper);
}
else
{
    char capital = char.ToUpper(textarray[0]);
    string textToUpper2 = text.Substring(1);
    Console.WriteLine(capital.ToString() + textToUpper2);
}
*/

//Task 3.2
/*
Console.WriteLine("Enter word");
string text = Console.ReadLine();
int index = text.IndexOf("a");
if (index == -1) 
{
    Console.WriteLine("a not found");
}
else
{
    Console.WriteLine(text + " contains letter a") ;
}
*/

//Task 3.3
/*
Console.WriteLine("Enter word"); //hello
string text = Console.ReadLine();
*/

/*
 * 
 * 
 */