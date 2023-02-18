 namespace bitwise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b ,result ;
            a = 48;
            b = 21;
            
            Console.Write("a's complement: ");
            Console.WriteLine(~a);
            
            Console.Write("b's complement: ");
            Console.WriteLine(~b);
            
            Console.Write("a and b: ");
            Console.WriteLine(a&b);
            
            result=a | b ;
            Console.WriteLine("result OR="+result);
            
            result = a ^ b;
            Console.WriteLine("result XOR:"+result);

            result = a << 2;
            Console.WriteLine("left shift of a:" + result);

            result = a >> 3;
            Console.WriteLine("right shift of a:" + result);

            
            result = b << 2;
            Console.WriteLine("left shift of b:" + result);

            result = b >> 3;
            Console.WriteLine("right shift of b:" + result);


        }
    }
}