namespace Day1;

public static class Logic
{
    static int entries;
    static int[] leftIds = null!;
    static int[] rightIds = null!;

    public static (string, string) GetSolutions(List<string> input)
    {
        return new ValueTuple<string, string>(GetFirstSolution(input), GetSecondSolution());    
    }
    
    public static string GetFirstSolution(List<string> input)
    {
        entries = input.Count;
        leftIds = new int[entries];
         rightIds = new int[entries];

        for (int i = 0; i < entries; i++)
        {
            var numbers = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
            leftIds[i] = int.Parse(numbers[0]);
            rightIds[i] = int.Parse(numbers[1]);
        }

        Array.Sort(leftIds);
        Array.Sort(rightIds);

        int[] distances = new int[entries];
        for (int i = 0; i < entries; i++)
        {
            distances[i] = Math.Abs(leftIds[i] - rightIds[i]);
        }

        int sum = distances.Sum();
        
        return sum.ToString();
    }

    public static string GetSecondSolution()
    {
        int similarityScore = 0;
        
        foreach (var location in leftIds)
        {
            int duplicatesCount = 0;
            foreach (var id in rightIds)
            {
                if (id == location) duplicatesCount++;
            }

            similarityScore += location * duplicatesCount;
        }
        
        return similarityScore.ToString();
    }
    
}