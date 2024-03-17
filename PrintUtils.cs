using System;
using System.Threading;

namespace PrintUtils
{
    public static class PrintUtils
    {
        public static void SlowPrint(string text, int rate = 20)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(1000/rate);
            }
            Console.WriteLine();
        }
    }
}
