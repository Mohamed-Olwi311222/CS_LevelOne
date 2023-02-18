using System.ComponentModel.DataAnnotations;

namespace telephone_company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter your balance:");
            float balance=float.Parse(Console.ReadLine());

            Console.Write("Please enter your call duration:");
            float duration=float.Parse(Console.ReadLine());

            float requiredbalance =(duration* 0.14f);

            if (requiredbalance <= balance)
            {
                Console.WriteLine("Call will proceed");
            }
            else 
            {
                Console.WriteLine("insuffiecient balance,please recharge");
            }
        }
    }
}