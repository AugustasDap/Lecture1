using C__Advanced_Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_Exam.Repositories
{
    public class FoodRepository
    {
        public readonly List<FoodItems> items = new List<FoodItems>();

        public FoodRepository()
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
                    items.Add(new FoodItems
                    {
                        Id = Array[0],
                        Name = Array[1],
                        Price = decimal.Parse(Array[2]),
                        Type = "food", //gerimai drink

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
                    items.Add(new FoodItems
                    {
                        Id = Array[0],
                        Name = Array[1],
                        Price = decimal.Parse(Array[2]),
                        Type = "drink",

                    });
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: {filePath} not found. No tables loaded.");
            }
        }



        public List<FoodItems> GetAllFoodItems()
        {
            return items;
        }

    }
}
