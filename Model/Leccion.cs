namespace E_learning_API.Model
{
    public class Leccion
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public List<Pregunta> Preguntas { get; set; }
        public int UmbralAprobacion { get; set; }
    }
}
