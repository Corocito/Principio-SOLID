using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability
{
    //Se crea una clase nueva aparte la cual se va a encargar especificamente de la exportacion de los archivos
    //Asi se cumple con el principio de Single Responsability
    public class ExportHelperCSV
    {
        //Se crea el Export y se recibe como parametro la coleccion de Student
        public void ExportStudents(IEnumerable<Student> students){
            //Se crea la lógica para la exportacion de los estudiantes
            string csv = String.Join(",", students.Select(x => x.ToString()).ToArray());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("Id;Fullname;Grades");
            foreach (var item in students)
            {
                sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
            }
            System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);
        }
    }
}