using Dominio.Clientes.Interfaces;
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
    [Route("/clientes")]
    public class ClientesController : ControllerBase
    {
        private readonly ILogger<ClientesController> _logger;
        private IClienteDominio _clienteDominio;

        public ClientesController(ILogger<ClientesController> logger, IClienteDominio clienteDominio)
        {
            _logger = logger;
            _clienteDominio = clienteDominio;
        }

        [HttpPost]
        [Route("/criar")]
        [ProducesResponseType(typeof(Nullable), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CriarNovoCliente([FromBody] Cliente cliente)
        {
            try
            {
                await _clienteDominio.CriarCliente(cliente);
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("{idCliente}")]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Nullable), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ObterCliente(Guid idCliente)
        {
            try
            {
                var cliente = await _clienteDominio.ObterCliente(idCliente);

                return Ok(cliente);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("")]
        [ProducesResponseType(typeof(List<Cliente>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ListarClientes()
        {
            try
            {
                var clientes = await _clienteDominio.ListarClientes();

                return Ok(clientes);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        [ProducesResponseType(typeof(Nullable), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AtualizarCliente([FromBody] Cliente cliente)
        {
            try
            {
                await _clienteDominio.AtualizarCliente(cliente);

                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
