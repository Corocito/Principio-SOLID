using OpenClose;

//Se cambia la variable de la lista de objetc a Employee, ya que es esta la 
CalculateSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180),
    new EmployeeContractor("Juanito", 200)
});

//Se crea el void que no devolvera nada y se encargara de mostrar la información
//Este recibe una lista la cual es Employee ya que es la que hereda a los demas Employees, se crea con el nombre employees
void CalculateSalaryMonthly(List<Employee> employees) 
{
    //Se crea un ciclo foreach para recorrer todos los elementos de la lista de empleados, se crea con la variable employee
    foreach (var employee in employees)
    {
        //Se elimina la mayoria de la logica para cumplir con el Single Responsability
        //Solo se necesita el WriteLine para mostrar la informacion, y se concatena el CalculateSalaryMonthly para realizar el calculo de cada empleado
        Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly():C1} ");
    }
}