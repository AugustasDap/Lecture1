using C__Advanced_Exam.Models;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C__Advanced_Exam
{
    public class Vouchers //objektas
    {
        public Guid Id { get; set; } = Guid.NewGuid(); //properties
        public List<FoodItems> FoodItems { get; set; }
        public decimal TotalPrice { get; set; }
        public string StaffId { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string TableNumber { get; set; }


        //total price skaiciuojamas nuo produktu ir kiekio 
        //i konstruktoriu paduodamas foodItems sarasas ir konstruktoriuje suskaiciuojamas total
        public Vouchers(List<FoodItems> foodItems, string staffId, string tableNumber) //konstruktorius
        {
            FoodItems = foodItems;
            foreach (var item in FoodItems)
            {
                TotalPrice += item.Price;
            }

            StaffId = staffId;
            TableNumber = tableNumber;

            WriteOrderToFile();
        }


        public void WriteOrderToFile()
        {
            string directoryPath = "C:\\Users\\Augustas\\source\\repos\\First\\C# Advanced Exam\\Data";
            try
            {
                //Directory.CreateDirectory("C:\\Users\\Augustas\\source\\repos\\First\\C# Advanced Exam\\Data");
                string filePath = Path.Combine(directoryPath, $"{StaffId}_order_{DateTime.ToString("yyyy_MM_dd_HH_mm_ss")}.txt");

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{DateTime}, employee: {StaffId}, table: {TableNumber}");
                    foreach (var item in FoodItems)
                    {
                        writer.WriteLine(item.ToString());
                    }
                    writer.WriteLine($"Total ordered {TotalPrice} EUR");
                }

                Console.WriteLine("Order data has been written to the voucher.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }


    }
}
