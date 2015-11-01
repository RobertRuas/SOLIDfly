using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocio.Endereco
{
    public class EnderecoBuscarBairro
    {
        private AcessoBancoDados.AcessoDadosSqlServer acessoDadosSqlServer = new AcessoBancoDados.AcessoDadosSqlServer();

        public DataTable Lista(string Pais, string UF, string Cidade, string Bairro)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdcionarParametro("@Pais", Pais);
            acessoDadosSqlServer.AdcionarParametro("@UF", UF);
            acessoDadosSqlServer.AdcionarParametro("@Cidade", Cidade);
            acessoDadosSqlServer.AdcionarParametro("@Bairro", Bairro);

            return acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "procEnderecoBuscarBairro");
        }
    }
}
