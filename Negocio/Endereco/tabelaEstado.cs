using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocio.Endereco
{
    public class tabelaEstado
    {
        private AcessoBancoDados.AcessoDadosSqlServer acessoDadosSqlServer = new AcessoBancoDados.AcessoDadosSqlServer();

        public DataTable Lista()
        {
            acessoDadosSqlServer.LimparParametros();

            return acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "procEstadoLista");
        }
    }
}
