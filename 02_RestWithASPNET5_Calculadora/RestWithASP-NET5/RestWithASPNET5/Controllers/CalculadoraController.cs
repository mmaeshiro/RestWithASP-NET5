using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestWithASPNET5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {   
        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        [HttpGet("soma/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Soma(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var sum = decimal.Parse(primeiroNumero) + decimal.Parse(segundoNumero);
                return Ok(sum.ToString());
            }

            return BadRequest("valor invalido");
        }

        [HttpGet("subtracao/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Subtracao(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var sum = decimal.Parse(primeiroNumero) - decimal.Parse(segundoNumero);
                return Ok(sum.ToString());
            }

            return BadRequest("valor invalido");
        }

        [HttpGet("divisao/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Divisao(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var sum = decimal.Parse(primeiroNumero) / decimal.Parse(segundoNumero);
                return Ok(sum.ToString());
            }

            return BadRequest("valor invalido");
        }

        [HttpGet("multiplicacao/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Multiplicacao(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var sum = decimal.Parse(primeiroNumero) * decimal.Parse(segundoNumero);
                return Ok(sum.ToString());
            }

            return BadRequest("valor invalido");
        }

        [HttpGet("media/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Media(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var sum = decimal.Parse(primeiroNumero) + decimal.Parse(segundoNumero) / 2;
                return Ok(sum.ToString());
            }

            return BadRequest("valor invalido");
        }

        [HttpGet("raizquadrada/{primeiroNumero}")]
        public IActionResult RaizQuadrada(string primeiroNumero)
        {
            if (IsNumeric(primeiroNumero))
            {
                var sqrt = Math.Sqrt(double.Parse(primeiroNumero));
                return Ok(sqrt.ToString());
            }

            return BadRequest("valor invalido");
        }

        private bool IsNumeric(string strNumero)
        {
            double numero;
            bool isNumebr = double.TryParse(strNumero,System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out numero);
            return isNumebr;
        }
    }
}
