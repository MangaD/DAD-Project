using System;
using System.Threading;

namespace API
{
    public static class Utilities
    {
        public static void WriteDebug(string debug)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(debug);
            Console.ResetColor();
        }

        public static void WriteError(string err)
        {
            //Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine(err);
            Console.ResetColor();
        }

        public static void Wait(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }
    }
}
