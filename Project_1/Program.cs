namespace Sollution_1.Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select number of the day:");
            var selectedDay = Console.ReadLine();
            int a = 0;
            if (int.TryParse(selectedDay, out a))
            {
                Console.WriteLine(IsDay(a));
            }
            else
            {
                Console.WriteLine($"wrong value");
            }

        }

        static string IsDay(int number)
        {
            switch (number)
            {
                case 1:
                    return ($"The day is Monday");

                case 2:
                    return ($"The day is Tuesday");

                case 3:
                    return ($"The day is Wednesday");

                case 4:
                    return ($"The day is Thursday");

                case 5:
                    return ($"The day is Friday");

                case 6:
                    return ($"The day is Saturday");

                case 7:
                    return ($"The day is Sunday");

                default:
                    return ("Wrong value");

            }
        }

    }
}