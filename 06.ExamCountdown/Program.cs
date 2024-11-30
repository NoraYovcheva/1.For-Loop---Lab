namespace _06.ExamCountdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int currentDays = 0;

            for (int i = days; i > 0; i--)
            {
                days = i;
                Console.WriteLine($"{days} days before the exam");
            }
            Console.WriteLine("The exam has come");
        }
    }
}
