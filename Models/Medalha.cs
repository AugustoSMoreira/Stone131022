namespace Stone131022.Models
{
    public class Medalha
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Jogador Jogador { get; set; }
        public int JogadorID { get; set; }
    }
}
