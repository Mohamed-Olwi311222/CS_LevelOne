using System.Security.Cryptography.X509Certificates;

namespace Perfect_numbers_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number to start counting from: ");
            int num1=int.Parse(Console.ReadLine());
            
            Console.Write("Enter the number to stop counting to: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 < 1)
            {
                num1 = 1;   //if the user enterd negative or zero ,shift num1 to 1 instead
            }
            
            for (int c=num1;c<=num2;c++)
            {
                int sum = 0;
                for (int d=1;d<c;d++)
                {
                    if (c % d == 0)
                       sum += d; 
                    else
                        continue;
                }
                if (sum == c)
                {
                    Console.WriteLine(c);
                }

            }


            Console.ReadKey();
        }
    }
}