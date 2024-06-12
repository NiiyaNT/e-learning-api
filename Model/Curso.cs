namespace E_learning_API.Model
{
    public class Curso
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Leccion> Lecciones { get; set; }
    }
}
