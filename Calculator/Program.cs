using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace calculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the value of X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of Y: ");
            double y = double.Parse(Console.ReadLine());

            Console.Write("what is the operator that you need? (1 for division), (2 for multiplication) , (3 for substraction) ,(4 for addition) ");
            int op = int.Parse(Console.ReadLine());

            while (op > 4 || op <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("please choose the correct number for the operator");
                op = int.Parse(Console.ReadLine());
            }
            
            if (op == 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("x/y= ");
                Console.Write(x / y);

            }
            else if (op == 2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("x*y= ");
                Console.Write(x * y);

            }
            else if (op == 3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("x-y= ");
                Console.Write(x - y);

            }
            else if (op == 4)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("x+y= ");
                Console.Write(x + y);

            }

            Thread.Sleep(10000);

        }
    }
}