namespace Apresentacao.Forms.Fornecedor
{
    partial class formFornecedorBuscar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.RazaoSocial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Seguimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Representante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelefonePrincipal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Código = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.campCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.campRazaoSocial = new System.Windows.Forms.TextBox();
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
            this.RazaoSocial,
            this.Seguimento,
            this.Representante,
            this.TelefonePrincipal,
            this.Status});
            this.listViewLista.ContextMenuStrip = this.contextMenuStrip;
            this.listViewLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLista.FullRowSelect = true;
            this.listViewLista.GridLines = true;
            this.listViewLista.Location = new System.Drawing.Point(0, 73);
            this.listViewLista.MultiSelect = false;
            this.listViewLista.Name = "listViewLista";
            this.listViewLista.Size = new System.Drawing.Size(854, 435);
            this.listViewLista.TabIndex = 5;
            this.listViewLista.UseCompatibleStateImageBehavior = false;
            this.listViewLista.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.campRazaoSocial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.campCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 73);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
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
            this.btn_Buscar.Location = new System.Drawing.Point(451, 26);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(91, 31);
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
            this.statusBar.Size = new System.Drawing.Size(854, 22);
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatus.Text = "status";
            // 
            // RazaoSocial
            // 
            this.RazaoSocial.Text = "Razão Social";
            this.RazaoSocial.Width = 263;
            // 
            // Seguimento
            // 
            this.Seguimento.Text = "Seguimento";
            this.Seguimento.Width = 128;
            // 
            // Representante
            // 
            this.Representante.Text = "Representante";
            this.Representante.Width = 177;
            // 
            // TelefonePrincipal
            // 
            this.TelefonePrincipal.Text = "Tel. Principal";
            this.TelefonePrincipal.Width = 117;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 93;
            // 
            // Código
            // 
            this.Código.Text = "Código";
            this.Código.Width = 57;
            // 
            // campCodigo
            // 
            this.campCodigo.Location = new System.Drawing.Point(15, 32);
            this.campCodigo.Name = "campCodigo";
            this.campCodigo.Size = new System.Drawing.Size(85, 20);
            this.campCodigo.TabIndex = 0;
            this.campCodigo.TextChanged += new System.EventHandler(this.campCodigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Razão Social";
            // 
            // campRazaoSocial
            // 
            this.campRazaoSocial.Location = new System.Drawing.Point(106, 32);
            this.campRazaoSocial.Name = "campRazaoSocial";
            this.campRazaoSocial.Size = new System.Drawing.Size(339, 20);
            this.campRazaoSocial.TabIndex = 1;
            this.campRazaoSocial.TextChanged += new System.EventHandler(this.campRazaoSocial_TextChanged);
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
            this.selecionarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selecionarToolStripMenuItem.Text = "Selecionar";
            this.selecionarToolStripMenuItem.Visible = false;
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // formFornecedorBuscar
            // 
            this.AcceptButton = this.btn_Buscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 530);
            this.Controls.Add(this.listViewLista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusBar);
            this.MinimizeBox = false;
            this.Name = "formFornecedorBuscar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Fornecedor";
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ColumnHeader RazaoSocial;
        private System.Windows.Forms.ColumnHeader Código;
        private System.Windows.Forms.ColumnHeader Seguimento;
        private System.Windows.Forms.ColumnHeader Representante;
        private System.Windows.Forms.ColumnHeader TelefonePrincipal;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.TextBox campRazaoSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campCodigo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem selecionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
    }
}