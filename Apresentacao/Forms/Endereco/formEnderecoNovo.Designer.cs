namespace Apresentacao.Forms.Endereco
{
    partial class formEnderecoNovo
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Camp_TipoLogr = new System.Windows.Forms.ComboBox();
            this.Camp_CEP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Camp_Cidade = new System.Windows.Forms.ComboBox();
            this.Camp_Bairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Camp_UF = new System.Windows.Forms.ComboBox();
            this.Camp_Logradouro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Camp_GeoLoc = new System.Windows.Forms.TextBox();
            this.Camp_Complemento = new System.Windows.Forms.TextBox();
            this.Camp_Numero = new System.Windows.Forms.TextBox();
            this.Camp_Pais = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetUFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUFBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.Camp_TipoLogr);
            this.groupBox.Controls.Add(this.Camp_CEP);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.Camp_Cidade);
            this.groupBox.Controls.Add(this.Camp_Bairro);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.Camp_UF);
            this.groupBox.Controls.Add(this.Camp_Logradouro);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.Camp_GeoLoc);
            this.groupBox.Controls.Add(this.Camp_Complemento);
            this.groupBox.Controls.Add(this.Camp_Numero);
            this.groupBox.Controls.Add(this.Camp_Pais);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(259, 284);
            this.groupBox.TabIndex = 17;
            this.groupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEP";
            // 
            // Camp_TipoLogr
            // 
            this.Camp_TipoLogr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Camp_TipoLogr.FormattingEnabled = true;
            this.Camp_TipoLogr.Items.AddRange(new object[] {
            "Rua",
            "Av",
            "Travessa",
            "Beco",
            "Ladeira",
            "Rodovia",
            "Estrada"});
            this.Camp_TipoLogr.Location = new System.Drawing.Point(79, 145);
            this.Camp_TipoLogr.Name = "Camp_TipoLogr";
            this.Camp_TipoLogr.Size = new System.Drawing.Size(171, 21);
            this.Camp_TipoLogr.TabIndex = 6;
            // 
            // Camp_CEP
            // 
            this.Camp_CEP.Location = new System.Drawing.Point(79, 13);
            this.Camp_CEP.Name = "Camp_CEP";
            this.Camp_CEP.Size = new System.Drawing.Size(171, 20);
            this.Camp_CEP.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tipo Logr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bairro";
            // 
            // Camp_Cidade
            // 
            this.Camp_Cidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Camp_Cidade.FormattingEnabled = true;
            this.Camp_Cidade.Location = new System.Drawing.Point(79, 92);
            this.Camp_Cidade.Name = "Camp_Cidade";
            this.Camp_Cidade.Size = new System.Drawing.Size(171, 21);
            this.Camp_Cidade.TabIndex = 4;
            // 
            // Camp_Bairro
            // 
            this.Camp_Bairro.Location = new System.Drawing.Point(79, 119);
            this.Camp_Bairro.Name = "Camp_Bairro";
            this.Camp_Bairro.Size = new System.Drawing.Size(171, 20);
            this.Camp_Bairro.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Logradouro";
            // 
            // Camp_UF
            // 
            this.Camp_UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Camp_UF.FormattingEnabled = true;
            this.Camp_UF.Location = new System.Drawing.Point(79, 65);
            this.Camp_UF.Name = "Camp_UF";
            this.Camp_UF.Size = new System.Drawing.Size(171, 21);
            this.Camp_UF.TabIndex = 3;
            this.Camp_UF.SelectedIndexChanged += new System.EventHandler(this.Camp_UF_SelectedIndexChanged);
            // 
            // Camp_Logradouro
            // 
            this.Camp_Logradouro.Location = new System.Drawing.Point(79, 172);
            this.Camp_Logradouro.Name = "Camp_Logradouro";
            this.Camp_Logradouro.Size = new System.Drawing.Size(171, 20);
            this.Camp_Logradouro.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "UF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Geo Loc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Complemento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "País";
            // 
            // Camp_GeoLoc
            // 
            this.Camp_GeoLoc.Location = new System.Drawing.Point(79, 250);
            this.Camp_GeoLoc.Name = "Camp_GeoLoc";
            this.Camp_GeoLoc.Size = new System.Drawing.Size(171, 20);
            this.Camp_GeoLoc.TabIndex = 10;
            // 
            // Camp_Complemento
            // 
            this.Camp_Complemento.Location = new System.Drawing.Point(79, 224);
            this.Camp_Complemento.Name = "Camp_Complemento";
            this.Camp_Complemento.Size = new System.Drawing.Size(171, 20);
            this.Camp_Complemento.TabIndex = 9;
            // 
            // Camp_Numero
            // 
            this.Camp_Numero.Location = new System.Drawing.Point(79, 198);
            this.Camp_Numero.Name = "Camp_Numero";
            this.Camp_Numero.Size = new System.Drawing.Size(171, 20);
            this.Camp_Numero.TabIndex = 8;
            // 
            // Camp_Pais
            // 
            this.Camp_Pais.Location = new System.Drawing.Point(79, 39);
            this.Camp_Pais.Name = "Camp_Pais";
            this.Camp_Pais.ReadOnly = true;
            this.Camp_Pais.Size = new System.Drawing.Size(171, 20);
            this.Camp_Pais.TabIndex = 2;
            this.Camp_Pais.Text = "Brasil";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(12, 302);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 20;
            this.btn_Cancelar.Text = "C&ancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(196, 302);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 19;
            this.btn_Cadastrar.Text = "&Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 339);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(283, 22);
            this.statusBar.TabIndex = 21;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatus.Text = "status";
            // 
            // formEnderecoNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 361);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formEnderecoNovo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Endereço";
            this.Load += new System.EventHandler(this.formEnderecoNovo_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUFBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Camp_TipoLogr;
        private System.Windows.Forms.TextBox Camp_CEP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Camp_Cidade;
        private System.Windows.Forms.TextBox Camp_Bairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Camp_UF;
        private System.Windows.Forms.TextBox Camp_Logradouro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Camp_GeoLoc;
        private System.Windows.Forms.TextBox Camp_Complemento;
        private System.Windows.Forms.TextBox Camp_Numero;
        private System.Windows.Forms.TextBox Camp_Pais;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource1;
        private System.Windows.Forms.BindingSource tblUFBindingSource;
        private System.Windows.Forms.BindingSource dataSetUFBindingSource;
    }
}