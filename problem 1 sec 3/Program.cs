namespace problem_1_sec_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

             Console.Write("whats the value of x? ");
             float x = float.Parse(Console.ReadLine());

            Console.Write("whats the value of y? ");
            float y= float.Parse(Console.ReadLine());

            Console.Write("which operand do you want? (1 for addition) (2 for substraction) (3 for multiplication) (4 for division) ");
            int op=int.Parse(Console.ReadLine());





            while (op <= 0 || op > 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("please enter the correct value for each opearand ");
                op = int.Parse(Console.ReadLine());
            }
                
            

            if (op == 1)
            {
                Console.Write("the value of the sum is: {0}",x+y);
                
            }else if(op == 2)
            {
                Console.Write("the value of the substraction is: {0}",x-y);
            }else if (op == 3)
            {
                Console.Write("the value of the multiplication is: {0}",x*y);
            }else if(op==4)
            {
                Console.Write("the value of the division is: {0}",x/y);
            }






        }
    }
}