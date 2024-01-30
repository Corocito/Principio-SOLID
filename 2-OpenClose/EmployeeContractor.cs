using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClose
{
    public class EmployeeContractor : Employee //,IEmployee para heredar de la Interfaz Employee
    {
        /*
        Solo se crea para demostrar como se definen los atributos utilizando el metodo de la interfaz
        public string Fullname {get;set;}
        public int HoursWorked {get;set;}
        */


        //Creacion del constructor para manejar los parametros recibidos de la clase padre
        public EmployeeContractor(string fullname, int hoursWorked){
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        //Se crea la implementación del método abstracto
        public override decimal CalculateSalaryMonthly()
        {

            decimal valorHora = 20000M;
            decimal salario = valorHora * HoursWorked;
            return salario;
        }
    }
}