using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_project
{
    public class Card
    {
        public int Pin { get; set; }
        public string Id { get; set; } //guid
        public decimal CardBalance { get; set; }

        public void Statement()
        {
            Console.WriteLine($"Current balance: {CardBalance}");
        }

        public void Withdraw(decimal input) //TODO
        {
            if (CardBalance >= input)
            {
                if (input < 1001)
                {
                    //Console.WriteLine($"Card balance: {card.CardBalance}");
                    CardBalance -= input;

                    Console.WriteLine($"Transaction successfull! Account balance: {CardBalance}");
                    new Transaction(Id, input, "withdraw");
                }
                else
                {
                    Console.WriteLine("Withdraw amount limited to 1000");
                }
            }
            else
            {
                Console.WriteLine("Insufficient funds.");

            }
        }

    }


}
