namespace Cinema.Models
{
    public class FilmeModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Titulo")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Digite a Produtora")]
        public string Produtora { get; set; }
        [Required(ErrorMessage = "Digite o Descricao")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Digite a Estreia")]
        public DateTime Estreia { get; set; } = DateTime.Now;
    }
}
