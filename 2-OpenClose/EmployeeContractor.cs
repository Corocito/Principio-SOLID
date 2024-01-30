using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClose
{
    public class EmployeeContractor : Employee
    {
        //Creacion del constructor para manejar los parametros recibidos de la clase padre
        public EmployeeContractor(string fullname, int hoursWorked){
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        //Se crea la implementacion del metodo abstracto
        public override decimal CalculateSalaryMonthly()
        {

            decimal valorHora = 20000M;
            decimal salario = valorHora * HoursWorked;
            return salario;
        }
    }
}