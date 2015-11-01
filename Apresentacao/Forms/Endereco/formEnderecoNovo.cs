using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;

namespace Apresentacao.Forms.Endereco
{
    public partial class formEnderecoNovo : Form
    {
        public formEnderecoNovo()
        {
            InitializeComponent();
        }

        private ObjetoTransferencia.Endereco DTOEndereco = new ObjetoTransferencia.Endereco();
        private DataTable UFs = new DataTable();

        private Negocio.Endereco.tabelaCidade enderecoCidade = new Negocio.Endereco.tabelaCidade();
        private Negocio.Endereco.tabelaEstado enderecoEstados = new Negocio.Endereco.tabelaEstado();

        private void formEnderecoNovo_Load(object sender, EventArgs e)
        {
            CarregarEstados();
            CarregarCidade();
            Camp_TipoLogr.SelectedIndex = 0;
        }

        private void LimparCampos()
        {
            Camp_CEP.Clear();
            CarregarEstados();
            Camp_Bairro.Clear();
            Camp_TipoLogr.SelectedIndex = 0;
            Camp_Logradouro.Clear();
            Camp_Numero.Clear();
            Camp_Complemento.Clear();
            Camp_GeoLoc.Clear();
        }

        private void CarregarEstados()
        {
            UFs = enderecoEstados.Lista();

            Camp_UF.Items.Clear();
            foreach (DataRow row in UFs.Rows)
            {
                Camp_UF.Items.Add(row["UF"].ToString());
                Camp_UF.SelectedIndex = 0;
            }
        }

        private void CarregarCidade()
        {
            foreach(DataRow rows in UFs.Rows)
            {
                if(rows["UF"].ToString() == Camp_UF.Text)
                {
                    Camp_Cidade.Items.Clear();
                    foreach (DataRow row in enderecoCidade.Lista(Convert.ToInt32(rows["ID"])).Rows)
                    {
                        Camp_Cidade.Items.Add(row["Nome"].ToString());
                        Camp_Cidade.SelectedIndex = 0;
                    }
                }
            }
        }

        private void Camp_UF_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarCidade();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                DTOEndereco.CEP = Camp_CEP.Text;
                DTOEndereco.Pais = Camp_Pais.Text;
                DTOEndereco.UF = Camp_UF.Text;
                DTOEndereco.Cidade = Camp_Cidade.Text;
                DTOEndereco.Bairro = Camp_Bairro.Text;
                DTOEndereco.TipoLogr = Camp_TipoLogr.Text;
                DTOEndereco.Logradouro = Camp_Logradouro.Text;
                DTOEndereco.Numero = Convert.ToInt32(Camp_Numero.Text);
                DTOEndereco.Complemento = Camp_Complemento.Text;
                DTOEndereco.GeoLoc = Camp_GeoLoc.Text;
                DTOEndereco.IDUsuario = 1; // Atribuido afim de testes
                DTOEndereco.DataCadastro = DateTime.Now; // Indiferente, pois será atribuida na stored procedure

                Negocio.Endereco.EnderecoOperacoes enderecoOperacoes = new Negocio.Endereco.EnderecoOperacoes();
                enderecoOperacoes.Cadastrar(DTOEndereco);

                MessageBox.Show("Cadastro realizado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                toolStripStatus.Text = "Cadastrado com sucesso";
                toolStripStatus.ForeColor = Color.Green;
                LimparCampos();
            }
            catch(Exception ex)
            {
                toolStripStatus.Text = "Erro ao cadastrar";
                toolStripStatus.ForeColor = Color.Red;

                DialogResult result = MessageBox.Show("Não foi possivel realizar o procedimento. \nDeseja visualizar mais detalhes?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja cancelar esta operação?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
