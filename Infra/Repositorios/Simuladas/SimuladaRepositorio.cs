using Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Repositorios.Simuladas
{
    public class SimuladaRepositorio : ISimuladaRepositorio
    {
        public Task CriarSimuladaPorMes(Simulada simulada)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Simulada>> ListarSimuladaPorAno(int anoReferencia, Guid idCliente)
        {
            throw new NotImplementedException();
        }

        public Task<Simulada> ObterSimulada(Guid simuladaId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> VerificaSeJaExisteSimulada(Guid planejamentoTributario, int mesReferencia, int anoReferencia)
        {
            throw new NotImplementedException();
        }
    }
}
