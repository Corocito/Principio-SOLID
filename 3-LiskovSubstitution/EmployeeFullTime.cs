namespace Liskov
{
    public class EmployeeFullTime : Employee
    {
        public int ExtraHours{get;set;}

        //Definicion del constructor
        public EmployeeFullTime(string fullname, int hoursWorked, int extrahours) : base(  fullname,  hoursWorked){
            //Solo es necesaria realizar la inicialización de la variable de horas extra para este empleado
            ExtraHours=extrahours;
        }

        //Formula para calcular el salario
        public override decimal CalculateSalary()
        {
            decimal valorHora = 50M;
            return valorHora * (HoursWorked + ExtraHours);
        }

    }
}