using System.Data.Common;

namespace Calculator_if__problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float firstnum, secondnum;
            char op;



            Console.Write("First Number: ");
            firstnum=float.Parse(Console.ReadLine());


            Console.Write("Second Number: ");
            secondnum = float.Parse(Console.ReadLine());

            Console.Write("Enter the operator(' + '  for addition , ' - ' for subtraction, ' * ' for multiplication , ' / ' for division): ");
           
            op = char.Parse(Console.ReadLine());

            while (op != '+' && op != '-' && op != '*' && op != '/')
            {
                Console.WriteLine("Please enter a correct operator: ");
                op = char.Parse(Console.ReadLine());
            }

            switch (op)
            {
                case '+':
                    Console.WriteLine("the addition is: {0}", firstnum + secondnum);
                    break;
                case '-':
                    Console.WriteLine("the subtraction is: {0}", firstnum - secondnum);
                    break;
                case '*':
                    Console.WriteLine("the multiplication is: {0}", firstnum * secondnum);
                    break;
                case '/':
                    Console.WriteLine("the division is: {0}", firstnum / secondnum);
                    break;
            }












        }
    }
}