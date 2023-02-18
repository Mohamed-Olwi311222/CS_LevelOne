using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            int num=int.Parse(Console.ReadLine());

            for(int x=0; x<=num; x++)
            {
                if(x%2==0)
                {
                    Console.WriteLine("{0} is even", x);
                }else                 {
                    Console.WriteLine("{0} is odd", x);
                }

            }

        }
    }
}