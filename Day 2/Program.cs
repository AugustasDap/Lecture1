//DAY 2
 
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

