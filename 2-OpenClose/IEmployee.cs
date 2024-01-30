using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClose
{
    public interface IEmployee
    {
        //Se crea la interfaz solo para demostrar como seria la solución al mismo problema pero implementando las interfaces
        string Fullname{get;set;}
        int HoursWorked{get;set;}
        decimal CalculateSalaryMonthly();
    }
}