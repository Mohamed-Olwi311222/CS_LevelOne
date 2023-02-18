namespace problem_2_for_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number: ");
            int num=int.Parse(Console.ReadLine());
            for(int i=0; i<=num; i++) {
                if (i% 2 == 0)
                {
                    Console.WriteLine("{0} is even", i);
                }
                else
                {
                    Console.WriteLine("{0} is odd", i);
                }
}
        }
    }
}