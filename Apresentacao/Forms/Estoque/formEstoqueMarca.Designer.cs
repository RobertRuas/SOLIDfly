namespace Apresentacao.Forms.Estoque
{
    partial class formEstoqueMarca
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.campMarca = new System.Windows.Forms.TextBox();
            this.campFornecedorPrincipal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.listViewLista = new System.Windows.Forms.ListView();
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FornecedorPrincipal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.campFornecedorPrincipal);
            this.groupBox1.Controls.Add(this.campMarca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // campMarca
            // 
            this.campMarca.Location = new System.Drawing.Point(15, 32);
            this.campMarca.Name = "campMarca";
            this.campMarca.Size = new System.Drawing.Size(152, 20);
            this.campMarca.TabIndex = 1;
            // 
            // campFornecedorPrincipal
            // 
            this.campFornecedorPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campFornecedorPrincipal.FormattingEnabled = true;
            this.campFornecedorPrincipal.Location = new System.Drawing.Point(173, 32);
            this.campFornecedorPrincipal.Name = "campFornecedorPrincipal";
            this.campFornecedorPrincipal.Size = new System.Drawing.Size(146, 21);
            this.campFornecedorPrincipal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fornecedor Principal";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(325, 32);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(67, 21);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 375);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(406, 22);
            this.statusBar.TabIndex = 23;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatus.Text = "status";
            // 
            // listViewLista
            // 
            this.listViewLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Marca,
            this.FornecedorPrincipal});
            this.listViewLista.ContextMenuStrip = this.contextMenuStrip;
            this.listViewLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLista.FullRowSelect = true;
            this.listViewLista.GridLines = true;
            this.listViewLista.Location = new System.Drawing.Point(0, 69);
            this.listViewLista.MultiSelect = false;
            this.listViewLista.Name = "listViewLista";
            this.listViewLista.Size = new System.Drawing.Size(406, 306);
            this.listViewLista.TabIndex = 24;
            this.listViewLista.UseCompatibleStateImageBehavior = false;
            this.listViewLista.View = System.Windows.Forms.View.Details;
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            this.Marca.Width = 181;
            // 
            // FornecedorPrincipal
            // 
            this.FornecedorPrincipal.Text = "Fornecedor Principal";
            this.FornecedorPrincipal.Width = 202;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(109, 26);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(301, 13);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(18, 16);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "+";
            // 
            // formEstoqueMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 397);
            this.Controls.Add(this.listViewLista);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formEstoqueMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque > Marcas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox campFornecedorPrincipal;
        private System.Windows.Forms.TextBox campMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ListView listViewLista;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader FornecedorPrincipal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}