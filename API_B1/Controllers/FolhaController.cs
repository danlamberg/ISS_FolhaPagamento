using Microsoft.AspNetCore.Mvc;

namespace API_B.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class FolhaController : ControllerBase
    {
        private List<Folha> folhas = new List<Folha>()
        {
            new Folha { Id = 1, HorasTrabalhadas = 160, ValorHora = 10 },
            new Folha { Id = 2, HorasTrabalhadas = 180, ValorHora = 12 },
            new Folha { Id = 3, HorasTrabalhadas = 150, ValorHora = 15 },
        };

        [HttpGet("listar")]
        public IActionResult Listar()
        {
            return Ok(folhas);
        }

        [HttpGet("total")]
        public IActionResult Total()
        {
            decimal total = folhas.Sum(f => f.SalarioLiquido);
            return Ok(total);
        }

        
        [HttpGet("media")]
        public IActionResult Media()
        {
            int quantidade = folhas.Count;
            decimal total = folhas.Sum(f => f.SalarioLiquido);
            decimal media = total / quantidade;

            var resultado = new
            {
                Quantidade = quantidade,
                Total = total,
                Media = media
            };

            return Ok(resultado);
        }
    }