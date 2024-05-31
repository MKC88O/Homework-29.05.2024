using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Symbol: ");
        string? symbol = Console.ReadLine();
        Console.WriteLine("Enter quantity steps: ");
        int steps = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < steps; i++)
        {
            Console.WriteLine(new string(' ', i * 2) + symbol + symbol + symbol);


            if (i < steps)
            {

                Console.WriteLine(new string(' ', i * 2) + "  " + symbol);
            }
        }
    }
}



