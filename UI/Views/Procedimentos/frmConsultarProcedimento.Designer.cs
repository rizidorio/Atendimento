namespace UI
{
    partial class frmConsultarProcedimentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlConsultarProcedimentosLista = new System.Windows.Forms.Panel();
            this.dgvConsultarProcedimentos = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoprocedimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flpConsultarProcedimentosProcurar = new System.Windows.Forms.FlowLayoutPanel();
            this.lblConsultarProcedimentosProcurarPor = new System.Windows.Forms.Label();
            this.rdoConsultarProcedimentosProcurarPorNome = new System.Windows.Forms.RadioButton();
            this.rdoConsultarProcedimentosProcurarInativo = new System.Windows.Forms.RadioButton();
            this.mtxConsultarProcedimentosProcurarPor = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultarProcedimentosVoltar = new System.Windows.Forms.Button();
            this.flpConsultarProcedimentosMenuLista = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConsultarProcedimentosEditar = new System.Windows.Forms.Button();
            this.btnConsultarProcedimentosDeletar = new System.Windows.Forms.Button();
            this.btnConsultarProcedimentosProcurar = new System.Windows.Forms.Button();
            this.btnConsultarProcedimentosFechar = new System.Windows.Forms.Button();
            this.grupoprocedimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlConsultarProcedimentosCampos = new System.Windows.Forms.Panel();
            this.txtConsultarProcedimentosDescricao = new System.Windows.Forms.TextBox();
            this.lblConsultarProcedimentosNome = new System.Windows.Forms.Label();
            this.lblConsultarProcedimentosGrupo = new System.Windows.Forms.Label();
            this.grpConsultarProcedimentosAtivo = new System.Windows.Forms.GroupBox();
            this.rdoConsultarProcedimentosAtivoNao = new System.Windows.Forms.RadioButton();
            this.rdoConsultarProcedimentosAtivoSim = new System.Windows.Forms.RadioButton();
            this.btnConsultarProcedimentosAddGrupo = new System.Windows.Forms.Button();
            this.btnConsultarProcedimentosSalvar = new System.Windows.Forms.Button();
            this.btnConsultarProcedimentosLimpar = new System.Windows.Forms.Button();
            this.btnConsultarProcedimentosSair = new System.Windows.Forms.Button();
            this.txtConsultarProcedimentosValor = new System.Windows.Forms.TextBox();
            this.lblConsultarProcedimentosValor = new System.Windows.Forms.Label();
            this.cmbConsultarProcedimentosGrupo = new System.Windows.Forms.ComboBox();
            this.txtConsultarProcedimentosNome = new System.Windows.Forms.TextBox();
            this.lblConsultarProcedimentosDescricao = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlConsultarProcedimentosLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarProcedimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedimentoBindingSource)).BeginInit();
            this.flpConsultarProcedimentosProcurar.SuspendLayout();
            this.flpConsultarProcedimentosMenuLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoprocedimentoBindingSource)).BeginInit();
            this.pnlConsultarProcedimentosCampos.SuspendLayout();
            this.grpConsultarProcedimentosAtivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConsultarProcedimentosLista
            // 
            this.pnlConsultarProcedimentosLista.Controls.Add(this.dgvConsultarProcedimentos);
            this.pnlConsultarProcedimentosLista.Controls.Add(this.flpConsultarProcedimentosProcurar);
            this.pnlConsultarProcedimentosLista.Controls.Add(this.flpConsultarProcedimentosMenuLista);
            this.pnlConsultarProcedimentosLista.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlConsultarProcedimentosLista.Location = new System.Drawing.Point(0, 0);
            this.pnlConsultarProcedimentosLista.Margin = new System.Windows.Forms.Padding(0);
            this.pnlConsultarProcedimentosLista.Name = "pnlConsultarProcedimentosLista";
            this.pnlConsultarProcedimentosLista.Size = new System.Drawing.Size(401, 348);
            this.pnlConsultarProcedimentosLista.TabIndex = 2;
            // 
            // dgvConsultarProcedimentos
            // 
            this.dgvConsultarProcedimentos.AllowUserToAddRows = false;
            this.dgvConsultarProcedimentos.AllowUserToDeleteRows = false;
            this.dgvConsultarProcedimentos.AutoGenerateColumns = false;
            this.dgvConsultarProcedimentos.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvConsultarProcedimentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultarProcedimentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultarProcedimentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConsultarProcedimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarProcedimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.grupoprocedimentoDataGridViewTextBoxColumn});
            this.dgvConsultarProcedimentos.DataSource = this.procedimentoBindingSource;
            this.dgvConsultarProcedimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultarProcedimentos.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvConsultarProcedimentos.Location = new System.Drawing.Point(0, 150);
            this.dgvConsultarProcedimentos.Name = "dgvConsultarProcedimentos";
            this.dgvConsultarProcedimentos.ReadOnly = true;
            this.dgvConsultarProcedimentos.RowTemplate.Height = 30;
            this.dgvConsultarProcedimentos.Size = new System.Drawing.Size(401, 198);
            this.dgvConsultarProcedimentos.TabIndex = 2;
            this.dgvConsultarProcedimentos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvConsultarProcedimentos_CellFormatting);
            this.dgvConsultarProcedimentos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvConsultarProcedimentos_RowHeaderMouseClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Procedimento";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 220;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 250;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.valorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorDataGridViewTextBoxColumn.Width = 130;
            // 
            // grupoprocedimentoDataGridViewTextBoxColumn
            // 
            this.grupoprocedimentoDataGridViewTextBoxColumn.DataPropertyName = "grupo_procedimento1";
            this.grupoprocedimentoDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.grupoprocedimentoDataGridViewTextBoxColumn.Name = "grupoprocedimentoDataGridViewTextBoxColumn";
            this.grupoprocedimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.grupoprocedimentoDataGridViewTextBoxColumn.Width = 200;
            // 
            // procedimentoBindingSource
            // 
            this.procedimentoBindingSource.DataSource = typeof(DAO.procedimento);
            // 
            // flpConsultarProcedimentosProcurar
            // 
            this.flpConsultarProcedimentosProcurar.Controls.Add(this.lblConsultarProcedimentosProcurarPor);
            this.flpConsultarProcedimentosProcurar.Controls.Add(this.rdoConsultarProcedimentosProcurarPorNome);
            this.flpConsultarProcedimentosProcurar.Controls.Add(this.rdoConsultarProcedimentosProcurarInativo);
            this.flpConsultarProcedimentosProcurar.Controls.Add(this.mtxConsultarProcedimentosProcurarPor);
            this.flpConsultarProcedimentosProcurar.Controls.Add(this.btnConsultarProcedimentosVoltar);
            this.flpConsultarProcedimentosProcurar.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpConsultarProcedimentosProcurar.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpConsultarProcedimentosProcurar.Location = new System.Drawing.Point(0, 72);
            this.flpConsultarProcedimentosProcurar.Margin = new System.Windows.Forms.Padding(0);
            this.flpConsultarProcedimentosProcurar.Name = "flpConsultarProcedimentosProcurar";
            this.flpConsultarProcedimentosProcurar.Padding = new System.Windows.Forms.Padding(5, 10, 0, 5);
            this.flpConsultarProcedimentosProcurar.Size = new System.Drawing.Size(401, 78);
            this.flpConsultarProcedimentosProcurar.TabIndex = 1;
            this.flpConsultarProcedimentosProcurar.Visible = false;
            // 
            // lblConsultarProcedimentosProcurarPor
            // 
            this.lblConsultarProcedimentosProcurarPor.AutoSize = true;
            this.lblConsultarProcedimentosProcurarPor.Location = new System.Drawing.Point(5, 10);
            this.lblConsultarProcedimentosProcurarPor.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblConsultarProcedimentosProcurarPor.Name = "lblConsultarProcedimentosProcurarPor";
            this.lblConsultarProcedimentosProcurarPor.Size = new System.Drawing.Size(113, 20);
            this.lblConsultarProcedimentosProcurarPor.TabIndex = 0;
            this.lblConsultarProcedimentosProcurarPor.Text = "Procurar por:";
            // 
            // rdoConsultarProcedimentosProcurarPorNome
            // 
            this.rdoConsultarProcedimentosProcurarPorNome.AutoSize = true;
            this.rdoConsultarProcedimentosProcurarPorNome.Location = new System.Drawing.Point(128, 10);
            this.rdoConsultarProcedimentosProcurarPorNome.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.rdoConsultarProcedimentosProcurarPorNome.Name = "rdoConsultarProcedimentosProcurarPorNome";
            this.rdoConsultarProcedimentosProcurarPorNome.Size = new System.Drawing.Size(74, 24);
            this.rdoConsultarProcedimentosProcurarPorNome.TabIndex = 1;
            this.rdoConsultarProcedimentosProcurarPorNome.TabStop = true;
            this.rdoConsultarProcedimentosProcurarPorNome.Text = "Nome";
            this.rdoConsultarProcedimentosProcurarPorNome.UseVisualStyleBackColor = true;
            this.rdoConsultarProcedimentosProcurarPorNome.Click += new System.EventHandler(this.RdoConsultarProcedimentosProcurarPorNome_Click);
            // 
            // rdoConsultarProcedimentosProcurarInativo
            // 
            this.rdoConsultarProcedimentosProcurarInativo.AutoSize = true;
            this.rdoConsultarProcedimentosProcurarInativo.Location = new System.Drawing.Point(207, 10);
            this.rdoConsultarProcedimentosProcurarInativo.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.rdoConsultarProcedimentosProcurarInativo.Name = "rdoConsultarProcedimentosProcurarInativo";
            this.rdoConsultarProcedimentosProcurarInativo.Size = new System.Drawing.Size(80, 24);
            this.rdoConsultarProcedimentosProcurarInativo.TabIndex = 2;
            this.rdoConsultarProcedimentosProcurarInativo.TabStop = true;
            this.rdoConsultarProcedimentosProcurarInativo.Text = "Inativo";
            this.rdoConsultarProcedimentosProcurarInativo.UseVisualStyleBackColor = true;
            this.rdoConsultarProcedimentosProcurarInativo.Click += new System.EventHandler(this.RdoConsultarProcedimentosProcurarInativo_Click);
            // 
            // mtxConsultarProcedimentosProcurarPor
            // 
            this.mtxConsultarProcedimentosProcurarPor.Location = new System.Drawing.Point(8, 37);
            this.mtxConsultarProcedimentosProcurarPor.Name = "mtxConsultarProcedimentosProcurarPor";
            this.mtxConsultarProcedimentosProcurarPor.Size = new System.Drawing.Size(335, 32);
            this.mtxConsultarProcedimentosProcurarPor.TabIndex = 27;
            this.mtxConsultarProcedimentosProcurarPor.Visible = false;
            this.mtxConsultarProcedimentosProcurarPor.TextChanged += new System.EventHandler(this.MtxConsultarProcedimentosProcurarPor_TextChanged);
            // 
            // btnConsultarProcedimentosVoltar
            // 
            this.btnConsultarProcedimentosVoltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosVoltar.FlatAppearance.BorderSize = 0;
            this.btnConsultarProcedimentosVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarProcedimentosVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProcedimentosVoltar.Image = global::UI.Properties.Resources.voltar32x32;
            this.btnConsultarProcedimentosVoltar.Location = new System.Drawing.Point(356, 34);
            this.btnConsultarProcedimentosVoltar.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConsultarProcedimentosVoltar.Name = "btnConsultarProcedimentosVoltar";
            this.btnConsultarProcedimentosVoltar.Size = new System.Drawing.Size(34, 34);
            this.btnConsultarProcedimentosVoltar.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnConsultarProcedimentosVoltar, "Voltar");
            this.btnConsultarProcedimentosVoltar.UseVisualStyleBackColor = true;
            this.btnConsultarProcedimentosVoltar.Visible = false;
            this.btnConsultarProcedimentosVoltar.Click += new System.EventHandler(this.BtnConsultarProcedimentosVoltar_Click);
            // 
            // flpConsultarProcedimentosMenuLista
            // 
            this.flpConsultarProcedimentosMenuLista.Controls.Add(this.btnConsultarProcedimentosEditar);
            this.flpConsultarProcedimentosMenuLista.Controls.Add(this.btnConsultarProcedimentosDeletar);
            this.flpConsultarProcedimentosMenuLista.Controls.Add(this.btnConsultarProcedimentosProcurar);
            this.flpConsultarProcedimentosMenuLista.Controls.Add(this.btnConsultarProcedimentosFechar);
            this.flpConsultarProcedimentosMenuLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpConsultarProcedimentosMenuLista.Location = new System.Drawing.Point(0, 0);
            this.flpConsultarProcedimentosMenuLista.Name = "flpConsultarProcedimentosMenuLista";
            this.flpConsultarProcedimentosMenuLista.Size = new System.Drawing.Size(401, 72);
            this.flpConsultarProcedimentosMenuLista.TabIndex = 0;
            // 
            // btnConsultarProcedimentosEditar
            // 
            this.btnConsultarProcedimentosEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosEditar.FlatAppearance.BorderSize = 0;
            this.btnConsultarProcedimentosEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarProcedimentosEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProcedimentosEditar.Image = global::UI.Properties.Resources.edit64x64;
            this.btnConsultarProcedimentosEditar.Location = new System.Drawing.Point(0, 0);
            this.btnConsultarProcedimentosEditar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnConsultarProcedimentosEditar.Name = "btnConsultarProcedimentosEditar";
            this.btnConsultarProcedimentosEditar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarProcedimentosEditar.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnConsultarProcedimentosEditar, "Editar");
            this.btnConsultarProcedimentosEditar.UseVisualStyleBackColor = true;
            this.btnConsultarProcedimentosEditar.Visible = false;
            this.btnConsultarProcedimentosEditar.Click += new System.EventHandler(this.BtnConsultarProcedimentosEditar_Click);
            // 
            // btnConsultarProcedimentosDeletar
            // 
            this.btnConsultarProcedimentosDeletar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosDeletar.FlatAppearance.BorderSize = 0;
            this.btnConsultarProcedimentosDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarProcedimentosDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProcedimentosDeletar.Image = global::UI.Properties.Resources.excluir64x64;
            this.btnConsultarProcedimentosDeletar.Location = new System.Drawing.Point(90, 0);
            this.btnConsultarProcedimentosDeletar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnConsultarProcedimentosDeletar.Name = "btnConsultarProcedimentosDeletar";
            this.btnConsultarProcedimentosDeletar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarProcedimentosDeletar.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnConsultarProcedimentosDeletar, "Excluir");
            this.btnConsultarProcedimentosDeletar.UseVisualStyleBackColor = true;
            this.btnConsultarProcedimentosDeletar.Visible = false;
            this.btnConsultarProcedimentosDeletar.Click += new System.EventHandler(this.BtnConsultarProcedimentosDeletar_Click);
            // 
            // btnConsultarProcedimentosProcurar
            // 
            this.btnConsultarProcedimentosProcurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosProcurar.FlatAppearance.BorderSize = 0;
            this.btnConsultarProcedimentosProcurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarProcedimentosProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProcedimentosProcurar.Image = global::UI.Properties.Resources.procurar;
            this.btnConsultarProcedimentosProcurar.Location = new System.Drawing.Point(180, 0);
            this.btnConsultarProcedimentosProcurar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnConsultarProcedimentosProcurar.Name = "btnConsultarProcedimentosProcurar";
            this.btnConsultarProcedimentosProcurar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarProcedimentosProcurar.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnConsultarProcedimentosProcurar, "Procurar");
            this.btnConsultarProcedimentosProcurar.UseVisualStyleBackColor = true;
            this.btnConsultarProcedimentosProcurar.Click += new System.EventHandler(this.BtnConsultarProcedimentosProcurar_Click);
            // 
            // btnConsultarProcedimentosFechar
            // 
            this.btnConsultarProcedimentosFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosFechar.FlatAppearance.BorderSize = 0;
            this.btnConsultarProcedimentosFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarProcedimentosFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProcedimentosFechar.Image = global::UI.Properties.Resources.fechar1;
            this.btnConsultarProcedimentosFechar.Location = new System.Drawing.Point(270, 0);
            this.btnConsultarProcedimentosFechar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnConsultarProcedimentosFechar.Name = "btnConsultarProcedimentosFechar";
            this.btnConsultarProcedimentosFechar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarProcedimentosFechar.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnConsultarProcedimentosFechar, "Fechar");
            this.btnConsultarProcedimentosFechar.UseVisualStyleBackColor = true;
            this.btnConsultarProcedimentosFechar.Click += new System.EventHandler(this.BtnConsultarProcedimentosFechar_Click);
            // 
            // grupoprocedimentoBindingSource
            // 
            this.grupoprocedimentoBindingSource.DataSource = typeof(DAO.grupo_procedimento);
            // 
            // pnlConsultarProcedimentosCampos
            // 
            this.pnlConsultarProcedimentosCampos.Controls.Add(this.txtConsultarProcedimentosDescricao);
            this.pnlConsultarProcedimentosCampos.Controls.Add(this.lblConsultarProcedimentosNome);
            this.pnlConsultarProcedimentosCampos.Controls.Add(this.lblConsultarProcedimentosGrupo);
            this.pnlConsultarProcedimentosCampos.Controls.Add(this.grpConsultarProcedimentosAtivo);
            this.pnlConsultarProcedimentosCampos.Controls.Add(this.btnConsultarProcedimentosAddGrupo);
            this.pnlConsultarProcedimentosCampos.Controls.Add(this.btnConsultarProcedimentosSalvar);
            this.pnlConsultarProcedimentosCampos.Controls.Add(this.btnConsultarProcedimentosLimpar);
            this.pnlConsultarProcedimentosCampos.Controls.Add(this.btnConsultarProcedimentosSair);
            this.pnlConsultarProcedimentosCampos.Controls.Add(this.txtConsultarProcedimentosValor);
            this.pnlConsultarProcedimentosCampos.Controls.Add(this.lblConsultarProcedimentosValor);
            this.pnlConsultarProcedimentosCampos.Controls.Add(this.cmbConsultarProcedimentosGrupo);
            this.pnlConsultarProcedimentosCampos.Controls.Add(this.txtConsultarProcedimentosNome);
            this.pnlConsultarProcedimentosCampos.Controls.Add(this.lblConsultarProcedimentosDescricao);
            this.pnlConsultarProcedimentosCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConsultarProcedimentosCampos.Location = new System.Drawing.Point(401, 0);
            this.pnlConsultarProcedimentosCampos.Margin = new System.Windows.Forms.Padding(0);
            this.pnlConsultarProcedimentosCampos.Name = "pnlConsultarProcedimentosCampos";
            this.pnlConsultarProcedimentosCampos.Size = new System.Drawing.Size(489, 348);
            this.pnlConsultarProcedimentosCampos.TabIndex = 4;
            this.pnlConsultarProcedimentosCampos.Visible = false;
            // 
            // txtConsultarProcedimentosDescricao
            // 
            this.txtConsultarProcedimentosDescricao.Location = new System.Drawing.Point(9, 104);
            this.txtConsultarProcedimentosDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.txtConsultarProcedimentosDescricao.Multiline = true;
            this.txtConsultarProcedimentosDescricao.Name = "txtConsultarProcedimentosDescricao";
            this.txtConsultarProcedimentosDescricao.Size = new System.Drawing.Size(457, 69);
            this.txtConsultarProcedimentosDescricao.TabIndex = 65;
            // 
            // lblConsultarProcedimentosNome
            // 
            this.lblConsultarProcedimentosNome.AutoSize = true;
            this.lblConsultarProcedimentosNome.Location = new System.Drawing.Point(9, 9);
            this.lblConsultarProcedimentosNome.Margin = new System.Windows.Forms.Padding(0);
            this.lblConsultarProcedimentosNome.Name = "lblConsultarProcedimentosNome";
            this.lblConsultarProcedimentosNome.Size = new System.Drawing.Size(119, 20);
            this.lblConsultarProcedimentosNome.TabIndex = 73;
            this.lblConsultarProcedimentosNome.Text = "Procedimento";
            // 
            // lblConsultarProcedimentosGrupo
            // 
            this.lblConsultarProcedimentosGrupo.AutoSize = true;
            this.lblConsultarProcedimentosGrupo.Location = new System.Drawing.Point(9, 194);
            this.lblConsultarProcedimentosGrupo.Margin = new System.Windows.Forms.Padding(0);
            this.lblConsultarProcedimentosGrupo.Name = "lblConsultarProcedimentosGrupo";
            this.lblConsultarProcedimentosGrupo.Size = new System.Drawing.Size(58, 20);
            this.lblConsultarProcedimentosGrupo.TabIndex = 73;
            this.lblConsultarProcedimentosGrupo.Text = "Grupo";
            // 
            // grpConsultarProcedimentosAtivo
            // 
            this.grpConsultarProcedimentosAtivo.Controls.Add(this.rdoConsultarProcedimentosAtivoNao);
            this.grpConsultarProcedimentosAtivo.Controls.Add(this.rdoConsultarProcedimentosAtivoSim);
            this.grpConsultarProcedimentosAtivo.Location = new System.Drawing.Point(391, 185);
            this.grpConsultarProcedimentosAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.grpConsultarProcedimentosAtivo.Name = "grpConsultarProcedimentosAtivo";
            this.grpConsultarProcedimentosAtivo.Size = new System.Drawing.Size(75, 91);
            this.grpConsultarProcedimentosAtivo.TabIndex = 76;
            this.grpConsultarProcedimentosAtivo.TabStop = false;
            this.grpConsultarProcedimentosAtivo.Text = "Ativo";
            // 
            // rdoConsultarProcedimentosAtivoNao
            // 
            this.rdoConsultarProcedimentosAtivoNao.AutoSize = true;
            this.rdoConsultarProcedimentosAtivoNao.Location = new System.Drawing.Point(6, 61);
            this.rdoConsultarProcedimentosAtivoNao.Name = "rdoConsultarProcedimentosAtivoNao";
            this.rdoConsultarProcedimentosAtivoNao.Size = new System.Drawing.Size(58, 24);
            this.rdoConsultarProcedimentosAtivoNao.TabIndex = 0;
            this.rdoConsultarProcedimentosAtivoNao.TabStop = true;
            this.rdoConsultarProcedimentosAtivoNao.Text = "Não";
            this.rdoConsultarProcedimentosAtivoNao.UseVisualStyleBackColor = true;
            // 
            // rdoConsultarProcedimentosAtivoSim
            // 
            this.rdoConsultarProcedimentosAtivoSim.AutoSize = true;
            this.rdoConsultarProcedimentosAtivoSim.Location = new System.Drawing.Point(6, 23);
            this.rdoConsultarProcedimentosAtivoSim.Name = "rdoConsultarProcedimentosAtivoSim";
            this.rdoConsultarProcedimentosAtivoSim.Size = new System.Drawing.Size(56, 24);
            this.rdoConsultarProcedimentosAtivoSim.TabIndex = 0;
            this.rdoConsultarProcedimentosAtivoSim.TabStop = true;
            this.rdoConsultarProcedimentosAtivoSim.Text = "Sim";
            this.rdoConsultarProcedimentosAtivoSim.UseVisualStyleBackColor = true;
            // 
            // btnConsultarProcedimentosAddGrupo
            // 
            this.btnConsultarProcedimentosAddGrupo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosAddGrupo.FlatAppearance.BorderSize = 0;
            this.btnConsultarProcedimentosAddGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosAddGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarProcedimentosAddGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProcedimentosAddGrupo.Image = global::UI.Properties.Resources.Novopq;
            this.btnConsultarProcedimentosAddGrupo.Location = new System.Drawing.Point(212, 220);
            this.btnConsultarProcedimentosAddGrupo.Margin = new System.Windows.Forms.Padding(0);
            this.btnConsultarProcedimentosAddGrupo.Name = "btnConsultarProcedimentosAddGrupo";
            this.btnConsultarProcedimentosAddGrupo.Size = new System.Drawing.Size(25, 25);
            this.btnConsultarProcedimentosAddGrupo.TabIndex = 75;
            this.toolTip1.SetToolTip(this.btnConsultarProcedimentosAddGrupo, "Adicionar grupo");
            this.btnConsultarProcedimentosAddGrupo.UseVisualStyleBackColor = true;
            this.btnConsultarProcedimentosAddGrupo.Click += new System.EventHandler(this.BtnConsultarProcedimentosAddGrupo_Click);
            // 
            // btnConsultarProcedimentosSalvar
            // 
            this.btnConsultarProcedimentosSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosSalvar.FlatAppearance.BorderSize = 0;
            this.btnConsultarProcedimentosSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarProcedimentosSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProcedimentosSalvar.Image = global::UI.Properties.Resources.salvar;
            this.btnConsultarProcedimentosSalvar.Location = new System.Drawing.Point(9, 267);
            this.btnConsultarProcedimentosSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnConsultarProcedimentosSalvar.Name = "btnConsultarProcedimentosSalvar";
            this.btnConsultarProcedimentosSalvar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarProcedimentosSalvar.TabIndex = 68;
            this.toolTip1.SetToolTip(this.btnConsultarProcedimentosSalvar, "Salvar");
            this.btnConsultarProcedimentosSalvar.UseVisualStyleBackColor = true;
            this.btnConsultarProcedimentosSalvar.Click += new System.EventHandler(this.BtnConsultarProcedimentosSalvar_Click);
            // 
            // btnConsultarProcedimentosLimpar
            // 
            this.btnConsultarProcedimentosLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosLimpar.FlatAppearance.BorderSize = 0;
            this.btnConsultarProcedimentosLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarProcedimentosLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProcedimentosLimpar.Image = global::UI.Properties.Resources.vassoura64;
            this.btnConsultarProcedimentosLimpar.Location = new System.Drawing.Point(92, 267);
            this.btnConsultarProcedimentosLimpar.Margin = new System.Windows.Forms.Padding(0);
            this.btnConsultarProcedimentosLimpar.Name = "btnConsultarProcedimentosLimpar";
            this.btnConsultarProcedimentosLimpar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarProcedimentosLimpar.TabIndex = 69;
            this.toolTip1.SetToolTip(this.btnConsultarProcedimentosLimpar, "Limpar campos");
            this.btnConsultarProcedimentosLimpar.UseVisualStyleBackColor = true;
            this.btnConsultarProcedimentosLimpar.Click += new System.EventHandler(this.BtnConsultarProcedimentoLimpar_Click);
            // 
            // btnConsultarProcedimentosSair
            // 
            this.btnConsultarProcedimentosSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosSair.FlatAppearance.BorderSize = 0;
            this.btnConsultarProcedimentosSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarProcedimentosSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarProcedimentosSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProcedimentosSair.Image = global::UI.Properties.Resources.sair64x64;
            this.btnConsultarProcedimentosSair.Location = new System.Drawing.Point(182, 267);
            this.btnConsultarProcedimentosSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnConsultarProcedimentosSair.Name = "btnConsultarProcedimentosSair";
            this.btnConsultarProcedimentosSair.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarProcedimentosSair.TabIndex = 70;
            this.toolTip1.SetToolTip(this.btnConsultarProcedimentosSair, "Sair edição");
            this.btnConsultarProcedimentosSair.UseVisualStyleBackColor = true;
            this.btnConsultarProcedimentosSair.Click += new System.EventHandler(this.BtnConsultarProcedimentoSair_Click);
            // 
            // txtConsultarProcedimentosValor
            // 
            this.txtConsultarProcedimentosValor.Location = new System.Drawing.Point(260, 219);
            this.txtConsultarProcedimentosValor.Margin = new System.Windows.Forms.Padding(0);
            this.txtConsultarProcedimentosValor.Name = "txtConsultarProcedimentosValor";
            this.txtConsultarProcedimentosValor.Size = new System.Drawing.Size(113, 32);
            this.txtConsultarProcedimentosValor.TabIndex = 67;
            this.txtConsultarProcedimentosValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtConsultarProcedimentosValor.Enter += new System.EventHandler(this.TxtConsultarProcedimentosValor_Enter);
            this.txtConsultarProcedimentosValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConsultarProcedimentosValor_KeyPress);
            this.txtConsultarProcedimentosValor.Leave += new System.EventHandler(this.TxtConsultarProcedimentosValor_Leave);
            // 
            // lblConsultarProcedimentosValor
            // 
            this.lblConsultarProcedimentosValor.AutoSize = true;
            this.lblConsultarProcedimentosValor.Location = new System.Drawing.Point(256, 194);
            this.lblConsultarProcedimentosValor.Margin = new System.Windows.Forms.Padding(0);
            this.lblConsultarProcedimentosValor.Name = "lblConsultarProcedimentosValor";
            this.lblConsultarProcedimentosValor.Size = new System.Drawing.Size(50, 20);
            this.lblConsultarProcedimentosValor.TabIndex = 74;
            this.lblConsultarProcedimentosValor.Text = "Valor";
            // 
            // cmbConsultarProcedimentosGrupo
            // 
            this.cmbConsultarProcedimentosGrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbConsultarProcedimentosGrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbConsultarProcedimentosGrupo.DataSource = this.grupoprocedimentoBindingSource;
            this.cmbConsultarProcedimentosGrupo.DisplayMember = "nome";
            this.cmbConsultarProcedimentosGrupo.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConsultarProcedimentosGrupo.FormattingEnabled = true;
            this.cmbConsultarProcedimentosGrupo.Location = new System.Drawing.Point(9, 219);
            this.cmbConsultarProcedimentosGrupo.Margin = new System.Windows.Forms.Padding(0, 5, 20, 0);
            this.cmbConsultarProcedimentosGrupo.Name = "cmbConsultarProcedimentosGrupo";
            this.cmbConsultarProcedimentosGrupo.Size = new System.Drawing.Size(195, 28);
            this.cmbConsultarProcedimentosGrupo.TabIndex = 66;
            this.cmbConsultarProcedimentosGrupo.ValueMember = "codigo";
            // 
            // txtConsultarProcedimentosNome
            // 
            this.txtConsultarProcedimentosNome.Location = new System.Drawing.Point(9, 32);
            this.txtConsultarProcedimentosNome.Margin = new System.Windows.Forms.Padding(0);
            this.txtConsultarProcedimentosNome.Name = "txtConsultarProcedimentosNome";
            this.txtConsultarProcedimentosNome.Size = new System.Drawing.Size(457, 32);
            this.txtConsultarProcedimentosNome.TabIndex = 64;
            // 
            // lblConsultarProcedimentosDescricao
            // 
            this.lblConsultarProcedimentosDescricao.AutoSize = true;
            this.lblConsultarProcedimentosDescricao.Location = new System.Drawing.Point(9, 81);
            this.lblConsultarProcedimentosDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.lblConsultarProcedimentosDescricao.Name = "lblConsultarProcedimentosDescricao";
            this.lblConsultarProcedimentosDescricao.Size = new System.Drawing.Size(86, 20);
            this.lblConsultarProcedimentosDescricao.TabIndex = 71;
            this.lblConsultarProcedimentosDescricao.Text = "Descrição";
            // 
            // frmConsultarProcedimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 348);
            this.Controls.Add(this.pnlConsultarProcedimentosCampos);
            this.Controls.Add(this.pnlConsultarProcedimentosLista);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmConsultarProcedimentos";
            this.Text = "Consultar Procedimentos";
            this.Load += new System.EventHandler(this.FrmConsultarProcedimento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultarProcedimentos_KeyDown);
            this.pnlConsultarProcedimentosLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarProcedimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedimentoBindingSource)).EndInit();
            this.flpConsultarProcedimentosProcurar.ResumeLayout(false);
            this.flpConsultarProcedimentosProcurar.PerformLayout();
            this.flpConsultarProcedimentosMenuLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grupoprocedimentoBindingSource)).EndInit();
            this.pnlConsultarProcedimentosCampos.ResumeLayout(false);
            this.pnlConsultarProcedimentosCampos.PerformLayout();
            this.grpConsultarProcedimentosAtivo.ResumeLayout(false);
            this.grpConsultarProcedimentosAtivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConsultarProcedimentosLista;
        private System.Windows.Forms.DataGridView dgvConsultarProcedimentos;
        private System.Windows.Forms.FlowLayoutPanel flpConsultarProcedimentosProcurar;
        private System.Windows.Forms.Label lblConsultarProcedimentosProcurarPor;
        private System.Windows.Forms.RadioButton rdoConsultarProcedimentosProcurarPorNome;
        private System.Windows.Forms.RadioButton rdoConsultarProcedimentosProcurarInativo;
        private System.Windows.Forms.MaskedTextBox mtxConsultarProcedimentosProcurarPor;
        private System.Windows.Forms.Button btnConsultarProcedimentosVoltar;
        private System.Windows.Forms.FlowLayoutPanel flpConsultarProcedimentosMenuLista;
        private System.Windows.Forms.Button btnConsultarProcedimentosEditar;
        private System.Windows.Forms.Button btnConsultarProcedimentosDeletar;
        private System.Windows.Forms.Button btnConsultarProcedimentosProcurar;
        private System.Windows.Forms.Button btnConsultarProcedimentosFechar;
        private System.Windows.Forms.BindingSource procedimentoBindingSource;
        private System.Windows.Forms.BindingSource grupoprocedimentoBindingSource;
        private System.Windows.Forms.Panel pnlConsultarProcedimentosCampos;
        private System.Windows.Forms.TextBox txtConsultarProcedimentosDescricao;
        private System.Windows.Forms.Label lblConsultarProcedimentosGrupo;
        private System.Windows.Forms.GroupBox grpConsultarProcedimentosAtivo;
        private System.Windows.Forms.RadioButton rdoConsultarProcedimentosAtivoNao;
        private System.Windows.Forms.RadioButton rdoConsultarProcedimentosAtivoSim;
        private System.Windows.Forms.Button btnConsultarProcedimentosAddGrupo;
        private System.Windows.Forms.Button btnConsultarProcedimentosSalvar;
        private System.Windows.Forms.Button btnConsultarProcedimentosLimpar;
        private System.Windows.Forms.Button btnConsultarProcedimentosSair;
        private System.Windows.Forms.TextBox txtConsultarProcedimentosValor;
        private System.Windows.Forms.Label lblConsultarProcedimentosValor;
        private System.Windows.Forms.ComboBox cmbConsultarProcedimentosGrupo;
        private System.Windows.Forms.TextBox txtConsultarProcedimentosNome;
        private System.Windows.Forms.Label lblConsultarProcedimentosDescricao;
        private System.Windows.Forms.Label lblConsultarProcedimentosNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoprocedimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}