using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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