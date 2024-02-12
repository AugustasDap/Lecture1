using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ATM_project
{
    internal class Transaction
    {
        public string CardId { get; set; } //guid
        public decimal Amount { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string TransType { get; set; } //Enum

        public Transaction(string cardId, decimal amount, string transType)
        {
            CardId = cardId;
            Amount = amount;
            TransType = transType;
            WriteTransactionToFile("C:\\Users\\Augustas\\source\\repos\\First\\ATM project", DateTime, cardId, amount, transType);
        }

        public static void WriteTransactionToFile(string directoryPath, DateTime dateTime, string cardId, decimal amount, string transType)
        {
            try
            {
                Directory.CreateDirectory("C:\\Users\\Augustas\\source\\repos\\First\\ATM project");
                //string filePath = "C:\\Users\\Augustas\\source\\repos\\First\\ATM project\\transaction.txt";
                string filePath = Path.Combine(directoryPath, $"{cardId}_transactions.txt");

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{dateTime}, CardId: {cardId}, Amount: {amount}, Transaction Type: {transType}");
                }

                Console.WriteLine("Transaction data has been written to the file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public static void ReadLast5Transactions(string directoryPath, string fileName)
        {
            try
            {
                // Construct the full file path
                string filePath = Path.Combine(directoryPath, fileName);

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    Console.WriteLine($"Last 5 transactions:");

                    // Read the last 5 lines from the file
                    string[] lines = File.ReadAllLines(filePath);
                    int startLine = Math.Max(0, lines.Length - 5);

                    for (int i = startLine; i < lines.Length; i++)
                    {
                        Console.WriteLine(lines[i]);
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"File {fileName} not found in the specified directory.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
