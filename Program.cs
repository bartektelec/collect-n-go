using System;
using static System.Console;
using System.Collections.Generic;

namespace CollectNGo
{
    class Program
    {

        static void Main(string[] args)
        {

            Intro();
        }

        private static void Intro()
        {
            WriteLine("Welcome to Collect N Go! Parcel box");
            WriteLine("Push any key to continue");
            ReadKey();
            Run();
        }

        private static void Run()
        {
            var machine = new Machine();
            var running = true;

            while(running)
            {
                WriteLine("========");
                WriteLine("Z to Insert code");
                WriteLine("X to Store a value");
                WriteLine("C to Open a box");

                WriteLine("========");
                var opened = machine.GetOpenBoxes();
                for(var i = 0; i < opened.Count; i ++)
                {
                    if (i == 0) WriteLine("These boxes are now open:");
                    WriteLine($"Box no. {opened[i]}");
                }


                var key = ReadKey().Key;
                Clear();
                switch(key)
                {
                    case ConsoleKey.Z:
                        WriteLine("Type in your code:");
                        string inputCode = ReadLine();

                        machine.InputCode(inputCode);
                        break;

                    case ConsoleKey.X:
                        WriteLine("What would you like to store?");
                        string inputContent = ReadLine();
                        var code = machine.Store(inputContent);
                        Clear();
                        WriteLine("Value has been stored");
                        WriteLine($"Access Code to open:{code}");

                        break;

                    case ConsoleKey.C:
                        WriteLine("Which box do you want to collect from?");
                        string collectBoxId = ReadKey().Key.ToString()[1].ToString();
                        Clear();
                        machine.Open(Convert.ToInt32(collectBoxId));


                        break;

                    case ConsoleKey.Escape:
                        running = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
