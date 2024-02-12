using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_project
{
    public class CardValidator
    {
        public static List<Card> validCards = new List<Card>();

        static CardValidator()
        {
            LoadValidCardGuidsFromFile("C:\\Users\\Augustas\\source\\repos\\First\\ATM project\\GUIDs.txt");
        }

        private static void LoadValidCardGuidsFromFile(string filePath)
        {
            try
            {
                foreach (var item in File.ReadAllLines(filePath))
                {
                    string[] Array = item.Split(';');
                    validCards.Add(new Card
                    {
                        Id = Array[0],
                        Pin = int.Parse(Array[1]),
                        CardBalance = decimal.Parse(Array[2]),
                    });
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: {filePath} not found. No valid card GUIDs loaded.");
            }
        }
        public static Card GetCard(string cardGuid)
        {
            return validCards.FirstOrDefault(x => x.Id == cardGuid);
        }
        public static bool IsValidCardGuid(string cardGuid)
        {
            return !string.IsNullOrEmpty(cardGuid) && validCards.Any(x => x.Id == cardGuid);
        }

        public static bool IsPinValid(string cardGuid, string userPin)
        {
            if (string.IsNullOrEmpty(cardGuid) || string.IsNullOrEmpty(userPin))
            {
                return false;
            }
            var card = validCards.FirstOrDefault(x => x.Id == cardGuid);
            //Find the first element in the validCards
            //list where the Id property matches the specified cardGuid.
            //If found, return that Card object;
            //otherwise, return null.
            if (card != null)
            {
                return card.Pin.ToString() == userPin;
            }

            return false;
        }

    }
}
