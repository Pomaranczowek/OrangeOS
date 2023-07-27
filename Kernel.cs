using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace realos
{
    public class Kernel : Sys.Kernel
    {
        int loggedin = 0;
        string pcname = "localhost";
        string username = "root";
        protected override void BeforeRun()
        {
            Console.WriteLine("OrangeOS Finished Booting.");
        }

        protected override void Run()
        {
            if (loggedin == 0)
            {
                Console.Clear();
                Console.WriteLine("Username:");
                string readname = Console.ReadLine();
                if (readname == username)
                {
                    Console.WriteLine("Password:");
                    var password = Console.ReadLine();
                    if (password == "123456")
                    {
                        Console.Clear();
                        Console.WriteLine("Successfully logged in.");
                        loggedin = 1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Password, try again");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Username, try again.");
                }
            }
            else
            {
                Console.Write(username + "@" + pcname + ": ");
                var input = Console.ReadLine();
                if (input == "numgame")
                {
                    Numgame.launch();
                }
                else if (input == "clear" || input == "cls")
                {
                    Console.Clear();
                }
                else if (input == "help" || input == "?" || input == "hlp")
                {
                    CmdList.ShowList();
                }
                else if (input == "programs")
                {
                    ProgramList.ShowList();
                }
                else if (input == "about")
                {
                    Console.WriteLine("OrangeOS v0.1 ALPHA");
                }
                else
                {
                    Console.WriteLine("Unknown Command or Program.");
                }
            }
        }
    }
}
