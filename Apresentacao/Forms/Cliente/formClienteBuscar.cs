using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Forms.Cliente
{
    public partial class formClienteBuscar : Form
    {
        public formClienteBuscar()
        {
            InitializeComponent();
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (listViewLista.SelectedItems.Count != 1)
            {
                contextMenuStrip.Enabled = false;
                MessageBox.Show("Selecione um registro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                contextMenuStrip.Enabled = true;
            }
        }
    }
}
