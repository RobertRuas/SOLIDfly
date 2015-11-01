using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Forms.Fornecedor
{
    public partial class formFornecedorVisualizar : Form
    {
        public formFornecedorVisualizar()
        {
            InitializeComponent();
        }

        private void formFornecedorVisualizar_Load(object sender, EventArgs e)
        {}

        private void cbox_Opcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbox_Opcoes.Text)
            {
                case "Novo":
                    formFornecedorNovo frmShowNovo = new formFornecedorNovo();
                    frmShowNovo.Show();
                    break;

                case "Editar":
                    formFornecedorEditar frmShowEditar = new formFornecedorEditar();
                    frmShowEditar.Show();
                    break;

                case "Visualizar Log":
                    formFornecedorLog frmShowVis = new formFornecedorLog();
                    frmShowVis.Show();
                    break;

                default:
                    MessageBox.Show("Opção invalida", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }
    }
}
