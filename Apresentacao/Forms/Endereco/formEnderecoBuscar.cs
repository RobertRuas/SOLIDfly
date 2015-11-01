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
    public partial class formEnderecoBuscar : Form
    {
        public formEnderecoBuscar()
        {
            InitializeComponent();

            camp_DataInicio.Value = DateTime.Now.AddDays(-30);
        }

        private ObjetoTransferencia.Endereco DTOEndereco = new ObjetoTransferencia.Endereco();
        private Negocio.Endereco.EnderecoBuscar enderecoBuscar = new Negocio.Endereco.EnderecoBuscar();
        private Negocio.Endereco.tabelaCidade enderecoCidade = new Negocio.Endereco.tabelaCidade();
        private Negocio.Endereco.tabelaEstado enderecoEstados = new Negocio.Endereco.tabelaEstado();
        private DataTable UFs = new DataTable();

        // ---------------------------------------------------------------------------------------------------------
        // Sobre carga

        Forms.Fornecedor.formFornecedorNovo formFornecedorNovo;
        Forms.Fornecedor.formFornecedorEditar formFornecedorEditar;

        public formEnderecoBuscar(Forms.Fornecedor.formFornecedorNovo form)
        {
            InitializeComponent();

            formFornecedorNovo = form;
            selecionarToolStripMenuItem.Visible = true;
        }

        public formEnderecoBuscar(Forms.Fornecedor.formFornecedorEditar form)
        {
            InitializeComponent();

            formFornecedorEditar = form;
            selecionarToolStripMenuItem.Visible = true;
        }

        // ---------------------------------------------------------------------------------------------------------


        private void formEnderecoBuscar_Activated(object sender, EventArgs e)
        {
            btn_Buscar.PerformClick();
        }

        private void formEnderecoBuscar_Load(object sender, EventArgs e)
        {
            CarregarUF();
            CarregarLista();
            SelecMG_MontesClaros();
            CarregarCheckColunas();
            MarcarColunasPadroes();
            VerificarColunasMarcadas();
        }


        // -----------------------------------------------------------------------------------

        private void cbox_UF_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Buscar.PerformClick();

            CarregarCidades();
            btn_Buscar.PerformClick();
        }

        private void cbox_Cidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Buscar.PerformClick();

            btn_Buscar.PerformClick();

            if((Camp_UF.Text != "") && (Camp_Cidade.Text != ""))
            {
                camp_Bairro.Enabled = true;
            }
            else
            {
                camp_Bairro.Enabled = false;
            }
        }

        private void camp_Bairro_TextChanged(object sender, EventArgs e)
        {
            btn_Buscar.PerformClick();

            if (camp_Bairro.Text != "")
            {
                checkb_Bairro.Enabled = true;
                checkb_Bairro.Checked = true;
            }
            else
            {
                checkb_Bairro.Enabled = false;
                checkb_Bairro.Checked = false;

                checkb_Logradouro.Enabled = false;
                checkb_Logradouro.Checked = false;
            }
        }

        private void checkb_Bairro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkb_Bairro.Checked)
            {
                camp_Logradouro.Enabled = true;
                if (camp_Logradouro.Text != "")
                {
                    checkb_Logradouro.Enabled = true;
                }
            }
            else
            {
                camp_Logradouro.Enabled = false;
                checkb_Logradouro.Enabled = false;
                checkb_Logradouro.Checked = false;
            }
        }

        private void camp_Logradouro_TextChanged(object sender, EventArgs e)
        {
            btn_Buscar.PerformClick();

            if (camp_Logradouro.Text != "")
            {
                checkb_Logradouro.Enabled = true;
                checkb_Logradouro.Checked = true;
            }
            else
            {
                checkb_Logradouro.Enabled = false;
                checkb_Logradouro.Checked = false;
            }
        }

        // -----------------------------------------------------------------------------------

        private void CarregarCheckColunas()
        {
            foreach (DataGridViewColumn column in dataGridView_Lista.Columns)
            {
                checkedListBox_Colunas.Items.Add(column.HeaderText, false);
            }
        }

        private void VerificarColunasMarcadas()
        {
            for (int i = 0; i < checkedListBox_Colunas.Items.Count; i++)
            {
                if(checkedListBox_Colunas.GetItemChecked(i))
                {
                    dataGridView_Lista.Columns[i].Visible = true;
                }
                else
                {
                    dataGridView_Lista.Columns[i].Visible = false;
                }
            }
        }

        private void MarcarColunasPadroes()
        {
            List<string> ColsPadroes = new List<string>();

            ColsPadroes.Add("CEP");
            ColsPadroes.Add("UF");
            ColsPadroes.Add("Cidade");
            ColsPadroes.Add("Bairro");
            ColsPadroes.Add("Logradouro");
            ColsPadroes.Add("Numero");

            for (int i = 0; i < ColsPadroes.Count; i++)
            {
                for (int j = 0; j < checkedListBox_Colunas.Items.Count; j++)
                {
                    if (checkedListBox_Colunas.Items[j].ToString() == ColsPadroes[i])
                    {
                        checkedListBox_Colunas.SetItemChecked(j, true);
                    }
                }
            }
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

        private void SelecMG_MontesClaros()
        {
            for (int i = 0; i < Camp_UF.Items.Count; i++)
            {
                if (Camp_UF.Items[i].ToString() == "MG")
                {
                    Camp_UF.SelectedIndex = i;
                }
            }

            for (int i = 0; i < Camp_Cidade.Items.Count; i++)
            {
                if (Camp_Cidade.Items[i].ToString() == "Montes Claros")
                {
                    Camp_Cidade.SelectedIndex = i;
                }
            }
        }

        private void CarregarLista()
        {
            DTOEndereco.Pais = "Brasil";
            DTOEndereco.UF = Camp_UF.Text;
            DTOEndereco.Cidade = Camp_Cidade.Text;

            dataGridView_Lista.DataSource = enderecoBuscar.BuscarCidade(DTOEndereco, camp_DataInicio.Value, camp_DataFim.Value);

            // Contagem de registro
            toolStripStatus.Text = dataGridView_Lista.Rows.Count + " item(s) encontrado(s)";
        }

        private void CarregarLista(DataTable dataTable)
        {
            DTOEndereco.Pais = "Brasil";
            DTOEndereco.UF = Camp_UF.Text;
            DTOEndereco.Cidade = Camp_Cidade.Text;

            dataGridView_Lista.DataSource = enderecoBuscar.BuscarCidade(DTOEndereco, camp_DataInicio.Value, camp_DataFim.Value);

            // Contagem de registro
            toolStripStatus.Text = dataGridView_Lista.Rows.Count + " item(s) encontrado(s)";
        }

        // -----------------------------------------------------------------------------------

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView_Lista.SelectedRows.Count != 1)
            {
                contextMenuStrip.Enabled = false;
                MessageBox.Show("Selecione um registro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                contextMenuStrip.Enabled = true;
            }
        }

        private void selecionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFornecedorNovo.campCodigoEndereco.Text = dataGridView_Lista.SelectedRows[0].Cells["ID"].ToString();
        }

        private void listViewLista_DoubleClick(object sender, EventArgs e)
        {
            if (formFornecedorNovo != null)
            {
                formFornecedorNovo.campCodigoEndereco.Text = dataGridView_Lista.SelectedRows[0].Cells["ID"].ToString();
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            CarregarLista();

            if(checkb_Bairro.Checked)
            {
                DTOEndereco.Pais = "Brasil";
                DTOEndereco.UF = Camp_UF.Text;
                DTOEndereco.Cidade = Camp_Cidade.Text;
                DTOEndereco.Bairro = camp_Bairro.Text;

                CarregarLista(enderecoBuscar.BuscarBairro(DTOEndereco, camp_DataInicio.Value, camp_DataFim.Value));
            }
            if(checkb_Logradouro.Checked)
            {
                DTOEndereco.Pais = "Brasil";
                DTOEndereco.UF = Camp_UF.Text;
                DTOEndereco.Cidade = Camp_Cidade.Text;
                DTOEndereco.Bairro = camp_Bairro.Text;
                DTOEndereco.Logradouro = camp_Logradouro.Text;

                CarregarLista(enderecoBuscar.BuscarLogradouro(DTOEndereco, camp_DataInicio.Value, camp_DataFim.Value));
            }
        }

        private void linkSelecMoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelecMG_MontesClaros();
        }

        private void checkedListBox_Colunas_SelectedValueChanged(object sender, EventArgs e)
        {
            VerificarColunasMarcadas();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEnderecoEditar formShow = new formEnderecoEditar(Convert.ToInt32(dataGridView_Lista.SelectedRows[0].Cells["ID"].Value));
            formShow.Show();
        }

        private void dataGridView_Lista_DoubleClick(object sender, EventArgs e)
        {
            formEnderecoVisualizar formShow = new formEnderecoVisualizar(Convert.ToInt32(dataGridView_Lista.SelectedRows[0].Cells["ID"].Value));
            formShow.Show();
        }
    }
}
