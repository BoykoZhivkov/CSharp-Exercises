bool[] houses = [true, false, false, false, false, true, false, false];
int[] scores = new int[8];

int days;
Console.Write("How many days will the houses compete? ");
while (!int.TryParse(Console.ReadLine(), out days))
{
    Console.Write("Invalid input. Please enter again: ");
}
Console.WriteLine();    

for (int i = 0; i < days; i++)
{
    // Use a temporary array to ensure all houses update based on the same state
    bool[] nextDay = new bool[8];

    for (int j = 0; j < 8; j++)
    {
        // If house has no neighbors on the left or right, we add imaginary house that is inactive
        bool left = (j == 0) ? false : houses[j - 1];
        bool right = (j == 7) ? false : houses[j + 1];

        // If left and right neighbors have the same status, 
        // the current house is inactive, otherwise the current house is active
        if (left == right)
            nextDay[j] = false;
        else 
            nextDay[j] = true;
        
        // Add points for every active house 
        if (nextDay[j])
            scores[j]++;
    }

    // Update house states for the next day
    houses = nextDay;
}

// Output final scores
Console.WriteLine("Final Scores: ");
for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"House {i + 1}: {scores[i]} points");
}

// Find highest scoring house (outputs the first occured house in case of a tie)
int maxScore = 0;
int winnerIndex = 0;
for (int i = 0; i < 8; i++)
{
    if (scores[i] > maxScore)
    {
        maxScore = scores[i];
        winnerIndex = i;
    }
}

Console.WriteLine($"\nThe winner is house {winnerIndex + 1} with {maxScore} points.");