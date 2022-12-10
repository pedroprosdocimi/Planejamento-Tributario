using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorios.Clientes
{
    public static class TabelasSql
    {
        public const string InserirCliente = 
            @"
                INSERT INTO 
                    Clientes 
                VALUES(
                    @id_cliente,
                    @nome_cliente,
                    @documento_cliente)
            ";
    }
}
