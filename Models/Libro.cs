namespace APINUMERO1.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int FechadePublicacion { get; set; }
        public int AutorId { get; set; }
        public string Autor { get; set; }
    }
}
