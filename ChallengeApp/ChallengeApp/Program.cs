using ChallengeApp; 

Employee employee1 = new Employee("Roman", "Szczęśliwy", 39);
Employee employee2 = new Employee("Zbigniew", "Zmęczony", 46);
Employee employee3 = new Employee("Mariola", "Radosna", 68);

employee1.AddScore(8);
employee1.AddScore(7);
employee1.AddScore(6);
employee1.AddScore(5);
employee1.AddScore(4);

employee2.AddScore(10);
employee2.AddScore(12);
employee2.AddScore(3);
employee2.AddScore(3);
employee2.AddScore(22);

employee3.AddScore(2);
employee3.AddScore(2);
employee3.AddScore(2);
employee3.AddScore(2);
employee3.AddScore(4);


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

Console.WriteLine("Pracownik, który osiągnął najwyższą liczbę punktów, czyli " 
    + maxResult + " to:  " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " lat " + employeeWithMaxResult.Age);
