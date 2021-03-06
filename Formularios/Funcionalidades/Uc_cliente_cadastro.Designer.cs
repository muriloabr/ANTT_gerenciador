namespace gerenciador_antt.Formularios
{
    partial class Uc_cliente_cadastro
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_cadastrar_cliente = new System.Windows.Forms.Button();
            this.lbl_apelido = new System.Windows.Forms.Label();
            this.txt_apelido_pf = new System.Windows.Forms.TextBox();
            this.msktxt_rntrc_pf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nome_pf = new System.Windows.Forms.TextBox();
            this.msktxt_rg_pf = new System.Windows.Forms.MaskedTextBox();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.msktxt_cpf_pf = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_pessoaFisica = new System.Windows.Forms.RadioButton();
            this.rbtn_pessoaJuridica = new System.Windows.Forms.RadioButton();
            this.dtpckr_dataNascimento_pf = new System.Windows.Forms.DateTimePicker();
            this.lbl_data_nascimento = new System.Windows.Forms.Label();
            this.gbx_dadosCliente_fisica = new System.Windows.Forms.GroupBox();
            this.gbx_contatoCliente = new System.Windows.Forms.GroupBox();
            this.cbx_tipo_contato = new System.Windows.Forms.ComboBox();
            this.msktxt_contato = new System.Windows.Forms.MaskedTextBox();
            this.btn_adicionarContato = new System.Windows.Forms.Button();
            this.gbx_contatosAdicionados = new System.Windows.Forms.GroupBox();
            this.pnl_contatos = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbx_enderecos = new System.Windows.Forms.GroupBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.cbx_tipo_endereco = new System.Windows.Forms.ComboBox();
            this.btn_gerarBaseEndereco = new System.Windows.Forms.Button();
            this.btn_adicionarEndereco = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.gbx_enderecosAdicionados = new System.Windows.Forms.GroupBox();
            this.pnl_enderecos = new System.Windows.Forms.Panel();
            this.txt_observacao = new System.Windows.Forms.TextBox();
            this.gbx_obs = new System.Windows.Forms.GroupBox();
            this.gbx_dadosCliente_juridica = new System.Windows.Forms.GroupBox();
            this.msktxt_cnpj_pj = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpckr_data_abertura_pj = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nomeFantasia_pj = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.msktxt_rntrc_pj = new System.Windows.Forms.MaskedTextBox();
            this.msktxt_ie_pj = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_razaoSocial_pf = new System.Windows.Forms.TextBox();
            this.erros = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_fechar = new System.Windows.Forms.Button();
            this.pnl_centro = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_codigo_nomenclatura = new System.Windows.Forms.Label();
            this.lbl_codigo_numero = new System.Windows.Forms.Label();
            this.pnl_fechar = new System.Windows.Forms.Panel();
            this.lbl_fechar = new System.Windows.Forms.Label();
            this.gbx_dadosCliente_fisica.SuspendLayout();
            this.gbx_contatoCliente.SuspendLayout();
            this.gbx_contatosAdicionados.SuspendLayout();
            this.gbx_enderecos.SuspendLayout();
            this.gbx_enderecosAdicionados.SuspendLayout();
            this.gbx_obs.SuspendLayout();
            this.gbx_dadosCliente_juridica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).BeginInit();
            this.pnl_centro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnl_fechar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cadastrar_cliente
            // 
            this.btn_cadastrar_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cadastrar_cliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cadastrar_cliente.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_cadastrar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar_cliente.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.btn_cadastrar_cliente.ForeColor = System.Drawing.Color.White;
            this.erros.SetIconAlignment(this.btn_cadastrar_cliente, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.btn_cadastrar_cliente.Image = global::gerenciador_antt.Properties.Resources.user;
            this.btn_cadastrar_cliente.Location = new System.Drawing.Point(684, 433);
            this.btn_cadastrar_cliente.Name = "btn_cadastrar_cliente";
            this.btn_cadastrar_cliente.Size = new System.Drawing.Size(310, 215);
            this.btn_cadastrar_cliente.TabIndex = 15;
            this.btn_cadastrar_cliente.Text = "Cadastrar";
            this.btn_cadastrar_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cadastrar_cliente.UseVisualStyleBackColor = false;
            this.btn_cadastrar_cliente.Click += new System.EventHandler(this.btn_cadastrar_cliente_Click);
            // 
            // lbl_apelido
            // 
            this.lbl_apelido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apelido.AutoSize = true;
            this.lbl_apelido.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_apelido.ForeColor = System.Drawing.Color.Black;
            this.lbl_apelido.Location = new System.Drawing.Point(715, 39);
            this.lbl_apelido.Name = "lbl_apelido";
            this.lbl_apelido.Size = new System.Drawing.Size(66, 21);
            this.lbl_apelido.TabIndex = 6;
            this.lbl_apelido.Text = "Apelido:";
            // 
            // txt_apelido_pf
            // 
            this.txt_apelido_pf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_apelido_pf.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_apelido_pf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apelido_pf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_apelido_pf.Location = new System.Drawing.Point(784, 38);
            this.txt_apelido_pf.Name = "txt_apelido_pf";
            this.txt_apelido_pf.Size = new System.Drawing.Size(183, 22);
            this.txt_apelido_pf.TabIndex = 2;
            // 
            // msktxt_rntrc_pf
            // 
            this.msktxt_rntrc_pf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.msktxt_rntrc_pf.BackColor = System.Drawing.Color.Gainsboro;
            this.msktxt_rntrc_pf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msktxt_rntrc_pf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msktxt_rntrc_pf.Location = new System.Drawing.Point(795, 88);
            this.msktxt_rntrc_pf.Mask = "AAA-00000000";
            this.msktxt_rntrc_pf.Name = "msktxt_rntrc_pf";
            this.msktxt_rntrc_pf.Size = new System.Drawing.Size(170, 22);
            this.msktxt_rntrc_pf.TabIndex = 6;
            this.msktxt_rntrc_pf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msktxt_rntrc_pf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.msktxt_rntrc_pf.Validated += new System.EventHandler(this.msktxt_rntrc_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(729, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "RNTRC:";
            // 
            // txt_nome_pf
            // 
            this.txt_nome_pf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nome_pf.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_nome_pf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome_pf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_nome_pf.Location = new System.Drawing.Point(56, 38);
            this.txt_nome_pf.Name = "txt_nome_pf";
            this.txt_nome_pf.Size = new System.Drawing.Size(631, 22);
            this.txt_nome_pf.TabIndex = 1;
            // 
            // msktxt_rg_pf
            // 
            this.msktxt_rg_pf.BackColor = System.Drawing.Color.Gainsboro;
            this.msktxt_rg_pf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msktxt_rg_pf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msktxt_rg_pf.Location = new System.Drawing.Point(343, 88);
            this.msktxt_rg_pf.Mask = "00,000,000-00";
            this.msktxt_rg_pf.Name = "msktxt_rg_pf";
            this.msktxt_rg_pf.Size = new System.Drawing.Size(144, 22);
            this.msktxt_rg_pf.TabIndex = 4;
            this.msktxt_rg_pf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_rg
            // 
            this.lbl_rg.AutoSize = true;
            this.lbl_rg.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_rg.ForeColor = System.Drawing.Color.Black;
            this.lbl_rg.Location = new System.Drawing.Point(306, 89);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(34, 21);
            this.lbl_rg.TabIndex = 0;
            this.lbl_rg.Text = "RG:";
            // 
            // msktxt_cpf_pf
            // 
            this.msktxt_cpf_pf.BackColor = System.Drawing.Color.Gainsboro;
            this.msktxt_cpf_pf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msktxt_cpf_pf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msktxt_cpf_pf.Location = new System.Drawing.Point(565, 88);
            this.msktxt_cpf_pf.Mask = "000,000,000-00";
            this.msktxt_cpf_pf.Name = "msktxt_cpf_pf";
            this.msktxt_cpf_pf.Size = new System.Drawing.Size(132, 22);
            this.msktxt_cpf_pf.TabIndex = 5;
            this.msktxt_cpf_pf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_cpf.ForeColor = System.Drawing.Color.Black;
            this.lbl_cpf.Location = new System.Drawing.Point(522, 89);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(40, 21);
            this.lbl_cpf.TabIndex = 0;
            this.lbl_cpf.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // rbtn_pessoaFisica
            // 
            this.rbtn_pessoaFisica.AutoSize = true;
            this.rbtn_pessoaFisica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rbtn_pessoaFisica.Checked = true;
            this.rbtn_pessoaFisica.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rbtn_pessoaFisica.Location = new System.Drawing.Point(154, 9);
            this.rbtn_pessoaFisica.Name = "rbtn_pessoaFisica";
            this.rbtn_pessoaFisica.Size = new System.Drawing.Size(118, 25);
            this.rbtn_pessoaFisica.TabIndex = 0;
            this.rbtn_pessoaFisica.TabStop = true;
            this.rbtn_pessoaFisica.Text = "Pessoa Física";
            this.rbtn_pessoaFisica.UseVisualStyleBackColor = false;
            this.rbtn_pessoaFisica.CheckedChanged += new System.EventHandler(this.rbtn_pessoaFisica_CheckedChanged);
            // 
            // rbtn_pessoaJuridica
            // 
            this.rbtn_pessoaJuridica.AutoSize = true;
            this.rbtn_pessoaJuridica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rbtn_pessoaJuridica.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rbtn_pessoaJuridica.Location = new System.Drawing.Point(283, 9);
            this.rbtn_pessoaJuridica.Name = "rbtn_pessoaJuridica";
            this.rbtn_pessoaJuridica.Size = new System.Drawing.Size(133, 25);
            this.rbtn_pessoaJuridica.TabIndex = 0;
            this.rbtn_pessoaJuridica.TabStop = true;
            this.rbtn_pessoaJuridica.Text = "Pessoa Jurídica";
            this.rbtn_pessoaJuridica.UseVisualStyleBackColor = false;
            this.rbtn_pessoaJuridica.CheckedChanged += new System.EventHandler(this.rbtn_pessoaJuridica_CheckedChanged);
            // 
            // dtpckr_dataNascimento_pf
            // 
            this.dtpckr_dataNascimento_pf.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpckr_dataNascimento_pf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpckr_dataNascimento_pf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpckr_dataNascimento_pf.Location = new System.Drawing.Point(159, 85);
            this.dtpckr_dataNascimento_pf.Name = "dtpckr_dataNascimento_pf";
            this.dtpckr_dataNascimento_pf.Size = new System.Drawing.Size(113, 29);
            this.dtpckr_dataNascimento_pf.TabIndex = 3;
            this.dtpckr_dataNascimento_pf.Value = new System.DateTime(2014, 11, 18, 0, 0, 0, 0);
            // 
            // lbl_data_nascimento
            // 
            this.lbl_data_nascimento.AutoSize = true;
            this.lbl_data_nascimento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_data_nascimento.ForeColor = System.Drawing.Color.Black;
            this.lbl_data_nascimento.Location = new System.Drawing.Point(3, 89);
            this.lbl_data_nascimento.Name = "lbl_data_nascimento";
            this.lbl_data_nascimento.Size = new System.Drawing.Size(153, 21);
            this.lbl_data_nascimento.TabIndex = 8;
            this.lbl_data_nascimento.Text = "Data de Nascimento:";
            // 
            // gbx_dadosCliente_fisica
            // 
            this.gbx_dadosCliente_fisica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_dadosCliente_fisica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbx_dadosCliente_fisica.Controls.Add(this.dtpckr_dataNascimento_pf);
            this.gbx_dadosCliente_fisica.Controls.Add(this.msktxt_rntrc_pf);
            this.gbx_dadosCliente_fisica.Controls.Add(this.txt_apelido_pf);
            this.gbx_dadosCliente_fisica.Controls.Add(this.msktxt_cpf_pf);
            this.gbx_dadosCliente_fisica.Controls.Add(this.msktxt_rg_pf);
            this.gbx_dadosCliente_fisica.Controls.Add(this.txt_nome_pf);
            this.gbx_dadosCliente_fisica.Controls.Add(this.label1);
            this.gbx_dadosCliente_fisica.Controls.Add(this.lbl_cpf);
            this.gbx_dadosCliente_fisica.Controls.Add(this.lbl_apelido);
            this.gbx_dadosCliente_fisica.Controls.Add(this.label4);
            this.gbx_dadosCliente_fisica.Controls.Add(this.lbl_data_nascimento);
            this.gbx_dadosCliente_fisica.Controls.Add(this.lbl_rg);
            this.gbx_dadosCliente_fisica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbx_dadosCliente_fisica.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gbx_dadosCliente_fisica.ForeColor = System.Drawing.Color.DimGray;
            this.gbx_dadosCliente_fisica.Location = new System.Drawing.Point(9, 41);
            this.gbx_dadosCliente_fisica.Name = "gbx_dadosCliente_fisica";
            this.gbx_dadosCliente_fisica.Size = new System.Drawing.Size(985, 136);
            this.gbx_dadosCliente_fisica.TabIndex = 0;
            this.gbx_dadosCliente_fisica.TabStop = false;
            this.gbx_dadosCliente_fisica.Text = "Dados";
            // 
            // gbx_contatoCliente
            // 
            this.gbx_contatoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_contatoCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbx_contatoCliente.Controls.Add(this.cbx_tipo_contato);
            this.gbx_contatoCliente.Controls.Add(this.msktxt_contato);
            this.gbx_contatoCliente.Controls.Add(this.btn_adicionarContato);
            this.gbx_contatoCliente.Controls.Add(this.gbx_contatosAdicionados);
            this.gbx_contatoCliente.Controls.Add(this.label8);
            this.gbx_contatoCliente.Controls.Add(this.label7);
            this.gbx_contatoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbx_contatoCliente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gbx_contatoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.gbx_contatoCliente.Location = new System.Drawing.Point(9, 183);
            this.gbx_contatoCliente.Name = "gbx_contatoCliente";
            this.gbx_contatoCliente.Size = new System.Drawing.Size(307, 465);
            this.gbx_contatoCliente.TabIndex = 5;
            this.gbx_contatoCliente.TabStop = false;
            this.gbx_contatoCliente.Text = "Contato";
            this.gbx_contatoCliente.SizeChanged += new System.EventHandler(this.gbx_contatoCliente_SizeChanged);
            // 
            // cbx_tipo_contato
            // 
            this.cbx_tipo_contato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_tipo_contato.BackColor = System.Drawing.Color.Gainsboro;
            this.cbx_tipo_contato.DisplayMember = "nome_tipo_contato";
            this.cbx_tipo_contato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo_contato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_tipo_contato.FormattingEnabled = true;
            this.cbx_tipo_contato.Location = new System.Drawing.Point(56, 35);
            this.cbx_tipo_contato.Name = "cbx_tipo_contato";
            this.cbx_tipo_contato.Size = new System.Drawing.Size(241, 29);
            this.cbx_tipo_contato.TabIndex = 7;
            this.cbx_tipo_contato.ValueMember = "cod_tipo_contato_pk";
            this.cbx_tipo_contato.DataSourceChanged += new System.EventHandler(this.cbx_tipo_contato_DataSourceChanged);
            this.cbx_tipo_contato.SelectedIndexChanged += new System.EventHandler(this.cbx_tipo_contato_SelectedIndexChanged);
            // 
            // msktxt_contato
            // 
            this.msktxt_contato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.msktxt_contato.BackColor = System.Drawing.Color.WhiteSmoke;
            this.msktxt_contato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msktxt_contato.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msktxt_contato.Location = new System.Drawing.Point(73, 73);
            this.msktxt_contato.Mask = "(99)9999-99999";
            this.msktxt_contato.Name = "msktxt_contato";
            this.msktxt_contato.Size = new System.Drawing.Size(224, 29);
            this.msktxt_contato.TabIndex = 8;
            // 
            // btn_adicionarContato
            // 
            this.btn_adicionarContato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_adicionarContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btn_adicionarContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionarContato.ForeColor = System.Drawing.Color.White;
            this.btn_adicionarContato.Location = new System.Drawing.Point(6, 110);
            this.btn_adicionarContato.Name = "btn_adicionarContato";
            this.btn_adicionarContato.Size = new System.Drawing.Size(291, 36);
            this.btn_adicionarContato.TabIndex = 9;
            this.btn_adicionarContato.Text = "Adicionar Contato↴";
            this.btn_adicionarContato.UseVisualStyleBackColor = false;
            this.btn_adicionarContato.Click += new System.EventHandler(this.btn_adicionarContato_Click);
            // 
            // gbx_contatosAdicionados
            // 
            this.gbx_contatosAdicionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_contatosAdicionados.Controls.Add(this.pnl_contatos);
            this.gbx_contatosAdicionados.ForeColor = System.Drawing.Color.Gray;
            this.gbx_contatosAdicionados.Location = new System.Drawing.Point(6, 152);
            this.gbx_contatosAdicionados.Name = "gbx_contatosAdicionados";
            this.gbx_contatosAdicionados.Size = new System.Drawing.Size(301, 313);
            this.gbx_contatosAdicionados.TabIndex = 8;
            this.gbx_contatosAdicionados.TabStop = false;
            this.gbx_contatosAdicionados.Text = "Lista de Contatos";
            // 
            // pnl_contatos
            // 
            this.pnl_contatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_contatos.AutoScroll = true;
            this.pnl_contatos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_contatos.ForeColor = System.Drawing.Color.Black;
            this.erros.SetIconAlignment(this.pnl_contatos, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.pnl_contatos.Location = new System.Drawing.Point(4, 28);
            this.pnl_contatos.Name = "pnl_contatos";
            this.pnl_contatos.Size = new System.Drawing.Size(273, 279);
            this.pnl_contatos.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Contato:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tipo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label9.Location = new System.Drawing.Point(267, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "|";
            // 
            // gbx_enderecos
            // 
            this.gbx_enderecos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_enderecos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbx_enderecos.Controls.Add(this.txt_endereco);
            this.gbx_enderecos.Controls.Add(this.cbx_tipo_endereco);
            this.gbx_enderecos.Controls.Add(this.btn_gerarBaseEndereco);
            this.gbx_enderecos.Controls.Add(this.btn_adicionarEndereco);
            this.gbx_enderecos.Controls.Add(this.label10);
            this.gbx_enderecos.Controls.Add(this.gbx_enderecosAdicionados);
            this.gbx_enderecos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbx_enderecos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gbx_enderecos.ForeColor = System.Drawing.Color.DimGray;
            this.gbx_enderecos.Location = new System.Drawing.Point(322, 183);
            this.gbx_enderecos.Name = "gbx_enderecos";
            this.gbx_enderecos.Size = new System.Drawing.Size(350, 465);
            this.gbx_enderecos.TabIndex = 10;
            this.gbx_enderecos.TabStop = false;
            this.gbx_enderecos.Text = "Endereço";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_endereco.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_endereco.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_endereco.Location = new System.Drawing.Point(83, 70);
            this.txt_endereco.Multiline = true;
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_endereco.Size = new System.Drawing.Size(253, 172);
            this.txt_endereco.TabIndex = 12;
            // 
            // cbx_tipo_endereco
            // 
            this.cbx_tipo_endereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_tipo_endereco.BackColor = System.Drawing.Color.Gainsboro;
            this.cbx_tipo_endereco.DisplayMember = "nome_tipo_endereco";
            this.cbx_tipo_endereco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo_endereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_tipo_endereco.FormattingEnabled = true;
            this.cbx_tipo_endereco.Location = new System.Drawing.Point(51, 35);
            this.cbx_tipo_endereco.Name = "cbx_tipo_endereco";
            this.cbx_tipo_endereco.Size = new System.Drawing.Size(285, 29);
            this.cbx_tipo_endereco.TabIndex = 10;
            this.cbx_tipo_endereco.ValueMember = "cod_tipo_endereco_pk";
            // 
            // btn_gerarBaseEndereco
            // 
            this.btn_gerarBaseEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btn_gerarBaseEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gerarBaseEndereco.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_gerarBaseEndereco.ForeColor = System.Drawing.Color.White;
            this.btn_gerarBaseEndereco.Location = new System.Drawing.Point(12, 70);
            this.btn_gerarBaseEndereco.Name = "btn_gerarBaseEndereco";
            this.btn_gerarBaseEndereco.Size = new System.Drawing.Size(65, 173);
            this.btn_gerarBaseEndereco.TabIndex = 11;
            this.btn_gerarBaseEndereco.Text = ">> Gerar Base >>";
            this.btn_gerarBaseEndereco.UseVisualStyleBackColor = false;
            this.btn_gerarBaseEndereco.Click += new System.EventHandler(this.btn_gerarBaseEndereco_Click);
            // 
            // btn_adicionarEndereco
            // 
            this.btn_adicionarEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_adicionarEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btn_adicionarEndereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_adicionarEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionarEndereco.ForeColor = System.Drawing.Color.White;
            this.btn_adicionarEndereco.Location = new System.Drawing.Point(12, 249);
            this.btn_adicionarEndereco.Name = "btn_adicionarEndereco";
            this.btn_adicionarEndereco.Size = new System.Drawing.Size(324, 51);
            this.btn_adicionarEndereco.TabIndex = 13;
            this.btn_adicionarEndereco.Text = "Adicionar Endereço↴";
            this.btn_adicionarEndereco.UseVisualStyleBackColor = false;
            this.btn_adicionarEndereco.Click += new System.EventHandler(this.btn_adicionarEndereco_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tipo:";
            // 
            // gbx_enderecosAdicionados
            // 
            this.gbx_enderecosAdicionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_enderecosAdicionados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbx_enderecosAdicionados.Controls.Add(this.pnl_enderecos);
            this.gbx_enderecosAdicionados.ForeColor = System.Drawing.Color.DimGray;
            this.gbx_enderecosAdicionados.Location = new System.Drawing.Point(0, 302);
            this.gbx_enderecosAdicionados.Name = "gbx_enderecosAdicionados";
            this.gbx_enderecosAdicionados.Size = new System.Drawing.Size(350, 163);
            this.gbx_enderecosAdicionados.TabIndex = 8;
            this.gbx_enderecosAdicionados.TabStop = false;
            this.gbx_enderecosAdicionados.Text = "Lista de Endereços";
            // 
            // pnl_enderecos
            // 
            this.pnl_enderecos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_enderecos.AutoScroll = true;
            this.pnl_enderecos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_enderecos.ForeColor = System.Drawing.Color.Black;
            this.erros.SetIconAlignment(this.pnl_enderecos, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.pnl_enderecos.Location = new System.Drawing.Point(9, 27);
            this.pnl_enderecos.Name = "pnl_enderecos";
            this.pnl_enderecos.Size = new System.Drawing.Size(316, 130);
            this.pnl_enderecos.TabIndex = 1;
            // 
            // txt_observacao
            // 
            this.txt_observacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_observacao.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_observacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_observacao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_observacao.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_observacao.Location = new System.Drawing.Point(6, 33);
            this.txt_observacao.Multiline = true;
            this.txt_observacao.Name = "txt_observacao";
            this.txt_observacao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_observacao.Size = new System.Drawing.Size(296, 209);
            this.txt_observacao.TabIndex = 14;
            this.txt_observacao.Text = "Observações...";
            this.txt_observacao.TextChanged += new System.EventHandler(this.txt_observacao_TextChanged);
            this.txt_observacao.Validated += new System.EventHandler(this.txt_observacao_Validated);
            this.txt_observacao.Leave += new System.EventHandler(this.txt_observacao_Leave);
            this.txt_observacao.Enter += new System.EventHandler(this.txt_observacao_Enter);
            // 
            // gbx_obs
            // 
            this.gbx_obs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_obs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbx_obs.Controls.Add(this.txt_observacao);
            this.gbx_obs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gbx_obs.ForeColor = System.Drawing.Color.DimGray;
            this.gbx_obs.Location = new System.Drawing.Point(684, 183);
            this.gbx_obs.Name = "gbx_obs";
            this.gbx_obs.Size = new System.Drawing.Size(310, 250);
            this.gbx_obs.TabIndex = 13;
            this.gbx_obs.TabStop = false;
            this.gbx_obs.Text = "Observações";
            // 
            // gbx_dadosCliente_juridica
            // 
            this.gbx_dadosCliente_juridica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_dadosCliente_juridica.Controls.Add(this.msktxt_cnpj_pj);
            this.gbx_dadosCliente_juridica.Controls.Add(this.label2);
            this.gbx_dadosCliente_juridica.Controls.Add(this.label3);
            this.gbx_dadosCliente_juridica.Controls.Add(this.dtpckr_data_abertura_pj);
            this.gbx_dadosCliente_juridica.Controls.Add(this.label5);
            this.gbx_dadosCliente_juridica.Controls.Add(this.label6);
            this.gbx_dadosCliente_juridica.Controls.Add(this.txt_nomeFantasia_pj);
            this.gbx_dadosCliente_juridica.Controls.Add(this.label12);
            this.gbx_dadosCliente_juridica.Controls.Add(this.msktxt_rntrc_pj);
            this.gbx_dadosCliente_juridica.Controls.Add(this.msktxt_ie_pj);
            this.gbx_dadosCliente_juridica.Controls.Add(this.label13);
            this.gbx_dadosCliente_juridica.Controls.Add(this.txt_razaoSocial_pf);
            this.gbx_dadosCliente_juridica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbx_dadosCliente_juridica.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gbx_dadosCliente_juridica.ForeColor = System.Drawing.Color.DimGray;
            this.gbx_dadosCliente_juridica.Location = new System.Drawing.Point(9, 41);
            this.gbx_dadosCliente_juridica.Name = "gbx_dadosCliente_juridica";
            this.gbx_dadosCliente_juridica.Size = new System.Drawing.Size(985, 136);
            this.gbx_dadosCliente_juridica.TabIndex = 9;
            this.gbx_dadosCliente_juridica.TabStop = false;
            this.gbx_dadosCliente_juridica.Text = "Dados";
            // 
            // msktxt_cnpj_pj
            // 
            this.msktxt_cnpj_pj.BackColor = System.Drawing.Color.Gainsboro;
            this.msktxt_cnpj_pj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msktxt_cnpj_pj.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msktxt_cnpj_pj.Location = new System.Drawing.Point(558, 86);
            this.msktxt_cnpj_pj.Mask = "00,000,000/0000-00";
            this.msktxt_cnpj_pj.Name = "msktxt_cnpj_pj";
            this.msktxt_cnpj_pj.Size = new System.Drawing.Size(153, 22);
            this.msktxt_cnpj_pj.TabIndex = 5;
            this.msktxt_cnpj_pj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data de Abertura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Razão Social:";
            // 
            // dtpckr_data_abertura_pj
            // 
            this.dtpckr_data_abertura_pj.CalendarMonthBackground = System.Drawing.Color.Honeydew;
            this.dtpckr_data_abertura_pj.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpckr_data_abertura_pj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpckr_data_abertura_pj.Location = new System.Drawing.Point(141, 86);
            this.dtpckr_data_abertura_pj.Name = "dtpckr_data_abertura_pj";
            this.dtpckr_data_abertura_pj.Size = new System.Drawing.Size(109, 29);
            this.dtpckr_data_abertura_pj.TabIndex = 3;
            this.dtpckr_data_abertura_pj.Value = new System.DateTime(2014, 11, 18, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(502, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "CNPJ:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(545, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nome Fantasia:";
            // 
            // txt_nomeFantasia_pj
            // 
            this.txt_nomeFantasia_pj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nomeFantasia_pj.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_nomeFantasia_pj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nomeFantasia_pj.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_nomeFantasia_pj.Location = new System.Drawing.Point(663, 36);
            this.txt_nomeFantasia_pj.Name = "txt_nomeFantasia_pj";
            this.txt_nomeFantasia_pj.Size = new System.Drawing.Size(296, 22);
            this.txt_nomeFantasia_pj.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(302, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "I.E:";
            // 
            // msktxt_rntrc_pj
            // 
            this.msktxt_rntrc_pj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.msktxt_rntrc_pj.BackColor = System.Drawing.Color.Gainsboro;
            this.msktxt_rntrc_pj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msktxt_rntrc_pj.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msktxt_rntrc_pj.Location = new System.Drawing.Point(817, 86);
            this.msktxt_rntrc_pj.Mask = "AAA-00000000";
            this.msktxt_rntrc_pj.Name = "msktxt_rntrc_pj";
            this.msktxt_rntrc_pj.Size = new System.Drawing.Size(142, 22);
            this.msktxt_rntrc_pj.TabIndex = 6;
            this.msktxt_rntrc_pj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msktxt_rntrc_pj.Validated += new System.EventHandler(this.msktxt_rntrc_Validated);
            // 
            // msktxt_ie_pj
            // 
            this.msktxt_ie_pj.BackColor = System.Drawing.Color.Gainsboro;
            this.msktxt_ie_pj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msktxt_ie_pj.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msktxt_ie_pj.Location = new System.Drawing.Point(333, 86);
            this.msktxt_ie_pj.Mask = "000,000,000,000";
            this.msktxt_ie_pj.Name = "msktxt_ie_pj";
            this.msktxt_ie_pj.Size = new System.Drawing.Size(127, 22);
            this.msktxt_ie_pj.TabIndex = 4;
            this.msktxt_ie_pj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(751, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 21);
            this.label13.TabIndex = 3;
            this.label13.Text = "RNTRC:";
            // 
            // txt_razaoSocial_pf
            // 
            this.txt_razaoSocial_pf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_razaoSocial_pf.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_razaoSocial_pf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_razaoSocial_pf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_razaoSocial_pf.Location = new System.Drawing.Point(106, 36);
            this.txt_razaoSocial_pf.Name = "txt_razaoSocial_pf";
            this.txt_razaoSocial_pf.Size = new System.Drawing.Size(412, 22);
            this.txt_razaoSocial_pf.TabIndex = 1;
            // 
            // erros
            // 
            this.erros.BlinkRate = 500;
            this.erros.ContainerControl = this;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_fechar.BackgroundImage = global::gerenciador_antt.Properties.Resources.excluir;
            this.btn_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fechar.Location = new System.Drawing.Point(66, 4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(25, 25);
            this.btn_fechar.TabIndex = 16;
            this.btn_fechar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // pnl_centro
            // 
            this.pnl_centro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_centro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_centro.BackColor = System.Drawing.Color.White;
            this.pnl_centro.Controls.Add(this.groupBox1);
            this.pnl_centro.Controls.Add(this.btn_cadastrar_cliente);
            this.pnl_centro.Controls.Add(this.pnl_fechar);
            this.pnl_centro.Controls.Add(this.rbtn_pessoaFisica);
            this.pnl_centro.Controls.Add(this.gbx_enderecos);
            this.pnl_centro.Controls.Add(this.label9);
            this.pnl_centro.Controls.Add(this.gbx_obs);
            this.pnl_centro.Controls.Add(this.gbx_contatoCliente);
            this.pnl_centro.Controls.Add(this.rbtn_pessoaJuridica);
            this.pnl_centro.Controls.Add(this.gbx_dadosCliente_fisica);
            this.pnl_centro.Controls.Add(this.gbx_dadosCliente_juridica);
            this.pnl_centro.ForeColor = System.Drawing.Color.Black;
            this.pnl_centro.Location = new System.Drawing.Point(0, 0);
            this.pnl_centro.Name = "pnl_centro";
            this.pnl_centro.Size = new System.Drawing.Size(1000, 665);
            this.pnl_centro.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_codigo_nomenclatura);
            this.groupBox1.Controls.Add(this.lbl_codigo_numero);
            this.groupBox1.Location = new System.Drawing.Point(9, -24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 63);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbl_codigo_nomenclatura
            // 
            this.lbl_codigo_nomenclatura.AutoSize = true;
            this.lbl_codigo_nomenclatura.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_codigo_nomenclatura.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_codigo_nomenclatura.Location = new System.Drawing.Point(6, 33);
            this.lbl_codigo_nomenclatura.Name = "lbl_codigo_nomenclatura";
            this.lbl_codigo_nomenclatura.Size = new System.Drawing.Size(63, 21);
            this.lbl_codigo_nomenclatura.TabIndex = 16;
            this.lbl_codigo_nomenclatura.Text = "Código:";
            this.lbl_codigo_nomenclatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_codigo_nomenclatura.Visible = false;
            // 
            // lbl_codigo_numero
            // 
            this.lbl_codigo_numero.AutoSize = true;
            this.lbl_codigo_numero.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_codigo_numero.ForeColor = System.Drawing.Color.Black;
            this.lbl_codigo_numero.Location = new System.Drawing.Point(64, 33);
            this.lbl_codigo_numero.Name = "lbl_codigo_numero";
            this.lbl_codigo_numero.Size = new System.Drawing.Size(19, 21);
            this.lbl_codigo_numero.TabIndex = 17;
            this.lbl_codigo_numero.Text = "0";
            this.lbl_codigo_numero.Visible = false;
            // 
            // pnl_fechar
            // 
            this.pnl_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_fechar.BackColor = System.Drawing.Color.Transparent;
            this.pnl_fechar.Controls.Add(this.btn_fechar);
            this.pnl_fechar.Controls.Add(this.lbl_fechar);
            this.pnl_fechar.Location = new System.Drawing.Point(902, 0);
            this.pnl_fechar.Name = "pnl_fechar";
            this.pnl_fechar.Size = new System.Drawing.Size(98, 32);
            this.pnl_fechar.TabIndex = 15;
            this.pnl_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // lbl_fechar
            // 
            this.lbl_fechar.AutoSize = true;
            this.lbl_fechar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbl_fechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_fechar.Location = new System.Drawing.Point(0, 1);
            this.lbl_fechar.Name = "lbl_fechar";
            this.lbl_fechar.Size = new System.Drawing.Size(69, 28);
            this.lbl_fechar.TabIndex = 15;
            this.lbl_fechar.Text = "Fechar";
            this.lbl_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // Uc_cliente_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnl_centro);
            this.Name = "Uc_cliente_cadastro";
            this.Size = new System.Drawing.Size(1146, 665);
            this.Load += new System.EventHandler(this.Uc_cliente_cadastro_Load);
            this.gbx_dadosCliente_fisica.ResumeLayout(false);
            this.gbx_dadosCliente_fisica.PerformLayout();
            this.gbx_contatoCliente.ResumeLayout(false);
            this.gbx_contatoCliente.PerformLayout();
            this.gbx_contatosAdicionados.ResumeLayout(false);
            this.gbx_enderecos.ResumeLayout(false);
            this.gbx_enderecos.PerformLayout();
            this.gbx_enderecosAdicionados.ResumeLayout(false);
            this.gbx_obs.ResumeLayout(false);
            this.gbx_obs.PerformLayout();
            this.gbx_dadosCliente_juridica.ResumeLayout(false);
            this.gbx_dadosCliente_juridica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).EndInit();
            this.pnl_centro.ResumeLayout(false);
            this.pnl_centro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_fechar.ResumeLayout(false);
            this.pnl_fechar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar_cliente;
        private System.Windows.Forms.TextBox txt_nome_pf;
        private System.Windows.Forms.MaskedTextBox msktxt_cpf_pf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_pessoaFisica;
        private System.Windows.Forms.RadioButton rbtn_pessoaJuridica;
        private System.Windows.Forms.Label lbl_apelido;
        private System.Windows.Forms.TextBox txt_apelido_pf;
        private System.Windows.Forms.MaskedTextBox msktxt_rntrc_pf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msktxt_rg_pf;
        private System.Windows.Forms.Label lbl_rg;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_data_nascimento;
        private System.Windows.Forms.DateTimePicker dtpckr_dataNascimento_pf;
        private System.Windows.Forms.GroupBox gbx_dadosCliente_fisica;
        private System.Windows.Forms.GroupBox gbx_contatoCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_tipo_contato;
        private System.Windows.Forms.MaskedTextBox msktxt_contato;
        private System.Windows.Forms.GroupBox gbx_contatosAdicionados;
        private System.Windows.Forms.Button btn_adicionarContato;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbx_enderecos;
        private System.Windows.Forms.Button btn_adicionarEndereco;
        private System.Windows.Forms.GroupBox gbx_enderecosAdicionados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_tipo_endereco;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.TextBox txt_observacao;
        private System.Windows.Forms.GroupBox gbx_obs;
        private System.Windows.Forms.Button btn_gerarBaseEndereco;
        private System.Windows.Forms.GroupBox gbx_dadosCliente_juridica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpckr_data_abertura_pj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msktxt_cnpj_pj;
        private System.Windows.Forms.TextBox txt_nomeFantasia_pj;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox msktxt_rntrc_pj;
        private System.Windows.Forms.MaskedTextBox msktxt_ie_pj;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_razaoSocial_pf;
        private System.Windows.Forms.ErrorProvider erros;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Panel pnl_contatos;
        private System.Windows.Forms.Panel pnl_enderecos;
        private System.Windows.Forms.Panel pnl_centro;
        private System.Windows.Forms.Panel pnl_fechar;
        private System.Windows.Forms.Label lbl_fechar;
        private System.Windows.Forms.Label lbl_codigo_numero;
        private System.Windows.Forms.Label lbl_codigo_nomenclatura;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
