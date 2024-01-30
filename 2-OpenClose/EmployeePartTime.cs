namespace OpenClose
{
    public class EmployeePartTime : Employee
    {
       //Se eliminan las propiedades ya que se heredan de Employee
       
       //Creación del constructor para la definicion y manejo de las propiedades recibidas de la clase padre
        public EmployeePartTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        //Se implementa el metodo abstracto para calcular el salario
        public override decimal CalculateSalaryMonthly()
        {
            decimal valorHora = 20000M;
            decimal salario = valorHora * HoursWorked;

            //Se crea la condicion para los bonos del empleado a medio tiempo
            if(HoursWorked>160){
                decimal compensacion = 5000M;
                int diasExtras = HoursWorked - 160;
                salario += compensacion * diasExtras;
            }
            return salario; 
        }
    }
}