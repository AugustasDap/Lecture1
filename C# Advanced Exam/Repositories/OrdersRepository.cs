using C__Advanced_Exam.Models;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_Exam.Repositories
{
    public class OrdersRepository
    {
        public List<Orders> food = new List<Orders>();
        public List<Orders> drinks = new List<Orders>();

        public OrdersRepository()
        {
            LoadFoodFromFile("C:\\Users\\Augustas\\source\\repos\\First\\C# Advanced Exam\\Data\\Food.txt");
            LoadDrinksFromFile("C:\\Users\\Augustas\\source\\repos\\First\\C# Advanced Exam\\Data\\Drinks.txt");
        }
        public void LoadFoodFromFile(string filePath)
        {
            try
            {
                foreach (var item in File.ReadAllLines(filePath))
                {
                    string[] Array = item.Split(';');
                    food.Add(new Orders
                    {
                        FoodId = Array[0],
                        FoodPrice = int.Parse(Array[1]),
                    });
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: {filePath} not found. No tables loaded.");
            }
        }

        public void LoadDrinksFromFile(string filePath)
        {
            try
            {
                foreach (var item in File.ReadAllLines(filePath))
                {
                    string[] Array = item.Split(';');
                    drinks.Add(new Orders
                    {
                        DrinkId = Array[0],
                        DrinkPrice = int.Parse(Array[1]),
                    });
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: {filePath} not found. No tables loaded.");
            }
        }



    }
}
