using Dominio.PlanejamentosTributarios.Interfaces;
using Entidades;
using Infra.Repositorios.PlanejamentosTributarios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.PlanejamentosTributarios
{
    public class PlanejamentoTributarioDominio : IPlanejamentoTributarioDominio
    {
        private IPlanejamentoTributarioRepositorio _planejamentoTributarioRepositorio;

        public PlanejamentoTributarioDominio(IPlanejamentoTributarioRepositorio planejamentoTributarioRepositorio)
        {
            this._planejamentoTributarioRepositorio = planejamentoTributarioRepositorio;
        }

        public async Task AtualizarPlanejamentoTributario(PlanejamentoTributario planejamentoTributario)
        {
            await _planejamentoTributarioRepositorio.AtualizarPlanejamentoTributario(planejamentoTributario);
        }

        public async Task CriarPlanejamentoTributario(PlanejamentoTributario planejamentoTributario)
        {
            await _planejamentoTributarioRepositorio.CriarPlanejamentoTributario(planejamentoTributario);
        }

        public async Task<List<PlanejamentoTributario>> ListarPlanejamentosTributariosPorCliente(Guid idCliente)
        {
            return await _planejamentoTributarioRepositorio.ListarPlanejamentosTributariosPorCliente(idCliente);
        }

        public async Task<PlanejamentoTributario> ObterPlanejamentoTributario(Guid idPlanejamentoTributario)
        {
            return await _planejamentoTributarioRepositorio.ObterPlanejamentoTributario(idPlanejamentoTributario);
        }
    }
}
