namespace problem_1_while_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number which do you want to keep adding to: ");
            int num = int.Parse(Console.ReadLine());


            int sum=0, i = 0;
            while (i <= num)
            {

               sum=i+sum ;
                i++;
            }
            Console.WriteLine("the submission is:{0}", sum);



        }
    }
}