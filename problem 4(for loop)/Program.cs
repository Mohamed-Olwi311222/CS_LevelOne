namespace problem_4_for_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("the number of subjects: ");
            int number=int.Parse(Console.ReadLine());
            int total = 0;
            for(int i=1; i<=number; i++) {
                Console.Write("the degree of subject {0}: ",i);
                int degree= int.Parse(Console.ReadLine());
                total=total+degree;

            
            }
            Console.Write("the total of your subjects degrees is {0} \n", total);
            double average = (double)total / number;
            Console.Write("your average is {0}", average);
        }
    }
}