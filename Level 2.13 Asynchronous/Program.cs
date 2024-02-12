using System;
using System.IO;
using System.Threading;
namespace Level_2._13_Asynchronous

{
    internal class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            //Task 1 progress bar

            ProgressBar progressBar = new ProgressBar();
            await progressBar.StartProgressAsync();
            Console.WriteLine("Program completed.");


            //Task 2 users desktop directory content

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            Timer timer = new Timer(PrintDesktopContents, desktopPath, 0, 5000);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Press Enter to exit.");
            Console.ResetColor();
            Console.ReadLine();

            // Dispose of the timer when the program exits
            timer.Dispose();

        }
        static void PrintDesktopContents(object state)
        {
            string desktopPath = (string)state;

            Console.WriteLine($"Contents of Desktop directory ({DateTime.Now}):");

            try
            {
                // Get all files in the Desktop directory
                string[] files = Directory.GetFiles(desktopPath);

                // Print the files
                foreach (string file in files)
                {
                    Console.WriteLine(Path.GetFileName(file));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine();
        }
    }
}