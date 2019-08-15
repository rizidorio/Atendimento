namespace UI
{
    partial class frmCadastrarCliente
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
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flpCadastrarClienteTipo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCadastrarClienteTipo = new System.Windows.Forms.Label();
            this.cmbCadastrarClienteTipo = new System.Windows.Forms.ComboBox();
            this.flpCadastrarClienteCampos = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCadastrarClienteNome = new System.Windows.Forms.Label();
            this.lblCadastrarClienteCPF = new System.Windows.Forms.Label();
            this.lblCadastrarClienteRG = new System.Windows.Forms.Label();
            this.lblCadastrarClienteNascimento = new System.Windows.Forms.Label();
            this.txtCadastrarClienteNome = new System.Windows.Forms.TextBox();
            this.mtxCadastrarClienteCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxCadastrarClienteRG = new System.Windows.Forms.MaskedTextBox();
            this.dtpCadastrarClienteNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblCadastrarClienteEstadoCivil = new System.Windows.Forms.Label();
            this.lblCadastrarClienteSexo = new System.Windows.Forms.Label();
            this.lblCadastrarClienteCEP = new System.Windows.Forms.Label();
            this.lblCadastrarClienteLogradouro = new System.Windows.Forms.Label();
            this.cmbCadastrarClienteEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cmbCadastrarClienteSexo = new System.Windows.Forms.ComboBox();
            this.mtxCadastrarClienteCEP = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrarClienteBuscarCep = new System.Windows.Forms.Button();
            this.txtCadastrarClienteLogradouro = new System.Windows.Forms.TextBox();
            this.lblCadastrarClienteNumero = new System.Windows.Forms.Label();
            this.lblCadastrarClienteComplemento = new System.Windows.Forms.Label();
            this.lblCadastrarClienteBairro = new System.Windows.Forms.Label();
            this.lblCadastrarClienteCidade = new System.Windows.Forms.Label();
            this.lblCadastrarClienteUF = new System.Windows.Forms.Label();
            this.txtCadastrarClienteNumero = new System.Windows.Forms.TextBox();
            this.txtCadastrarClienteComplemento = new System.Windows.Forms.TextBox();
            this.txtCadastrarClienteBairro = new System.Windows.Forms.TextBox();
            this.txtCadastrarClienteCidade = new System.Windows.Forms.TextBox();
            this.txtCadastrarClienteUF = new System.Windows.Forms.TextBox();
            this.lblCadastrarClienteDDD = new System.Windows.Forms.Label();
            this.lblCadastrarClienteTelefone = new System.Windows.Forms.Label();
            this.lblCadastrarClienteCelular = new System.Windows.Forms.Label();
            this.lblCadastrarClienteEmail = new System.Windows.Forms.Label();
            this.mtxCadastrarClienteDDD = new System.Windows.Forms.MaskedTextBox();
            this.mtxCadastrarClienteTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxCadastrarClienteCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtCadastrarClienteEmail = new System.Windows.Forms.TextBox();
            this.btnCadastrarClienteMenuSalvar = new System.Windows.Forms.Button();
            this.btnCadastrarClienteMenuLimpar = new System.Windows.Forms.Button();
            this.btnCadastrarClienteMenuSair = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.flpCadastrarClienteTipo.SuspendLayout();
            this.flpCadastrarClienteCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(DAO.cliente);
            // 
            // flpCadastrarClienteTipo
            // 
            this.flpCadastrarClienteTipo.Controls.Add(this.lblCadastrarClienteTipo);
            this.flpCadastrarClienteTipo.Controls.Add(this.cmbCadastrarClienteTipo);
            this.flpCadastrarClienteTipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCadastrarClienteTipo.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpCadastrarClienteTipo.Location = new System.Drawing.Point(0, 0);
            this.flpCadastrarClienteTipo.Name = "flpCadastrarClienteTipo";
            this.flpCadastrarClienteTipo.Size = new System.Drawing.Size(870, 33);
            this.flpCadastrarClienteTipo.TabIndex = 8;
            // 
            // lblCadastrarClienteTipo
            // 
            this.lblCadastrarClienteTipo.AutoSize = true;
            this.lblCadastrarClienteTipo.Location = new System.Drawing.Point(0, 6);
            this.lblCadastrarClienteTipo.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblCadastrarClienteTipo.Name = "lblCadastrarClienteTipo";
            this.lblCadastrarClienteTipo.Size = new System.Drawing.Size(131, 20);
            this.lblCadastrarClienteTipo.TabIndex = 2;
            this.lblCadastrarClienteTipo.Text = "Tipo de Cliente";
            // 
            // cmbCadastrarClienteTipo
            // 
            this.cmbCadastrarClienteTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCadastrarClienteTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCadastrarClienteTipo.BackColor = System.Drawing.Color.White;
            this.flpCadastrarClienteTipo.SetFlowBreak(this.cmbCadastrarClienteTipo, true);
            this.cmbCadastrarClienteTipo.FormattingEnabled = true;
            this.cmbCadastrarClienteTipo.Items.AddRange(new object[] {
            "Pessoa Física",
            "Pessoa Jurídica"});
            this.cmbCadastrarClienteTipo.Location = new System.Drawing.Point(131, 0);
            this.cmbCadastrarClienteTipo.Margin = new System.Windows.Forms.Padding(0);
            this.cmbCadastrarClienteTipo.Name = "cmbCadastrarClienteTipo";
            this.cmbCadastrarClienteTipo.Size = new System.Drawing.Size(147, 28);
            this.cmbCadastrarClienteTipo.TabIndex = 3;
            this.cmbCadastrarClienteTipo.Text = "-- Selecione --";
            this.cmbCadastrarClienteTipo.SelectedIndexChanged += new System.EventHandler(this.CmbCadastrarClienteTipo_SelectedIndexChanged);
            // 
            // flpCadastrarClienteCampos
            // 
            this.flpCadastrarClienteCampos.Controls.Add(this.lblCadastrarClienteNome);
            this.flpCadastrarClienteCampos.Controls.Add(this.lblCadastrarClienteCPF);
            this.flpCadastrarClienteCampos.Controls.Add(this.lblCadastrarClienteRG);
            this.flpCadastrarClienteCampos.Controls.Add(this.lblCadastrarClienteNascimento);
            this.flpCadastrarClienteCampos.Controls.Add(this.txtCadastrarClienteNome);
            this.flpCadastrarClienteCampos.Controls.Add(this.mtxCadastrarClienteCPF);
            this.flpCadastrarClienteCampos.Controls.Add(this.mtxCadastrarClienteRG);
            this.flpCadastrarClienteCampos.Controls.Add(this.dtpCadastrarClienteNascimento);
            this.flpCadastrarClienteCampos.Controls.Add(this.lblCadastrarClienteEstadoCivil);
            this.flpCadastrarClienteCampos.Controls.Add(this.lblCadastrarClienteSexo);
            this.flpCadastrarClienteCampos.Controls.Add(this.lblCadastrarClienteCEP);
            this.flpCadastrarClienteCampos.Controls.Add(this.lblCadastrarClienteLogradouro);
            this.flpCadastrarClienteCampos.Controls.Add(this.cmbCadastrarClienteEstadoCivil);
            this.flpCadastrarClienteCampos.Controls.Add(this.cmbCadastrarClienteSexo);
            this.flpCadastrarClienteCampos.Controls.Add(this.mtxCadastrarClienteCEP);
            this.flpCadastrarClienteCampos.Controls.Add(this.btnCadastrarClienteBuscarCep);
            this.flpCadastrarClienteCampos.Controls.Add(this.txtCadastrarClienteLogradouro);
            this.flpCadastrarClienteCampos.Controls.Add(this.lblCadastrarClienteNumero);
            this.flpCadastrarClienteCampos.Controls.Add(this.lblCadastrarClienteComplemento);
            this.flpCadastrarClienteCampos.Controls.Add(this.lblCadastrarClienteBairro);
            this.flpCadastrarClienteCampos.Controls.Add(this.lblCadastrarClienteCidade);
            this.flpCadastrarClienteCampos.Controls.Add(this.lblCadastrarClienteUF);
            this.flpCadastrarClienteCampos.Controls.Add(this.txtCadastrarClienteNumero);
            this.flpCadastrarClienteCampos.Controls.Add(this.txtCadastrarClienteComplemento);
            this.flpCadastrarClienteCampos.Controls.Add(this.txtCadastrarClienteBairro);
            this.flpCadastrarClienteCampos.Controls.Add(this.txtCadastrarClienteCidade);
            this.flpCadastrarClienteCampos.Controls.Add(this.txtCadastrarClienteUF);
            this.flpCadastrarClienteCampos.Controls.Add(this.lblCadastrarClienteDDD);
            this.flpCadastrarClienteCampos.Controls.Add(this.lblCadastrarClienteTelefone);
            this.flpCadastrarClienteCampos.Controls.Add(this.lblCadastrarClienteCelular);
            this.flpCadastrarClienteCampos.Controls.Add(this.lblCadastrarClienteEmail);
            this.flpCadastrarClienteCampos.Controls.Add(this.mtxCadastrarClienteDDD);
            this.flpCadastrarClienteCampos.Controls.Add(this.mtxCadastrarClienteTelefone);
            this.flpCadastrarClienteCampos.Controls.Add(this.mtxCadastrarClienteCelular);
            this.flpCadastrarClienteCampos.Controls.Add(this.txtCadastrarClienteEmail);
            this.flpCadastrarClienteCampos.Controls.Add(this.btnCadastrarClienteMenuSalvar);
            this.flpCadastrarClienteCampos.Controls.Add(this.btnCadastrarClienteMenuLimpar);
            this.flpCadastrarClienteCampos.Controls.Add(this.btnCadastrarClienteMenuSair);
            this.flpCadastrarClienteCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCadastrarClienteCampos.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpCadastrarClienteCampos.Location = new System.Drawing.Point(0, 33);
            this.flpCadastrarClienteCampos.Margin = new System.Windows.Forms.Padding(0);
            this.flpCadastrarClienteCampos.Name = "flpCadastrarClienteCampos";
            this.flpCadastrarClienteCampos.Size = new System.Drawing.Size(870, 443);
            this.flpCadastrarClienteCampos.TabIndex = 9;
            // 
            // lblCadastrarClienteNome
            // 
            this.lblCadastrarClienteNome.AutoSize = true;
            this.lblCadastrarClienteNome.Location = new System.Drawing.Point(0, 0);
            this.lblCadastrarClienteNome.Margin = new System.Windows.Forms.Padding(0);
            this.lblCadastrarClienteNome.Name = "lblCadastrarClienteNome";
            this.lblCadastrarClienteNome.Size = new System.Drawing.Size(56, 20);
            this.lblCadastrarClienteNome.TabIndex = 0;
            this.lblCadastrarClienteNome.Text = "Nome";
            this.lblCadastrarClienteNome.Visible = false;
            // 
            // lblCadastrarClienteCPF
            // 
            this.lblCadastrarClienteCPF.AutoSize = true;
            this.lblCadastrarClienteCPF.Location = new System.Drawing.Point(396, 0);
            this.lblCadastrarClienteCPF.Margin = new System.Windows.Forms.Padding(340, 0, 0, 0);
            this.lblCadastrarClienteCPF.Name = "lblCadastrarClienteCPF";
            this.lblCadastrarClienteCPF.Size = new System.Drawing.Size(38, 20);
            this.lblCadastrarClienteCPF.TabIndex = 0;
            this.lblCadastrarClienteCPF.Text = "CPF";
            this.lblCadastrarClienteCPF.Visible = false;
            // 
            // lblCadastrarClienteRG
            // 
            this.lblCadastrarClienteRG.AutoSize = true;
            this.lblCadastrarClienteRG.Location = new System.Drawing.Point(586, 0);
            this.lblCadastrarClienteRG.Margin = new System.Windows.Forms.Padding(152, 0, 0, 0);
            this.lblCadastrarClienteRG.Name = "lblCadastrarClienteRG";
            this.lblCadastrarClienteRG.Size = new System.Drawing.Size(31, 20);
            this.lblCadastrarClienteRG.TabIndex = 0;
            this.lblCadastrarClienteRG.Text = "RG";
            this.lblCadastrarClienteRG.Visible = false;
            // 
            // lblCadastrarClienteNascimento
            // 
            this.lblCadastrarClienteNascimento.AutoSize = true;
            this.flpCadastrarClienteCampos.SetFlowBreak(this.lblCadastrarClienteNascimento, true);
            this.lblCadastrarClienteNascimento.Location = new System.Drawing.Point(728, 0);
            this.lblCadastrarClienteNascimento.Margin = new System.Windows.Forms.Padding(111, 0, 0, 0);
            this.lblCadastrarClienteNascimento.Name = "lblCadastrarClienteNascimento";
            this.lblCadastrarClienteNascimento.Size = new System.Drawing.Size(102, 20);
            this.lblCadastrarClienteNascimento.TabIndex = 0;
            this.lblCadastrarClienteNascimento.Text = "Nascimento";
            this.lblCadastrarClienteNascimento.Visible = false;
            // 
            // txtCadastrarClienteNome
            // 
            this.txtCadastrarClienteNome.Location = new System.Drawing.Point(3, 20);
            this.txtCadastrarClienteNome.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.txtCadastrarClienteNome.Name = "txtCadastrarClienteNome";
            this.txtCadastrarClienteNome.Size = new System.Drawing.Size(376, 32);
            this.txtCadastrarClienteNome.TabIndex = 1;
            this.txtCadastrarClienteNome.Visible = false;
            // 
            // mtxCadastrarClienteCPF
            // 
            this.mtxCadastrarClienteCPF.Location = new System.Drawing.Point(399, 20);
            this.mtxCadastrarClienteCPF.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.mtxCadastrarClienteCPF.Mask = "000,000,000-00";
            this.mtxCadastrarClienteCPF.Name = "mtxCadastrarClienteCPF";
            this.mtxCadastrarClienteCPF.Size = new System.Drawing.Size(172, 32);
            this.mtxCadastrarClienteCPF.TabIndex = 2;
            this.mtxCadastrarClienteCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxCadastrarClienteCPF.Visible = false;
            // 
            // mtxCadastrarClienteRG
            // 
            this.mtxCadastrarClienteRG.Location = new System.Drawing.Point(591, 20);
            this.mtxCadastrarClienteRG.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.mtxCadastrarClienteRG.Mask = "00,000,000-0";
            this.mtxCadastrarClienteRG.Name = "mtxCadastrarClienteRG";
            this.mtxCadastrarClienteRG.Size = new System.Drawing.Size(120, 32);
            this.mtxCadastrarClienteRG.TabIndex = 3;
            this.mtxCadastrarClienteRG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxCadastrarClienteRG.Visible = false;
            // 
            // dtpCadastrarClienteNascimento
            // 
            this.dtpCadastrarClienteNascimento.CustomFormat = "";
            this.flpCadastrarClienteCampos.SetFlowBreak(this.dtpCadastrarClienteNascimento, true);
            this.dtpCadastrarClienteNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCadastrarClienteNascimento.Location = new System.Drawing.Point(731, 20);
            this.dtpCadastrarClienteNascimento.Margin = new System.Windows.Forms.Padding(20, 0, 0, 40);
            this.dtpCadastrarClienteNascimento.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpCadastrarClienteNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpCadastrarClienteNascimento.Name = "dtpCadastrarClienteNascimento";
            this.dtpCadastrarClienteNascimento.Size = new System.Drawing.Size(132, 32);
            this.dtpCadastrarClienteNascimento.TabIndex = 4;
            this.dtpCadastrarClienteNascimento.Visible = false;
            // 
            // lblCadastrarClienteEstadoCivil
            // 
            this.lblCadastrarClienteEstadoCivil.AutoSize = true;
            this.lblCadastrarClienteEstadoCivil.Location = new System.Drawing.Point(0, 92);
            this.lblCadastrarClienteEstadoCivil.Margin = new System.Windows.Forms.Padding(0);
            this.lblCadastrarClienteEstadoCivil.Name = "lblCadastrarClienteEstadoCivil";
            this.lblCadastrarClienteEstadoCivil.Size = new System.Drawing.Size(100, 20);
            this.lblCadastrarClienteEstadoCivil.TabIndex = 0;
            this.lblCadastrarClienteEstadoCivil.Text = "Estado Civil";
            this.lblCadastrarClienteEstadoCivil.Visible = false;
            // 
            // lblCadastrarClienteSexo
            // 
            this.lblCadastrarClienteSexo.AutoSize = true;
            this.lblCadastrarClienteSexo.Location = new System.Drawing.Point(170, 92);
            this.lblCadastrarClienteSexo.Margin = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.lblCadastrarClienteSexo.Name = "lblCadastrarClienteSexo";
            this.lblCadastrarClienteSexo.Size = new System.Drawing.Size(48, 20);
            this.lblCadastrarClienteSexo.TabIndex = 0;
            this.lblCadastrarClienteSexo.Text = "Sexo";
            this.lblCadastrarClienteSexo.Visible = false;
            // 
            // lblCadastrarClienteCEP
            // 
            this.lblCadastrarClienteCEP.AutoSize = true;
            this.lblCadastrarClienteCEP.Location = new System.Drawing.Point(335, 92);
            this.lblCadastrarClienteCEP.Margin = new System.Windows.Forms.Padding(117, 0, 0, 0);
            this.lblCadastrarClienteCEP.Name = "lblCadastrarClienteCEP";
            this.lblCadastrarClienteCEP.Size = new System.Drawing.Size(38, 20);
            this.lblCadastrarClienteCEP.TabIndex = 0;
            this.lblCadastrarClienteCEP.Text = "CEP";
            this.lblCadastrarClienteCEP.Visible = false;
            // 
            // lblCadastrarClienteLogradouro
            // 
            this.lblCadastrarClienteLogradouro.AutoSize = true;
            this.flpCadastrarClienteCampos.SetFlowBreak(this.lblCadastrarClienteLogradouro, true);
            this.lblCadastrarClienteLogradouro.Location = new System.Drawing.Point(501, 92);
            this.lblCadastrarClienteLogradouro.Margin = new System.Windows.Forms.Padding(128, 0, 0, 0);
            this.lblCadastrarClienteLogradouro.Name = "lblCadastrarClienteLogradouro";
            this.lblCadastrarClienteLogradouro.Size = new System.Drawing.Size(101, 20);
            this.lblCadastrarClienteLogradouro.TabIndex = 0;
            this.lblCadastrarClienteLogradouro.Text = "Logradouro";
            this.lblCadastrarClienteLogradouro.Visible = false;
            // 
            // cmbCadastrarClienteEstadoCivil
            // 
            this.cmbCadastrarClienteEstadoCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCadastrarClienteEstadoCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCadastrarClienteEstadoCivil.FormattingEnabled = true;
            this.cmbCadastrarClienteEstadoCivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Separado(a)",
            "Viúvo(a)"});
            this.cmbCadastrarClienteEstadoCivil.Location = new System.Drawing.Point(3, 114);
            this.cmbCadastrarClienteEstadoCivil.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.cmbCadastrarClienteEstadoCivil.Name = "cmbCadastrarClienteEstadoCivil";
            this.cmbCadastrarClienteEstadoCivil.Size = new System.Drawing.Size(149, 28);
            this.cmbCadastrarClienteEstadoCivil.TabIndex = 5;
            this.cmbCadastrarClienteEstadoCivil.Visible = false;
            // 
            // cmbCadastrarClienteSexo
            // 
            this.cmbCadastrarClienteSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCadastrarClienteSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCadastrarClienteSexo.FormattingEnabled = true;
            this.cmbCadastrarClienteSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbCadastrarClienteSexo.Location = new System.Drawing.Point(172, 114);
            this.cmbCadastrarClienteSexo.Margin = new System.Windows.Forms.Padding(20, 2, 0, 0);
            this.cmbCadastrarClienteSexo.Name = "cmbCadastrarClienteSexo";
            this.cmbCadastrarClienteSexo.Size = new System.Drawing.Size(148, 28);
            this.cmbCadastrarClienteSexo.TabIndex = 6;
            this.cmbCadastrarClienteSexo.Visible = false;
            // 
            // mtxCadastrarClienteCEP
            // 
            this.mtxCadastrarClienteCEP.Location = new System.Drawing.Point(340, 112);
            this.mtxCadastrarClienteCEP.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.mtxCadastrarClienteCEP.Mask = "00,000-000";
            this.mtxCadastrarClienteCEP.Name = "mtxCadastrarClienteCEP";
            this.mtxCadastrarClienteCEP.Size = new System.Drawing.Size(113, 32);
            this.mtxCadastrarClienteCEP.TabIndex = 7;
            this.mtxCadastrarClienteCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxCadastrarClienteCEP.Visible = false;
            // 
            // btnCadastrarClienteBuscarCep
            // 
            this.btnCadastrarClienteBuscarCep.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarClienteBuscarCep.FlatAppearance.BorderSize = 0;
            this.btnCadastrarClienteBuscarCep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarClienteBuscarCep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarClienteBuscarCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarClienteBuscarCep.Image = global::UI.Properties.Resources.procurarpq2;
            this.btnCadastrarClienteBuscarCep.Location = new System.Drawing.Point(456, 115);
            this.btnCadastrarClienteBuscarCep.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnCadastrarClienteBuscarCep.Name = "btnCadastrarClienteBuscarCep";
            this.btnCadastrarClienteBuscarCep.Size = new System.Drawing.Size(25, 25);
            this.btnCadastrarClienteBuscarCep.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnCadastrarClienteBuscarCep, "Buscar CEP");
            this.btnCadastrarClienteBuscarCep.UseVisualStyleBackColor = true;
            this.btnCadastrarClienteBuscarCep.Visible = false;
            this.btnCadastrarClienteBuscarCep.Click += new System.EventHandler(this.BtnCadastrarClienteBuscarCep_Click);
            // 
            // txtCadastrarClienteLogradouro
            // 
            this.flpCadastrarClienteCampos.SetFlowBreak(this.txtCadastrarClienteLogradouro, true);
            this.txtCadastrarClienteLogradouro.Location = new System.Drawing.Point(501, 112);
            this.txtCadastrarClienteLogradouro.Margin = new System.Windows.Forms.Padding(20, 0, 0, 40);
            this.txtCadastrarClienteLogradouro.Name = "txtCadastrarClienteLogradouro";
            this.txtCadastrarClienteLogradouro.Size = new System.Drawing.Size(359, 32);
            this.txtCadastrarClienteLogradouro.TabIndex = 9;
            this.txtCadastrarClienteLogradouro.Visible = false;
            // 
            // lblCadastrarClienteNumero
            // 
            this.lblCadastrarClienteNumero.AutoSize = true;
            this.lblCadastrarClienteNumero.Location = new System.Drawing.Point(0, 184);
            this.lblCadastrarClienteNumero.Margin = new System.Windows.Forms.Padding(0);
            this.lblCadastrarClienteNumero.Name = "lblCadastrarClienteNumero";
            this.lblCadastrarClienteNumero.Size = new System.Drawing.Size(73, 20);
            this.lblCadastrarClienteNumero.TabIndex = 0;
            this.lblCadastrarClienteNumero.Text = "Número";
            this.lblCadastrarClienteNumero.Visible = false;
            // 
            // lblCadastrarClienteComplemento
            // 
            this.lblCadastrarClienteComplemento.AutoSize = true;
            this.lblCadastrarClienteComplemento.Location = new System.Drawing.Point(117, 184);
            this.lblCadastrarClienteComplemento.Margin = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.lblCadastrarClienteComplemento.Name = "lblCadastrarClienteComplemento";
            this.lblCadastrarClienteComplemento.Size = new System.Drawing.Size(121, 20);
            this.lblCadastrarClienteComplemento.TabIndex = 0;
            this.lblCadastrarClienteComplemento.Text = "Complemento";
            this.lblCadastrarClienteComplemento.Visible = false;
            // 
            // lblCadastrarClienteBairro
            // 
            this.lblCadastrarClienteBairro.AutoSize = true;
            this.lblCadastrarClienteBairro.Location = new System.Drawing.Point(390, 184);
            this.lblCadastrarClienteBairro.Margin = new System.Windows.Forms.Padding(152, 0, 0, 0);
            this.lblCadastrarClienteBairro.Name = "lblCadastrarClienteBairro";
            this.lblCadastrarClienteBairro.Size = new System.Drawing.Size(56, 20);
            this.lblCadastrarClienteBairro.TabIndex = 0;
            this.lblCadastrarClienteBairro.Text = "Bairro";
            this.lblCadastrarClienteBairro.Visible = false;
            // 
            // lblCadastrarClienteCidade
            // 
            this.lblCadastrarClienteCidade.AutoSize = true;
            this.lblCadastrarClienteCidade.Location = new System.Drawing.Point(588, 184);
            this.lblCadastrarClienteCidade.Margin = new System.Windows.Forms.Padding(142, 0, 0, 0);
            this.lblCadastrarClienteCidade.Name = "lblCadastrarClienteCidade";
            this.lblCadastrarClienteCidade.Size = new System.Drawing.Size(64, 20);
            this.lblCadastrarClienteCidade.TabIndex = 0;
            this.lblCadastrarClienteCidade.Text = "Cidade";
            this.lblCadastrarClienteCidade.Visible = false;
            // 
            // lblCadastrarClienteUF
            // 
            this.lblCadastrarClienteUF.AutoSize = true;
            this.flpCadastrarClienteCampos.SetFlowBreak(this.lblCadastrarClienteUF, true);
            this.lblCadastrarClienteUF.Location = new System.Drawing.Point(778, 184);
            this.lblCadastrarClienteUF.Margin = new System.Windows.Forms.Padding(126, 0, 0, 0);
            this.lblCadastrarClienteUF.Name = "lblCadastrarClienteUF";
            this.lblCadastrarClienteUF.Size = new System.Drawing.Size(29, 20);
            this.lblCadastrarClienteUF.TabIndex = 0;
            this.lblCadastrarClienteUF.Text = "UF";
            this.lblCadastrarClienteUF.Visible = false;
            // 
            // txtCadastrarClienteNumero
            // 
            this.txtCadastrarClienteNumero.Location = new System.Drawing.Point(3, 204);
            this.txtCadastrarClienteNumero.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.txtCadastrarClienteNumero.Name = "txtCadastrarClienteNumero";
            this.txtCadastrarClienteNumero.Size = new System.Drawing.Size(97, 32);
            this.txtCadastrarClienteNumero.TabIndex = 10;
            this.txtCadastrarClienteNumero.Visible = false;
            // 
            // txtCadastrarClienteComplemento
            // 
            this.txtCadastrarClienteComplemento.Location = new System.Drawing.Point(120, 204);
            this.txtCadastrarClienteComplemento.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.txtCadastrarClienteComplemento.Name = "txtCadastrarClienteComplemento";
            this.txtCadastrarClienteComplemento.Size = new System.Drawing.Size(253, 32);
            this.txtCadastrarClienteComplemento.TabIndex = 11;
            this.txtCadastrarClienteComplemento.Visible = false;
            // 
            // txtCadastrarClienteBairro
            // 
            this.txtCadastrarClienteBairro.Location = new System.Drawing.Point(393, 204);
            this.txtCadastrarClienteBairro.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.txtCadastrarClienteBairro.Name = "txtCadastrarClienteBairro";
            this.txtCadastrarClienteBairro.Size = new System.Drawing.Size(178, 32);
            this.txtCadastrarClienteBairro.TabIndex = 12;
            this.txtCadastrarClienteBairro.Visible = false;
            // 
            // txtCadastrarClienteCidade
            // 
            this.txtCadastrarClienteCidade.Location = new System.Drawing.Point(591, 204);
            this.txtCadastrarClienteCidade.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.txtCadastrarClienteCidade.Name = "txtCadastrarClienteCidade";
            this.txtCadastrarClienteCidade.Size = new System.Drawing.Size(171, 32);
            this.txtCadastrarClienteCidade.TabIndex = 13;
            this.txtCadastrarClienteCidade.Visible = false;
            // 
            // txtCadastrarClienteUF
            // 
            this.flpCadastrarClienteCampos.SetFlowBreak(this.txtCadastrarClienteUF, true);
            this.txtCadastrarClienteUF.Location = new System.Drawing.Point(782, 204);
            this.txtCadastrarClienteUF.Margin = new System.Windows.Forms.Padding(20, 0, 0, 40);
            this.txtCadastrarClienteUF.Name = "txtCadastrarClienteUF";
            this.txtCadastrarClienteUF.Size = new System.Drawing.Size(81, 32);
            this.txtCadastrarClienteUF.TabIndex = 14;
            this.txtCadastrarClienteUF.Visible = false;
            // 
            // lblCadastrarClienteDDD
            // 
            this.lblCadastrarClienteDDD.AutoSize = true;
            this.lblCadastrarClienteDDD.Location = new System.Drawing.Point(0, 276);
            this.lblCadastrarClienteDDD.Margin = new System.Windows.Forms.Padding(0);
            this.lblCadastrarClienteDDD.Name = "lblCadastrarClienteDDD";
            this.lblCadastrarClienteDDD.Size = new System.Drawing.Size(45, 20);
            this.lblCadastrarClienteDDD.TabIndex = 0;
            this.lblCadastrarClienteDDD.Text = "DDD";
            this.lblCadastrarClienteDDD.Visible = false;
            // 
            // lblCadastrarClienteTelefone
            // 
            this.lblCadastrarClienteTelefone.AutoSize = true;
            this.lblCadastrarClienteTelefone.Location = new System.Drawing.Point(74, 276);
            this.lblCadastrarClienteTelefone.Margin = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.lblCadastrarClienteTelefone.Name = "lblCadastrarClienteTelefone";
            this.lblCadastrarClienteTelefone.Size = new System.Drawing.Size(80, 20);
            this.lblCadastrarClienteTelefone.TabIndex = 0;
            this.lblCadastrarClienteTelefone.Text = "Telefone";
            this.lblCadastrarClienteTelefone.Visible = false;
            // 
            // lblCadastrarClienteCelular
            // 
            this.lblCadastrarClienteCelular.AutoSize = true;
            this.lblCadastrarClienteCelular.Location = new System.Drawing.Point(204, 276);
            this.lblCadastrarClienteCelular.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lblCadastrarClienteCelular.Name = "lblCadastrarClienteCelular";
            this.lblCadastrarClienteCelular.Size = new System.Drawing.Size(66, 20);
            this.lblCadastrarClienteCelular.TabIndex = 0;
            this.lblCadastrarClienteCelular.Text = "Celular";
            this.lblCadastrarClienteCelular.Visible = false;
            // 
            // lblCadastrarClienteEmail
            // 
            this.lblCadastrarClienteEmail.AutoSize = true;
            this.flpCadastrarClienteCampos.SetFlowBreak(this.lblCadastrarClienteEmail, true);
            this.lblCadastrarClienteEmail.Location = new System.Drawing.Point(336, 276);
            this.lblCadastrarClienteEmail.Margin = new System.Windows.Forms.Padding(66, 0, 0, 0);
            this.lblCadastrarClienteEmail.Name = "lblCadastrarClienteEmail";
            this.lblCadastrarClienteEmail.Size = new System.Drawing.Size(61, 20);
            this.lblCadastrarClienteEmail.TabIndex = 0;
            this.lblCadastrarClienteEmail.Text = "E-mail";
            this.lblCadastrarClienteEmail.Visible = false;
            // 
            // mtxCadastrarClienteDDD
            // 
            this.mtxCadastrarClienteDDD.Location = new System.Drawing.Point(3, 296);
            this.mtxCadastrarClienteDDD.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.mtxCadastrarClienteDDD.Mask = "(00)";
            this.mtxCadastrarClienteDDD.Name = "mtxCadastrarClienteDDD";
            this.mtxCadastrarClienteDDD.Size = new System.Drawing.Size(53, 32);
            this.mtxCadastrarClienteDDD.TabIndex = 15;
            this.mtxCadastrarClienteDDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxCadastrarClienteDDD.Visible = false;
            // 
            // mtxCadastrarClienteTelefone
            // 
            this.mtxCadastrarClienteTelefone.Location = new System.Drawing.Point(76, 296);
            this.mtxCadastrarClienteTelefone.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.mtxCadastrarClienteTelefone.Mask = "00000-0000";
            this.mtxCadastrarClienteTelefone.Name = "mtxCadastrarClienteTelefone";
            this.mtxCadastrarClienteTelefone.Size = new System.Drawing.Size(111, 32);
            this.mtxCadastrarClienteTelefone.TabIndex = 16;
            this.mtxCadastrarClienteTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxCadastrarClienteTelefone.Visible = false;
            this.mtxCadastrarClienteTelefone.Leave += new System.EventHandler(this.MtxCadastrarClienteTelefone_Leave);
            // 
            // mtxCadastrarClienteCelular
            // 
            this.mtxCadastrarClienteCelular.Location = new System.Drawing.Point(207, 296);
            this.mtxCadastrarClienteCelular.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.mtxCadastrarClienteCelular.Mask = "00000-0000";
            this.mtxCadastrarClienteCelular.Name = "mtxCadastrarClienteCelular";
            this.mtxCadastrarClienteCelular.Size = new System.Drawing.Size(113, 32);
            this.mtxCadastrarClienteCelular.TabIndex = 17;
            this.mtxCadastrarClienteCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxCadastrarClienteCelular.Visible = false;
            // 
            // txtCadastrarClienteEmail
            // 
            this.txtCadastrarClienteEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.flpCadastrarClienteCampos.SetFlowBreak(this.txtCadastrarClienteEmail, true);
            this.txtCadastrarClienteEmail.Location = new System.Drawing.Point(340, 296);
            this.txtCadastrarClienteEmail.Margin = new System.Windows.Forms.Padding(20, 0, 0, 40);
            this.txtCadastrarClienteEmail.Name = "txtCadastrarClienteEmail";
            this.txtCadastrarClienteEmail.Size = new System.Drawing.Size(523, 32);
            this.txtCadastrarClienteEmail.TabIndex = 18;
            this.txtCadastrarClienteEmail.Visible = false;
            // 
            // btnCadastrarClienteMenuSalvar
            // 
            this.btnCadastrarClienteMenuSalvar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrarClienteMenuSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarClienteMenuSalvar.FlatAppearance.BorderSize = 0;
            this.btnCadastrarClienteMenuSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarClienteMenuSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarClienteMenuSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarClienteMenuSalvar.Image = global::UI.Properties.Resources.salvar;
            this.btnCadastrarClienteMenuSalvar.Location = new System.Drawing.Point(0, 368);
            this.btnCadastrarClienteMenuSalvar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnCadastrarClienteMenuSalvar.Name = "btnCadastrarClienteMenuSalvar";
            this.btnCadastrarClienteMenuSalvar.Size = new System.Drawing.Size(70, 70);
            this.btnCadastrarClienteMenuSalvar.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnCadastrarClienteMenuSalvar, "Salvar");
            this.btnCadastrarClienteMenuSalvar.UseVisualStyleBackColor = true;
            this.btnCadastrarClienteMenuSalvar.Visible = false;
            this.btnCadastrarClienteMenuSalvar.Click += new System.EventHandler(this.BtnCadastrarClienteMenuSalvar_Click);
            // 
            // btnCadastrarClienteMenuLimpar
            // 
            this.btnCadastrarClienteMenuLimpar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrarClienteMenuLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarClienteMenuLimpar.FlatAppearance.BorderSize = 0;
            this.btnCadastrarClienteMenuLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarClienteMenuLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarClienteMenuLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarClienteMenuLimpar.Image = global::UI.Properties.Resources.vassoura64;
            this.btnCadastrarClienteMenuLimpar.Location = new System.Drawing.Point(90, 368);
            this.btnCadastrarClienteMenuLimpar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnCadastrarClienteMenuLimpar.Name = "btnCadastrarClienteMenuLimpar";
            this.btnCadastrarClienteMenuLimpar.Size = new System.Drawing.Size(70, 70);
            this.btnCadastrarClienteMenuLimpar.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnCadastrarClienteMenuLimpar, "Limpar campos");
            this.btnCadastrarClienteMenuLimpar.UseVisualStyleBackColor = true;
            this.btnCadastrarClienteMenuLimpar.Visible = false;
            this.btnCadastrarClienteMenuLimpar.Click += new System.EventHandler(this.BtnCadastrarClienteMenuLimpar_Click);
            // 
            // btnCadastrarClienteMenuSair
            // 
            this.btnCadastrarClienteMenuSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrarClienteMenuSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarClienteMenuSair.FlatAppearance.BorderSize = 0;
            this.btnCadastrarClienteMenuSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarClienteMenuSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarClienteMenuSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarClienteMenuSair.Image = global::UI.Properties.Resources.sair64x64;
            this.btnCadastrarClienteMenuSair.Location = new System.Drawing.Point(180, 368);
            this.btnCadastrarClienteMenuSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarClienteMenuSair.Name = "btnCadastrarClienteMenuSair";
            this.btnCadastrarClienteMenuSair.Size = new System.Drawing.Size(70, 70);
            this.btnCadastrarClienteMenuSair.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnCadastrarClienteMenuSair, "Fechar cadastro");
            this.btnCadastrarClienteMenuSair.UseVisualStyleBackColor = true;
            this.btnCadastrarClienteMenuSair.Visible = false;
            this.btnCadastrarClienteMenuSair.Click += new System.EventHandler(this.BtnCadastrarClienteMenuSair_Click);
            // 
            // frmCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 476);
            this.Controls.Add(this.flpCadastrarClienteCampos);
            this.Controls.Add(this.flpCadastrarClienteTipo);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastrarCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmCadastroCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroCliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.flpCadastrarClienteTipo.ResumeLayout(false);
            this.flpCadastrarClienteTipo.PerformLayout();
            this.flpCadastrarClienteCampos.ResumeLayout(false);
            this.flpCadastrarClienteCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flpCadastrarClienteTipo;
        private System.Windows.Forms.Label lblCadastrarClienteTipo;
        private System.Windows.Forms.ComboBox cmbCadastrarClienteTipo;
        private System.Windows.Forms.FlowLayoutPanel flpCadastrarClienteCampos;
        private System.Windows.Forms.Label lblCadastrarClienteNome;
        private System.Windows.Forms.Label lblCadastrarClienteCPF;
        private System.Windows.Forms.Label lblCadastrarClienteRG;
        private System.Windows.Forms.Label lblCadastrarClienteNascimento;
        private System.Windows.Forms.TextBox txtCadastrarClienteNome;
        private System.Windows.Forms.MaskedTextBox mtxCadastrarClienteCPF;
        private System.Windows.Forms.MaskedTextBox mtxCadastrarClienteRG;
        private System.Windows.Forms.DateTimePicker dtpCadastrarClienteNascimento;
        private System.Windows.Forms.Label lblCadastrarClienteEstadoCivil;
        private System.Windows.Forms.Label lblCadastrarClienteSexo;
        private System.Windows.Forms.Label lblCadastrarClienteCEP;
        private System.Windows.Forms.Label lblCadastrarClienteLogradouro;
        private System.Windows.Forms.ComboBox cmbCadastrarClienteEstadoCivil;
        private System.Windows.Forms.ComboBox cmbCadastrarClienteSexo;
        private System.Windows.Forms.MaskedTextBox mtxCadastrarClienteCEP;
        private System.Windows.Forms.Button btnCadastrarClienteBuscarCep;
        private System.Windows.Forms.TextBox txtCadastrarClienteLogradouro;
        private System.Windows.Forms.Label lblCadastrarClienteNumero;
        private System.Windows.Forms.Label lblCadastrarClienteComplemento;
        private System.Windows.Forms.Label lblCadastrarClienteBairro;
        private System.Windows.Forms.Label lblCadastrarClienteCidade;
        private System.Windows.Forms.Label lblCadastrarClienteUF;
        private System.Windows.Forms.TextBox txtCadastrarClienteNumero;
        private System.Windows.Forms.TextBox txtCadastrarClienteComplemento;
        private System.Windows.Forms.TextBox txtCadastrarClienteBairro;
        private System.Windows.Forms.TextBox txtCadastrarClienteCidade;
        private System.Windows.Forms.TextBox txtCadastrarClienteUF;
        private System.Windows.Forms.Label lblCadastrarClienteDDD;
        private System.Windows.Forms.Label lblCadastrarClienteTelefone;
        private System.Windows.Forms.Label lblCadastrarClienteCelular;
        private System.Windows.Forms.Label lblCadastrarClienteEmail;
        private System.Windows.Forms.MaskedTextBox mtxCadastrarClienteDDD;
        private System.Windows.Forms.MaskedTextBox mtxCadastrarClienteTelefone;
        private System.Windows.Forms.MaskedTextBox mtxCadastrarClienteCelular;
        private System.Windows.Forms.TextBox txtCadastrarClienteEmail;
        private System.Windows.Forms.Button btnCadastrarClienteMenuSalvar;
        private System.Windows.Forms.Button btnCadastrarClienteMenuLimpar;
        private System.Windows.Forms.Button btnCadastrarClienteMenuSair;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}