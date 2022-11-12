using Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Simuladas.Interfaces
{
    public interface ISimuladaDominio
    {
        Task CriarSimulada(Simulada simulada);
        Task<IEnumerable<SimuladaResposta>> ListarSimuladaPorAno(int anoReferencia, Guid idCliente);
    }
}
