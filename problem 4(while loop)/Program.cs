namespace problem_4_while_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("the number of subjects: ");
            int number = int.Parse(Console.ReadLine());
            int total = 0;
            int i = 1;
            while(i<=number){
                Console.Write("the degree of subject {0}: ", i);
                int degree = int.Parse(Console.ReadLine());
                total = total + degree;
                i++;

            }
            Console.Write("the total of your subjects degrees is {0} \n", total);
            double average = (double)total / number;
            Console.Write("your average is {0}", average);
        }
    }
}