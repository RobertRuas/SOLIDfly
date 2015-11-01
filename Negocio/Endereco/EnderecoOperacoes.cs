using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocio.Endereco
{
    public class EnderecoOperacoes
    {
        private AcessoBancoDados.AcessoDadosSqlServer acessoDadosSqlServer = new AcessoBancoDados.AcessoDadosSqlServer();

        public void Cadastrar(ObjetoTransferencia.Endereco DTOEndereco)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdcionarParametro("@CEP", DTOEndereco.CEP);
                acessoDadosSqlServer.AdcionarParametro("@Pais", DTOEndereco.Pais);
                acessoDadosSqlServer.AdcionarParametro("@UF", DTOEndereco.UF);
                acessoDadosSqlServer.AdcionarParametro("@Cidade", DTOEndereco.Cidade);
                acessoDadosSqlServer.AdcionarParametro("@Bairro", DTOEndereco.Bairro);
                acessoDadosSqlServer.AdcionarParametro("@TipoLogr", DTOEndereco.TipoLogr);
                acessoDadosSqlServer.AdcionarParametro("@Logradouro", DTOEndereco.Logradouro);
                acessoDadosSqlServer.AdcionarParametro("@Numero", DTOEndereco.Numero);
                acessoDadosSqlServer.AdcionarParametro("@Complemento", DTOEndereco.Complemento);
                acessoDadosSqlServer.AdcionarParametro("@GeoLoc", DTOEndereco.GeoLoc);
                acessoDadosSqlServer.AdcionarParametro("@IDUsuarioCad", DTOEndereco.IDUsuario);
                acessoDadosSqlServer.AdcionarParametro("@DataCadastro", DTOEndereco.DataCadastro);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "procEnderecoNovo");
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel realizar procedimento. Detalhes: " + ex.Message);
            }
        }

        public void Editar(ObjetoTransferencia.Endereco DTOEndereco)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdcionarParametro("@ID", DTOEndereco.ID);
                acessoDadosSqlServer.AdcionarParametro("@Pais", DTOEndereco.Pais);
                acessoDadosSqlServer.AdcionarParametro("@UF", DTOEndereco.UF);
                acessoDadosSqlServer.AdcionarParametro("@Cidade", DTOEndereco.Cidade);
                acessoDadosSqlServer.AdcionarParametro("@Bairro", DTOEndereco.Bairro);
                acessoDadosSqlServer.AdcionarParametro("@TipoLogr", DTOEndereco.TipoLogr);
                acessoDadosSqlServer.AdcionarParametro("@Logradouro", DTOEndereco.Logradouro);
                acessoDadosSqlServer.AdcionarParametro("@Numero", DTOEndereco.Numero);
                acessoDadosSqlServer.AdcionarParametro("@Complemento", DTOEndereco.Complemento);
                acessoDadosSqlServer.AdcionarParametro("@GeoLoc", DTOEndereco.GeoLoc);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "procEnderecoEditar");
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel realizar procedimento. Detalhes: " + ex.Message);
            }
        }
    }
}
