using Microsoft.AspNetCore.Mvc;
using SalaFilmeAPI.DTOs;
using SalaFilmeAPI.Entity;
using SalaFilmeAPI.Infra;

namespace SalaFilmeAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CinemaController(AppDbContext context)
        {
            _context = context;
        }

        // POST: Sala
        [HttpPost]
        [Route("sala")]
        [ProducesResponseType(200), ProducesResponseType(400), ProducesResponseType(500)]
        public async Task<IActionResult> InserirSala([FromBody] SalaDTO request)
        {
            try
            {
                var sala = (Sala)request;
                _context.Salas.Add(sala);
                await _context.SaveChangesAsync();
                return Ok(sala);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao criar sala: {ex.Message}");
            }
        }

        // GET: Salas
        [HttpGet]
        [Route("sala")]
        [ProducesResponseType(200), ProducesResponseType(500)]
        public IActionResult ListarSalas()
        {
            try
            {
                var salas = _context.Salas.ToList();
                return Ok(salas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao buscar salas: {ex.Message}");
            }
        }

        // POST: Filme
        [HttpPost]
        [Route("filme")]
        [ProducesResponseType(200), ProducesResponseType(400), ProducesResponseType(500)]
        public async Task<IActionResult> InserirFilme([FromBody] FilmeDTO request)
        {
            try
            {
                var filme = (Filme)request;
                _context.Filmes.Add(filme);
                await _context.SaveChangesAsync();
                return Ok(filme);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao criar filme: {ex.Message}");
            }
        }

        // GET: Filmes
        [HttpGet]
        [Route("filme")]
        [ProducesResponseType(200), ProducesResponseType(500)]
        public IActionResult ListarFilmes()
        {
            try
            {
                var filmes = _context.Filmes.ToList();
                return Ok(filmes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao buscar filmes: {ex.Message}");
            }
        }
    }
}
