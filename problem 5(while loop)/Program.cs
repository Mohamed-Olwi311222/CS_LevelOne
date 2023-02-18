namespace problem_5_while_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 4)
            {
                int x = 0;
                while (x <= i)
                {
                    Console.Write("*");
                    x++;
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}