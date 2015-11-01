using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Forms.Endereco
{
    public partial class formEnderecoEditar : Form
    {
        private int ID = 0;
        public formEnderecoEditar(int ID_)
        {
            InitializeComponent();

            ID = ID_;
        }

        private ObjetoTransferencia.Endereco DTOEndereco = new ObjetoTransferencia.Endereco();
        private Negocio.Endereco.EnderecoBuscar enderecoBuscar = new Negocio.Endereco.EnderecoBuscar();
        private Negocio.Endereco.tabelaCidade enderecoCidade = new Negocio.Endereco.tabelaCidade();
        private Negocio.Endereco.tabelaEstado enderecoEstados = new Negocio.Endereco.tabelaEstado();
        private DataTable UFs = new DataTable();

        private void formEnderecoEditar_Load(object sender, EventArgs e)
        {
            CarregarUF();
            CarregarCampos();
        }

        private void CarregarCampos()
        {
            Negocio.Endereco.EnderecoBuscar enderecoBuscar = new Negocio.Endereco.EnderecoBuscar();

            ObjetoTransferencia.Endereco DTOEndereco = new ObjetoTransferencia.Endereco();

            DTOEndereco = enderecoBuscar.Lista(ID);

            Camp_CEP.Text = DTOEndereco.CEP;
            Camp_Pais.Text = DTOEndereco.Pais;
            Camp_UF.Text = DTOEndereco.UF;
            Camp_Cidade.Text = DTOEndereco.Cidade;
            Camp_Bairro.Text = DTOEndereco.Bairro;
            Camp_TipoLogr.Text = DTOEndereco.TipoLogr;
            Camp_Logradouro.Text = DTOEndereco.Logradouro;
            Camp_Numero.Text = DTOEndereco.Numero.ToString();
            Camp_Complemento.Text = DTOEndereco.Complemento;
            Camp_GeoLoc.Text = DTOEndereco.GeoLoc;
        }

        private void CarregarUF()
        {
            UFs = enderecoEstados.Lista();

            Camp_UF.Items.Clear();
            foreach (DataRow row in UFs.Rows)
            {
                Camp_UF.Items.Add(row["UF"].ToString());
                Camp_UF.SelectedIndex = 0;
            }
        }

        private void CarregarCidades()
        {
            foreach (DataRow rows in UFs.Rows)
            {
                if (rows["UF"].ToString() == Camp_UF.Text)
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
            CarregarCidades();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                DTOEndereco.ID = ID;
                DTOEndereco.Pais = Camp_Pais.Text;
                DTOEndereco.UF = Camp_UF.Text;
                DTOEndereco.Cidade = Camp_Cidade.Text;
                DTOEndereco.Bairro = Camp_Bairro.Text;
                DTOEndereco.TipoLogr = Camp_TipoLogr.Text;
                DTOEndereco.Logradouro = Camp_Logradouro.Text;
                DTOEndereco.Numero = Convert.ToInt32(Camp_Numero.Text);
                DTOEndereco.Complemento = Camp_Complemento.Text;
                DTOEndereco.GeoLoc = Camp_GeoLoc.Text;

                Negocio.Endereco.EnderecoOperacoes enderecoOperacoes = new Negocio.Endereco.EnderecoOperacoes();
                enderecoOperacoes.Editar(DTOEndereco);

                MessageBox.Show("Edição realizada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                toolStripStatus.Text = "Edição realizada com sucesso";
                toolStripStatus.ForeColor = Color.Green;
                groupBox.Enabled = false;
            }
            catch (Exception ex)
            {
                toolStripStatus.Text = "Erro ao Editar";
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

            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
