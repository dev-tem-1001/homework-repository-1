namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}+{1}={1}+{0}", a, b);
        }
    }
}
