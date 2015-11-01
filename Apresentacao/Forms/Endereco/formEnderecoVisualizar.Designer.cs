namespace Apresentacao.Forms.Endereco
{
    partial class formEnderecoVisualizar
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_Opcoes = new System.Windows.Forms.ComboBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Camp_CEP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Camp_Bairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Camp_Logradouro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Camp_GeoLoc = new System.Windows.Forms.TextBox();
            this.Camp_Complemento = new System.Windows.Forms.TextBox();
            this.Camp_Numero = new System.Windows.Forms.TextBox();
            this.Camp_Pais = new System.Windows.Forms.TextBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.Camp_UF = new System.Windows.Forms.TextBox();
            this.Camp_Cidade = new System.Windows.Forms.TextBox();
            this.Camp_TipoLogr = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Opções";
            // 
            // cbox_Opcoes
            // 
            this.cbox_Opcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Opcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Opcoes.FormattingEnabled = true;
            this.cbox_Opcoes.Items.AddRange(new object[] {
            "Novo",
            "Editar",
            "Visualizar Log",
            "Excluir"});
            this.cbox_Opcoes.Location = new System.Drawing.Point(15, 28);
            this.cbox_Opcoes.Name = "cbox_Opcoes";
            this.cbox_Opcoes.Size = new System.Drawing.Size(259, 21);
            this.cbox_Opcoes.TabIndex = 30;
            this.cbox_Opcoes.SelectedIndexChanged += new System.EventHandler(this.cbox_Opcoes_SelectedIndexChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.Camp_CEP);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.Camp_Cidade);
            this.groupBox.Controls.Add(this.Camp_TipoLogr);
            this.groupBox.Controls.Add(this.Camp_Bairro);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.Camp_Logradouro);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.label12);
            this.groupBox.Controls.Add(this.Camp_GeoLoc);
            this.groupBox.Controls.Add(this.Camp_Complemento);
            this.groupBox.Controls.Add(this.Camp_Numero);
            this.groupBox.Controls.Add(this.Camp_UF);
            this.groupBox.Controls.Add(this.Camp_Pais);
            this.groupBox.Location = new System.Drawing.Point(15, 55);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(259, 279);
            this.groupBox.TabIndex = 19;
            this.groupBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CEP";
            // 
            // Camp_CEP
            // 
            this.Camp_CEP.Location = new System.Drawing.Point(79, 13);
            this.Camp_CEP.Name = "Camp_CEP";
            this.Camp_CEP.ReadOnly = true;
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
            // Camp_Bairro
            // 
            this.Camp_Bairro.Location = new System.Drawing.Point(79, 119);
            this.Camp_Bairro.Name = "Camp_Bairro";
            this.Camp_Bairro.ReadOnly = true;
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
            // Camp_Logradouro
            // 
            this.Camp_Logradouro.Location = new System.Drawing.Point(79, 172);
            this.Camp_Logradouro.Name = "Camp_Logradouro";
            this.Camp_Logradouro.ReadOnly = true;
            this.Camp_Logradouro.Size = new System.Drawing.Size(171, 20);
            this.Camp_Logradouro.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "UF";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Número";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "País";
            // 
            // Camp_GeoLoc
            // 
            this.Camp_GeoLoc.Location = new System.Drawing.Point(79, 250);
            this.Camp_GeoLoc.Name = "Camp_GeoLoc";
            this.Camp_GeoLoc.ReadOnly = true;
            this.Camp_GeoLoc.Size = new System.Drawing.Size(171, 20);
            this.Camp_GeoLoc.TabIndex = 10;
            // 
            // Camp_Complemento
            // 
            this.Camp_Complemento.Location = new System.Drawing.Point(79, 224);
            this.Camp_Complemento.Name = "Camp_Complemento";
            this.Camp_Complemento.ReadOnly = true;
            this.Camp_Complemento.Size = new System.Drawing.Size(171, 20);
            this.Camp_Complemento.TabIndex = 9;
            // 
            // Camp_Numero
            // 
            this.Camp_Numero.Location = new System.Drawing.Point(79, 198);
            this.Camp_Numero.Name = "Camp_Numero";
            this.Camp_Numero.ReadOnly = true;
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
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 341);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(283, 22);
            this.statusBar.TabIndex = 33;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatus.Text = "status";
            // 
            // Camp_UF
            // 
            this.Camp_UF.Location = new System.Drawing.Point(79, 65);
            this.Camp_UF.Name = "Camp_UF";
            this.Camp_UF.ReadOnly = true;
            this.Camp_UF.Size = new System.Drawing.Size(171, 20);
            this.Camp_UF.TabIndex = 3;
            // 
            // Camp_Cidade
            // 
            this.Camp_Cidade.Location = new System.Drawing.Point(79, 93);
            this.Camp_Cidade.Name = "Camp_Cidade";
            this.Camp_Cidade.ReadOnly = true;
            this.Camp_Cidade.Size = new System.Drawing.Size(171, 20);
            this.Camp_Cidade.TabIndex = 4;
            // 
            // Camp_TipoLogr
            // 
            this.Camp_TipoLogr.Location = new System.Drawing.Point(79, 145);
            this.Camp_TipoLogr.Name = "Camp_TipoLogr";
            this.Camp_TipoLogr.ReadOnly = true;
            this.Camp_TipoLogr.Size = new System.Drawing.Size(171, 20);
            this.Camp_TipoLogr.TabIndex = 6;
            // 
            // formEnderecoVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_Opcoes);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.statusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formEnderecoVisualizar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes do endereço";
            this.Load += new System.EventHandler(this.formEnderecoVisualizar_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_Opcoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Camp_CEP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Camp_Bairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Camp_Logradouro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Camp_GeoLoc;
        private System.Windows.Forms.TextBox Camp_Complemento;
        private System.Windows.Forms.TextBox Camp_Numero;
        private System.Windows.Forms.TextBox Camp_Pais;
        private System.Windows.Forms.TextBox Camp_Cidade;
        private System.Windows.Forms.TextBox Camp_TipoLogr;
        private System.Windows.Forms.TextBox Camp_UF;
    }
}