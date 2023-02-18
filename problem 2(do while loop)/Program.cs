namespace problem_2_do_while_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            do
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
            } while (i <= num);
        }
    }
}