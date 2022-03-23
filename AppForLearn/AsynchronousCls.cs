using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    public class AsynchronousCls
    {
        public async Task LoadingRest()
        {
            //Console.WriteLine("Loaded the mse-2014v1.0 package");
            //Task.Run(() =>
            //{
            //    Console.WriteLine("Completed!");
            //});
            //Console.WriteLine("Installed successfully!");

            Console.WriteLine("About to launch a task...");
            // CS4014: Because this call is not awaited, execution of the current method continues before the call is completed.
            // Consider applying the 'await' operator to the result of the call.
            Task.Run(() =>
            {
                var iterations = 0;
                for (int ctr = 0; ctr < int.MaxValue; ctr++)
                    iterations++;
                Console.WriteLine("Completed looping operation...");
                throw new InvalidOperationException();
            });
            await Task.Delay(30000);
            var e = 1;
            //await Task.Delay(5000);
            //Console.WriteLine("Exiting after 5 second delay");
        }

        public void LoadingPre()
        {
            // Console.WriteLine("Loaded the F3lib package");
            LoadingRest();
            // Console.WriteLine("Loaded the fan-cn v4.3.3 package");
        }
    }
}
