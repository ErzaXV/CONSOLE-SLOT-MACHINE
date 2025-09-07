using SLOT_MACHINE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Gamesystem gamesystem = new Gamesystem();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   _ )    _ )    _ )        \\  |  ____|   ___|   _ \\    _ \\  \r\n   _ \\    _ \\    _ \\         \\ |  __|    |      |   |  |   | \r\n  (   |  (   |  (   |      |\\  |  |      |   |  __ <   |   | \r\n \\___/  \\___/  \\___/      _| \\_| _____| \\____| _| \\_\\ \\___/  \r\n                                                             ");
            gamesystem.system();

            
        } 
    }
}
