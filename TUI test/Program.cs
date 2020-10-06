using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;

namespace TUI_test
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Define the colour colours
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            //start
            Console.WriteLine("TUI test\nClearing in 3 sec...");
            Thread.Sleep(3000);
            Console.Clear();
            //Gradient test
            Console.WriteLine("\n░▒▓█\n");
            Console.WriteLine("|█████▓▓▓▓▒▒▒▒░░░░    |");
            Console.WriteLine("|███▓▓▓▓▒▒▒▒░░░░      |");
            Console.WriteLine("|█████▓▓▓▓▒▒▒▒░░░░    |");
            Console.WriteLine("\nDiscord art:\n");
            //Discord art (8h, 12w)
            Console.WriteLine("    ██████    ██████");
            Console.WriteLine("  ████████████████████");
            Console.WriteLine("  ████    ████    ████");
            Console.WriteLine("██████    ████    ██████");
            Console.WriteLine("████████████████████████");
            Console.WriteLine("████████████████████████");
            Console.WriteLine("  ██████        ██████");
            Console.WriteLine("    ██████    ██████\n");
            Thread.Sleep(5000);
            //Mario art (16h, 12w)
            Console.WriteLine("      ████████████");
            Console.WriteLine("    ████████████████████");
            Console.WriteLine("    ▓▓▓▓▓▓▒▒▒▒▒▒  ▒▒");
            Console.WriteLine("  ▓▓▒▒▓▓▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒");
            Console.WriteLine("  ▓▓▒▒▓▓▓▓▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒");
            Console.WriteLine("  ▓▓▓▓▒▒▒▒▒▒▒▒▒▒        ");
            Console.WriteLine("      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine("    ████░░████████");
            Console.WriteLine("  ██████░░████░░██████");
            Console.WriteLine("████████░░░░░░░░████████");
            Console.WriteLine("▒▒▒▒██░░  ░░░░  ░░██▒▒▒▒");
            Console.WriteLine("▒▒▒▒▒▒░░░░░░░░░░░░▒▒▒▒▒▒");
            Console.WriteLine("▒▒▒▒░░░░░░░░░░░░░░░░▒▒▒▒");
            Console.WriteLine("    ░░░░░░    ░░░░░░");
            Console.WriteLine("  ▒▒▒▒▒▒        ▒▒▒▒▒▒");
            Console.WriteLine("▒▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒▒");
            //Trying out this thing:
            Print();
            ColourPixelTest();
        }
        static void Print(string s = "jgjdgfhfgjjgi") {
            Console.WriteLine(s);
            Console.WriteLine(s);
        }

        static void ColourPixelTest(string c = "Test") {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(c);

            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(c);

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(c);

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(c);

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(c);

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(c);

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(c);

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(c);

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(c);

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(c);

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(c);

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(c);

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(c);

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(c);

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(c);
            Console.ResetColor();
        }
    }
}
