using Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Repositorios.Simuladas
{
    public interface ISimuladaRepositorio
    {
        public Task CriarSimuladaPorMes(Simulada simulada);
        public Task<bool> VerificaSeJaExisteSimulada(Guid planejamentoTributario, int mesReferencia, int anoReferencia);
        public Task<Simulada> ObterSimulada(Guid simuladaId);
        public Task<IEnumerable<Simulada>> ListarSimuladaPorAno(int anoReferencia, Guid idCliente);
    }
}
