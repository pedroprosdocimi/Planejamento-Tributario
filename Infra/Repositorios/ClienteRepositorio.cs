using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private List<Cliente> ClientesMock;
        public ClienteRepositorio()
        {
            ClientesMock = new List<Cliente>();
        }
        public async Task AtualizarCliente(Cliente cliente)
        {
            var clienteRemover = ClientesMock.FirstOrDefault(c => c.IdCliente == cliente.IdCliente);

            ClientesMock.Remove(clienteRemover);    

            ClientesMock.Add(cliente);
        }

        public async Task CriarCliente(Cliente cliente)
        {
            ClientesMock.Add(cliente);
        }

        public async Task<List<Cliente>> ListarCliente()
        {
            return ClientesMock;
        }

        public async Task<Cliente> ObterCliente(Guid IdCliente)
        {
            return ClientesMock.FirstOrDefault(c => c.IdCliente == IdCliente);
        }
    }
}
