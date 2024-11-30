namespace _01.NumbersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for ( ; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
