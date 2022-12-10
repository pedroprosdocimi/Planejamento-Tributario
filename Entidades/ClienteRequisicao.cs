using System;

namespace Entidades
{
    public class ClienteRequisicao
    {
        public string NomeCliente { get; set; }
        public string DocumentoCliente { get; set; }
              

        public Cliente ParaEntidade() => new Cliente(NomeCliente, DocumentoCliente);
    }
}
