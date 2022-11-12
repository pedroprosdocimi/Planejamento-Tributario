using Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.PlanejamentosTributarios.Interfaces
{
    public interface IPlanejamentoTributarioDominio
    {
        Task<PlanejamentoTributario> ObterPlanejamentoTributario(Guid idPlanejamentoTributario);
        Task<List<PlanejamentoTributario>> ListarPlanejamentosTributariosPorCliente(Guid idCliente);
        Task CriarPlanejamentoTributario(PlanejamentoTributario planejamentoTributario);
        Task AtualizarPlanejamentoTributario(PlanejamentoTributario planejamentoTributario);
    }
}
