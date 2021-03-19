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
        public IActionResult Get(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var sum = decimal.Parse(primeiroNumero) + decimal.Parse(segundoNumero);
                return Ok(sum.ToString());
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
