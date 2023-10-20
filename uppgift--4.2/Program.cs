using System;

class Program
{
    static void Main()
    {
        int maxNumber = int.MinValue;

        do
        {
            Console.Write("Skriv in ett heltal: ");
            int number;

            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            else
            {
                Console.WriteLine("Ogiltigt heltal. Försök igen.");
            }

            Console.Write("Vill du skriva in ett till heltal? (j/n): ");
            string input = Console.ReadLine();

            if (!string.Equals(input, "j", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

        } while (true);

        Console.WriteLine($"Det största talet du skrev in var: {maxNumber}");
    }
}
