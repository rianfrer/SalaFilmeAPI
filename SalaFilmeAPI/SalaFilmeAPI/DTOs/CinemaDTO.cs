using SalaFilmeAPI.Entity;

namespace SalaFilmeAPI.DTOs
{
    public class CinemaDTO
    {
        public int SalaId { get; set; }
        public int FilmeId { get; set; }
        public bool Status { get; set; }

        public static implicit operator Cinema(CinemaDTO dto)
            => new Cinema(dto.SalaId, dto.FilmeId, dto.Status);
    }
}
