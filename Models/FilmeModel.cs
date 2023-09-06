namespace Cinema.Models
{
    public class FilmeModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Produtora { get; set; }
        public string Descricao { get; set; }
        public DateTime Estreia { get; set; } = DateTime.Now;
    }
}
