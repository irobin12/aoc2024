// See https://aka.ms/new-console-template for more information

const string day = "Day1";
const string data = "Data";
const string testData = "TestData";

(string, string) GetSolutions(string fileName)
{
    return Day1.Logic.GetSolutions(ParseData(fileName));
}

var solutions = GetSolutions(testData);
Console.WriteLine("The test solution for the 1st part is: ");
Console.WriteLine(solutions.Item1);
Console.WriteLine("The test solution for the 2nd part is: ");
Console.WriteLine(solutions.Item2);

Console.WriteLine("\n");

solutions = GetSolutions(data);
Console.WriteLine("The actual solution for the 1st part is: ");
Console.WriteLine(solutions.Item1);
Console.WriteLine("The actual solution for the 2nd part is: ");
Console.WriteLine(solutions.Item2);

List<string> ParseData(string fileName)
{
    List<string> lines = new();
    StreamReader reader = new StreamReader($"{day}/{fileName}.txt");

    while (reader.Peek() >= 0)
    {
        var line = reader.ReadLine();
        if (line == null) break;
        lines.Add(line);
    }

    return lines;
}