using Dominio.Clientes.Interfaces;
using Entidades;
using Infra.Repositorios.Clientes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Clientes
{
    public class ClienteDominio : IClienteDominio
    {
        private IClienteRepositorio _clienteRepositorio;

        public ClienteDominio(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public async Task AtualizarCliente(Cliente cliente)
        {
            await _clienteRepositorio.AtualizarCliente(cliente);
        }

        public async Task CriarCliente(Cliente cliente)
        {
            await _clienteRepositorio.CriarCliente(cliente);
        }

        public async Task<List<Cliente>> ListarClientes()
        {
            return await _clienteRepositorio.ListarCliente();
        }

        public async Task<Cliente> ObterCliente(Guid idCliente)
        {
            return await _clienteRepositorio.ObterCliente(idCliente);   
        }
    }
}
