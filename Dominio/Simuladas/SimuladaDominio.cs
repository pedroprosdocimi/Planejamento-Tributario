using Dominio.Simuladas.Interfaces;
using Entidades;
using Infra.Repositorios.Simuladas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Simuladas
{
    public class SimuladaDominio : ISimuladaDominio
    {
        private ISimuladaRepositorio _simuladaRepositorio;

        public SimuladaDominio(ISimuladaRepositorio simuladaRepositorio)
        {
            _simuladaRepositorio = simuladaRepositorio;
        }

        public async Task CriarSimulada(Simulada simulada)
        {
            ValidaRequisicao(simulada);

            if(!await _simuladaRepositorio.VerificaSeJaExisteSimulada(simulada.IdPlanejamentoTributario, simulada.MesReferencia, simulada.AnoReferencia))
            {
                await _simuladaRepositorio.CriarSimuladaPorMes(simulada);
            }
            else
            {
                throw new Exception("Ja existe uma simulada para o planejamento tributario, mes e ano informados");
            }
        }

        public async Task<IEnumerable<SimuladaResposta>> ListarSimuladaPorAno(int anoReferencia, Guid idCliente)
        {
            var listaSimuladasAno = await _simuladaRepositorio.ListarSimuladaPorAno(anoReferencia, idCliente);

            return listaSimuladasAno.Select(sa => CalcularFormulas(sa));
        }

        private SimuladaResposta CalcularFormulas(Simulada simulada)
        {
            var receitaOperacionalLiquida = CalcularReceitaOperacionalLiquida(simulada.DescontosIncondicionais, simulada.VendasCanceladas);
            var lucroBruto = CalcularLucroBruto(receitaOperacionalLiquida, simulada.CustoOperacional);
            var resultadoOperacional = CalcularResultadoOperacional(lucroBruto, simulada.DespesasPrestacaoServico, simulada.DespesasAdministrativas, simulada.DespesasTributarias, 
                simulada.DespesasFinanceiras, simulada.ReceitasFinanceiras);
            var resultadoAntesImpostoEParticipacoes = CalcularResultadoAntesImpostoEParticipacoes(resultadoOperacional, simulada.GanhosCapitalVendaAtivoPermanente, simulada.ReceitasNaoOperacionais);
            var lucroPrejuizo = CalcularLucroPrejuizo(resultadoAntesImpostoEParticipacoes, simulada.ProvisaoContribuicaoSocial, simulada.ProvisaoIRPJ);

            return new SimuladaResposta()
            {
                ReceitaOperacionalLiquida = receitaOperacionalLiquida,
                LucroBruto = lucroBruto,
                ResultadoOperacional = resultadoOperacional,
                ResultadoAntesImpostoEParticipacoes = resultadoAntesImpostoEParticipacoes,
                LucroPrejuizo = lucroPrejuizo,
                AnoReferencia = simulada.AnoReferencia,
                DespesasAdministrativas = simulada.DespesasAdministrativas,
                GanhosCapitalVendaAtivoPermanente = simulada.GanhosCapitalVendaAtivoPermanente,
                CustoOperacional = simulada.CustoOperacional,
                DescontosIncondicionais = simulada.DescontosIncondicionais,
                DespesasFinanceiras = simulada.DespesasFinanceiras,
                DespesasPrestacaoServico = simulada.DespesasPrestacaoServico,
                DespesasTributarias = simulada.DespesasTributarias,
                MesReferencia = simulada.MesReferencia,
                ProvisaoContribuicaoSocial = simulada.ProvisaoContribuicaoSocial,
                ProvisaoIRPJ = simulada.ProvisaoIRPJ,
                ReceitasFinanceiras = simulada.ReceitasFinanceiras,
                ReceitasNaoOperacionais = simulada.ReceitasNaoOperacionais,
                ServicosPrestados = simulada.ServicosPrestados,
                VendasCanceladas = simulada.VendasCanceladas
            };
        }

        private double CalcularLucroPrejuizo(double resultadoAntesImpostoEParticipacoes, double provisaoContribuicaoSocial, double provisaoIRPJ)
        {
            return resultadoAntesImpostoEParticipacoes + provisaoIRPJ + provisaoContribuicaoSocial;
        }

        private double CalcularResultadoAntesImpostoEParticipacoes(double resultadoOperacional, double ganhosCapitalVendaAtivoPermanente, double receitasNaoOperacionais)
        {
            return resultadoOperacional + ganhosCapitalVendaAtivoPermanente + receitasNaoOperacionais;
        }

        private double CalcularResultadoOperacional(double lucroBruto, double despesasPrestacaoServico, double despesasAdministrativas, double despesasTributarias, 
            double despesasFinanceiras, double receitasFinanceiras)
        {
            return lucroBruto + despesasPrestacaoServico + despesasAdministrativas + despesasTributarias + despesasFinanceiras + receitasFinanceiras;
        }

        private double CalcularLucroBruto(double receitaOperacionalLiquida, double custoOperacional)
        {
            return receitaOperacionalLiquida + custoOperacional;
        }

        private double CalcularReceitaOperacionalLiquida(double descontosIncondicionais, double vendasCanceladas)
        {
            return descontosIncondicionais + vendasCanceladas;
        }

        private void ValidaRequisicao(Simulada simulada)
        {
            //validar com enerson os campos que nao podem ser nulos na simulada
        }
    }
}
