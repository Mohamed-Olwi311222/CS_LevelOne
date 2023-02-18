namespace problem_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("whats the value of x?") ;

            
            int x = int.Parse(Console.ReadLine());

            
            Console.Write("whats the value of y?");
            
            
            int y = int.Parse(Console.ReadLine());
            

            Console.WriteLine("result={0}",x+y);
        
        }
    }
}