using System.Diagnostics.Tracing;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!\nHow many dice rolls would you like to simulate?");
        int numberOfRolls = Convert.ToInt32(Console.ReadLine());

        DiceRoller diceRoller = new DiceRoller();
        int[] results = diceRoller.RollDice(numberOfRolls);

        PrintHistogram(results, numberOfRolls);
    }

    static void PrintHistogram(int[] results, int numberOfRolls)
    {
        Console.WriteLine($"DICE ROLLING SIMULATION RESULTS \nEach '*' represents 1% of the total number of rolls. \nTotal number of rolls = {numberOfRolls}");

        for (int iCount = 0; iCount < results.Length; iCount++)
        {
            double percentage = (double)results[iCount] / numberOfRolls * 100;
            int asterisksCount = (int)Math.Round(percentage); // Round to the nearest whole number

            Console.WriteLine($"{iCount + 2}: {new string('*', asterisksCount)}");
        }
    }
}

public class DiceRoller
{
    public int[] RollDice(int numberOfRolls)
    {
        // "Random" creating an instance of the "Random" class and naming it "random" (an instance of the class)
        Random random = new Random();
        int[] results = new int[11];

        for (int iCount = 0; iCount < numberOfRolls; iCount++)
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);

            int sum = die1 + die2;

            results[sum - 2]++;
        }

        return results;
    }
}