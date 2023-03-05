using ChallengeApp;

Console.WriteLine("Welcome to the STAT program for employees assessment");
Console.WriteLine("====================================================");
Console.WriteLine();

var supervisor = new Supervisor("Zbyszek", "Lato");

while (true)
{
    Console.Write("Give next grade for supervisor: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception cought: {e.Message}");
    }
}

var statisticsSuper = supervisor.GetStatistics();

Console.WriteLine();
Console.WriteLine($"Results for supervisor:");
Console.WriteLine($"Min: {statisticsSuper.Min}");
Console.WriteLine($"Max: {statisticsSuper.Max}");
Console.WriteLine($"Average in points: {statisticsSuper.Average:N2}");
Console.WriteLine($"Average in letter format:  {statisticsSuper.AverageLetter}");
Console.WriteLine();

var employee = new Employee("Agnieszka", "Falkowska");

while (true)
{
    Console.Write("Give next grade for employee: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception cought: {e.Message}");
    }
}

var statistics = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine($"Results for employee:");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average in points: {statistics.Average:N2}");
Console.WriteLine($"Average in letter format:  {statistics.AverageLetter}");
