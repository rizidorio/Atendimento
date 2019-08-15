namespace UI
{
    partial class frmConsultarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flpConsultarClienteCampos = new System.Windows.Forms.FlowLayoutPanel();
            this.lblConsultarClienteNome = new System.Windows.Forms.Label();
            this.lblConsultarClienteCPF = new System.Windows.Forms.Label();
            this.lblConsultarClienteRG = new System.Windows.Forms.Label();
            this.lblConsultarClienteNascimento = new System.Windows.Forms.Label();
            this.txtConsultarClienteNome = new System.Windows.Forms.TextBox();
            this.mtxConsultarClienteCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxConsultarClienteRG = new System.Windows.Forms.MaskedTextBox();
            this.dtpConsultarClienteNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblConsultarClienteEstadoCivil = new System.Windows.Forms.Label();
            this.lblConsultarClienteSexo = new System.Windows.Forms.Label();
            this.lblConsultarClienteCEP = new System.Windows.Forms.Label();
            this.lblConsultarClienteLogradouro = new System.Windows.Forms.Label();
            this.cmbConsultarClienteEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cmbConsultarClienteSexo = new System.Windows.Forms.ComboBox();
            this.mtxConsultarClienteCEP = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultarClienteBuscarCep = new System.Windows.Forms.Button();
            this.txtConsultarClienteLogradouro = new System.Windows.Forms.TextBox();
            this.lblConsultarClienteNumero = new System.Windows.Forms.Label();
            this.lblConsultarClienteComplemento = new System.Windows.Forms.Label();
            this.lblConsultarClienteBairro = new System.Windows.Forms.Label();
            this.lblConsultarClienteCidade = new System.Windows.Forms.Label();
            this.lblConsultarClienteUF = new System.Windows.Forms.Label();
            this.txtConsultarClienteNumero = new System.Windows.Forms.TextBox();
            this.txtConsultarClienteComplemento = new System.Windows.Forms.TextBox();
            this.txtConsultarClienteBairro = new System.Windows.Forms.TextBox();
            this.txtConsultarClienteCidade = new System.Windows.Forms.TextBox();
            this.txtConsultarClienteUF = new System.Windows.Forms.TextBox();
            this.lblConsultarClienteDDD = new System.Windows.Forms.Label();
            this.lblConsultarClienteTelefone = new System.Windows.Forms.Label();
            this.lblConsultarClienteCelular = new System.Windows.Forms.Label();
            this.lblConsultarClienteEmail = new System.Windows.Forms.Label();
            this.lblConsultarClienteAtivo = new System.Windows.Forms.Label();
            this.mtxConsultarClienteDDD = new System.Windows.Forms.MaskedTextBox();
            this.mtxConsultarClienteTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxConsultarClienteCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtConsultarClienteEmail = new System.Windows.Forms.TextBox();
            this.rdoConsultarClienteAtivoSim = new System.Windows.Forms.RadioButton();
            this.rdoConsultarClienteAtivoNao = new System.Windows.Forms.RadioButton();
            this.btnConsultarClienteMenuSalvar = new System.Windows.Forms.Button();
            this.btnConsultarClienteMenuLimpar = new System.Windows.Forms.Button();
            this.btnConsultarClienteMenuSair = new System.Windows.Forms.Button();
            this.dgvConsultarCliente = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlConsultarClienteLista = new System.Windows.Forms.Panel();
            this.flpConsultarClienteProcurar = new System.Windows.Forms.FlowLayoutPanel();
            this.lblConsultarClienteProcurarPor = new System.Windows.Forms.Label();
            this.rdoConsultarClienteProcurarPorNome = new System.Windows.Forms.RadioButton();
            this.rdoConsultarClienteProcurarPorInativo = new System.Windows.Forms.RadioButton();
            this.rdoConsultarClienteProcurarPorCNPJ = new System.Windows.Forms.RadioButton();
            this.rdoConsultarClienteProcurarPorCPF = new System.Windows.Forms.RadioButton();
            this.mtxConsultarClienteProcurarPor = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultarClienteVoltar = new System.Windows.Forms.Button();
            this.flpConsultarClienteMenuLista = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConsultarClienteEditar = new System.Windows.Forms.Button();
            this.btnConsultarClienteDeletar = new System.Windows.Forms.Button();
            this.btnConsultarClienteProcurar = new System.Windows.Forms.Button();
            this.btnConsultarClienteFechar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flpConsultarClienteCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.pnlConsultarClienteLista.SuspendLayout();
            this.flpConsultarClienteProcurar.SuspendLayout();
            this.flpConsultarClienteMenuLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpConsultarClienteCampos
            // 
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteNome);
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteCPF);
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteRG);
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteNascimento);
            this.flpConsultarClienteCampos.Controls.Add(this.txtConsultarClienteNome);
            this.flpConsultarClienteCampos.Controls.Add(this.mtxConsultarClienteCPF);
            this.flpConsultarClienteCampos.Controls.Add(this.mtxConsultarClienteRG);
            this.flpConsultarClienteCampos.Controls.Add(this.dtpConsultarClienteNascimento);
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteEstadoCivil);
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteSexo);
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteCEP);
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteLogradouro);
            this.flpConsultarClienteCampos.Controls.Add(this.cmbConsultarClienteEstadoCivil);
            this.flpConsultarClienteCampos.Controls.Add(this.cmbConsultarClienteSexo);
            this.flpConsultarClienteCampos.Controls.Add(this.mtxConsultarClienteCEP);
            this.flpConsultarClienteCampos.Controls.Add(this.btnConsultarClienteBuscarCep);
            this.flpConsultarClienteCampos.Controls.Add(this.txtConsultarClienteLogradouro);
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteNumero);
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteComplemento);
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteBairro);
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteCidade);
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteUF);
            this.flpConsultarClienteCampos.Controls.Add(this.txtConsultarClienteNumero);
            this.flpConsultarClienteCampos.Controls.Add(this.txtConsultarClienteComplemento);
            this.flpConsultarClienteCampos.Controls.Add(this.txtConsultarClienteBairro);
            this.flpConsultarClienteCampos.Controls.Add(this.txtConsultarClienteCidade);
            this.flpConsultarClienteCampos.Controls.Add(this.txtConsultarClienteUF);
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteDDD);
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteTelefone);
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteCelular);
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteEmail);
            this.flpConsultarClienteCampos.Controls.Add(this.lblConsultarClienteAtivo);
            this.flpConsultarClienteCampos.Controls.Add(this.mtxConsultarClienteDDD);
            this.flpConsultarClienteCampos.Controls.Add(this.mtxConsultarClienteTelefone);
            this.flpConsultarClienteCampos.Controls.Add(this.mtxConsultarClienteCelular);
            this.flpConsultarClienteCampos.Controls.Add(this.txtConsultarClienteEmail);
            this.flpConsultarClienteCampos.Controls.Add(this.rdoConsultarClienteAtivoSim);
            this.flpConsultarClienteCampos.Controls.Add(this.rdoConsultarClienteAtivoNao);
            this.flpConsultarClienteCampos.Controls.Add(this.btnConsultarClienteMenuSalvar);
            this.flpConsultarClienteCampos.Controls.Add(this.btnConsultarClienteMenuLimpar);
            this.flpConsultarClienteCampos.Controls.Add(this.btnConsultarClienteMenuSair);
            this.flpConsultarClienteCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpConsultarClienteCampos.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpConsultarClienteCampos.Location = new System.Drawing.Point(419, 0);
            this.flpConsultarClienteCampos.Margin = new System.Windows.Forms.Padding(0);
            this.flpConsultarClienteCampos.Name = "flpConsultarClienteCampos";
            this.flpConsultarClienteCampos.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.flpConsultarClienteCampos.Size = new System.Drawing.Size(843, 452);
            this.flpConsultarClienteCampos.TabIndex = 4;
            this.flpConsultarClienteCampos.Visible = false;
            // 
            // lblConsultarClienteNome
            // 
            this.lblConsultarClienteNome.AutoSize = true;
            this.lblConsultarClienteNome.Location = new System.Drawing.Point(5, 5);
            this.lblConsultarClienteNome.Margin = new System.Windows.Forms.Padding(0);
            this.lblConsultarClienteNome.Name = "lblConsultarClienteNome";
            this.lblConsultarClienteNome.Size = new System.Drawing.Size(56, 20);
            this.lblConsultarClienteNome.TabIndex = 28;
            this.lblConsultarClienteNome.Text = "Nome";
            // 
            // lblConsultarClienteCPF
            // 
            this.lblConsultarClienteCPF.AutoSize = true;
            this.lblConsultarClienteCPF.Location = new System.Drawing.Point(367, 5);
            this.lblConsultarClienteCPF.Margin = new System.Windows.Forms.Padding(306, 0, 0, 0);
            this.lblConsultarClienteCPF.Name = "lblConsultarClienteCPF";
            this.lblConsultarClienteCPF.Size = new System.Drawing.Size(38, 20);
            this.lblConsultarClienteCPF.TabIndex = 41;
            this.lblConsultarClienteCPF.Text = "CPF";
            // 
            // lblConsultarClienteRG
            // 
            this.lblConsultarClienteRG.AutoSize = true;
            this.lblConsultarClienteRG.Location = new System.Drawing.Point(559, 5);
            this.lblConsultarClienteRG.Margin = new System.Windows.Forms.Padding(154, 0, 0, 0);
            this.lblConsultarClienteRG.Name = "lblConsultarClienteRG";
            this.lblConsultarClienteRG.Size = new System.Drawing.Size(31, 20);
            this.lblConsultarClienteRG.TabIndex = 40;
            this.lblConsultarClienteRG.Text = "RG";
            // 
            // lblConsultarClienteNascimento
            // 
            this.lblConsultarClienteNascimento.AutoSize = true;
            this.lblConsultarClienteNascimento.Location = new System.Drawing.Point(701, 5);
            this.lblConsultarClienteNascimento.Margin = new System.Windows.Forms.Padding(111, 0, 0, 0);
            this.lblConsultarClienteNascimento.Name = "lblConsultarClienteNascimento";
            this.lblConsultarClienteNascimento.Size = new System.Drawing.Size(102, 20);
            this.lblConsultarClienteNascimento.TabIndex = 44;
            this.lblConsultarClienteNascimento.Text = "Nascimento";
            // 
            // txtConsultarClienteNome
            // 
            this.txtConsultarClienteNome.Location = new System.Drawing.Point(8, 25);
            this.txtConsultarClienteNome.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.txtConsultarClienteNome.Name = "txtConsultarClienteNome";
            this.txtConsultarClienteNome.Size = new System.Drawing.Size(340, 32);
            this.txtConsultarClienteNome.TabIndex = 45;
            // 
            // mtxConsultarClienteCPF
            // 
            this.mtxConsultarClienteCPF.Location = new System.Drawing.Point(368, 25);
            this.mtxConsultarClienteCPF.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.mtxConsultarClienteCPF.Mask = "000,000,000-00";
            this.mtxConsultarClienteCPF.Name = "mtxConsultarClienteCPF";
            this.mtxConsultarClienteCPF.Size = new System.Drawing.Size(172, 32);
            this.mtxConsultarClienteCPF.TabIndex = 46;
            this.mtxConsultarClienteCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtxConsultarClienteRG
            // 
            this.mtxConsultarClienteRG.Location = new System.Drawing.Point(560, 25);
            this.mtxConsultarClienteRG.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.mtxConsultarClienteRG.Mask = "00,000,000-0";
            this.mtxConsultarClienteRG.Name = "mtxConsultarClienteRG";
            this.mtxConsultarClienteRG.Size = new System.Drawing.Size(120, 32);
            this.mtxConsultarClienteRG.TabIndex = 47;
            this.mtxConsultarClienteRG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpConsultarClienteNascimento
            // 
            this.dtpConsultarClienteNascimento.CustomFormat = "";
            this.flpConsultarClienteCampos.SetFlowBreak(this.dtpConsultarClienteNascimento, true);
            this.dtpConsultarClienteNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpConsultarClienteNascimento.Location = new System.Drawing.Point(700, 25);
            this.dtpConsultarClienteNascimento.Margin = new System.Windows.Forms.Padding(20, 0, 0, 40);
            this.dtpConsultarClienteNascimento.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpConsultarClienteNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpConsultarClienteNascimento.Name = "dtpConsultarClienteNascimento";
            this.dtpConsultarClienteNascimento.Size = new System.Drawing.Size(132, 32);
            this.dtpConsultarClienteNascimento.TabIndex = 48;
            // 
            // lblConsultarClienteEstadoCivil
            // 
            this.lblConsultarClienteEstadoCivil.AutoSize = true;
            this.lblConsultarClienteEstadoCivil.Location = new System.Drawing.Point(5, 97);
            this.lblConsultarClienteEstadoCivil.Margin = new System.Windows.Forms.Padding(0);
            this.lblConsultarClienteEstadoCivil.Name = "lblConsultarClienteEstadoCivil";
            this.lblConsultarClienteEstadoCivil.Size = new System.Drawing.Size(100, 20);
            this.lblConsultarClienteEstadoCivil.TabIndex = 43;
            this.lblConsultarClienteEstadoCivil.Text = "Estado Civil";
            // 
            // lblConsultarClienteSexo
            // 
            this.lblConsultarClienteSexo.AutoSize = true;
            this.lblConsultarClienteSexo.Location = new System.Drawing.Point(175, 97);
            this.lblConsultarClienteSexo.Margin = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.lblConsultarClienteSexo.Name = "lblConsultarClienteSexo";
            this.lblConsultarClienteSexo.Size = new System.Drawing.Size(48, 20);
            this.lblConsultarClienteSexo.TabIndex = 39;
            this.lblConsultarClienteSexo.Text = "Sexo";
            // 
            // lblConsultarClienteCEP
            // 
            this.lblConsultarClienteCEP.AutoSize = true;
            this.lblConsultarClienteCEP.Location = new System.Drawing.Point(340, 97);
            this.lblConsultarClienteCEP.Margin = new System.Windows.Forms.Padding(117, 0, 0, 0);
            this.lblConsultarClienteCEP.Name = "lblConsultarClienteCEP";
            this.lblConsultarClienteCEP.Size = new System.Drawing.Size(38, 20);
            this.lblConsultarClienteCEP.TabIndex = 42;
            this.lblConsultarClienteCEP.Text = "CEP";
            // 
            // lblConsultarClienteLogradouro
            // 
            this.lblConsultarClienteLogradouro.AutoSize = true;
            this.flpConsultarClienteCampos.SetFlowBreak(this.lblConsultarClienteLogradouro, true);
            this.lblConsultarClienteLogradouro.Location = new System.Drawing.Point(506, 97);
            this.lblConsultarClienteLogradouro.Margin = new System.Windows.Forms.Padding(128, 0, 0, 0);
            this.lblConsultarClienteLogradouro.Name = "lblConsultarClienteLogradouro";
            this.lblConsultarClienteLogradouro.Size = new System.Drawing.Size(101, 20);
            this.lblConsultarClienteLogradouro.TabIndex = 37;
            this.lblConsultarClienteLogradouro.Text = "Logradouro";
            // 
            // cmbConsultarClienteEstadoCivil
            // 
            this.cmbConsultarClienteEstadoCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbConsultarClienteEstadoCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbConsultarClienteEstadoCivil.FormattingEnabled = true;
            this.cmbConsultarClienteEstadoCivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Separado(a)",
            "Viúvo(a)"});
            this.cmbConsultarClienteEstadoCivil.Location = new System.Drawing.Point(8, 119);
            this.cmbConsultarClienteEstadoCivil.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.cmbConsultarClienteEstadoCivil.Name = "cmbConsultarClienteEstadoCivil";
            this.cmbConsultarClienteEstadoCivil.Size = new System.Drawing.Size(149, 28);
            this.cmbConsultarClienteEstadoCivil.TabIndex = 49;
            // 
            // cmbConsultarClienteSexo
            // 
            this.cmbConsultarClienteSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbConsultarClienteSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbConsultarClienteSexo.FormattingEnabled = true;
            this.cmbConsultarClienteSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbConsultarClienteSexo.Location = new System.Drawing.Point(177, 119);
            this.cmbConsultarClienteSexo.Margin = new System.Windows.Forms.Padding(20, 2, 0, 0);
            this.cmbConsultarClienteSexo.Name = "cmbConsultarClienteSexo";
            this.cmbConsultarClienteSexo.Size = new System.Drawing.Size(148, 28);
            this.cmbConsultarClienteSexo.TabIndex = 50;
            // 
            // mtxConsultarClienteCEP
            // 
            this.mtxConsultarClienteCEP.Location = new System.Drawing.Point(345, 117);
            this.mtxConsultarClienteCEP.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.mtxConsultarClienteCEP.Mask = "00,000-000";
            this.mtxConsultarClienteCEP.Name = "mtxConsultarClienteCEP";
            this.mtxConsultarClienteCEP.Size = new System.Drawing.Size(113, 32);
            this.mtxConsultarClienteCEP.TabIndex = 51;
            this.mtxConsultarClienteCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConsultarClienteBuscarCep
            // 
            this.btnConsultarClienteBuscarCep.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarClienteBuscarCep.FlatAppearance.BorderSize = 0;
            this.btnConsultarClienteBuscarCep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarClienteBuscarCep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarClienteBuscarCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClienteBuscarCep.Image = global::UI.Properties.Resources.procurarpq2;
            this.btnConsultarClienteBuscarCep.Location = new System.Drawing.Point(461, 120);
            this.btnConsultarClienteBuscarCep.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnConsultarClienteBuscarCep.Name = "btnConsultarClienteBuscarCep";
            this.btnConsultarClienteBuscarCep.Size = new System.Drawing.Size(25, 25);
            this.btnConsultarClienteBuscarCep.TabIndex = 52;
            this.toolTip1.SetToolTip(this.btnConsultarClienteBuscarCep, "Pesquisar CEP");
            this.btnConsultarClienteBuscarCep.UseVisualStyleBackColor = true;
            this.btnConsultarClienteBuscarCep.Click += new System.EventHandler(this.BtnConsultarClienteBuscarCep_Click);
            // 
            // txtConsultarClienteLogradouro
            // 
            this.flpConsultarClienteCampos.SetFlowBreak(this.txtConsultarClienteLogradouro, true);
            this.txtConsultarClienteLogradouro.Location = new System.Drawing.Point(506, 117);
            this.txtConsultarClienteLogradouro.Margin = new System.Windows.Forms.Padding(20, 0, 0, 40);
            this.txtConsultarClienteLogradouro.Name = "txtConsultarClienteLogradouro";
            this.txtConsultarClienteLogradouro.Size = new System.Drawing.Size(326, 32);
            this.txtConsultarClienteLogradouro.TabIndex = 54;
            // 
            // lblConsultarClienteNumero
            // 
            this.lblConsultarClienteNumero.AutoSize = true;
            this.lblConsultarClienteNumero.Location = new System.Drawing.Point(5, 189);
            this.lblConsultarClienteNumero.Margin = new System.Windows.Forms.Padding(0);
            this.lblConsultarClienteNumero.Name = "lblConsultarClienteNumero";
            this.lblConsultarClienteNumero.Size = new System.Drawing.Size(73, 20);
            this.lblConsultarClienteNumero.TabIndex = 36;
            this.lblConsultarClienteNumero.Text = "Número";
            // 
            // lblConsultarClienteComplemento
            // 
            this.lblConsultarClienteComplemento.AutoSize = true;
            this.lblConsultarClienteComplemento.Location = new System.Drawing.Point(122, 189);
            this.lblConsultarClienteComplemento.Margin = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.lblConsultarClienteComplemento.Name = "lblConsultarClienteComplemento";
            this.lblConsultarClienteComplemento.Size = new System.Drawing.Size(121, 20);
            this.lblConsultarClienteComplemento.TabIndex = 35;
            this.lblConsultarClienteComplemento.Text = "Complemento";
            // 
            // lblConsultarClienteBairro
            // 
            this.lblConsultarClienteBairro.AutoSize = true;
            this.lblConsultarClienteBairro.Location = new System.Drawing.Point(395, 189);
            this.lblConsultarClienteBairro.Margin = new System.Windows.Forms.Padding(152, 0, 0, 0);
            this.lblConsultarClienteBairro.Name = "lblConsultarClienteBairro";
            this.lblConsultarClienteBairro.Size = new System.Drawing.Size(56, 20);
            this.lblConsultarClienteBairro.TabIndex = 38;
            this.lblConsultarClienteBairro.Text = "Bairro";
            // 
            // lblConsultarClienteCidade
            // 
            this.lblConsultarClienteCidade.AutoSize = true;
            this.lblConsultarClienteCidade.Location = new System.Drawing.Point(593, 189);
            this.lblConsultarClienteCidade.Margin = new System.Windows.Forms.Padding(142, 0, 0, 0);
            this.lblConsultarClienteCidade.Name = "lblConsultarClienteCidade";
            this.lblConsultarClienteCidade.Size = new System.Drawing.Size(64, 20);
            this.lblConsultarClienteCidade.TabIndex = 34;
            this.lblConsultarClienteCidade.Text = "Cidade";
            // 
            // lblConsultarClienteUF
            // 
            this.lblConsultarClienteUF.AutoSize = true;
            this.flpConsultarClienteCampos.SetFlowBreak(this.lblConsultarClienteUF, true);
            this.lblConsultarClienteUF.Location = new System.Drawing.Point(783, 189);
            this.lblConsultarClienteUF.Margin = new System.Windows.Forms.Padding(126, 0, 0, 0);
            this.lblConsultarClienteUF.Name = "lblConsultarClienteUF";
            this.lblConsultarClienteUF.Size = new System.Drawing.Size(29, 20);
            this.lblConsultarClienteUF.TabIndex = 33;
            this.lblConsultarClienteUF.Text = "UF";
            // 
            // txtConsultarClienteNumero
            // 
            this.txtConsultarClienteNumero.Location = new System.Drawing.Point(8, 209);
            this.txtConsultarClienteNumero.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.txtConsultarClienteNumero.Name = "txtConsultarClienteNumero";
            this.txtConsultarClienteNumero.Size = new System.Drawing.Size(97, 32);
            this.txtConsultarClienteNumero.TabIndex = 55;
            // 
            // txtConsultarClienteComplemento
            // 
            this.txtConsultarClienteComplemento.Location = new System.Drawing.Point(125, 209);
            this.txtConsultarClienteComplemento.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.txtConsultarClienteComplemento.Name = "txtConsultarClienteComplemento";
            this.txtConsultarClienteComplemento.Size = new System.Drawing.Size(253, 32);
            this.txtConsultarClienteComplemento.TabIndex = 56;
            // 
            // txtConsultarClienteBairro
            // 
            this.txtConsultarClienteBairro.Location = new System.Drawing.Point(398, 209);
            this.txtConsultarClienteBairro.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.txtConsultarClienteBairro.Name = "txtConsultarClienteBairro";
            this.txtConsultarClienteBairro.Size = new System.Drawing.Size(178, 32);
            this.txtConsultarClienteBairro.TabIndex = 57;
            // 
            // txtConsultarClienteCidade
            // 
            this.txtConsultarClienteCidade.Location = new System.Drawing.Point(596, 209);
            this.txtConsultarClienteCidade.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.txtConsultarClienteCidade.Name = "txtConsultarClienteCidade";
            this.txtConsultarClienteCidade.Size = new System.Drawing.Size(171, 32);
            this.txtConsultarClienteCidade.TabIndex = 58;
            // 
            // txtConsultarClienteUF
            // 
            this.flpConsultarClienteCampos.SetFlowBreak(this.txtConsultarClienteUF, true);
            this.txtConsultarClienteUF.Location = new System.Drawing.Point(787, 209);
            this.txtConsultarClienteUF.Margin = new System.Windows.Forms.Padding(20, 0, 0, 40);
            this.txtConsultarClienteUF.Name = "txtConsultarClienteUF";
            this.txtConsultarClienteUF.Size = new System.Drawing.Size(45, 32);
            this.txtConsultarClienteUF.TabIndex = 59;
            // 
            // lblConsultarClienteDDD
            // 
            this.lblConsultarClienteDDD.AutoSize = true;
            this.lblConsultarClienteDDD.Location = new System.Drawing.Point(5, 281);
            this.lblConsultarClienteDDD.Margin = new System.Windows.Forms.Padding(0);
            this.lblConsultarClienteDDD.Name = "lblConsultarClienteDDD";
            this.lblConsultarClienteDDD.Size = new System.Drawing.Size(45, 20);
            this.lblConsultarClienteDDD.TabIndex = 32;
            this.lblConsultarClienteDDD.Text = "DDD";
            // 
            // lblConsultarClienteTelefone
            // 
            this.lblConsultarClienteTelefone.AutoSize = true;
            this.lblConsultarClienteTelefone.Location = new System.Drawing.Point(70, 281);
            this.lblConsultarClienteTelefone.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblConsultarClienteTelefone.Name = "lblConsultarClienteTelefone";
            this.lblConsultarClienteTelefone.Size = new System.Drawing.Size(80, 20);
            this.lblConsultarClienteTelefone.TabIndex = 31;
            this.lblConsultarClienteTelefone.Text = "Telefone";
            // 
            // lblConsultarClienteCelular
            // 
            this.lblConsultarClienteCelular.AutoSize = true;
            this.lblConsultarClienteCelular.Location = new System.Drawing.Point(200, 281);
            this.lblConsultarClienteCelular.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lblConsultarClienteCelular.Name = "lblConsultarClienteCelular";
            this.lblConsultarClienteCelular.Size = new System.Drawing.Size(66, 20);
            this.lblConsultarClienteCelular.TabIndex = 30;
            this.lblConsultarClienteCelular.Text = "Celular";
            // 
            // lblConsultarClienteEmail
            // 
            this.lblConsultarClienteEmail.AutoSize = true;
            this.lblConsultarClienteEmail.Location = new System.Drawing.Point(332, 281);
            this.lblConsultarClienteEmail.Margin = new System.Windows.Forms.Padding(66, 0, 0, 0);
            this.lblConsultarClienteEmail.Name = "lblConsultarClienteEmail";
            this.lblConsultarClienteEmail.Size = new System.Drawing.Size(61, 20);
            this.lblConsultarClienteEmail.TabIndex = 29;
            this.lblConsultarClienteEmail.Text = "E-mail";
            // 
            // lblConsultarClienteAtivo
            // 
            this.lblConsultarClienteAtivo.AutoSize = true;
            this.flpConsultarClienteCampos.SetFlowBreak(this.lblConsultarClienteAtivo, true);
            this.lblConsultarClienteAtivo.Location = new System.Drawing.Point(743, 281);
            this.lblConsultarClienteAtivo.Margin = new System.Windows.Forms.Padding(350, 0, 0, 0);
            this.lblConsultarClienteAtivo.Name = "lblConsultarClienteAtivo";
            this.lblConsultarClienteAtivo.Size = new System.Drawing.Size(49, 20);
            this.lblConsultarClienteAtivo.TabIndex = 67;
            this.lblConsultarClienteAtivo.Text = "Ativo";
            // 
            // mtxConsultarClienteDDD
            // 
            this.mtxConsultarClienteDDD.Location = new System.Drawing.Point(8, 301);
            this.mtxConsultarClienteDDD.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.mtxConsultarClienteDDD.Mask = "(00)";
            this.mtxConsultarClienteDDD.Name = "mtxConsultarClienteDDD";
            this.mtxConsultarClienteDDD.Size = new System.Drawing.Size(42, 32);
            this.mtxConsultarClienteDDD.TabIndex = 60;
            this.mtxConsultarClienteDDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxConsultarClienteTelefone
            // 
            this.mtxConsultarClienteTelefone.Location = new System.Drawing.Point(70, 301);
            this.mtxConsultarClienteTelefone.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.mtxConsultarClienteTelefone.Mask = "00000-0000";
            this.mtxConsultarClienteTelefone.Name = "mtxConsultarClienteTelefone";
            this.mtxConsultarClienteTelefone.Size = new System.Drawing.Size(111, 32);
            this.mtxConsultarClienteTelefone.TabIndex = 61;
            this.mtxConsultarClienteTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxConsultarClienteTelefone.Leave += new System.EventHandler(this.MtxConsultarClienteTelefone_Leave);
            // 
            // mtxConsultarClienteCelular
            // 
            this.mtxConsultarClienteCelular.Location = new System.Drawing.Point(201, 301);
            this.mtxConsultarClienteCelular.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.mtxConsultarClienteCelular.Mask = "00000-0000";
            this.mtxConsultarClienteCelular.Name = "mtxConsultarClienteCelular";
            this.mtxConsultarClienteCelular.Size = new System.Drawing.Size(113, 32);
            this.mtxConsultarClienteCelular.TabIndex = 62;
            this.mtxConsultarClienteCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtConsultarClienteEmail
            // 
            this.txtConsultarClienteEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtConsultarClienteEmail.Location = new System.Drawing.Point(334, 301);
            this.txtConsultarClienteEmail.Margin = new System.Windows.Forms.Padding(20, 0, 20, 40);
            this.txtConsultarClienteEmail.Name = "txtConsultarClienteEmail";
            this.txtConsultarClienteEmail.Size = new System.Drawing.Size(350, 32);
            this.txtConsultarClienteEmail.TabIndex = 63;
            // 
            // rdoConsultarClienteAtivoSim
            // 
            this.rdoConsultarClienteAtivoSim.AutoSize = true;
            this.rdoConsultarClienteAtivoSim.Location = new System.Drawing.Point(704, 306);
            this.rdoConsultarClienteAtivoSim.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.rdoConsultarClienteAtivoSim.Name = "rdoConsultarClienteAtivoSim";
            this.rdoConsultarClienteAtivoSim.Size = new System.Drawing.Size(56, 24);
            this.rdoConsultarClienteAtivoSim.TabIndex = 0;
            this.rdoConsultarClienteAtivoSim.TabStop = true;
            this.rdoConsultarClienteAtivoSim.Text = "Sim";
            this.rdoConsultarClienteAtivoSim.UseVisualStyleBackColor = true;
            // 
            // rdoConsultarClienteAtivoNao
            // 
            this.rdoConsultarClienteAtivoNao.AutoSize = true;
            this.flpConsultarClienteCampos.SetFlowBreak(this.rdoConsultarClienteAtivoNao, true);
            this.rdoConsultarClienteAtivoNao.Location = new System.Drawing.Point(780, 306);
            this.rdoConsultarClienteAtivoNao.Margin = new System.Windows.Forms.Padding(20, 5, 0, 0);
            this.rdoConsultarClienteAtivoNao.Name = "rdoConsultarClienteAtivoNao";
            this.rdoConsultarClienteAtivoNao.Size = new System.Drawing.Size(58, 24);
            this.rdoConsultarClienteAtivoNao.TabIndex = 0;
            this.rdoConsultarClienteAtivoNao.TabStop = true;
            this.rdoConsultarClienteAtivoNao.Text = "Não";
            this.rdoConsultarClienteAtivoNao.UseVisualStyleBackColor = true;
            // 
            // btnConsultarClienteMenuSalvar
            // 
            this.btnConsultarClienteMenuSalvar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarClienteMenuSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarClienteMenuSalvar.FlatAppearance.BorderSize = 0;
            this.btnConsultarClienteMenuSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarClienteMenuSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarClienteMenuSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClienteMenuSalvar.Image = global::UI.Properties.Resources.salvar;
            this.btnConsultarClienteMenuSalvar.Location = new System.Drawing.Point(5, 373);
            this.btnConsultarClienteMenuSalvar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnConsultarClienteMenuSalvar.Name = "btnConsultarClienteMenuSalvar";
            this.btnConsultarClienteMenuSalvar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarClienteMenuSalvar.TabIndex = 64;
            this.toolTip1.SetToolTip(this.btnConsultarClienteMenuSalvar, "Salvar");
            this.btnConsultarClienteMenuSalvar.UseVisualStyleBackColor = true;
            this.btnConsultarClienteMenuSalvar.Click += new System.EventHandler(this.BtnConsultarClienteMenuSalvar_Click);
            // 
            // btnConsultarClienteMenuLimpar
            // 
            this.btnConsultarClienteMenuLimpar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarClienteMenuLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarClienteMenuLimpar.FlatAppearance.BorderSize = 0;
            this.btnConsultarClienteMenuLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarClienteMenuLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarClienteMenuLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClienteMenuLimpar.Image = global::UI.Properties.Resources.vassoura64;
            this.btnConsultarClienteMenuLimpar.Location = new System.Drawing.Point(95, 373);
            this.btnConsultarClienteMenuLimpar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnConsultarClienteMenuLimpar.Name = "btnConsultarClienteMenuLimpar";
            this.btnConsultarClienteMenuLimpar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarClienteMenuLimpar.TabIndex = 65;
            this.toolTip1.SetToolTip(this.btnConsultarClienteMenuLimpar, "Limpar campos");
            this.btnConsultarClienteMenuLimpar.UseVisualStyleBackColor = true;
            this.btnConsultarClienteMenuLimpar.Click += new System.EventHandler(this.BtnConsultarClienteMenuLimpar_Click);
            // 
            // btnConsultarClienteMenuSair
            // 
            this.btnConsultarClienteMenuSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarClienteMenuSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarClienteMenuSair.FlatAppearance.BorderSize = 0;
            this.btnConsultarClienteMenuSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarClienteMenuSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarClienteMenuSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClienteMenuSair.Image = global::UI.Properties.Resources.sair64x64;
            this.btnConsultarClienteMenuSair.Location = new System.Drawing.Point(185, 373);
            this.btnConsultarClienteMenuSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnConsultarClienteMenuSair.Name = "btnConsultarClienteMenuSair";
            this.btnConsultarClienteMenuSair.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarClienteMenuSair.TabIndex = 66;
            this.toolTip1.SetToolTip(this.btnConsultarClienteMenuSair, "Fechar edição");
            this.btnConsultarClienteMenuSair.UseVisualStyleBackColor = true;
            this.btnConsultarClienteMenuSair.Click += new System.EventHandler(this.BtnConsultarClienteMenuSair_Click);
            // 
            // dgvConsultarCliente
            // 
            this.dgvConsultarCliente.AllowUserToAddRows = false;
            this.dgvConsultarCliente.AllowUserToDeleteRows = false;
            this.dgvConsultarCliente.AutoGenerateColumns = false;
            this.dgvConsultarCliente.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvConsultarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultarCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultarCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cpfcnpjDataGridViewTextBoxColumn,
            this.dddDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.logradouroDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.datanascimentoDataGridViewTextBoxColumn});
            this.dgvConsultarCliente.DataSource = this.clienteBindingSource;
            this.dgvConsultarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultarCliente.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvConsultarCliente.Location = new System.Drawing.Point(0, 149);
            this.dgvConsultarCliente.Name = "dgvConsultarCliente";
            this.dgvConsultarCliente.ReadOnly = true;
            this.dgvConsultarCliente.RowTemplate.Height = 30;
            this.dgvConsultarCliente.Size = new System.Drawing.Size(419, 303);
            this.dgvConsultarCliente.TabIndex = 2;
            this.dgvConsultarCliente.Visible = false;
            this.dgvConsultarCliente.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvConsultarCliente_RowHeaderMouseClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 220;
            // 
            // cpfcnpjDataGridViewTextBoxColumn
            // 
            this.cpfcnpjDataGridViewTextBoxColumn.DataPropertyName = "cpf_cnpj";
            this.cpfcnpjDataGridViewTextBoxColumn.HeaderText = "CPF / CNPJ";
            this.cpfcnpjDataGridViewTextBoxColumn.Name = "cpfcnpjDataGridViewTextBoxColumn";
            this.cpfcnpjDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpfcnpjDataGridViewTextBoxColumn.Width = 150;
            // 
            // dddDataGridViewTextBoxColumn
            // 
            this.dddDataGridViewTextBoxColumn.DataPropertyName = "ddd";
            this.dddDataGridViewTextBoxColumn.HeaderText = "DDD";
            this.dddDataGridViewTextBoxColumn.Name = "dddDataGridViewTextBoxColumn";
            this.dddDataGridViewTextBoxColumn.ReadOnly = true;
            this.dddDataGridViewTextBoxColumn.Width = 50;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 120;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            this.celularDataGridViewTextBoxColumn.Width = 120;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 180;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "Cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logradouroDataGridViewTextBoxColumn
            // 
            this.logradouroDataGridViewTextBoxColumn.DataPropertyName = "logradouro";
            this.logradouroDataGridViewTextBoxColumn.HeaderText = "Logradouro";
            this.logradouroDataGridViewTextBoxColumn.Name = "logradouroDataGridViewTextBoxColumn";
            this.logradouroDataGridViewTextBoxColumn.ReadOnly = true;
            this.logradouroDataGridViewTextBoxColumn.Width = 180;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn.Width = 70;
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "Complemento";
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            this.complementoDataGridViewTextBoxColumn.ReadOnly = true;
            this.complementoDataGridViewTextBoxColumn.Width = 120;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "UF";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 50;
            // 
            // datanascimentoDataGridViewTextBoxColumn
            // 
            this.datanascimentoDataGridViewTextBoxColumn.DataPropertyName = "data_nascimento";
            this.datanascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.datanascimentoDataGridViewTextBoxColumn.Name = "datanascimentoDataGridViewTextBoxColumn";
            this.datanascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.datanascimentoDataGridViewTextBoxColumn.Width = 130;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(DAO.cliente);
            // 
            // pnlConsultarClienteLista
            // 
            this.pnlConsultarClienteLista.Controls.Add(this.dgvConsultarCliente);
            this.pnlConsultarClienteLista.Controls.Add(this.flpConsultarClienteProcurar);
            this.pnlConsultarClienteLista.Controls.Add(this.flpConsultarClienteMenuLista);
            this.pnlConsultarClienteLista.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlConsultarClienteLista.Location = new System.Drawing.Point(0, 0);
            this.pnlConsultarClienteLista.Margin = new System.Windows.Forms.Padding(0);
            this.pnlConsultarClienteLista.Name = "pnlConsultarClienteLista";
            this.pnlConsultarClienteLista.Size = new System.Drawing.Size(419, 452);
            this.pnlConsultarClienteLista.TabIndex = 3;
            // 
            // flpConsultarClienteProcurar
            // 
            this.flpConsultarClienteProcurar.Controls.Add(this.lblConsultarClienteProcurarPor);
            this.flpConsultarClienteProcurar.Controls.Add(this.rdoConsultarClienteProcurarPorNome);
            this.flpConsultarClienteProcurar.Controls.Add(this.rdoConsultarClienteProcurarPorInativo);
            this.flpConsultarClienteProcurar.Controls.Add(this.rdoConsultarClienteProcurarPorCNPJ);
            this.flpConsultarClienteProcurar.Controls.Add(this.rdoConsultarClienteProcurarPorCPF);
            this.flpConsultarClienteProcurar.Controls.Add(this.mtxConsultarClienteProcurarPor);
            this.flpConsultarClienteProcurar.Controls.Add(this.btnConsultarClienteVoltar);
            this.flpConsultarClienteProcurar.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpConsultarClienteProcurar.Location = new System.Drawing.Point(0, 72);
            this.flpConsultarClienteProcurar.Margin = new System.Windows.Forms.Padding(0);
            this.flpConsultarClienteProcurar.Name = "flpConsultarClienteProcurar";
            this.flpConsultarClienteProcurar.Padding = new System.Windows.Forms.Padding(5, 10, 0, 5);
            this.flpConsultarClienteProcurar.Size = new System.Drawing.Size(419, 77);
            this.flpConsultarClienteProcurar.TabIndex = 1;
            this.flpConsultarClienteProcurar.Visible = false;
            // 
            // lblConsultarClienteProcurarPor
            // 
            this.lblConsultarClienteProcurarPor.AutoSize = true;
            this.lblConsultarClienteProcurarPor.Location = new System.Drawing.Point(5, 10);
            this.lblConsultarClienteProcurarPor.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblConsultarClienteProcurarPor.Name = "lblConsultarClienteProcurarPor";
            this.lblConsultarClienteProcurarPor.Size = new System.Drawing.Size(113, 20);
            this.lblConsultarClienteProcurarPor.TabIndex = 0;
            this.lblConsultarClienteProcurarPor.Text = "Procurar por:";
            // 
            // rdoConsultarClienteProcurarPorNome
            // 
            this.rdoConsultarClienteProcurarPorNome.AutoSize = true;
            this.rdoConsultarClienteProcurarPorNome.Location = new System.Drawing.Point(128, 10);
            this.rdoConsultarClienteProcurarPorNome.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.rdoConsultarClienteProcurarPorNome.Name = "rdoConsultarClienteProcurarPorNome";
            this.rdoConsultarClienteProcurarPorNome.Size = new System.Drawing.Size(74, 24);
            this.rdoConsultarClienteProcurarPorNome.TabIndex = 1;
            this.rdoConsultarClienteProcurarPorNome.TabStop = true;
            this.rdoConsultarClienteProcurarPorNome.Text = "Nome";
            this.rdoConsultarClienteProcurarPorNome.UseVisualStyleBackColor = true;
            this.rdoConsultarClienteProcurarPorNome.Click += new System.EventHandler(this.RdoConsultarClienteProcurarPorNome_Click);
            // 
            // rdoConsultarClienteProcurarPorInativo
            // 
            this.rdoConsultarClienteProcurarPorInativo.AutoSize = true;
            this.rdoConsultarClienteProcurarPorInativo.Location = new System.Drawing.Point(207, 10);
            this.rdoConsultarClienteProcurarPorInativo.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.rdoConsultarClienteProcurarPorInativo.Name = "rdoConsultarClienteProcurarPorInativo";
            this.rdoConsultarClienteProcurarPorInativo.Size = new System.Drawing.Size(80, 24);
            this.rdoConsultarClienteProcurarPorInativo.TabIndex = 2;
            this.rdoConsultarClienteProcurarPorInativo.TabStop = true;
            this.rdoConsultarClienteProcurarPorInativo.Text = "Inativo";
            this.rdoConsultarClienteProcurarPorInativo.UseVisualStyleBackColor = true;
            this.rdoConsultarClienteProcurarPorInativo.Click += new System.EventHandler(this.RdoConsultarClienteProcurarPorInativo_Click);
            // 
            // rdoConsultarClienteProcurarPorCNPJ
            // 
            this.rdoConsultarClienteProcurarPorCNPJ.AutoSize = true;
            this.rdoConsultarClienteProcurarPorCNPJ.Location = new System.Drawing.Point(292, 10);
            this.rdoConsultarClienteProcurarPorCNPJ.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.rdoConsultarClienteProcurarPorCNPJ.Name = "rdoConsultarClienteProcurarPorCNPJ";
            this.rdoConsultarClienteProcurarPorCNPJ.Size = new System.Drawing.Size(64, 24);
            this.rdoConsultarClienteProcurarPorCNPJ.TabIndex = 5;
            this.rdoConsultarClienteProcurarPorCNPJ.TabStop = true;
            this.rdoConsultarClienteProcurarPorCNPJ.Text = "CNPJ";
            this.rdoConsultarClienteProcurarPorCNPJ.UseVisualStyleBackColor = true;
            this.rdoConsultarClienteProcurarPorCNPJ.Click += new System.EventHandler(this.RdoConsultarClienteProcurarPorCNPJ_Click);
            // 
            // rdoConsultarClienteProcurarPorCPF
            // 
            this.rdoConsultarClienteProcurarPorCPF.AutoSize = true;
            this.flpConsultarClienteProcurar.SetFlowBreak(this.rdoConsultarClienteProcurarPorCPF, true);
            this.rdoConsultarClienteProcurarPorCPF.Location = new System.Drawing.Point(361, 10);
            this.rdoConsultarClienteProcurarPorCPF.Margin = new System.Windows.Forms.Padding(0);
            this.rdoConsultarClienteProcurarPorCPF.Name = "rdoConsultarClienteProcurarPorCPF";
            this.rdoConsultarClienteProcurarPorCPF.Size = new System.Drawing.Size(56, 24);
            this.rdoConsultarClienteProcurarPorCPF.TabIndex = 2;
            this.rdoConsultarClienteProcurarPorCPF.TabStop = true;
            this.rdoConsultarClienteProcurarPorCPF.Text = "CPF";
            this.rdoConsultarClienteProcurarPorCPF.UseVisualStyleBackColor = true;
            this.rdoConsultarClienteProcurarPorCPF.Click += new System.EventHandler(this.RdoConsultarClienteProcurarPorCPF_Click);
            // 
            // mtxConsultarClienteProcurarPor
            // 
            this.mtxConsultarClienteProcurarPor.Location = new System.Drawing.Point(8, 37);
            this.mtxConsultarClienteProcurarPor.Name = "mtxConsultarClienteProcurarPor";
            this.mtxConsultarClienteProcurarPor.Size = new System.Drawing.Size(335, 32);
            this.mtxConsultarClienteProcurarPor.TabIndex = 27;
            this.mtxConsultarClienteProcurarPor.Visible = false;
            this.mtxConsultarClienteProcurarPor.TextChanged += new System.EventHandler(this.MtxConsultarClienteProcurarPor_TextChanged);
            // 
            // btnConsultarClienteVoltar
            // 
            this.btnConsultarClienteVoltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarClienteVoltar.FlatAppearance.BorderSize = 0;
            this.btnConsultarClienteVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarClienteVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarClienteVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClienteVoltar.Image = global::UI.Properties.Resources.voltar32x32;
            this.btnConsultarClienteVoltar.Location = new System.Drawing.Point(356, 34);
            this.btnConsultarClienteVoltar.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConsultarClienteVoltar.Name = "btnConsultarClienteVoltar";
            this.btnConsultarClienteVoltar.Size = new System.Drawing.Size(34, 34);
            this.btnConsultarClienteVoltar.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnConsultarClienteVoltar, "Voltar");
            this.btnConsultarClienteVoltar.UseVisualStyleBackColor = true;
            this.btnConsultarClienteVoltar.Visible = false;
            this.btnConsultarClienteVoltar.Click += new System.EventHandler(this.BtnConsultarClienteVoltar_Click);
            // 
            // flpConsultarClienteMenuLista
            // 
            this.flpConsultarClienteMenuLista.Controls.Add(this.btnConsultarClienteEditar);
            this.flpConsultarClienteMenuLista.Controls.Add(this.btnConsultarClienteDeletar);
            this.flpConsultarClienteMenuLista.Controls.Add(this.btnConsultarClienteProcurar);
            this.flpConsultarClienteMenuLista.Controls.Add(this.btnConsultarClienteFechar);
            this.flpConsultarClienteMenuLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpConsultarClienteMenuLista.Location = new System.Drawing.Point(0, 0);
            this.flpConsultarClienteMenuLista.Name = "flpConsultarClienteMenuLista";
            this.flpConsultarClienteMenuLista.Size = new System.Drawing.Size(419, 72);
            this.flpConsultarClienteMenuLista.TabIndex = 0;
            // 
            // btnConsultarClienteEditar
            // 
            this.btnConsultarClienteEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarClienteEditar.FlatAppearance.BorderSize = 0;
            this.btnConsultarClienteEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarClienteEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarClienteEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClienteEditar.Image = global::UI.Properties.Resources.editar;
            this.btnConsultarClienteEditar.Location = new System.Drawing.Point(0, 0);
            this.btnConsultarClienteEditar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnConsultarClienteEditar.Name = "btnConsultarClienteEditar";
            this.btnConsultarClienteEditar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarClienteEditar.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnConsultarClienteEditar, "Editar");
            this.btnConsultarClienteEditar.UseVisualStyleBackColor = true;
            this.btnConsultarClienteEditar.Visible = false;
            this.btnConsultarClienteEditar.Click += new System.EventHandler(this.BtnConsultarClienteEditar_Click);
            // 
            // btnConsultarClienteDeletar
            // 
            this.btnConsultarClienteDeletar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarClienteDeletar.FlatAppearance.BorderSize = 0;
            this.btnConsultarClienteDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarClienteDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarClienteDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClienteDeletar.Image = global::UI.Properties.Resources.apagar;
            this.btnConsultarClienteDeletar.Location = new System.Drawing.Point(90, 0);
            this.btnConsultarClienteDeletar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnConsultarClienteDeletar.Name = "btnConsultarClienteDeletar";
            this.btnConsultarClienteDeletar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarClienteDeletar.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnConsultarClienteDeletar, "Excluir");
            this.btnConsultarClienteDeletar.UseVisualStyleBackColor = true;
            this.btnConsultarClienteDeletar.Visible = false;
            this.btnConsultarClienteDeletar.Click += new System.EventHandler(this.BtnConsultarClienteDeletar_Click);
            // 
            // btnConsultarClienteProcurar
            // 
            this.btnConsultarClienteProcurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarClienteProcurar.FlatAppearance.BorderSize = 0;
            this.btnConsultarClienteProcurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarClienteProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarClienteProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClienteProcurar.Image = global::UI.Properties.Resources.procurar;
            this.btnConsultarClienteProcurar.Location = new System.Drawing.Point(180, 0);
            this.btnConsultarClienteProcurar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnConsultarClienteProcurar.Name = "btnConsultarClienteProcurar";
            this.btnConsultarClienteProcurar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarClienteProcurar.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnConsultarClienteProcurar, "Procurar");
            this.btnConsultarClienteProcurar.UseVisualStyleBackColor = true;
            this.btnConsultarClienteProcurar.Click += new System.EventHandler(this.BtnConsultarClienteProcurar_Click);
            // 
            // btnConsultarClienteFechar
            // 
            this.btnConsultarClienteFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarClienteFechar.FlatAppearance.BorderSize = 0;
            this.btnConsultarClienteFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarClienteFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarClienteFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClienteFechar.Image = global::UI.Properties.Resources.fechar1;
            this.btnConsultarClienteFechar.Location = new System.Drawing.Point(270, 0);
            this.btnConsultarClienteFechar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnConsultarClienteFechar.Name = "btnConsultarClienteFechar";
            this.btnConsultarClienteFechar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarClienteFechar.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnConsultarClienteFechar, "Fechar");
            this.btnConsultarClienteFechar.UseVisualStyleBackColor = true;
            this.btnConsultarClienteFechar.Click += new System.EventHandler(this.BtnConsultarClienteFechar_Click);
            // 
            // frmConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 452);
            this.Controls.Add(this.flpConsultarClienteCampos);
            this.Controls.Add(this.pnlConsultarClienteLista);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmConsultarCliente";
            this.Text = "Consultar Clientes";
            this.Load += new System.EventHandler(this.FrmConsultarCliente_Load);
            this.flpConsultarClienteCampos.ResumeLayout(false);
            this.flpConsultarClienteCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.pnlConsultarClienteLista.ResumeLayout(false);
            this.flpConsultarClienteProcurar.ResumeLayout(false);
            this.flpConsultarClienteProcurar.PerformLayout();
            this.flpConsultarClienteMenuLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpConsultarClienteCampos;
        private System.Windows.Forms.DataGridView dgvConsultarCliente;
        private System.Windows.Forms.Panel pnlConsultarClienteLista;
        private System.Windows.Forms.FlowLayoutPanel flpConsultarClienteProcurar;
        private System.Windows.Forms.Label lblConsultarClienteProcurarPor;
        private System.Windows.Forms.RadioButton rdoConsultarClienteProcurarPorNome;
        private System.Windows.Forms.RadioButton rdoConsultarClienteProcurarPorInativo;
        private System.Windows.Forms.RadioButton rdoConsultarClienteProcurarPorCNPJ;
        private System.Windows.Forms.RadioButton rdoConsultarClienteProcurarPorCPF;
        private System.Windows.Forms.MaskedTextBox mtxConsultarClienteProcurarPor;
        private System.Windows.Forms.Button btnConsultarClienteVoltar;
        private System.Windows.Forms.FlowLayoutPanel flpConsultarClienteMenuLista;
        private System.Windows.Forms.Button btnConsultarClienteEditar;
        private System.Windows.Forms.Button btnConsultarClienteDeletar;
        private System.Windows.Forms.Button btnConsultarClienteProcurar;
        private System.Windows.Forms.Button btnConsultarClienteFechar;
        private System.Windows.Forms.Label lblConsultarClienteNome;
        private System.Windows.Forms.Label lblConsultarClienteCPF;
        private System.Windows.Forms.Label lblConsultarClienteRG;
        private System.Windows.Forms.Label lblConsultarClienteNascimento;
        private System.Windows.Forms.TextBox txtConsultarClienteNome;
        private System.Windows.Forms.MaskedTextBox mtxConsultarClienteCPF;
        private System.Windows.Forms.MaskedTextBox mtxConsultarClienteRG;
        private System.Windows.Forms.DateTimePicker dtpConsultarClienteNascimento;
        private System.Windows.Forms.Label lblConsultarClienteEstadoCivil;
        private System.Windows.Forms.Label lblConsultarClienteSexo;
        private System.Windows.Forms.Label lblConsultarClienteCEP;
        private System.Windows.Forms.Label lblConsultarClienteLogradouro;
        private System.Windows.Forms.ComboBox cmbConsultarClienteEstadoCivil;
        private System.Windows.Forms.ComboBox cmbConsultarClienteSexo;
        private System.Windows.Forms.MaskedTextBox mtxConsultarClienteCEP;
        private System.Windows.Forms.Button btnConsultarClienteBuscarCep;
        private System.Windows.Forms.TextBox txtConsultarClienteLogradouro;
        private System.Windows.Forms.Label lblConsultarClienteNumero;
        private System.Windows.Forms.Label lblConsultarClienteComplemento;
        private System.Windows.Forms.Label lblConsultarClienteBairro;
        private System.Windows.Forms.Label lblConsultarClienteCidade;
        private System.Windows.Forms.Label lblConsultarClienteUF;
        private System.Windows.Forms.TextBox txtConsultarClienteNumero;
        private System.Windows.Forms.TextBox txtConsultarClienteComplemento;
        private System.Windows.Forms.TextBox txtConsultarClienteBairro;
        private System.Windows.Forms.TextBox txtConsultarClienteCidade;
        private System.Windows.Forms.TextBox txtConsultarClienteUF;
        private System.Windows.Forms.Label lblConsultarClienteDDD;
        private System.Windows.Forms.Label lblConsultarClienteTelefone;
        private System.Windows.Forms.Label lblConsultarClienteCelular;
        private System.Windows.Forms.Label lblConsultarClienteEmail;
        private System.Windows.Forms.Label lblConsultarClienteAtivo;
        private System.Windows.Forms.MaskedTextBox mtxConsultarClienteDDD;
        private System.Windows.Forms.MaskedTextBox mtxConsultarClienteTelefone;
        private System.Windows.Forms.MaskedTextBox mtxConsultarClienteCelular;
        private System.Windows.Forms.TextBox txtConsultarClienteEmail;
        private System.Windows.Forms.RadioButton rdoConsultarClienteAtivoSim;
        private System.Windows.Forms.RadioButton rdoConsultarClienteAtivoNao;
        private System.Windows.Forms.Button btnConsultarClienteMenuSalvar;
        private System.Windows.Forms.Button btnConsultarClienteMenuLimpar;
        private System.Windows.Forms.Button btnConsultarClienteMenuSair;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}