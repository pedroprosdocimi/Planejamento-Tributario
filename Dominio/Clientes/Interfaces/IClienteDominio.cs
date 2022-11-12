using Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Clientes.Interfaces
{
    public interface IClienteDominio
    {
        Task<Cliente> ObterCliente(Guid idCliente);
        Task<List<Cliente>> ListarClientes();
        Task CriarCliente(Cliente cliente);
        Task AtualizarCliente(Cliente cliente);
    }
}
