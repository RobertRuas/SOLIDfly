namespace Apresentacao.Forms.Cliente
{
    partial class formClienteBuscar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewLista = new System.Windows.Forms.ListView();
            this.Código = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.campNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.campCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sexo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelPrincipal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelMovel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelAlternativo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataCadastro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusAtual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.campDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkB_DataCadastro = new System.Windows.Forms.CheckBox();
            this.checkB_Sexo = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selecionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewLista
            // 
            this.listViewLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Código,
            this.Nome,
            this.Sexo,
            this.Cidade,
            this.Bairro,
            this.TelPrincipal,
            this.TelMovel,
            this.TelAlternativo,
            this.Email,
            this.DataCadastro,
            this.StatusAtual});
            this.listViewLista.ContextMenuStrip = this.contextMenuStrip;
            this.listViewLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLista.FullRowSelect = true;
            this.listViewLista.GridLines = true;
            this.listViewLista.Location = new System.Drawing.Point(0, 124);
            this.listViewLista.MultiSelect = false;
            this.listViewLista.Name = "listViewLista";
            this.listViewLista.Size = new System.Drawing.Size(1061, 384);
            this.listViewLista.TabIndex = 8;
            this.listViewLista.UseCompatibleStateImageBehavior = false;
            this.listViewLista.View = System.Windows.Forms.View.Details;
            // 
            // Código
            // 
            this.Código.Text = "Código";
            this.Código.Width = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkB_Sexo);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkB_DataCadastro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.campDataNasc);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.campNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.campCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1061, 124);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // campNome
            // 
            this.campNome.Location = new System.Drawing.Point(106, 32);
            this.campNome.Name = "campNome";
            this.campNome.Size = new System.Drawing.Size(439, 20);
            this.campNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // campCodigo
            // 
            this.campCodigo.Location = new System.Drawing.Point(15, 32);
            this.campCodigo.Name = "campCodigo";
            this.campCodigo.Size = new System.Drawing.Size(85, 20);
            this.campCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(551, 32);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(158, 70);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 508);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1061, 22);
            this.statusBar.TabIndex = 6;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatus.Text = "status";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 187;
            // 
            // Sexo
            // 
            this.Sexo.Text = "Sexo";
            this.Sexo.Width = 64;
            // 
            // TelPrincipal
            // 
            this.TelPrincipal.Text = "Tel. Principal";
            this.TelPrincipal.Width = 79;
            // 
            // TelMovel
            // 
            this.TelMovel.Text = "Tel. Movel";
            this.TelMovel.Width = 74;
            // 
            // TelAlternativo
            // 
            this.TelAlternativo.Text = "Tel. Alternativo";
            this.TelAlternativo.Width = 70;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 139;
            // 
            // DataCadastro
            // 
            this.DataCadastro.Text = "Data de Cadastro";
            this.DataCadastro.Width = 85;
            // 
            // StatusAtual
            // 
            this.StatusAtual.Text = "Status Atual";
            this.StatusAtual.Width = 71;
            // 
            // Cidade
            // 
            this.Cidade.Text = "Cidade";
            this.Cidade.Width = 89;
            // 
            // Bairro
            // 
            this.Bairro.Text = "Bairro";
            this.Bairro.Width = 112;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Homem",
            "Mulher",
            "Não Informado"});
            this.comboBox1.Location = new System.Drawing.Point(15, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // campDataNasc
            // 
            this.campDataNasc.Location = new System.Drawing.Point(144, 82);
            this.campDataNasc.Mask = "00/00/0000";
            this.campDataNasc.Name = "campDataNasc";
            this.campDataNasc.Size = new System.Drawing.Size(86, 20);
            this.campDataNasc.TabIndex = 7;
            this.campDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(252, 82);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(86, 20);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "a";
            // 
            // checkB_DataCadastro
            // 
            this.checkB_DataCadastro.AutoSize = true;
            this.checkB_DataCadastro.Location = new System.Drawing.Point(144, 58);
            this.checkB_DataCadastro.Name = "checkB_DataCadastro";
            this.checkB_DataCadastro.Size = new System.Drawing.Size(108, 17);
            this.checkB_DataCadastro.TabIndex = 9;
            this.checkB_DataCadastro.Text = "Data de cadastro";
            this.checkB_DataCadastro.UseVisualStyleBackColor = true;
            // 
            // checkB_Sexo
            // 
            this.checkB_Sexo.AutoSize = true;
            this.checkB_Sexo.Location = new System.Drawing.Point(15, 58);
            this.checkB_Sexo.Name = "checkB_Sexo";
            this.checkB_Sexo.Size = new System.Drawing.Size(50, 17);
            this.checkB_Sexo.TabIndex = 10;
            this.checkB_Sexo.Text = "Sexo";
            this.checkB_Sexo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(344, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Bairro";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selecionarToolStripMenuItem,
            this.visualizarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.toolStripSeparator1,
            this.excluirToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 120);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // selecionarToolStripMenuItem
            // 
            this.selecionarToolStripMenuItem.Name = "selecionarToolStripMenuItem";
            this.selecionarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.selecionarToolStripMenuItem.Text = "Selecionar";
            this.selecionarToolStripMenuItem.Visible = false;
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // formClienteBuscar
            // 
            this.AcceptButton = this.btn_Buscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 530);
            this.Controls.Add(this.listViewLista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusBar);
            this.MinimizeBox = false;
            this.Name = "formClienteBuscar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewLista;
        private System.Windows.Forms.ColumnHeader Código;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox campNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Sexo;
        private System.Windows.Forms.ColumnHeader Cidade;
        private System.Windows.Forms.ColumnHeader Bairro;
        private System.Windows.Forms.ColumnHeader TelPrincipal;
        private System.Windows.Forms.ColumnHeader TelMovel;
        private System.Windows.Forms.ColumnHeader TelAlternativo;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader DataCadastro;
        private System.Windows.Forms.ColumnHeader StatusAtual;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox campDataNasc;
        private System.Windows.Forms.CheckBox checkB_Sexo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkB_DataCadastro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem selecionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
    }
}