namespace multiplication_table_for_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table");
            for(int i=1; i<=9; i++) {
                for(int x=1; x<=9; x++) {

                    Console.WriteLine("{0}*{1}={2} ",i,x,i*x);
                
                }    
            
            }
        }
    }
}