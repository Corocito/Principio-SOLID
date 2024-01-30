using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    //Contiene una referencia directa con otra clase, lo cual crea una dependencia
    //La mejor forma de corregir esto es creando una interfaz la cual solamente le permita acceder a la información necesaria
    //sin tener que hacer referencia a la clase, solamente referencia a la interfaz y a la informacion que esta le permite ver
    StudentRepository studentRepository = new StudentRepository();
    Logbook logbook = new Logbook();

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        logbook.Add($"returning student's list");
        return studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody]Student student)
    {
        studentRepository.Add(student);
        logbook.Add($"The Student {student.Fullname} have been added");
    }
}
