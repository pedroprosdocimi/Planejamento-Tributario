namespace Infra.Repositorios
{
    public static class TabelasSql
    {
        public const string TabelaCliente =
            @"
                CREATE TABLE Clientes(
	                [IdCliente] [varchar](255) NOT NULL,
	                [NomeCliente] [varchar](255) NOT NULL,
	                [DocumentoCliente] [varchar](255) NOT NULL
                )
            ";
    }
}
