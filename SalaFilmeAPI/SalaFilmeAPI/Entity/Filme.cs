namespace SalaFilmeAPI.Entity
{
    public class Filme
    {
        public Filme()
        {
            Cinemas = new List<Cinema>();
        }

        public Filme(string nome, string diretor, string duracao, int ano) : this()
        {
            Nome = nome;
            Diretor = diretor;
            Duracao = duracao;
            Ano = ano;
        }

        public int Id { get; protected set; }
        public string Nome { get; protected set; }
        public string Diretor { get; protected set; }
        public string Duracao { get; protected set; }
        public int Ano { get; protected set; }
        public virtual IList<Cinema> Cinemas { get; protected set; }
    }
}
