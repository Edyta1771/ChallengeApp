using ChallengeApp;

Console.WriteLine("Witamy w programie STAT do oceny pracowników");
Console.WriteLine("============================================");
Console.WriteLine();

var employee = new Employee("Agnieszka", "Falkowska");

while (true) 
{
    Console.Write("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Average as letter:  {statistics.AverageLetter}");
