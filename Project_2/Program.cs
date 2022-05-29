namespace Sollution_1.Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for show multiplication table:");
            var userInput = Console.ReadLine();
            var a = 0;
            if (int.TryParse(userInput, out a))
            {
                for (var i = 1; i < 11; i++)
                {
                    Console.WriteLine(Table(a, i));
                }
            }
            else
            {
                Console.WriteLine($"wrong value");
            }
        }
        static string Table(int number, int i)
        {
            return ($"{number}*{i}={number * i}");
        }
    }
}