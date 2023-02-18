namespace Prime_or_Odd_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number to start counting from: ");
            int num1=int.Parse(Console.ReadLine());
            
            Console.Write("Enter the number to stop counting to: ");
            int num2 = int.Parse(Console.ReadLine());

            int tmp = 0;
            for(int c=num1; c<=num2; c++) {
               for(int i=1; i<=c; i++)
                {
                    if(c%i==0) { 
                    tmp++;
                    }
                }
                if (tmp == 2)
                {
                    Console.WriteLine(c);
                    tmp= 0;
                }
                else
                {
                    tmp = 0;
                    continue;
                }
            }
            
        }
    }
}