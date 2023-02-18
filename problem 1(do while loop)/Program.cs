namespace problem_1_do_while_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number which do you want to keep adding to: ");
            int num = int.Parse(Console.ReadLine());


            int sum = 0, i = 0;
            do
            {

                sum = i + sum;
                i++;
            } while (i <= num);
                Console.WriteLine("the submission is:{0}", sum);



        }
    }
}