using ChallengeApp;

var employee = new Employee("Agnieszka", "Falkowska");
employee.AddGrade("3");
employee.AddGrade("Ola");
employee.AddGrade(16);
employee.AddGrade(17.98);
employee.AddGrade(13867);

var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

//Console.WriteLine($"  Min: {statistics.Min}");
//Console.WriteLine($"  Max: {statistics.Max}");
//Console.WriteLine($"  Average: {statistics.Average:N2}");

Console.WriteLine($"  Wyniki z pętli ForEach:");
Console.WriteLine($"  Min: {statistics1.Min}");
Console.WriteLine($"  Max: {statistics1.Max}");
Console.WriteLine($"  Average: {statistics1.Average:N2}");
Console.WriteLine();

Console.WriteLine($"  Wyniki z pętli For:");
Console.WriteLine($"  Min: {statistics2.Min}");
Console.WriteLine($"  Max: {statistics2.Max}");
Console.WriteLine($"  Average: {statistics2.Average:N2}");
Console.WriteLine();

Console.WriteLine($"  Wyniki z pętli DoWhile:");
Console.WriteLine($"  Min: {statistics3.Min}");
Console.WriteLine($"  Max: {statistics3.Max}");
Console.WriteLine($"  Average: {statistics3.Average:N2}");
Console.WriteLine();

Console.WriteLine($"  Wyniki z pętli While:");
Console.WriteLine($"  Min: {statistics4.Min}");
Console.WriteLine($"  Max: {statistics4.Max}");
Console.WriteLine($"  Average: {statistics4.Average:N2}");
Console.WriteLine();
