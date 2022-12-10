using Dominio.Clientes.Interfaces;
using Dominio.Simuladas.Interfaces;
using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Planejamento_Tributario.Controllers
{
    [ApiController]
    public class SimuladasController : ControllerBase
    {
        private readonly ILogger<SimuladasController> _logger;
        private ISimuladaDominio _simuladaDominio;

        public SimuladasController(ILogger<SimuladasController> logger, ISimuladaDominio simuladaDominio)
        {
            _logger = logger;
            _simuladaDominio = simuladaDominio;
        }

        [HttpPost]
        [Route("/Simulada/Criar")]
        [ProducesResponseType(typeof(Nullable), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CriarSimulada([FromBody] Simulada simulada)
        {
            try
            {
                await _simuladaDominio.CriarSimulada(simulada);
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
