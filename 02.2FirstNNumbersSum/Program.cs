namespace _02._2FirstNNumbersSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            sum += 1;
            Console.Write(1);

            for (int i = 2; i <= number; i++)
            {
                sum += i;
                Console.Write($"+{i}");
            }
          
            Console.WriteLine($"={sum}");
        }
    }
}
