namespace Apresentacao.Forms.Cliente
{
    partial class formClienteVisualizar
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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.campLimiteParcelamentoAberto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.campLimiteCredito = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.campEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.campTelAlternativo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.campTelMovel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.campTelPrincipal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.campCodigoEndereco = new System.Windows.Forms.TextBox();
            this.Camp_CEP = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Camp_TipoLogr = new System.Windows.Forms.TextBox();
            this.Camp_Bairro = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.campGeoLoc = new System.Windows.Forms.TextBox();
            this.campLogradouro = new System.Windows.Forms.TextBox();
            this.Camp_Cidade = new System.Windows.Forms.TextBox();
            this.Camp_UF = new System.Windows.Forms.TextBox();
            this.Camp_Numero = new System.Windows.Forms.TextBox();
            this.Camp_Pais = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.campDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.campNome = new System.Windows.Forms.TextBox();
            this.campNomeMae = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.campRG = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.campCPF = new System.Windows.Forms.TextBox();
            this.fotoCliente = new System.Windows.Forms.PictureBox();
            this.campSexo = new System.Windows.Forms.TextBox();
            this.campStatusInicial = new System.Windows.Forms.TextBox();
            this.campStatusMotivo = new System.Windows.Forms.TextBox();
            this.statusBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campLimiteCredito)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 33;
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
            this.cbox_Opcoes.Size = new System.Drawing.Size(274, 21);
            this.cbox_Opcoes.TabIndex = 32;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 554);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(794, 22);
            this.statusBar.TabIndex = 42;
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
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.fotoCliente);
            this.groupBox1.Location = new System.Drawing.Point(15, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 488);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 406);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(556, 69);
            this.textBox6.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Observações";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.campStatusMotivo);
            this.groupBox5.Controls.Add(this.campStatusInicial);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Location = new System.Drawing.Point(568, 368);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(188, 107);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "Status Inicial";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Motivo Status";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.campLimiteParcelamentoAberto);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.campLimiteCredito);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(568, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 105);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // campLimiteParcelamentoAberto
            // 
            this.campLimiteParcelamentoAberto.Location = new System.Drawing.Point(9, 71);
            this.campLimiteParcelamentoAberto.Name = "campLimiteParcelamentoAberto";
            this.campLimiteParcelamentoAberto.ReadOnly = true;
            this.campLimiteParcelamentoAberto.Size = new System.Drawing.Size(169, 20);
            this.campLimiteParcelamentoAberto.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Limite de Parcelamentos em aberto";
            // 
            // campLimiteCredito
            // 
            this.campLimiteCredito.DecimalPlaces = 2;
            this.campLimiteCredito.Location = new System.Drawing.Point(9, 32);
            this.campLimiteCredito.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.campLimiteCredito.Name = "campLimiteCredito";
            this.campLimiteCredito.ReadOnly = true;
            this.campLimiteCredito.Size = new System.Drawing.Size(169, 20);
            this.campLimiteCredito.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Limite de Credito";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.campEmail);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.campTelAlternativo);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.campTelMovel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.campTelPrincipal);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(6, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(556, 69);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // campEmail
            // 
            this.campEmail.Location = new System.Drawing.Point(381, 32);
            this.campEmail.Name = "campEmail";
            this.campEmail.ReadOnly = true;
            this.campEmail.Size = new System.Drawing.Size(166, 20);
            this.campEmail.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(378, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Email";
            // 
            // campTelAlternativo
            // 
            this.campTelAlternativo.Location = new System.Drawing.Point(257, 32);
            this.campTelAlternativo.Name = "campTelAlternativo";
            this.campTelAlternativo.ReadOnly = true;
            this.campTelAlternativo.Size = new System.Drawing.Size(118, 20);
            this.campTelAlternativo.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Telefone Alternativo";
            // 
            // campTelMovel
            // 
            this.campTelMovel.Location = new System.Drawing.Point(133, 32);
            this.campTelMovel.Name = "campTelMovel";
            this.campTelMovel.ReadOnly = true;
            this.campTelMovel.Size = new System.Drawing.Size(118, 20);
            this.campTelMovel.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Telefone Movel";
            // 
            // campTelPrincipal
            // 
            this.campTelPrincipal.Location = new System.Drawing.Point(9, 32);
            this.campTelPrincipal.Name = "campTelPrincipal";
            this.campTelPrincipal.ReadOnly = true;
            this.campTelPrincipal.Size = new System.Drawing.Size(118, 20);
            this.campTelPrincipal.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefone Principal";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.campCodigoEndereco);
            this.groupBox8.Controls.Add(this.Camp_CEP);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.Camp_TipoLogr);
            this.groupBox8.Controls.Add(this.Camp_Bairro);
            this.groupBox8.Controls.Add(this.label29);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Controls.Add(this.campGeoLoc);
            this.groupBox8.Controls.Add(this.campLogradouro);
            this.groupBox8.Controls.Add(this.Camp_Cidade);
            this.groupBox8.Controls.Add(this.Camp_UF);
            this.groupBox8.Controls.Add(this.Camp_Numero);
            this.groupBox8.Controls.Add(this.Camp_Pais);
            this.groupBox8.Location = new System.Drawing.Point(6, 206);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(556, 181);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(104, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Código do Endereço";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "CEP";
            // 
            // campCodigoEndereco
            // 
            this.campCodigoEndereco.Location = new System.Drawing.Point(9, 32);
            this.campCodigoEndereco.Name = "campCodigoEndereco";
            this.campCodigoEndereco.ReadOnly = true;
            this.campCodigoEndereco.Size = new System.Drawing.Size(537, 20);
            this.campCodigoEndereco.TabIndex = 10;
            // 
            // Camp_CEP
            // 
            this.Camp_CEP.Location = new System.Drawing.Point(11, 71);
            this.Camp_CEP.Name = "Camp_CEP";
            this.Camp_CEP.ReadOnly = true;
            this.Camp_CEP.Size = new System.Drawing.Size(103, 20);
            this.Camp_CEP.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(188, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Tipo Logr";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Bairro";
            // 
            // Camp_TipoLogr
            // 
            this.Camp_TipoLogr.Location = new System.Drawing.Point(191, 110);
            this.Camp_TipoLogr.Name = "Camp_TipoLogr";
            this.Camp_TipoLogr.ReadOnly = true;
            this.Camp_TipoLogr.Size = new System.Drawing.Size(72, 20);
            this.Camp_TipoLogr.TabIndex = 17;
            // 
            // Camp_Bairro
            // 
            this.Camp_Bairro.Location = new System.Drawing.Point(13, 110);
            this.Camp_Bairro.Name = "Camp_Bairro";
            this.Camp_Bairro.ReadOnly = true;
            this.Camp_Bairro.Size = new System.Drawing.Size(171, 20);
            this.Camp_Bairro.TabIndex = 16;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(266, 95);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(61, 13);
            this.label29.TabIndex = 3;
            this.label29.Text = "Logradouro";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(297, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Cidade";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(228, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "UF";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(124, 133);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Geo Loc";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 133);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Número";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(119, 55);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "País";
            // 
            // campGeoLoc
            // 
            this.campGeoLoc.Location = new System.Drawing.Point(127, 149);
            this.campGeoLoc.Name = "campGeoLoc";
            this.campGeoLoc.ReadOnly = true;
            this.campGeoLoc.Size = new System.Drawing.Size(419, 20);
            this.campGeoLoc.TabIndex = 20;
            // 
            // campLogradouro
            // 
            this.campLogradouro.Location = new System.Drawing.Point(269, 110);
            this.campLogradouro.Name = "campLogradouro";
            this.campLogradouro.ReadOnly = true;
            this.campLogradouro.Size = new System.Drawing.Size(277, 20);
            this.campLogradouro.TabIndex = 18;
            // 
            // Camp_Cidade
            // 
            this.Camp_Cidade.Location = new System.Drawing.Point(300, 70);
            this.Camp_Cidade.Name = "Camp_Cidade";
            this.Camp_Cidade.ReadOnly = true;
            this.Camp_Cidade.Size = new System.Drawing.Size(246, 20);
            this.Camp_Cidade.TabIndex = 15;
            // 
            // Camp_UF
            // 
            this.Camp_UF.Location = new System.Drawing.Point(231, 70);
            this.Camp_UF.Name = "Camp_UF";
            this.Camp_UF.ReadOnly = true;
            this.Camp_UF.Size = new System.Drawing.Size(63, 20);
            this.Camp_UF.TabIndex = 14;
            // 
            // Camp_Numero
            // 
            this.Camp_Numero.Location = new System.Drawing.Point(13, 149);
            this.Camp_Numero.Name = "Camp_Numero";
            this.Camp_Numero.ReadOnly = true;
            this.Camp_Numero.Size = new System.Drawing.Size(103, 20);
            this.Camp_Numero.TabIndex = 19;
            // 
            // Camp_Pais
            // 
            this.Camp_Pais.Location = new System.Drawing.Point(122, 71);
            this.Camp_Pais.Name = "Camp_Pais";
            this.Camp_Pais.ReadOnly = true;
            this.Camp_Pais.Size = new System.Drawing.Size(103, 20);
            this.Camp_Pais.TabIndex = 13;
            this.Camp_Pais.Text = "Brasil";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.campDataNasc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.campNome);
            this.groupBox2.Controls.Add(this.campNomeMae);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.campSexo);
            this.groupBox2.Controls.Add(this.campRG);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.campCPF);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sexo";
            // 
            // campDataNasc
            // 
            this.campDataNasc.Location = new System.Drawing.Point(281, 71);
            this.campDataNasc.Mask = "00/00/0000";
            this.campDataNasc.Name = "campDataNasc";
            this.campDataNasc.ReadOnly = true;
            this.campDataNasc.Size = new System.Drawing.Size(135, 20);
            this.campDataNasc.TabIndex = 5;
            this.campDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Data de Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome Completo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome Completo da Mãe";
            // 
            // campNome
            // 
            this.campNome.Location = new System.Drawing.Point(9, 32);
            this.campNome.Name = "campNome";
            this.campNome.ReadOnly = true;
            this.campNome.Size = new System.Drawing.Size(266, 20);
            this.campNome.TabIndex = 1;
            // 
            // campNomeMae
            // 
            this.campNomeMae.Location = new System.Drawing.Point(9, 71);
            this.campNomeMae.Name = "campNomeMae";
            this.campNomeMae.ReadOnly = true;
            this.campNomeMae.Size = new System.Drawing.Size(266, 20);
            this.campNomeMae.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "RG";
            // 
            // campRG
            // 
            this.campRG.Location = new System.Drawing.Point(422, 32);
            this.campRG.Name = "campRG";
            this.campRG.ReadOnly = true;
            this.campRG.Size = new System.Drawing.Size(125, 20);
            this.campRG.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(278, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "CPF";
            // 
            // campCPF
            // 
            this.campCPF.Location = new System.Drawing.Point(281, 32);
            this.campCPF.Name = "campCPF";
            this.campCPF.ReadOnly = true;
            this.campCPF.Size = new System.Drawing.Size(135, 20);
            this.campCPF.TabIndex = 2;
            // 
            // fotoCliente
            // 
            this.fotoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoCliente.Location = new System.Drawing.Point(568, 35);
            this.fotoCliente.Name = "fotoCliente";
            this.fotoCliente.Size = new System.Drawing.Size(188, 223);
            this.fotoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoCliente.TabIndex = 1;
            this.fotoCliente.TabStop = false;
            // 
            // campSexo
            // 
            this.campSexo.Location = new System.Drawing.Point(422, 71);
            this.campSexo.Name = "campSexo";
            this.campSexo.ReadOnly = true;
            this.campSexo.Size = new System.Drawing.Size(125, 20);
            this.campSexo.TabIndex = 6;
            // 
            // campStatusInicial
            // 
            this.campStatusInicial.Location = new System.Drawing.Point(9, 33);
            this.campStatusInicial.Name = "campStatusInicial";
            this.campStatusInicial.ReadOnly = true;
            this.campStatusInicial.Size = new System.Drawing.Size(166, 20);
            this.campStatusInicial.TabIndex = 25;
            // 
            // campStatusMotivo
            // 
            this.campStatusMotivo.Location = new System.Drawing.Point(9, 72);
            this.campStatusMotivo.Name = "campStatusMotivo";
            this.campStatusMotivo.ReadOnly = true;
            this.campStatusMotivo.Size = new System.Drawing.Size(166, 20);
            this.campStatusMotivo.TabIndex = 26;
            // 
            // formClienteVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 576);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_Opcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formClienteVisualizar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes do Cliente";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campLimiteCredito)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_Opcoes;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox campLimiteParcelamentoAberto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown campLimiteCredito;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox campEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox campTelAlternativo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox campTelMovel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox campTelPrincipal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox campCodigoEndereco;
        private System.Windows.Forms.TextBox Camp_CEP;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Camp_TipoLogr;
        private System.Windows.Forms.TextBox Camp_Bairro;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox campGeoLoc;
        private System.Windows.Forms.TextBox campLogradouro;
        private System.Windows.Forms.TextBox Camp_Cidade;
        private System.Windows.Forms.TextBox Camp_UF;
        private System.Windows.Forms.TextBox Camp_Numero;
        private System.Windows.Forms.TextBox Camp_Pais;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox campDataNasc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox campNome;
        private System.Windows.Forms.TextBox campNomeMae;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campRG;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox campCPF;
        private System.Windows.Forms.PictureBox fotoCliente;
        private System.Windows.Forms.TextBox campStatusMotivo;
        private System.Windows.Forms.TextBox campStatusInicial;
        private System.Windows.Forms.TextBox campSexo;
    }
}