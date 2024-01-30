namespace Liskov
{
    public class EmployeeContractor : Employee
    {

        //Definicion del constructor    
        public EmployeeContractor(string fullname, int hoursWorked) : base(fullname, hoursWorked){
        }

        public override decimal CalculateSalary()
        {
            decimal valorHora = 40M;
            return valorHora * HoursWorked;
        }
    }
} 