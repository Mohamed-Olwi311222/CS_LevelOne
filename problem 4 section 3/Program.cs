namespace problem_4_section_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 3, b = 4, c = 5, n = 0;

            Console.Write("problem 4.1: ");
            Console.WriteLine(a-- + b* ++c);

            Console.Write("problem 4.2: ");
            Console.WriteLine(a++ + b/--c);

            Console.Write("problem 4.3: ");
            bool f = a+ b* --c>c/a;
            Console.WriteLine(f);

        }
    }
}