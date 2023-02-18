using System.Net.NetworkInformation;

namespace balance_problem_if_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            float balance, duration, price;
            Console.Write("Please enter your balance: ");
            balance =float.Parse(Console.ReadLine());
            
            
            Console.Write("Please enter your call duration: ");
            duration = float.Parse(Console.ReadLine());


            Console.Write("Please enter the price of the minute: ");
            price = float.Parse(Console.ReadLine());


            float requiredbalance=duration*price;

            Console.Write("Is the user a spam? (true for yes and false for no) ");
            bool spam=bool.Parse(Console.ReadLine());

            if (requiredbalance <= balance && spam == false)
            {
                Console.WriteLine("Call will proceed");
            }
            else if(spam==true)
            {
                Console.WriteLine("User isnt allowed to call");
            }
            else if(requiredbalance > balance)
            {
                    Console.WriteLine("Insufficient balance,please recharge");
            }



            
        }
    }
}