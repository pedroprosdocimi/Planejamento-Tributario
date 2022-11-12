using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Planejamento_Tributario.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planejamento_Tributario.Controllers
{
    [ApiController]
    [Route("/clientes")]
    public class ClientesController : ControllerBase
    {     
        private readonly ILogger<ClientesController> _logger;

        public ClientesController(ILogger<ClientesController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("/criar")]
        [ProducesResponseType(typeof(Nullable), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CriarNovoCliente([FromBody] Cliente cliente)
        {
                return Ok(new Cliente());
        }

        [HttpGet]
        [Route("{idCliente}")]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Nullable), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ObterCliente(Guid idCliente)
        {
            return Ok(new Cliente());
        }

        [HttpGet]
        [Route("")]
        [ProducesResponseType(typeof(List<Cliente>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ListarClientes()
        {
            return Ok(new Cliente());
        }

        [HttpPut]
        [ProducesResponseType(typeof(Nullable), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AtualizarCliente([FromBody] Cliente cliente)
        {
            return Ok(new Cliente());
        }
    }
}
