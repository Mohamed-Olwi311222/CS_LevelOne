namespace coffeproblemv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("putting kanka");
            Console.WriteLine("putting coffe in a cup");
            Console.Write("how many sugar spoons do u want? ");
            int sugar = int.Parse(Console.ReadLine());
            
            if (sugar > 0)
            {
                for (int i = 1; i <= sugar; i++)
                {
                    Console.WriteLine("putting sugar spoon number " + i);
                }
                Console.WriteLine("coffe is ready to serve");
            }else{
                Console.WriteLine("coffe is ready to serve");
            }
 
        }

    }
}