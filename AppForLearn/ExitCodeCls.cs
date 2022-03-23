using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    public class ExitCodeCls
    {
        public string proccessName { get; set; }

        public ExitCodeCls(string proccessName)
        {
            this.proccessName = proccessName;
        }

        public void PrintExitCode()
        {

            // Start the process.
            using (Process myProcess = Process.Start(this.proccessName))
            {
                // Display the process statistics until
                // the user closes the program.
                do
                {
                    if (!myProcess.HasExited)
                    {
                        // Refresh the current process property values.
                        myProcess.Refresh();

                        Console.WriteLine();

                        // Display current process statistics.

                        Console.WriteLine($"{myProcess} -");
                        Console.WriteLine("-------------------------------------");

                        if (myProcess.Responding)
                        {
                            Console.WriteLine("Status = Running");
                        }
                        else
                        {
                            Console.WriteLine("Status = Not Responding");
                        }
                    }
                }
                while (!myProcess.WaitForExit(1000));

                Console.WriteLine();
                Console.WriteLine($"  Process exit code          : {myProcess.ExitCode}");
            }
        }

        public void PrintExitCode2()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            //settings up parameters for the install process
            process.StartInfo.FileName = this.proccessName;

            process.Start();

            process.WaitForExit();
            Console.WriteLine($"  Process exit code          : {process.ExitCode}");
            // Check for sucessful completion
            // return (process.ExitCode == 0) ? true : false;
        }
    }
}
