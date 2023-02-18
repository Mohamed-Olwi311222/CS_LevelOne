namespace problem_3_for_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            int num=int.Parse(Console.ReadLine());
            int i=0;
            do
            {

                if (i == 2)
                {
                    i++;
                    continue;

                }
                Console.WriteLine("Printing number {0}", i);
                i++;

            } while (i <= num);
                    
            
        }
    }
}