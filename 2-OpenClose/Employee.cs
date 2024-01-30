using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClose
{
    public abstract class Employee
    {
        public string Fullname {get;set;}
        public int HoursWorked{get;set;}


        //Se crea un metodo para las demas clases que se encargará de realizar el calculo salarial
        public abstract decimal CalculateSalaryMonthly();
    }
}