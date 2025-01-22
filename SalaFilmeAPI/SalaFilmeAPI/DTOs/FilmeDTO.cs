using SalaFilmeAPI.Entity;

namespace SalaFilmeAPI.DTOs
{
    public class FilmeDTO
    {
        public string Nome { get; set; }
        public string Diretor { get; set; }
        public string Duracao { get; set; }
        public int Ano { get; set; }

        public static implicit operator Filme(FilmeDTO dto)
            => new Filme(dto.Nome, dto.Diretor, dto.Duracao, dto.Ano);
    }
}
