namespace E_learning_API.Model
{
    public class Pregunta
    {
        public int Id { get; set; }
        public string Enunciado { get; set; }
        public TipoPregunta Tipo { get; set; }
        public List<Opcion> Opciones { get; set; }
        public int Puntuacion { get; set; }
        public int LeccionId { get; set; }
        public Leccion Leccion { get; set; }
    }

    public enum TipoPregunta
    {
        Booleana,
        OpcionUnica,
        OpcionMultipleUnaCorrecta,
        OpcionMultipleTodasCorrectas
    }

    public class Opcion
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public bool EsCorrecta { get; set; }
    }
}
