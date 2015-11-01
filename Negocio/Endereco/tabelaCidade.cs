using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocio.Endereco
{
    public class tabelaCidade
    {
        private AcessoBancoDados.AcessoDadosSqlServer acessoDadosSqlServer = new AcessoBancoDados.AcessoDadosSqlServer();

        public DataTable Lista(int IDEstado)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdcionarParametro("@IDEstado", IDEstado);
            return acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "procCidadeLista");
        }
    }
}