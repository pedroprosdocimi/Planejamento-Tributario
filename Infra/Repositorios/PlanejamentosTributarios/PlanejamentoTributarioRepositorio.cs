using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Repositorios.PlanejamentosTributarios
{
    public class PlanejamentoTributarioRepositorio : IPlanejamentoTributarioRepositorio
    {
        private List<PlanejamentoTributario> PlanejamentosTributariosMock;
        public PlanejamentoTributarioRepositorio()
        {
            PlanejamentosTributariosMock = new List<PlanejamentoTributario>();
        }

        public async Task AtualizarPlanejamentoTributario(PlanejamentoTributario planejamentoTributario)
        {
            var planejamentoFinanceiroRemover = PlanejamentosTributariosMock.FirstOrDefault(pt => pt.IdCliente == planejamentoTributario.IdCliente && pt.IdPlanejamentoTributario == planejamentoTributario.IdPlanejamentoTributario);

            PlanejamentosTributariosMock.Remove(planejamentoFinanceiroRemover);

            PlanejamentosTributariosMock.Add(planejamentoTributario);
        }

        public async Task CriarPlanejamentoTributario(PlanejamentoTributario planejamentoTributario)
        {
            PlanejamentosTributariosMock.Add(planejamentoTributario);
        }

        public async Task<List<PlanejamentoTributario>> ListarPlanejamentosTributariosPorCliente(Guid idCliente)
        {
            return PlanejamentosTributariosMock;
        }

        public async Task<PlanejamentoTributario> ObterPlanejamentoTributario(Guid idPlanejamentoTributario)
        {
            return PlanejamentosTributariosMock.FirstOrDefault(pt => pt.IdCliente == idPlanejamentoTributario);
        }
    }
}
