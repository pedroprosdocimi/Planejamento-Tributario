using Dominio.PlanejamentosTributarios.Interfaces;
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
    [Route("/planejamento-tributario")]
    public class PlanejamentoTributarioController : ControllerBase
    {
        private readonly ILogger<PlanejamentoTributarioController> _logger;
        private IPlanejamentoTributarioDominio _planejamentoTributarioDominio;

        public PlanejamentoTributarioController(ILogger<PlanejamentoTributarioController> logger, IPlanejamentoTributarioDominio planejamentoTributarioDominio)
        {
            _logger = logger;
            _planejamentoTributarioDominio = planejamentoTributarioDominio;
        }

        [HttpPost]
        [Route("/criar")]
        [ProducesResponseType(typeof(Nullable), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CriarNovoPlanejamentoTributario([FromBody] PlanejamentoTributario planejamentoTributario)
        {
            try
            {
                await _planejamentoTributarioDominio.CriarPlanejamentoTributario(planejamentoTributario);
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("{idPlanejamentoTributario}")]
        [ProducesResponseType(typeof(PlanejamentoTributario), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Nullable), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ObterPlanejamentoTributario(Guid idPlanejamentoTributario)
        {
            try
            {
                var PlanejamentoTributario = await _planejamentoTributarioDominio.ObterPlanejamentoTributario(idPlanejamentoTributario);

                return Ok(PlanejamentoTributario);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("")]
        [ProducesResponseType(typeof(List<PlanejamentoTributario>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ListarPlanejamentoTributario(Guid idCliente)
        {
            try
            {
                var listaPlanejamentoTributario = await _planejamentoTributarioDominio.ListarPlanejamentosTributariosPorCliente(idCliente);

                return Ok(listaPlanejamentoTributario);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        [ProducesResponseType(typeof(Nullable), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AtualizarPlanejamentoTributario([FromBody] PlanejamentoTributario planejamentoTributario)
        {
            try
            {
                await _planejamentoTributarioDominio.AtualizarPlanejamentoTributario(planejamentoTributario);

                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
