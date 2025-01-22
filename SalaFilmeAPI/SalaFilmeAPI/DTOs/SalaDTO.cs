using SalaFilmeAPI.Entity;

namespace SalaFilmeAPI.DTOs
{
    public class SalaDTO
    {
        public string Descricao { get; set; }

        public static implicit operator Sala(SalaDTO dto)  // Conversão implícita de SalaDTO para Sala
            => new Sala(dto.Descricao);
    }
}