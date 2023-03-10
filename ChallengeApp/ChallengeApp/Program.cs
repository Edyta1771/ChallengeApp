using ChallengeApp;

Console.WriteLine("Welcome to the STAT program for employees assessment");
Console.WriteLine("====================================================");
Console.WriteLine();

var employee = new EmployeeInFile("Agnieszka", "Falkowska");
Console.WriteLine($"Please insert grades for the employee: {employee.Name} {employee.Surname}");
Console.WriteLine();
Console.WriteLine($"The grade should be in the range 0 - 100 or A - E");
Console.WriteLine("Press q to get statistics");
Console.WriteLine();

employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("New grade added");
}

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
    Console.WriteLine();
}

var statistics = employee.GetStatistics();

Console.WriteLine("====================================================");
Console.WriteLine();
Console.WriteLine($"Results for the employee: {employee.Name} {employee.Surname}");
Console.WriteLine($"Number of grades received: {statistics.Count}");
Console.WriteLine($"Min grade: {statistics.Min}");
Console.WriteLine($"Max grade: {statistics.Max}");
Console.WriteLine($"Average in points: {statistics.Average:N2}");
Console.WriteLine($"Average as letter: {statistics.AverageLetter}");






//var supervisor = new Supervisor("Zbyszek", "Lato");

//while (true)
//{
//    Console.Write("Give next grade for supervisor: ");
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }

//    try
//    {
//        supervisor.AddGrade(input);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception cought: {e.Message}");
//    }
//}

//var statisticsSuper = supervisor.GetStatistics();

//Console.WriteLine();
//Console.WriteLine($"Results for supervisor:");
//Console.WriteLine($"Min: {statisticsSuper.Min}");
//Console.WriteLine($"Max: {statisticsSuper.Max}");
//Console.WriteLine($"Average in points: {statisticsSuper.Average:N2}");
//Console.WriteLine($"Average in letter format:  {statisticsSuper.AverageLetter}");
//Console.WriteLine();

