using C__Advanced_Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_Exam.Repositories
{
    public class TablesRepository
    {
        public List<Tables> tables = new List<Tables>();

        public TablesRepository()
        {
            LoadTablesFromFile("C:\\Users\\Augustas\\source\\repos\\First\\C# Advanced Exam\\Data\\Tables.txt"); //staff file
        }
        public void LoadTablesFromFile(string filePath)
        {
            try
            {
                foreach (var item in File.ReadAllLines(filePath))
                {
                    string[] Array = item.Split(';');
                    tables.Add(new Tables
                    {
                        TableNumber = Array[0],
                        Seats = int.Parse(Array[1]),
                        TableOccupation = Array[2],
                    });
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: {filePath} not found. No tables loaded.");
            }
        }
        //iskelti spausdinima i UI ir panaudoti metoda GetAllTables (food repository)

        public List<Tables> GetAllTables()
        {
            return tables;
        }
        public void UpdateTable(string tableName, string tableStatus)
        {
            tables.FirstOrDefault(x => x.TableNumber == tableName).TableOccupation = tableStatus;

            File.WriteAllLines("C:\\Users\\Augustas\\source\\repos\\First\\C# Advanced Exam\\Data\\Tables.txt", tables.Select(x => x.ToString()));
        }


    }
}
