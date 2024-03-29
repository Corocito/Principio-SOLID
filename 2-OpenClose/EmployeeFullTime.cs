namespace OpenClose
{
    public class EmployeeFullTime : Employee //,IEmployee
    {
        //Se eliminan las variables ya que se heredan de Employee
        /*
        Solo se crea para demostrar como se definen los atributos utilizando el metodo de la interfaz
        public string Fullname {get;set;}
        public int HoursWorked {get;set;}
        */

        //Creación del constructor el cual se encarga de la definicion y manejo de los datos recibidos de la clase padre
        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        //Se crea la implementacion del metodo abstracto
        //Se realiza el calculo del salario del empleado de tiempo completo
        public override decimal CalculateSalaryMonthly()
        {
            decimal valorHora = 30000M;
            decimal salario = valorHora * HoursWorked; //Se utiliza las caracteristicas heredadas de la clase padre HoursWorked             
            return salario;
        }
    }
}