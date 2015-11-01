namespace Apresentacao.Forms.Endereco
{
    partial class formEnderecoBuscar
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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.camp_DataFim = new System.Windows.Forms.DateTimePicker();
            this.camp_DataInicio = new System.Windows.Forms.DateTimePicker();
            this.linkSelecMoc = new System.Windows.Forms.LinkLabel();
            this.checkb_Logradouro = new System.Windows.Forms.CheckBox();
            this.checkb_Bairro = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.camp_Logradouro = new System.Windows.Forms.TextBox();
            this.camp_Bairro = new System.Windows.Forms.TextBox();
            this.Camp_Cidade = new System.Windows.Forms.ComboBox();
            this.Camp_UF = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selecionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_Lista = new System.Windows.Forms.DataGridView();
            this.checkedListBox_Colunas = new System.Windows.Forms.CheckedListBox();
            this.statusBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 532);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(870, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatus.Text = "status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.camp_DataFim);
            this.groupBox1.Controls.Add(this.camp_DataInicio);
            this.groupBox1.Controls.Add(this.linkSelecMoc);
            this.groupBox1.Controls.Add(this.checkb_Logradouro);
            this.groupBox1.Controls.Add(this.checkb_Bairro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.camp_Logradouro);
            this.groupBox1.Controls.Add(this.camp_Bairro);
            this.groupBox1.Controls.Add(this.Camp_Cidade);
            this.groupBox1.Controls.Add(this.Camp_UF);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 127);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data de Cadastro";
            // 
            // camp_DataFim
            // 
            this.camp_DataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.camp_DataFim.Location = new System.Drawing.Point(239, 12);
            this.camp_DataFim.Name = "camp_DataFim";
            this.camp_DataFim.Size = new System.Drawing.Size(131, 20);
            this.camp_DataFim.TabIndex = 7;
            // 
            // camp_DataInicio
            // 
            this.camp_DataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.camp_DataInicio.Location = new System.Drawing.Point(102, 12);
            this.camp_DataInicio.Name = "camp_DataInicio";
            this.camp_DataInicio.Size = new System.Drawing.Size(131, 20);
            this.camp_DataInicio.TabIndex = 7;
            // 
            // linkSelecMoc
            // 
            this.linkSelecMoc.AutoSize = true;
            this.linkSelecMoc.Location = new System.Drawing.Point(296, 43);
            this.linkSelecMoc.Name = "linkSelecMoc";
            this.linkSelecMoc.Size = new System.Drawing.Size(74, 13);
            this.linkSelecMoc.TabIndex = 5;
            this.linkSelecMoc.TabStop = true;
            this.linkSelecMoc.Text = "Montes Claros";
            this.linkSelecMoc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSelecMoc_LinkClicked);
            // 
            // checkb_Logradouro
            // 
            this.checkb_Logradouro.AutoSize = true;
            this.checkb_Logradouro.Enabled = false;
            this.checkb_Logradouro.Location = new System.Drawing.Point(8, 95);
            this.checkb_Logradouro.Name = "checkb_Logradouro";
            this.checkb_Logradouro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkb_Logradouro.Size = new System.Drawing.Size(80, 17);
            this.checkb_Logradouro.TabIndex = 4;
            this.checkb_Logradouro.Text = "Logradouro";
            this.checkb_Logradouro.UseVisualStyleBackColor = true;
            // 
            // checkb_Bairro
            // 
            this.checkb_Bairro.AutoSize = true;
            this.checkb_Bairro.Enabled = false;
            this.checkb_Bairro.Location = new System.Drawing.Point(35, 69);
            this.checkb_Bairro.Name = "checkb_Bairro";
            this.checkb_Bairro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkb_Bairro.Size = new System.Drawing.Size(53, 17);
            this.checkb_Bairro.TabIndex = 4;
            this.checkb_Bairro.Text = "Bairro";
            this.checkb_Bairro.UseVisualStyleBackColor = true;
            this.checkb_Bairro.CheckedChanged += new System.EventHandler(this.checkb_Bairro_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "UF";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(376, 12);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(65, 100);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // camp_Logradouro
            // 
            this.camp_Logradouro.Enabled = false;
            this.camp_Logradouro.Location = new System.Drawing.Point(94, 93);
            this.camp_Logradouro.Name = "camp_Logradouro";
            this.camp_Logradouro.Size = new System.Drawing.Size(276, 20);
            this.camp_Logradouro.TabIndex = 1;
            this.camp_Logradouro.TextChanged += new System.EventHandler(this.camp_Logradouro_TextChanged);
            // 
            // camp_Bairro
            // 
            this.camp_Bairro.Enabled = false;
            this.camp_Bairro.Location = new System.Drawing.Point(94, 67);
            this.camp_Bairro.Name = "camp_Bairro";
            this.camp_Bairro.Size = new System.Drawing.Size(276, 20);
            this.camp_Bairro.TabIndex = 1;
            this.camp_Bairro.TextChanged += new System.EventHandler(this.camp_Bairro_TextChanged);
            // 
            // Camp_Cidade
            // 
            this.Camp_Cidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Camp_Cidade.FormattingEnabled = true;
            this.Camp_Cidade.Location = new System.Drawing.Point(140, 40);
            this.Camp_Cidade.Name = "Camp_Cidade";
            this.Camp_Cidade.Size = new System.Drawing.Size(150, 21);
            this.Camp_Cidade.TabIndex = 0;
            this.Camp_Cidade.SelectedIndexChanged += new System.EventHandler(this.cbox_Cidade_SelectedIndexChanged);
            // 
            // Camp_UF
            // 
            this.Camp_UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Camp_UF.FormattingEnabled = true;
            this.Camp_UF.Location = new System.Drawing.Point(33, 40);
            this.Camp_UF.Name = "Camp_UF";
            this.Camp_UF.Size = new System.Drawing.Size(55, 21);
            this.Camp_UF.TabIndex = 0;
            this.Camp_UF.SelectedIndexChanged += new System.EventHandler(this.cbox_UF_SelectedIndexChanged);
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
            this.contextMenuStrip.Size = new System.Drawing.Size(129, 98);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // selecionarToolStripMenuItem
            // 
            this.selecionarToolStripMenuItem.Name = "selecionarToolStripMenuItem";
            this.selecionarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.selecionarToolStripMenuItem.Text = "Selecionar";
            this.selecionarToolStripMenuItem.Visible = false;
            this.selecionarToolStripMenuItem.Click += new System.EventHandler(this.selecionarToolStripMenuItem_Click);
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
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
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
            // dataGridView_Lista
            // 
            this.dataGridView_Lista.AllowUserToAddRows = false;
            this.dataGridView_Lista.AllowUserToDeleteRows = false;
            this.dataGridView_Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Lista.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_Lista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lista.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridView_Lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Lista.Location = new System.Drawing.Point(159, 127);
            this.dataGridView_Lista.Name = "dataGridView_Lista";
            this.dataGridView_Lista.ReadOnly = true;
            this.dataGridView_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Lista.Size = new System.Drawing.Size(711, 405);
            this.dataGridView_Lista.TabIndex = 4;
            this.dataGridView_Lista.DoubleClick += new System.EventHandler(this.dataGridView_Lista_DoubleClick);
            // 
            // checkedListBox_Colunas
            // 
            this.checkedListBox_Colunas.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox_Colunas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_Colunas.CheckOnClick = true;
            this.checkedListBox_Colunas.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkedListBox_Colunas.FormattingEnabled = true;
            this.checkedListBox_Colunas.Location = new System.Drawing.Point(0, 127);
            this.checkedListBox_Colunas.Name = "checkedListBox_Colunas";
            this.checkedListBox_Colunas.Size = new System.Drawing.Size(159, 405);
            this.checkedListBox_Colunas.TabIndex = 5;
            this.checkedListBox_Colunas.SelectedValueChanged += new System.EventHandler(this.checkedListBox_Colunas_SelectedValueChanged);
            // 
            // formEnderecoBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 554);
            this.Controls.Add(this.dataGridView_Lista);
            this.Controls.Add(this.checkedListBox_Colunas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusBar);
            this.MinimizeBox = false;
            this.Name = "formEnderecoBuscar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Endereco";
            this.Activated += new System.EventHandler(this.formEnderecoBuscar_Activated);
            this.Load += new System.EventHandler(this.formEnderecoBuscar_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkb_Logradouro;
        private System.Windows.Forms.CheckBox checkb_Bairro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox camp_Logradouro;
        private System.Windows.Forms.TextBox camp_Bairro;
        private System.Windows.Forms.ComboBox Camp_Cidade;
        private System.Windows.Forms.ComboBox Camp_UF;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecionarToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkSelecMoc;
        private System.Windows.Forms.DateTimePicker camp_DataFim;
        private System.Windows.Forms.DateTimePicker camp_DataInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_Lista;
        private System.Windows.Forms.CheckedListBox checkedListBox_Colunas;
    }
}