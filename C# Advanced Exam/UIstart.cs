using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using C__Advanced_Exam.Models;
using C__Advanced_Exam.Repositories;



namespace C__Advanced_Exam
{
    public class UIstart
    {
        private readonly FoodRepository _foodRepository;
        private readonly TablesRepository _tableRepository;
        private readonly StaffRepository _staffRepository;
        public UIstart() //konstruktorius
        {
            _foodRepository = new FoodRepository();
            _tableRepository = new TablesRepository();
            _staffRepository = new StaffRepository();
        }


        public void Run()
        {

            string input = "";
            Console.WriteLine("Welcome to the FoodDrinkCodeRepeat!");

            Console.Write("Enter employee ID: ");
            string employeeId = Console.ReadLine();


            if (_staffRepository.IsValidStaffId(employeeId))
            {
                Console.Write("PIN: ");
                string userPin = Console.ReadLine();
                do
                {
                    if (_staffRepository.IsPinValid(employeeId, userPin))
                    {
                        Staff employee = _staffRepository.GetId(employeeId);
                        Console.WriteLine("PIN is OK");
                        Console.Clear();
                        Console.WriteLine("Please select what you want to do:");
                        //Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("1. Start new order");
                        Console.WriteLine("2. Tables management");
                        Console.WriteLine("3. Vouchers");
                        Console.WriteLine("4. Log-off to main menu");
                        Console.WriteLine();
                        input = Console.ReadLine();

                        switch (input)
                        {
                            case "1": //Start new order
                                Console.Clear();
                                FillOrder(employeeId);
                                Back();
                                break;
                            case "2": //Tables management
                                Console.Clear();
                                Console.WriteLine($"Current tables occupation:");
                                TableAvailability();
                                Back();
                                break;
                            case "3": //Vouchers
                                Console.Clear();
                                GetVouchersList();
                                Back();
                                break;
                            case "4": //Log-off to main menu
                                Console.Clear();
                                //TODO implement back to login menu
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
                Console.WriteLine("Invalid ID. Please try again.");
            }


            Console.WriteLine("Thank you for using the FoodDrinkCodeRepeat!");

        }
        public void Back()
        {
            string input = "";
            do
            {
                Console.WriteLine("Type x to exit to main menu");
                input = Console.ReadLine();
                Console.Clear();
            }
            while (input != "x");

        }
        public void FillOrder(string employeeId)
        {
            //table selection:
            Console.WriteLine("Please select table");
            TableAvailability();
            string tableSelection = Console.ReadLine();
            _tableRepository.UpdateTable(tableSelection, "order");


            //food selection:
            Console.Clear();
            Console.WriteLine("Please select food or exit(x):");
            Console.WriteLine();
            var foodList = _foodRepository.GetAllFoodItems();
            foreach (var food in foodList)
            {
                Console.WriteLine(food.ToString());
            }
            //FoodRepository.MenuToScreen("C:\\Users\\Augustas\\source\\repos\\First\\C# Advanced Exam\\Data\\Food.txt");

            var iteamsAndQuantity = Selection();
            List<FoodItems> list = new List<FoodItems>();
            //is items and quantity dic pasikursim sarasa foodItems ir sukursim voucheri
            foreach (var iteam in iteamsAndQuantity)
            {
                var food = foodList.FirstOrDefault(x => x.Id == iteam.Key);
                for (var j = 0; j < iteam.Value; j++)
                {
                    list.Add(food);
                }
            }
            Vouchers vouchers = new Vouchers(list, employeeId, tableSelection);


            Console.Clear();
            //drinks selection:
            //Console.WriteLine("Please select drinks:");
            //Console.WriteLine();
            //FoodRepository.MenuToScreen("C:\\Users\\Augustas\\source\\repos\\First\\C# Advanced Exam\\Data\\Drinks.txt");
            //Selection("C:\\Users\\Augustas\\source\\repos\\First\\C# Advanced Exam\\Data\\Drinks.txt");

        }



        public Dictionary<string, int> Selection()
        {

            bool exitRequest = false;
            Dictionary<string, int> ItemAndQuantity = new Dictionary<string, int>();
            do
            {
                string foodInput = Console.ReadLine();
                if (foodInput == "x")
                {
                    exitRequest = true;
                }
                else if (foodInput != "x")
                {
                    Console.WriteLine($"{foodInput} qty?");
                    int qty = int.Parse(Console.ReadLine());

                    ItemAndQuantity.Add(foodInput, qty);

                }


            } while (!exitRequest);

            return ItemAndQuantity;

            //string voucherFilePath = "C:\\Users\\Augustas\\source\\repos\\First\\C# Advanced Exam\\Data\\testvoucher.txt";
            //Vouchers.WriteOrderToFile();
        }
        public void TableAvailability()
        {
            try
            {
                var tables = _tableRepository.GetAllTables();

                foreach (var table in tables)
                {
                    if (table.TableOccupation.Contains("free"))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine(table.ToString());

                }
                Console.ResetColor();
                Console.WriteLine();


            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        public void GetVouchersList()
        {
            string directoryPath = "C:\\Users\\Augustas\\source\\repos\\First\\C# Advanced Exam\\Data";
            string filePattern = @"\d+_order_\d{4}_\d{2}_\d{2}_\d{2}_\d{2}_\d{2}\.txt";
            try
            {
                string[] files = Directory.GetFiles(directoryPath);
                var filteredFiles = files.Where(file => Regex.IsMatch(Path.GetFileName(file), filePattern)).ToList();
                Console.WriteLine("Available vouchers:");
                int fileNumber = 1;
                foreach (var file in filteredFiles)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{fileNumber} - {Path.GetFileName(file)}");
                    fileNumber++;
                }
                Console.ResetColor();
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
