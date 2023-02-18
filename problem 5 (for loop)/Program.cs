namespace problem_5__for_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<=4; i++)
            {
                for(int x = 0; x <= i; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}