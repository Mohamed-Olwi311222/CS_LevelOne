namespace problem_5_do_while_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do{
                
                int x = 0;
                
                do{
                   Console.Write("*");
                    x++;
                } while (x <= i);
                Console.WriteLine();
                i++;
            } while (i <= 4);
        }
    }
}