using System;

namespace Entidades
{
    public class Cliente
    {        
        public Guid IdCliente { get; set; }    
        public string NomeCliente { get; set; }
        public string DocumentoCliente { get; set; }    

        public Cliente()
        {
            IdCliente = Guid.NewGuid();
        }

        public Cliente(Guid idCliente)
        {
            IdCliente = idCliente;
        }

        public Cliente(string nomeCliente, string documentoCliente)
        {
            IdCliente = Guid.NewGuid();
            NomeCliente  = nomeCliente;
            DocumentoCliente = documentoCliente;
        }
    }
}
