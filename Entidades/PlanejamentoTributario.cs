using System;

namespace Entidades
{
    public class PlanejamentoTributario
    {
        public int IdPlanejamentoTributario { get; set; }    
        public Guid IdCliente { get; set; }
        public int AnoReferencia { get; set; }    
    }
}
