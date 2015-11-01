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
    public partial class formEnderecoVisualizar : Form
    {
        private int ID;

        public formEnderecoVisualizar(int ID_)
        {
            InitializeComponent();

            ID = ID_;
        }

        private void formEnderecoVisualizar_Load(object sender, EventArgs e)
        {
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

        private void cbox_Opcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbox_Opcoes.Text)
            {
                case "Novo":
                    formEnderecoNovo frmShowNovo = new formEnderecoNovo();
                    frmShowNovo.Show();
                    break;

                case "Editar":
                    formEnderecoEditar frmShowEditar = new formEnderecoEditar(ID);
                    frmShowEditar.Show();
                    break;

                case "Visualizar Log":
                    formEnderecoLog frmShowVis = new formEnderecoLog();
                    frmShowVis.Show();
                    break;

                default:
                    MessageBox.Show("Opção invalida", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }
    }
}
