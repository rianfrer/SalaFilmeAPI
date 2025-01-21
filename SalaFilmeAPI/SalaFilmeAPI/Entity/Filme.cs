namespace SalaFilmeAPI.Entity
{
    public class Filme
    {
        public Filme()
        {
        }

        public Filme(string nome, string diretor, string duracao)
        {
            this.Nome = nome;
            this.Diretor = diretor;
            this.Duracao = duracao;
        }
         
        public int Id { get; protected set; }
        public string Nome { get; protected set; }
        public string Diretor { get; protected set; }
        public string Duracao { get; protected set; }
    }
}