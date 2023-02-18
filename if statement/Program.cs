using System;

namespace if_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool closed= false ;
            bool broken = true;

            if (closed)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("lamp is opening ");
            }
            else if(broken)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("the lamp is broken, please repair");
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("lamp is already opened");
            }
        }
    }
}