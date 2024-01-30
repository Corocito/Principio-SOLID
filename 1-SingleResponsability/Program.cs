using SingleResponsability;

//Se cambia la estructura

//Se crea un objeto de StudentRepository para acceder a sus metodos igual que ExportHelperCSV
StudentRepository studentRepository = new();
ExportHelperCSV exportarEstudiante = new();

//Se accede al metodo de ExportStudents y se le pasa el parametro GetAll de studentsRepository para darle la lista de estudiantes y los convierta a CSV
exportarEstudiante.ExportStudents(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");