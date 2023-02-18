namespace problem_1_sec7_for_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number which do you want to keep adding to: ");
            int num=int.Parse(Console.ReadLine());
            int sum=0;
            for(int i=0; i<=num; i++)
            {
                sum =i+sum;
            }
            Console.WriteLine("the submission is:{0}", sum);



        }
    }
}