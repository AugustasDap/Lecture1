using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._13_Asynchronous
{
    internal class ProgressBar
    {
        private int progress;

        public int Progress
        {
            get { return progress; }
            set { progress = value; }
        }

        public async Task StartProgressAsync()
        {
            Task.Run(UpdateProgress);
            await Task.Run(PrintProgress);
        }

        private async Task UpdateProgress()

        {
            while (progress <= 10)
            {
                progress++;
                //Console.WriteLine($"Progress: {progress}%");
                await Task.Delay(1000); // Asynchronously wait for 1 second
            }
        }
        private async Task PrintProgress()

        {
            while (progress <= 10)
            {
                progress++;
                Console.WriteLine($"Progress: {progress}%");
                await Task.Delay(3000); // Asynchronously wait for 3 second
            }
        }

    }
}
