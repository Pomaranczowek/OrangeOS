using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realos
{
    internal class CmdList
    {
        public static void ShowList()
        {
            Console.WriteLine("Command List:");
            Console.WriteLine("help - Shows the command list - alias: hlp, ?");
            Console.WriteLine("clear - Clears the command line - alias: cls");
            Console.WriteLine("programs - Shows the program list");
        }
    }
}
