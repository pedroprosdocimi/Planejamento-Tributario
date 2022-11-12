using Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Repositorios
{
    public interface IClienteRepositorio
    {
        Task<Cliente> ObterCliente(Guid IdCliente);
        Task<List<Cliente>> ListarCliente();
        Task CriarCliente(Cliente cliente);
        Task AtualizarCliente(Cliente cliente); 
    }
}
