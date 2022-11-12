using System;

namespace Entidades
{
    public class Simulada
    {      
        public Guid IdCliente { get; set; }
        public Guid IdPlanejamentoTributario { get; set; }
        public int MesReferencia { get; set; }
        public int AnoReferencia { get; set; }

        //RECEITAS OPERACIONAIS
        public double ServicosPrestados { get; set; }
        public double DescontosIncondicionais { get; set; }
        public double VendasCanceladas { get; set; }
        public double CustoOperacional { get; set; }
        public double DespesasPrestacaoServico { get; set; }
        public double DespesasAdministrativas { get; set; }
        public double DespesasTributarias { get; set; }
        public double DespesasFinanceiras { get; set; }
        public double ReceitasFinanceiras { get; set; }

        //RECEITAS NAO OPERACIONAIS
        public double GanhosCapitalVendaAtivoPermanente { get; set; }
        public double ReceitasNaoOperacionais { get; set; }
        public double ProvisaoIRPJ { get; set; }
        public double ProvisaoContribuicaoSocial { get; set; }
    }
}
