using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Forms.Estoque
{
    public partial class formEstoqueNovo : Form
    {
        public formEstoqueNovo()
        {
            InitializeComponent();
        }

        private void linkMarca_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formEstoqueMarca frmOpen = new formEstoqueMarca();
            frmOpen.ShowDialog();
        }

        private void linkModelo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formEstoqueMarcaModelo frmOpen = new formEstoqueMarcaModelo();
            frmOpen.ShowDialog();
        }
    }
}
