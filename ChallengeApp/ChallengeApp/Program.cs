using ChallengeApp;

var employee = new Employee("Agnieszka", "Falkowska");
employee.AddGrade("3");
employee.AddGrade("Ola");
employee.AddGrade(16);
employee.AddGrade(17.98);
employee.AddGrade(13867);

var statistics = employee.GetStatistics();

Console.WriteLine($"  Min: {statistics.Min}");
Console.WriteLine($"  Max: {statistics.Max}");
Console.WriteLine($"  Average: {statistics.Average:N2}");

