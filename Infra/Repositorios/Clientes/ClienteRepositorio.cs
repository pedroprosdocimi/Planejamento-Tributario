using Entidades;
using System;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace Infra.Repositorios.Clientes
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private List<Cliente> ClientesMock;
        private SqlConnection Connection; 
        public ClienteRepositorio()
        {
            Connection = new SqlConnection("Server=localhost;Database=master;Trusted_Connection=True;");
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
            var parametros = new DynamicParameters();

            parametros.Add("@id_cliente", cliente.IdCliente, DbType.Guid);
            parametros.Add("@nome_cliente", cliente.NomeCliente, DbType.String);
            parametros.Add("@documento_cliente", cliente.DocumentoCliente, DbType.String);

            await Connection.ExecuteAsync(TabelasSql.InserirCliente, parametros);

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
