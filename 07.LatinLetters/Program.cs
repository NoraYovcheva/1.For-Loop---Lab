namespace _07.LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char leterOne = char.Parse(Console.ReadLine());
            char leterTwo = char.Parse(Console.ReadLine());

            for (char i = leterOne; i <= leterTwo; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
