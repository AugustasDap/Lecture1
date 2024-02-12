using System;

namespace ATM_project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = "";
            Console.WriteLine("Welcome to the ATM!");

            Console.Write("Insert your card (enter card GUID): ");
            string insertedCardGuid = Console.ReadLine();


            if (CardValidator.IsValidCardGuid(insertedCardGuid))
            {
                Console.Write("Card is valid. Please enter PIN: ");
                string userPin = Console.ReadLine();
                do
                {
                    if (CardValidator.IsPinValid(insertedCardGuid, userPin))
                    {
                        Card card = CardValidator.GetCard(insertedCardGuid);
                        Console.WriteLine("PIN is OK");
                        Console.Clear();
                        Console.WriteLine("Your selection");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("1. Current amount");
                        Console.WriteLine("2. Last 5 transactions");
                        Console.WriteLine("3. Withdraw money");
                        Console.WriteLine("4. EXIT");
                        Console.WriteLine();
                        input = Console.ReadLine();

                        switch (input)
                        {
                            case "1": //Current amount
                                Console.Clear();
                                card.Statement();
                                Back();
                                break;
                            case "2": //Last 5 transactions
                                Console.Clear();
                                Transaction.ReadLast5Transactions("C:\\Users\\Augustas\\source\\repos\\First\\ATM project\\", $"{card.Id}_transactions.txt");
                                Back();
                                break;
                            case "3": //Withdraw money
                                Console.Clear();
                                Console.Write("Enter amount to withdraw: ");
                                decimal amountToWithdraw = decimal.Parse(Console.ReadLine());
                                card.Withdraw(amountToWithdraw);
                                Back();
                                break;
                            case "4": //Exit
                                Console.Clear();

                                break;
                            default: //Error

                                break;
                        }


                    }
                    else
                    {
                        Console.WriteLine("Invalid PIN.");
                    }
                } while (input != "4");
            }


            else
            {
                Console.WriteLine("Invalid card. Please try again.");
            }


            Console.WriteLine("Thank you for using the ATM!");

        }
        public static void Back()
        {
            string input = "";
            do
            {
                Console.WriteLine("Type b to exit to main menu");
                input = Console.ReadLine();
                Console.Clear();
            }
            while (input != "b");
        }
    }
}