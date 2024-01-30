namespace SingleResponsability
{
    //Creación del objeto
    public class Student
    {
        //Definicion de los atributos
        public int Id { get; set; }
        public string Fullname { get; set; }
        public List<double> Grades { get; set; }

        //Creacion del constructor al cual no se puede acceder
        public Student()
        {
            this.Fullname = string.Empty;
            this.Grades = new List<double>();
        }

        //Creacion del constructor al cual se accede a ingresar datos
        public Student(int id, string fullname, List<double> grades)
        {
            this.Id = id;
            this.Fullname = fullname;
            this.Grades = grades;
        }
    }
}