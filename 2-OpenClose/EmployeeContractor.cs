using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClose
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullname, int hoursWorked){
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        //Se crea la implementacion del metodo abstracto
        public override decimal CalculateSalaryMonthly()
        {
            throw new NotImplementedException();
        }
    }
}