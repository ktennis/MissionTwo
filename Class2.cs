using System;

//get random num for both dice
public class DiceRoll
{
    public static int[] SimulateDiceRolls(int numRolls)
    {
        Random rnd = new Random();
        int[] results = new int[13];
        for (int i = 0; i < numRolls; i++)
        {
            // Simulate rolling two dice
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int sum = dice1 + dice2;

            // Increment the corresponding result in the array
            results[sum]++;
        }

        return results;
    }

}
