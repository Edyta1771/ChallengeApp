using ChallengeApp;

var employee1 = new Employee("Agata", "Kolicka", "23");
var employee2 = new Employee("Sebastian", "Nowicki", "41");
var employee3 = new Employee("Marek", "Buczek", "35");

employee1.AddScore(7);
employee1.AddScore(3);
employee1.AddScore(8);
employee1.AddScore(2);
employee1.AddScore(5);

employee2.AddScore(9);
employee2.AddScore(9);
employee2.AddScore(5);
employee2.AddScore(10);
employee2.AddScore(7);

employee3.AddScore(8);
employee3.AddScore(4);
employee3.AddScore(7);
employee3.AddScore(6);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.Write("Pracownik z najwyższą ilością punktów: ");
Console.WriteLine(employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname);
Console.WriteLine("Zdobyta ilość punktów: " + maxResult);
