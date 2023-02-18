namespace Prime_Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number to start counting from: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter the number to stop counting to: ");
            int fnum = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int c = num; c <= fnum; c++)
            {
                for (int i = 1; i <=c; i++)
                {
                    if (c % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    Console.WriteLine(c);
                    counter = 0;
                }
                else
                {
                    counter = 0;
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}