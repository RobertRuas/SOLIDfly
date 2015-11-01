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
    public partial class formFornecedorEditar : Form
    {
        public formFornecedorEditar()
        {
            InitializeComponent();
        }

        private void linkBuscarEndereco_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.Endereco.formEnderecoBuscar frmBuscarEndereco = new Endereco.formEnderecoBuscar(this);
            frmBuscarEndereco.ShowDialog();
        }

        private void LinkAlterarLogoTipo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Imagem JPG (*.JPG)|*.jpg";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;

                Bitmap image = new Bitmap(FileName);
                imageLogo.Image = image;
                imageLogo.BorderStyle = BorderStyle.None;
            }
        }
    }
}
