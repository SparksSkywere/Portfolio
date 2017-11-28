using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleapp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to my test application");
            System.Threading.Thread.Sleep(6000);
            Console.Clear();
            Console.WriteLine("This application will open the CMD for testing purposes, dont worry nothing will happen");
            System.Threading.Thread.Sleep(7000);
            Console.Clear();
            Console.WriteLine("Press any key to open the CMD - It will ask for admin privileges");
            Console.ReadKey();

            var proc1 = new System.Diagnostics.ProcessStartInfo();
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "";
            proc1.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            System.Diagnostics.Process.Start(proc1);

        }
    }
}
