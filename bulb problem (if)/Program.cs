namespace bulb_problem__if_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool close=true;

            if (close=true)
            {
                Console.WriteLine("opening the bulb");
            }else if (close != true)
            {
                Console.WriteLine("bulb is already open");
            }
            else
            {
                Console.WriteLine("bulb is broken , please repair");
            }




        }
    }
}