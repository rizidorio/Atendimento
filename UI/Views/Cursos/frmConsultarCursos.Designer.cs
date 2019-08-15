namespace UI
{
    partial class frmConsultarCursos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlConsultarCursosLista = new System.Windows.Forms.Panel();
            this.dgvConsultarCursos = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.investimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargahorariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupocursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flpConsultarCursosProcurar = new System.Windows.Forms.FlowLayoutPanel();
            this.lblConsultarCursosProcurarPor = new System.Windows.Forms.Label();
            this.rdoConsultarCursosProcurarPorNome = new System.Windows.Forms.RadioButton();
            this.rdoConsultarCursosProcurarPorInativo = new System.Windows.Forms.RadioButton();
            this.mtxConsultarCursosProcurarPor = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultarCursosVoltar = new System.Windows.Forms.Button();
            this.flpConsultarCursosMenuLista = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConsultarCursosEditar = new System.Windows.Forms.Button();
            this.btnConsultarCursosDeletar = new System.Windows.Forms.Button();
            this.btnConsultarCursosProcurar = new System.Windows.Forms.Button();
            this.btnConsultarCursosFechar = new System.Windows.Forms.Button();
            this.pnlConsultarCursosCampos = new System.Windows.Forms.Panel();
            this.grpConsultarCursosAtivo = new System.Windows.Forms.GroupBox();
            this.rdoConsultarCursosAtivoNao = new System.Windows.Forms.RadioButton();
            this.rdoConsultarCursosAtivoSim = new System.Windows.Forms.RadioButton();
            this.mtxConsultarCursosCargaHoraria = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultarCursosAddGrupo = new System.Windows.Forms.Button();
            this.btnConsultarCursoSalvar = new System.Windows.Forms.Button();
            this.btnConsultarCursoLimpar = new System.Windows.Forms.Button();
            this.btnConsultarCursosSair = new System.Windows.Forms.Button();
            this.lblConsultarCursosNome = new System.Windows.Forms.Label();
            this.txtConsultarCursosInvestimento = new System.Windows.Forms.TextBox();
            this.txtConsultarCursosNome = new System.Windows.Forms.TextBox();
            this.lblConsultarCursosDescricao = new System.Windows.Forms.Label();
            this.lblConsultarCursosCargaHoraria = new System.Windows.Forms.Label();
            this.txtConsultarCursosDescricao = new System.Windows.Forms.TextBox();
            this.lblConsultarCursosInvestimento = new System.Windows.Forms.Label();
            this.lblConsultarCursosGrupo = new System.Windows.Forms.Label();
            this.cmbConsultarCursosGrupo = new System.Windows.Forms.ComboBox();
            this.grupocursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlConsultarCursosLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.flpConsultarCursosProcurar.SuspendLayout();
            this.flpConsultarCursosMenuLista.SuspendLayout();
            this.pnlConsultarCursosCampos.SuspendLayout();
            this.grpConsultarCursosAtivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupocursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConsultarCursosLista
            // 
            this.pnlConsultarCursosLista.Controls.Add(this.dgvConsultarCursos);
            this.pnlConsultarCursosLista.Controls.Add(this.flpConsultarCursosProcurar);
            this.pnlConsultarCursosLista.Controls.Add(this.flpConsultarCursosMenuLista);
            this.pnlConsultarCursosLista.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlConsultarCursosLista.Location = new System.Drawing.Point(0, 0);
            this.pnlConsultarCursosLista.Margin = new System.Windows.Forms.Padding(0);
            this.pnlConsultarCursosLista.Name = "pnlConsultarCursosLista";
            this.pnlConsultarCursosLista.Size = new System.Drawing.Size(401, 426);
            this.pnlConsultarCursosLista.TabIndex = 1;
            // 
            // dgvConsultarCursos
            // 
            this.dgvConsultarCursos.AllowUserToAddRows = false;
            this.dgvConsultarCursos.AllowUserToDeleteRows = false;
            this.dgvConsultarCursos.AutoGenerateColumns = false;
            this.dgvConsultarCursos.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvConsultarCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultarCursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultarCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultarCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.investimentoDataGridViewTextBoxColumn,
            this.cargahorariaDataGridViewTextBoxColumn,
            this.grupocursoDataGridViewTextBoxColumn});
            this.dgvConsultarCursos.DataSource = this.cursoBindingSource;
            this.dgvConsultarCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultarCursos.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvConsultarCursos.Location = new System.Drawing.Point(0, 150);
            this.dgvConsultarCursos.Name = "dgvConsultarCursos";
            this.dgvConsultarCursos.ReadOnly = true;
            this.dgvConsultarCursos.RowTemplate.Height = 30;
            this.dgvConsultarCursos.Size = new System.Drawing.Size(401, 276);
            this.dgvConsultarCursos.TabIndex = 2;
            this.dgvConsultarCursos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvConsultarCursos_CellFormatting);
            this.dgvConsultarCursos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvConsultarCursos_RowHeaderMouseClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 180;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 250;
            // 
            // investimentoDataGridViewTextBoxColumn
            // 
            this.investimentoDataGridViewTextBoxColumn.DataPropertyName = "investimento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.investimentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.investimentoDataGridViewTextBoxColumn.HeaderText = "Investimento";
            this.investimentoDataGridViewTextBoxColumn.Name = "investimentoDataGridViewTextBoxColumn";
            this.investimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.investimentoDataGridViewTextBoxColumn.Width = 120;
            // 
            // cargahorariaDataGridViewTextBoxColumn
            // 
            this.cargahorariaDataGridViewTextBoxColumn.DataPropertyName = "carga_horaria";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cargahorariaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.cargahorariaDataGridViewTextBoxColumn.HeaderText = "Carga Horária";
            this.cargahorariaDataGridViewTextBoxColumn.Name = "cargahorariaDataGridViewTextBoxColumn";
            this.cargahorariaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cargahorariaDataGridViewTextBoxColumn.Width = 150;
            // 
            // grupocursoDataGridViewTextBoxColumn
            // 
            this.grupocursoDataGridViewTextBoxColumn.DataPropertyName = "grupo_curso1";
            this.grupocursoDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.grupocursoDataGridViewTextBoxColumn.Name = "grupocursoDataGridViewTextBoxColumn";
            this.grupocursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.grupocursoDataGridViewTextBoxColumn.Width = 120;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(DAO.curso);
            // 
            // flpConsultarCursosProcurar
            // 
            this.flpConsultarCursosProcurar.Controls.Add(this.lblConsultarCursosProcurarPor);
            this.flpConsultarCursosProcurar.Controls.Add(this.rdoConsultarCursosProcurarPorNome);
            this.flpConsultarCursosProcurar.Controls.Add(this.rdoConsultarCursosProcurarPorInativo);
            this.flpConsultarCursosProcurar.Controls.Add(this.mtxConsultarCursosProcurarPor);
            this.flpConsultarCursosProcurar.Controls.Add(this.btnConsultarCursosVoltar);
            this.flpConsultarCursosProcurar.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpConsultarCursosProcurar.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpConsultarCursosProcurar.Location = new System.Drawing.Point(0, 72);
            this.flpConsultarCursosProcurar.Margin = new System.Windows.Forms.Padding(0);
            this.flpConsultarCursosProcurar.Name = "flpConsultarCursosProcurar";
            this.flpConsultarCursosProcurar.Padding = new System.Windows.Forms.Padding(5, 10, 0, 5);
            this.flpConsultarCursosProcurar.Size = new System.Drawing.Size(401, 78);
            this.flpConsultarCursosProcurar.TabIndex = 1;
            this.flpConsultarCursosProcurar.Visible = false;
            // 
            // lblConsultarCursosProcurarPor
            // 
            this.lblConsultarCursosProcurarPor.AutoSize = true;
            this.lblConsultarCursosProcurarPor.Location = new System.Drawing.Point(5, 10);
            this.lblConsultarCursosProcurarPor.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblConsultarCursosProcurarPor.Name = "lblConsultarCursosProcurarPor";
            this.lblConsultarCursosProcurarPor.Size = new System.Drawing.Size(113, 20);
            this.lblConsultarCursosProcurarPor.TabIndex = 0;
            this.lblConsultarCursosProcurarPor.Text = "Procurar por:";
            // 
            // rdoConsultarCursosProcurarPorNome
            // 
            this.rdoConsultarCursosProcurarPorNome.AutoSize = true;
            this.rdoConsultarCursosProcurarPorNome.Location = new System.Drawing.Point(128, 10);
            this.rdoConsultarCursosProcurarPorNome.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.rdoConsultarCursosProcurarPorNome.Name = "rdoConsultarCursosProcurarPorNome";
            this.rdoConsultarCursosProcurarPorNome.Size = new System.Drawing.Size(74, 24);
            this.rdoConsultarCursosProcurarPorNome.TabIndex = 1;
            this.rdoConsultarCursosProcurarPorNome.TabStop = true;
            this.rdoConsultarCursosProcurarPorNome.Text = "Nome";
            this.rdoConsultarCursosProcurarPorNome.UseVisualStyleBackColor = true;
            this.rdoConsultarCursosProcurarPorNome.Click += new System.EventHandler(this.RdoConsultarCursosProcurarPorNome_Click);
            // 
            // rdoConsultarCursosProcurarPorInativo
            // 
            this.rdoConsultarCursosProcurarPorInativo.AutoSize = true;
            this.rdoConsultarCursosProcurarPorInativo.Location = new System.Drawing.Point(207, 10);
            this.rdoConsultarCursosProcurarPorInativo.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.rdoConsultarCursosProcurarPorInativo.Name = "rdoConsultarCursosProcurarPorInativo";
            this.rdoConsultarCursosProcurarPorInativo.Size = new System.Drawing.Size(80, 24);
            this.rdoConsultarCursosProcurarPorInativo.TabIndex = 2;
            this.rdoConsultarCursosProcurarPorInativo.TabStop = true;
            this.rdoConsultarCursosProcurarPorInativo.Text = "Inativo";
            this.rdoConsultarCursosProcurarPorInativo.UseVisualStyleBackColor = true;
            this.rdoConsultarCursosProcurarPorInativo.Click += new System.EventHandler(this.RdoConsultarCursosProcurarPorInativo_Click);
            // 
            // mtxConsultarCursosProcurarPor
            // 
            this.mtxConsultarCursosProcurarPor.Location = new System.Drawing.Point(8, 37);
            this.mtxConsultarCursosProcurarPor.Name = "mtxConsultarCursosProcurarPor";
            this.mtxConsultarCursosProcurarPor.Size = new System.Drawing.Size(335, 32);
            this.mtxConsultarCursosProcurarPor.TabIndex = 27;
            this.mtxConsultarCursosProcurarPor.Visible = false;
            this.mtxConsultarCursosProcurarPor.TextChanged += new System.EventHandler(this.MtxConsultarCursosProcurarPor_TextChanged);
            // 
            // btnConsultarCursosVoltar
            // 
            this.btnConsultarCursosVoltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarCursosVoltar.FlatAppearance.BorderSize = 0;
            this.btnConsultarCursosVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarCursosVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarCursosVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCursosVoltar.Image = global::UI.Properties.Resources.voltar32x32;
            this.btnConsultarCursosVoltar.Location = new System.Drawing.Point(356, 34);
            this.btnConsultarCursosVoltar.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConsultarCursosVoltar.Name = "btnConsultarCursosVoltar";
            this.btnConsultarCursosVoltar.Size = new System.Drawing.Size(34, 34);
            this.btnConsultarCursosVoltar.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnConsultarCursosVoltar, "Voltar");
            this.btnConsultarCursosVoltar.UseVisualStyleBackColor = true;
            this.btnConsultarCursosVoltar.Visible = false;
            this.btnConsultarCursosVoltar.Click += new System.EventHandler(this.BtnConsultarCursosVoltar_Click);
            // 
            // flpConsultarCursosMenuLista
            // 
            this.flpConsultarCursosMenuLista.Controls.Add(this.btnConsultarCursosEditar);
            this.flpConsultarCursosMenuLista.Controls.Add(this.btnConsultarCursosDeletar);
            this.flpConsultarCursosMenuLista.Controls.Add(this.btnConsultarCursosProcurar);
            this.flpConsultarCursosMenuLista.Controls.Add(this.btnConsultarCursosFechar);
            this.flpConsultarCursosMenuLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpConsultarCursosMenuLista.Location = new System.Drawing.Point(0, 0);
            this.flpConsultarCursosMenuLista.Name = "flpConsultarCursosMenuLista";
            this.flpConsultarCursosMenuLista.Size = new System.Drawing.Size(401, 72);
            this.flpConsultarCursosMenuLista.TabIndex = 0;
            // 
            // btnConsultarCursosEditar
            // 
            this.btnConsultarCursosEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarCursosEditar.FlatAppearance.BorderSize = 0;
            this.btnConsultarCursosEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarCursosEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarCursosEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCursosEditar.Image = global::UI.Properties.Resources.edit64x64;
            this.btnConsultarCursosEditar.Location = new System.Drawing.Point(0, 0);
            this.btnConsultarCursosEditar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnConsultarCursosEditar.Name = "btnConsultarCursosEditar";
            this.btnConsultarCursosEditar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarCursosEditar.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnConsultarCursosEditar, "Editar");
            this.btnConsultarCursosEditar.UseVisualStyleBackColor = true;
            this.btnConsultarCursosEditar.Visible = false;
            this.btnConsultarCursosEditar.Click += new System.EventHandler(this.BtnConsultarCursosEditar_Click);
            // 
            // btnConsultarCursosDeletar
            // 
            this.btnConsultarCursosDeletar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarCursosDeletar.FlatAppearance.BorderSize = 0;
            this.btnConsultarCursosDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarCursosDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarCursosDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCursosDeletar.Image = global::UI.Properties.Resources.excluir64x64;
            this.btnConsultarCursosDeletar.Location = new System.Drawing.Point(90, 0);
            this.btnConsultarCursosDeletar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnConsultarCursosDeletar.Name = "btnConsultarCursosDeletar";
            this.btnConsultarCursosDeletar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarCursosDeletar.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnConsultarCursosDeletar, "Excluir");
            this.btnConsultarCursosDeletar.UseVisualStyleBackColor = true;
            this.btnConsultarCursosDeletar.Visible = false;
            this.btnConsultarCursosDeletar.Click += new System.EventHandler(this.BtnConsultarCursosDeletar_Click);
            // 
            // btnConsultarCursosProcurar
            // 
            this.btnConsultarCursosProcurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarCursosProcurar.FlatAppearance.BorderSize = 0;
            this.btnConsultarCursosProcurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarCursosProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarCursosProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCursosProcurar.Image = global::UI.Properties.Resources.procurar;
            this.btnConsultarCursosProcurar.Location = new System.Drawing.Point(180, 0);
            this.btnConsultarCursosProcurar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnConsultarCursosProcurar.Name = "btnConsultarCursosProcurar";
            this.btnConsultarCursosProcurar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarCursosProcurar.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnConsultarCursosProcurar, "Procurar");
            this.btnConsultarCursosProcurar.UseVisualStyleBackColor = true;
            this.btnConsultarCursosProcurar.Click += new System.EventHandler(this.BtnConsultarCursosProcurar_Click);
            // 
            // btnConsultarCursosFechar
            // 
            this.btnConsultarCursosFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarCursosFechar.FlatAppearance.BorderSize = 0;
            this.btnConsultarCursosFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarCursosFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarCursosFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCursosFechar.Image = global::UI.Properties.Resources.fechar1;
            this.btnConsultarCursosFechar.Location = new System.Drawing.Point(270, 0);
            this.btnConsultarCursosFechar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnConsultarCursosFechar.Name = "btnConsultarCursosFechar";
            this.btnConsultarCursosFechar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarCursosFechar.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnConsultarCursosFechar, "Fechar");
            this.btnConsultarCursosFechar.UseVisualStyleBackColor = true;
            this.btnConsultarCursosFechar.Click += new System.EventHandler(this.BtnConsultarCursosFechar_Click);
            // 
            // pnlConsultarCursosCampos
            // 
            this.pnlConsultarCursosCampos.Controls.Add(this.grpConsultarCursosAtivo);
            this.pnlConsultarCursosCampos.Controls.Add(this.mtxConsultarCursosCargaHoraria);
            this.pnlConsultarCursosCampos.Controls.Add(this.btnConsultarCursosAddGrupo);
            this.pnlConsultarCursosCampos.Controls.Add(this.btnConsultarCursoSalvar);
            this.pnlConsultarCursosCampos.Controls.Add(this.btnConsultarCursoLimpar);
            this.pnlConsultarCursosCampos.Controls.Add(this.btnConsultarCursosSair);
            this.pnlConsultarCursosCampos.Controls.Add(this.lblConsultarCursosNome);
            this.pnlConsultarCursosCampos.Controls.Add(this.txtConsultarCursosInvestimento);
            this.pnlConsultarCursosCampos.Controls.Add(this.txtConsultarCursosNome);
            this.pnlConsultarCursosCampos.Controls.Add(this.lblConsultarCursosDescricao);
            this.pnlConsultarCursosCampos.Controls.Add(this.lblConsultarCursosCargaHoraria);
            this.pnlConsultarCursosCampos.Controls.Add(this.txtConsultarCursosDescricao);
            this.pnlConsultarCursosCampos.Controls.Add(this.lblConsultarCursosInvestimento);
            this.pnlConsultarCursosCampos.Controls.Add(this.lblConsultarCursosGrupo);
            this.pnlConsultarCursosCampos.Controls.Add(this.cmbConsultarCursosGrupo);
            this.pnlConsultarCursosCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConsultarCursosCampos.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConsultarCursosCampos.Location = new System.Drawing.Point(401, 0);
            this.pnlConsultarCursosCampos.Margin = new System.Windows.Forms.Padding(0);
            this.pnlConsultarCursosCampos.Name = "pnlConsultarCursosCampos";
            this.pnlConsultarCursosCampos.Size = new System.Drawing.Size(528, 426);
            this.pnlConsultarCursosCampos.TabIndex = 2;
            this.pnlConsultarCursosCampos.Visible = false;
            // 
            // grpConsultarCursosAtivo
            // 
            this.grpConsultarCursosAtivo.Controls.Add(this.rdoConsultarCursosAtivoNao);
            this.grpConsultarCursosAtivo.Controls.Add(this.rdoConsultarCursosAtivoSim);
            this.grpConsultarCursosAtivo.Location = new System.Drawing.Point(229, 262);
            this.grpConsultarCursosAtivo.Name = "grpConsultarCursosAtivo";
            this.grpConsultarCursosAtivo.Size = new System.Drawing.Size(279, 56);
            this.grpConsultarCursosAtivo.TabIndex = 63;
            this.grpConsultarCursosAtivo.TabStop = false;
            this.grpConsultarCursosAtivo.Text = "Ativo";
            // 
            // rdoConsultarCursosAtivoNao
            // 
            this.rdoConsultarCursosAtivoNao.AutoSize = true;
            this.rdoConsultarCursosAtivoNao.Location = new System.Drawing.Point(162, 26);
            this.rdoConsultarCursosAtivoNao.Name = "rdoConsultarCursosAtivoNao";
            this.rdoConsultarCursosAtivoNao.Size = new System.Drawing.Size(58, 24);
            this.rdoConsultarCursosAtivoNao.TabIndex = 0;
            this.rdoConsultarCursosAtivoNao.TabStop = true;
            this.rdoConsultarCursosAtivoNao.Text = "Não";
            this.rdoConsultarCursosAtivoNao.UseVisualStyleBackColor = true;
            // 
            // rdoConsultarCursosAtivoSim
            // 
            this.rdoConsultarCursosAtivoSim.AutoSize = true;
            this.rdoConsultarCursosAtivoSim.Location = new System.Drawing.Point(55, 26);
            this.rdoConsultarCursosAtivoSim.Name = "rdoConsultarCursosAtivoSim";
            this.rdoConsultarCursosAtivoSim.Size = new System.Drawing.Size(56, 24);
            this.rdoConsultarCursosAtivoSim.TabIndex = 0;
            this.rdoConsultarCursosAtivoSim.TabStop = true;
            this.rdoConsultarCursosAtivoSim.Text = "Sim";
            this.rdoConsultarCursosAtivoSim.UseVisualStyleBackColor = true;
            // 
            // mtxConsultarCursosCargaHoraria
            // 
            this.mtxConsultarCursosCargaHoraria.Location = new System.Drawing.Point(13, 285);
            this.mtxConsultarCursosCargaHoraria.Mask = "00:00";
            this.mtxConsultarCursosCargaHoraria.Name = "mtxConsultarCursosCargaHoraria";
            this.mtxConsultarCursosCargaHoraria.Size = new System.Drawing.Size(156, 32);
            this.mtxConsultarCursosCargaHoraria.TabIndex = 5;
            this.mtxConsultarCursosCargaHoraria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxConsultarCursosCargaHoraria.ValidatingType = typeof(System.DateTime);
            // 
            // btnConsultarCursosAddGrupo
            // 
            this.btnConsultarCursosAddGrupo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarCursosAddGrupo.FlatAppearance.BorderSize = 0;
            this.btnConsultarCursosAddGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarCursosAddGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarCursosAddGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCursosAddGrupo.Image = global::UI.Properties.Resources.Novopq;
            this.btnConsultarCursosAddGrupo.Location = new System.Drawing.Point(229, 219);
            this.btnConsultarCursosAddGrupo.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnConsultarCursosAddGrupo.Name = "btnConsultarCursosAddGrupo";
            this.btnConsultarCursosAddGrupo.Size = new System.Drawing.Size(25, 25);
            this.btnConsultarCursosAddGrupo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnConsultarCursosAddGrupo, "Adicionar grupo");
            this.btnConsultarCursosAddGrupo.UseVisualStyleBackColor = true;
            this.btnConsultarCursosAddGrupo.Click += new System.EventHandler(this.BtnConsultarCursosAddGrupo_Click);
            // 
            // btnConsultarCursoSalvar
            // 
            this.btnConsultarCursoSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarCursoSalvar.FlatAppearance.BorderSize = 0;
            this.btnConsultarCursoSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarCursoSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarCursoSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCursoSalvar.Image = global::UI.Properties.Resources.salvar;
            this.btnConsultarCursoSalvar.Location = new System.Drawing.Point(13, 340);
            this.btnConsultarCursoSalvar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnConsultarCursoSalvar.Name = "btnConsultarCursoSalvar";
            this.btnConsultarCursoSalvar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarCursoSalvar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnConsultarCursoSalvar, "Salvar");
            this.btnConsultarCursoSalvar.UseVisualStyleBackColor = true;
            this.btnConsultarCursoSalvar.Click += new System.EventHandler(this.BtnConsultarCursoSalvar_Click);
            // 
            // btnConsultarCursoLimpar
            // 
            this.btnConsultarCursoLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarCursoLimpar.FlatAppearance.BorderSize = 0;
            this.btnConsultarCursoLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarCursoLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarCursoLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCursoLimpar.Image = global::UI.Properties.Resources.vassoura64;
            this.btnConsultarCursoLimpar.Location = new System.Drawing.Point(103, 340);
            this.btnConsultarCursoLimpar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnConsultarCursoLimpar.Name = "btnConsultarCursoLimpar";
            this.btnConsultarCursoLimpar.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarCursoLimpar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnConsultarCursoLimpar, "Limpar campos");
            this.btnConsultarCursoLimpar.UseVisualStyleBackColor = true;
            this.btnConsultarCursoLimpar.Click += new System.EventHandler(this.BtnConsultarCursoLimpar_Click);
            // 
            // btnConsultarCursosSair
            // 
            this.btnConsultarCursosSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarCursosSair.FlatAppearance.BorderSize = 0;
            this.btnConsultarCursosSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarCursosSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarCursosSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCursosSair.Image = global::UI.Properties.Resources.sair64x64;
            this.btnConsultarCursosSair.Location = new System.Drawing.Point(193, 340);
            this.btnConsultarCursosSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnConsultarCursosSair.Name = "btnConsultarCursosSair";
            this.btnConsultarCursosSair.Size = new System.Drawing.Size(70, 70);
            this.btnConsultarCursosSair.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnConsultarCursosSair, "Sair edição");
            this.btnConsultarCursosSair.UseVisualStyleBackColor = true;
            this.btnConsultarCursosSair.Click += new System.EventHandler(this.BtnConsultarCursoSair_Click);
            // 
            // lblConsultarCursosNome
            // 
            this.lblConsultarCursosNome.AutoSize = true;
            this.lblConsultarCursosNome.Location = new System.Drawing.Point(13, 12);
            this.lblConsultarCursosNome.Margin = new System.Windows.Forms.Padding(0);
            this.lblConsultarCursosNome.Name = "lblConsultarCursosNome";
            this.lblConsultarCursosNome.Size = new System.Drawing.Size(55, 20);
            this.lblConsultarCursosNome.TabIndex = 59;
            this.lblConsultarCursosNome.Text = "Curso";
            // 
            // txtConsultarCursosInvestimento
            // 
            this.txtConsultarCursosInvestimento.Location = new System.Drawing.Point(294, 217);
            this.txtConsultarCursosInvestimento.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.txtConsultarCursosInvestimento.Name = "txtConsultarCursosInvestimento";
            this.txtConsultarCursosInvestimento.Size = new System.Drawing.Size(214, 32);
            this.txtConsultarCursosInvestimento.TabIndex = 6;
            this.txtConsultarCursosInvestimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtConsultarCursosInvestimento.Enter += new System.EventHandler(this.TxtConsultarCursosInvestimento_Enter);
            this.txtConsultarCursosInvestimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConsultarCursosInvestimento_KeyPress);
            this.txtConsultarCursosInvestimento.Leave += new System.EventHandler(this.TxtConsultarCursosInvestimento_Leave);
            // 
            // txtConsultarCursosNome
            // 
            this.txtConsultarCursosNome.Location = new System.Drawing.Point(13, 35);
            this.txtConsultarCursosNome.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.txtConsultarCursosNome.Name = "txtConsultarCursosNome";
            this.txtConsultarCursosNome.Size = new System.Drawing.Size(495, 32);
            this.txtConsultarCursosNome.TabIndex = 1;
            // 
            // lblConsultarCursosDescricao
            // 
            this.lblConsultarCursosDescricao.AutoSize = true;
            this.lblConsultarCursosDescricao.Location = new System.Drawing.Point(13, 84);
            this.lblConsultarCursosDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.lblConsultarCursosDescricao.Name = "lblConsultarCursosDescricao";
            this.lblConsultarCursosDescricao.Size = new System.Drawing.Size(86, 20);
            this.lblConsultarCursosDescricao.TabIndex = 60;
            this.lblConsultarCursosDescricao.Text = "Descrição";
            // 
            // lblConsultarCursosCargaHoraria
            // 
            this.lblConsultarCursosCargaHoraria.AutoSize = true;
            this.lblConsultarCursosCargaHoraria.Location = new System.Drawing.Point(13, 262);
            this.lblConsultarCursosCargaHoraria.Margin = new System.Windows.Forms.Padding(0);
            this.lblConsultarCursosCargaHoraria.Name = "lblConsultarCursosCargaHoraria";
            this.lblConsultarCursosCargaHoraria.Size = new System.Drawing.Size(119, 20);
            this.lblConsultarCursosCargaHoraria.TabIndex = 62;
            this.lblConsultarCursosCargaHoraria.Text = "Carga Horária";
            // 
            // txtConsultarCursosDescricao
            // 
            this.txtConsultarCursosDescricao.Location = new System.Drawing.Point(13, 107);
            this.txtConsultarCursosDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.txtConsultarCursosDescricao.Multiline = true;
            this.txtConsultarCursosDescricao.Name = "txtConsultarCursosDescricao";
            this.txtConsultarCursosDescricao.Size = new System.Drawing.Size(495, 69);
            this.txtConsultarCursosDescricao.TabIndex = 2;
            // 
            // lblConsultarCursosInvestimento
            // 
            this.lblConsultarCursosInvestimento.AutoSize = true;
            this.lblConsultarCursosInvestimento.Location = new System.Drawing.Point(294, 192);
            this.lblConsultarCursosInvestimento.Margin = new System.Windows.Forms.Padding(0);
            this.lblConsultarCursosInvestimento.Name = "lblConsultarCursosInvestimento";
            this.lblConsultarCursosInvestimento.Size = new System.Drawing.Size(112, 20);
            this.lblConsultarCursosInvestimento.TabIndex = 62;
            this.lblConsultarCursosInvestimento.Text = "Investimento";
            // 
            // lblConsultarCursosGrupo
            // 
            this.lblConsultarCursosGrupo.AutoSize = true;
            this.lblConsultarCursosGrupo.Location = new System.Drawing.Point(13, 192);
            this.lblConsultarCursosGrupo.Margin = new System.Windows.Forms.Padding(238, 0, 0, 0);
            this.lblConsultarCursosGrupo.Name = "lblConsultarCursosGrupo";
            this.lblConsultarCursosGrupo.Size = new System.Drawing.Size(58, 20);
            this.lblConsultarCursosGrupo.TabIndex = 61;
            this.lblConsultarCursosGrupo.Text = "Grupo";
            // 
            // cmbConsultarCursosGrupo
            // 
            this.cmbConsultarCursosGrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbConsultarCursosGrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbConsultarCursosGrupo.DataSource = this.grupocursoBindingSource;
            this.cmbConsultarCursosGrupo.DisplayMember = "nome";
            this.cmbConsultarCursosGrupo.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConsultarCursosGrupo.FormattingEnabled = true;
            this.cmbConsultarCursosGrupo.Location = new System.Drawing.Point(13, 217);
            this.cmbConsultarCursosGrupo.Margin = new System.Windows.Forms.Padding(0, 5, 20, 0);
            this.cmbConsultarCursosGrupo.Name = "cmbConsultarCursosGrupo";
            this.cmbConsultarCursosGrupo.Size = new System.Drawing.Size(211, 28);
            this.cmbConsultarCursosGrupo.TabIndex = 3;
            this.cmbConsultarCursosGrupo.ValueMember = "codigo";
            // 
            // grupocursoBindingSource
            // 
            this.grupocursoBindingSource.DataSource = typeof(DAO.grupo_curso);
            // 
            // frmConsultarCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 426);
            this.Controls.Add(this.pnlConsultarCursosCampos);
            this.Controls.Add(this.pnlConsultarCursosLista);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultarCursos";
            this.Text = "Consultar Cursos";
            this.Load += new System.EventHandler(this.FrmConsultarCursos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultarCursos_KeyDown);
            this.pnlConsultarCursosLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            this.flpConsultarCursosProcurar.ResumeLayout(false);
            this.flpConsultarCursosProcurar.PerformLayout();
            this.flpConsultarCursosMenuLista.ResumeLayout(false);
            this.pnlConsultarCursosCampos.ResumeLayout(false);
            this.pnlConsultarCursosCampos.PerformLayout();
            this.grpConsultarCursosAtivo.ResumeLayout(false);
            this.grpConsultarCursosAtivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupocursoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConsultarCursosLista;
        private System.Windows.Forms.DataGridView dgvConsultarCursos;
        private System.Windows.Forms.FlowLayoutPanel flpConsultarCursosProcurar;
        private System.Windows.Forms.Label lblConsultarCursosProcurarPor;
        private System.Windows.Forms.RadioButton rdoConsultarCursosProcurarPorNome;
        private System.Windows.Forms.MaskedTextBox mtxConsultarCursosProcurarPor;
        private System.Windows.Forms.Button btnConsultarCursosVoltar;
        private System.Windows.Forms.FlowLayoutPanel flpConsultarCursosMenuLista;
        private System.Windows.Forms.Button btnConsultarCursosEditar;
        private System.Windows.Forms.Button btnConsultarCursosDeletar;
        private System.Windows.Forms.Button btnConsultarCursosProcurar;
        private System.Windows.Forms.Button btnConsultarCursosFechar;
        private System.Windows.Forms.RadioButton rdoConsultarCursosProcurarPorInativo;
        private System.Windows.Forms.Panel pnlConsultarCursosCampos;
        private System.Windows.Forms.Button btnConsultarCursosAddGrupo;
        private System.Windows.Forms.Button btnConsultarCursoSalvar;
        private System.Windows.Forms.Button btnConsultarCursoLimpar;
        private System.Windows.Forms.Button btnConsultarCursosSair;
        private System.Windows.Forms.Label lblConsultarCursosNome;
        private System.Windows.Forms.TextBox txtConsultarCursosInvestimento;
        private System.Windows.Forms.TextBox txtConsultarCursosNome;
        private System.Windows.Forms.Label lblConsultarCursosDescricao;
        private System.Windows.Forms.Label lblConsultarCursosCargaHoraria;
        private System.Windows.Forms.TextBox txtConsultarCursosDescricao;
        private System.Windows.Forms.Label lblConsultarCursosInvestimento;
        private System.Windows.Forms.Label lblConsultarCursosGrupo;
        private System.Windows.Forms.ComboBox cmbConsultarCursosGrupo;
        public System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.BindingSource grupocursoBindingSource;
        private System.Windows.Forms.GroupBox grpConsultarCursosAtivo;
        private System.Windows.Forms.RadioButton rdoConsultarCursosAtivoNao;
        private System.Windows.Forms.RadioButton rdoConsultarCursosAtivoSim;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn investimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargahorariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupocursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox mtxConsultarCursosCargaHoraria;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}