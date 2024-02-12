           // 1st task - triangle
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
           Console.WriteLine("================================");