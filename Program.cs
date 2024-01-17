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

// DiceRoller class
public class DiceRoller
{
    // DiceRoller class has a method "RollDice" where numberOfRolls is passed in as a parameter. 
    public int[] RollDice(int numberOfRolls)
    {
        // "Random" creating an instance of the "Random" class and naming it "random" (an instance of the class).
        Random random = new Random();

        // Store the frequency of each possible sum that can result from rolling two six-sided die.
        int[] results = new int[11];

        // Roll the dice for the numberOfRolls that the user inputted. 
        for (int iCount = 0; iCount < numberOfRolls; iCount++)
        {
            // A number between 1 and 6 can be chosen for each die that is rolled. 
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);

            // Sum the results of the two dice.
            int sum = die1 + die2;

            // Subtract the results of the die by 2 to correctly match the result to the indexing of the array.
            results[sum - 2]++;
        }

        // Return the results. 
        return results;
    }
}