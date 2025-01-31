namespace SalaFilmeAPI.Entity
{
    public class Sala
    {
        public Sala()
        {
        }

        public Sala(string descricao) : this()
        {
            Descricao = descricao;
        }

        public int Id { get; protected set; }
        public string Descricao { get; protected set; }
    }
}
