using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ObjetoTransferencia;

namespace Negocio.Endereco
{
    public class EnderecoBuscar
    {
        private AcessoBancoDados.AcessoDadosSqlServer acessoDadosSqlServer = new AcessoBancoDados.AcessoDadosSqlServer();

        public ObjetoTransferencia.Endereco Lista(int ID)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdcionarParametro("@ID", ID);
            DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "procEnderecoBuscarID");

            ObjetoTransferencia.Endereco DTOEndereco = new ObjetoTransferencia.Endereco();

            DTOEndereco.CEP = dataTable.Rows[0]["CEP"].ToString();
	        DTOEndereco.Pais = dataTable.Rows[0]["Pais"].ToString();
	        DTOEndereco.UF = dataTable.Rows[0]["UF"].ToString();
	        DTOEndereco.Cidade = dataTable.Rows[0]["Cidade"].ToString();
	        DTOEndereco.Bairro = dataTable.Rows[0]["Bairro"].ToString();
	        DTOEndereco.TipoLogr = dataTable.Rows[0]["TipoLogr"].ToString();
	        DTOEndereco.Logradouro = dataTable.Rows[0]["Logradouro"].ToString();
	        DTOEndereco.Numero = Convert.ToInt32(dataTable.Rows[0]["Numero"].ToString());
	        DTOEndereco.Complemento = dataTable.Rows[0]["Complemento"].ToString();
	        DTOEndereco.GeoLoc = dataTable.Rows[0]["GeoLoc"].ToString();
	        DTOEndereco.IDUsuario = Convert.ToInt32(dataTable.Rows[0]["IDUsuarioCad"].ToString());
	        DTOEndereco.DataCadastro = Convert.ToDateTime(dataTable.Rows[0]["DataCadastro"].ToString());

            return DTOEndereco;
        }

        public DataTable Lista(DateTime DataCadastro_Inicio, DateTime DataCadastro_Fim)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdcionarParametro("@DataCadastro_Inicio", DataCadastro_Inicio.ToShortDateString());
            acessoDadosSqlServer.AdcionarParametro("@DataCadastro_Fim", DataCadastro_Fim);

            return acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "procEnderecoListar");
        }

        public DataTable BuscarCidade(ObjetoTransferencia.Endereco DTOEndereco, DateTime DataCadastro_Inicio, DateTime DataCadastro_Fim)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdcionarParametro("@Pais", DTOEndereco.Pais);
            acessoDadosSqlServer.AdcionarParametro("@UF", DTOEndereco.UF);
            acessoDadosSqlServer.AdcionarParametro("@Cidade", DTOEndereco.Cidade);
            acessoDadosSqlServer.AdcionarParametro("@DataCadastro_Inicio", DataCadastro_Inicio.ToShortDateString());
            acessoDadosSqlServer.AdcionarParametro("@DataCadastro_Fim", DataCadastro_Fim);

            return acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "procEnderecoBuscarCidade");
        }

        public DataTable BuscarBairro(ObjetoTransferencia.Endereco DTOEndereco, DateTime DataCadastro_Inicio, DateTime DataCadastro_Fim)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdcionarParametro("@Pais", DTOEndereco.Pais);
            acessoDadosSqlServer.AdcionarParametro("@UF", DTOEndereco.UF);
            acessoDadosSqlServer.AdcionarParametro("@Cidade", DTOEndereco.Cidade);
            acessoDadosSqlServer.AdcionarParametro("@Bairro", DTOEndereco.Bairro);
            acessoDadosSqlServer.AdcionarParametro("@DataCadastro_Inicio", DataCadastro_Inicio.ToShortDateString());
            acessoDadosSqlServer.AdcionarParametro("@DataCadastro_Fim", DataCadastro_Fim);

            return acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "procEnderecoBuscarBairro");
        }

        public DataTable BuscarLogradouro(ObjetoTransferencia.Endereco DTOEndereco, DateTime DataCadastro_Inicio, DateTime DataCadastro_Fim)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdcionarParametro("@Pais", DTOEndereco.Pais);
            acessoDadosSqlServer.AdcionarParametro("@UF", DTOEndereco.UF);
            acessoDadosSqlServer.AdcionarParametro("@Cidade", DTOEndereco.Cidade);
            acessoDadosSqlServer.AdcionarParametro("@Bairro", DTOEndereco.Bairro);
            acessoDadosSqlServer.AdcionarParametro("@Logradouro", DTOEndereco.Logradouro);
            acessoDadosSqlServer.AdcionarParametro("@DataCadastro_Inicio", DataCadastro_Inicio.ToShortDateString());
            acessoDadosSqlServer.AdcionarParametro("@DataCadastro_Fim", DataCadastro_Fim);

            return acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "procEnderecoBuscarLogradouro");
        }

        
    }
}
