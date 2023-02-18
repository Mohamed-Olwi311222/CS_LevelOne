namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, c, tmp = 0; //tmp is for the counter of the numbers which num is divisible by

            for (num = 2; num <= 100; num++)
            {
                for (c = 1; c <= num; c++)
                {
                    if (num % c == 0)  
                    {
                        tmp++; //increament tmp if num divisible by any numbers from 1 to itself
                    }
                }
                if (tmp == 2) //to check if num divisible by 1 and itself only
                {
                    Console.WriteLine("{0} is prime", num);
                    tmp = 0; //so it can come back to the if statement to check again
                }
                else //if tmp>2 then num is divisible by another number/s beside 1 and itself
                {
                    Console.WriteLine("{0} isnt prime ", num);
                    tmp = 0; //so it can come back to the if statement to check again
                }

            }
        }
    }
}