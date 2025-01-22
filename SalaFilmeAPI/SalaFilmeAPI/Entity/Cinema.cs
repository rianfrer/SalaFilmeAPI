namespace SalaFilmeAPI.Entity
{
    public class Cinema
    {
        public Cinema() { }

        public Cinema(int salaId, int filmeId, bool status)
        {
            SalaId = salaId;
            FilmeId = filmeId;
            Status = status;
        }

        public int Id { get; protected set; }
        public int SalaId { get; protected set; }
        public int FilmeId { get; protected set; }
        public bool Status { get; protected set; }

        public virtual Sala Sala { get; protected set; }
        public virtual Filme Filme { get; protected set; }
    }
}
