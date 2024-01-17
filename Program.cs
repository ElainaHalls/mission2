// Elaina Halls 
// Section 1
// Mission 2

using System.Diagnostics.Tracing;

internal class Program
{
    // Main class
    private static void Main(string[] args)
    {
        // Ask the user to enter in the number of rolls they'd like to simulate.
        Console.WriteLine("Welcome to the dice throwing simulator!\nHow many dice rolls would you like to simulate?");
       
        // Convert the number of rolls to an integer.
        int numberOfRolls = Convert.ToInt32(Console.ReadLine());

        // Create an instance of the DiceRoller class and call the RollDice method.
        DiceRoller diceRoller = new DiceRoller();

        // Pass the user's input of number of rolls and create a results array of that length. 
        int[] results = diceRoller.RollDice(numberOfRolls);

        // Call the PrintHistogram method and pass in the parameters "results" and "numberOfRolls"
        PrintHistogram(results, numberOfRolls);
    }

    // PrintHistogram method. Pass the results array and numberOfRolls.
    static void PrintHistogram(int[] results, int numberOfRolls)
    {
        // Output once the dice have been "rolled".
        Console.WriteLine($"DICE ROLLING SIMULATION RESULTS \nEach '*' represents 1% of the total number of rolls. \nTotal number of rolls = {numberOfRolls}");

        // Iterate through the results array.
        for (int iCount = 0; iCount < results.Length; iCount++)
        {
            // Calculate the percentage of the total number of rolls for each number. 
            // "double" is a data type that represents double-precision floating-point numbers.
            double percentage = (double)results[iCount] / numberOfRolls * 100;

            // Round to the nearest whole number
            int asterisksCount = (int)Math.Round(percentage); 

            // Output the number with its corresponding percentage of rolls (display every 1% with an *). 
            Console.WriteLine($"{iCount + 2}: {new string('*', asterisksCount)}");
        }
    }
}