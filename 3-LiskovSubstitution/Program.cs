using Liskov;

CalculateSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160, 10),
    new EmployeeContractor("Manuel Lopera", 180),
    new EmployeeFullTime("Juanito", 200,20),
    new EmployeeFullTime("Juana del Arco", 500, 0),
    new EmployeeFullTime("Hermenegildo", 403,80),
    new EmployeeContractor("Pepe Grillo",100)
});

void CalculateSalaryMonthly(List<Employee> employees) 
{
    foreach (var employee in employees)
    {
        Console.WriteLine($"The {employee.Fullname}'s salary is {employee.CalculateSalary()}");
        
    }
}