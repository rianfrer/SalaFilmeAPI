namespace SalaFilmeAPI.Entity
{
    public class Sala
    {
        public Sala()
        {
            Cinemas = new List<Cinema>();
        }

        public Sala(string descricao) : this()
        {
            Descricao = descricao;
        }

        public int Id { get; protected set; }
        public string Descricao { get; protected set; }
        public virtual IList<Cinema> Cinemas { get; protected set; } 
    }
}
