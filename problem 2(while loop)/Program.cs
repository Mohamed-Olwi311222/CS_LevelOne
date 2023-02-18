namespace problem_2_while_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number: ");
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            while(i <= num) 
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} is even", i);
                    
                }
                else
                {
                    Console.WriteLine("{0} is odd", i);
                }
                i++;
            }
        }
    }
}