namespace UI
{
    partial class frmUnidadeMedida
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
            this.pnlCadastroUndMedidaTitulo = new System.Windows.Forms.Panel();
            this.btnCadastroUndMedidaMinimizar = new System.Windows.Forms.Button();
            this.btnCadastroUndMedidaFechar = new System.Windows.Forms.Button();
            this.lblCadastroUndMedidaTitulo = new System.Windows.Forms.Label();
            this.pnlCadastroUndMedidaLista = new System.Windows.Forms.Panel();
            this.dgvUndMedida = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidademedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flpCadastroUndMedidaProcurar = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCadastroUndMedidaProcurarPor = new System.Windows.Forms.Label();
            this.txtCadastroUndMedidaProcurarPor = new System.Windows.Forms.TextBox();
            this.flpCadastroUndMedidaListaMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCadastroUndMedidaMenuNovo = new System.Windows.Forms.Button();
            this.btnCadastroUndMedidaMenuEditar = new System.Windows.Forms.Button();
            this.btnCadastroUndMedidaMenuApagar = new System.Windows.Forms.Button();
            this.btnCadastroUndMedidaMenuProcurar = new System.Windows.Forms.Button();
            this.pnlCadastrarUndMedidaCampos = new System.Windows.Forms.Panel();
            this.flpCadastrarUndMedidaCampos = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCadastrarUndMedidaCodigo = new System.Windows.Forms.Label();
            this.txtCadastrarUndMedidaCodigo = new System.Windows.Forms.TextBox();
            this.lblCadastrarUndMedidaNome = new System.Windows.Forms.Label();
            this.txtCadastrarUndMedidaNome = new System.Windows.Forms.TextBox();
            this.grpCadastrarUndMedidaAtivo = new System.Windows.Forms.GroupBox();
            this.rdoCadastrarUndMedidaAtivoNao = new System.Windows.Forms.RadioButton();
            this.rdoCadastrarUndMedidaAtivoSim = new System.Windows.Forms.RadioButton();
            this.flpCadastrarUndMedidaMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCadastrarUndMedidaMenuSalvar = new System.Windows.Forms.Button();
            this.btnCadastrarUndMedidaMenuLimpar = new System.Windows.Forms.Button();
            this.btnCadastrarUndMedidaMenuSair = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlCadastroUndMedidaTitulo.SuspendLayout();
            this.pnlCadastroUndMedidaLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUndMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidademedidaBindingSource)).BeginInit();
            this.flpCadastroUndMedidaProcurar.SuspendLayout();
            this.flpCadastroUndMedidaListaMenu.SuspendLayout();
            this.pnlCadastrarUndMedidaCampos.SuspendLayout();
            this.flpCadastrarUndMedidaCampos.SuspendLayout();
            this.grpCadastrarUndMedidaAtivo.SuspendLayout();
            this.flpCadastrarUndMedidaMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadastroUndMedidaTitulo
            // 
            this.pnlCadastroUndMedidaTitulo.BackColor = System.Drawing.Color.MintCream;
            this.pnlCadastroUndMedidaTitulo.Controls.Add(this.btnCadastroUndMedidaMinimizar);
            this.pnlCadastroUndMedidaTitulo.Controls.Add(this.btnCadastroUndMedidaFechar);
            this.pnlCadastroUndMedidaTitulo.Controls.Add(this.lblCadastroUndMedidaTitulo);
            this.pnlCadastroUndMedidaTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCadastroUndMedidaTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastroUndMedidaTitulo.Margin = new System.Windows.Forms.Padding(6);
            this.pnlCadastroUndMedidaTitulo.Name = "pnlCadastroUndMedidaTitulo";
            this.pnlCadastroUndMedidaTitulo.Size = new System.Drawing.Size(507, 22);
            this.pnlCadastroUndMedidaTitulo.TabIndex = 7;
            // 
            // btnCadastroUndMedidaMinimizar
            // 
            this.btnCadastroUndMedidaMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCadastroUndMedidaMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroUndMedidaMinimizar.FlatAppearance.BorderSize = 0;
            this.btnCadastroUndMedidaMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.btnCadastroUndMedidaMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCadastroUndMedidaMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroUndMedidaMinimizar.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroUndMedidaMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnCadastroUndMedidaMinimizar.Image = global::UI.Properties.Resources.minimizar;
            this.btnCadastroUndMedidaMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastroUndMedidaMinimizar.Location = new System.Drawing.Point(447, 0);
            this.btnCadastroUndMedidaMinimizar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCadastroUndMedidaMinimizar.Name = "btnCadastroUndMedidaMinimizar";
            this.btnCadastroUndMedidaMinimizar.Size = new System.Drawing.Size(30, 22);
            this.btnCadastroUndMedidaMinimizar.TabIndex = 5;
            this.btnCadastroUndMedidaMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnCadastroUndMedidaMinimizar, "Minimizar");
            this.btnCadastroUndMedidaMinimizar.UseVisualStyleBackColor = true;
            this.btnCadastroUndMedidaMinimizar.Click += new System.EventHandler(this.BtnCadastroUndMedidaMinimizar_Click);
            // 
            // btnCadastroUndMedidaFechar
            // 
            this.btnCadastroUndMedidaFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCadastroUndMedidaFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroUndMedidaFechar.FlatAppearance.BorderSize = 0;
            this.btnCadastroUndMedidaFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.btnCadastroUndMedidaFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCadastroUndMedidaFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroUndMedidaFechar.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroUndMedidaFechar.ForeColor = System.Drawing.Color.White;
            this.btnCadastroUndMedidaFechar.Image = global::UI.Properties.Resources.fechar;
            this.btnCadastroUndMedidaFechar.Location = new System.Drawing.Point(477, 0);
            this.btnCadastroUndMedidaFechar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCadastroUndMedidaFechar.Name = "btnCadastroUndMedidaFechar";
            this.btnCadastroUndMedidaFechar.Size = new System.Drawing.Size(30, 22);
            this.btnCadastroUndMedidaFechar.TabIndex = 4;
            this.btnCadastroUndMedidaFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnCadastroUndMedidaFechar, "Fechar");
            this.btnCadastroUndMedidaFechar.UseVisualStyleBackColor = true;
            this.btnCadastroUndMedidaFechar.Click += new System.EventHandler(this.BtnCadastroUndMedidaFechar_Click);
            // 
            // lblCadastroUndMedidaTitulo
            // 
            this.lblCadastroUndMedidaTitulo.AutoSize = true;
            this.lblCadastroUndMedidaTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCadastroUndMedidaTitulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroUndMedidaTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblCadastroUndMedidaTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblCadastroUndMedidaTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblCadastroUndMedidaTitulo.Name = "lblCadastroUndMedidaTitulo";
            this.lblCadastroUndMedidaTitulo.Size = new System.Drawing.Size(256, 18);
            this.lblCadastroUndMedidaTitulo.TabIndex = 0;
            this.lblCadastroUndMedidaTitulo.Text = "Cadastro Unidades de Medida";
            // 
            // pnlCadastroUndMedidaLista
            // 
            this.pnlCadastroUndMedidaLista.Controls.Add(this.dgvUndMedida);
            this.pnlCadastroUndMedidaLista.Controls.Add(this.flpCadastroUndMedidaProcurar);
            this.pnlCadastroUndMedidaLista.Controls.Add(this.flpCadastroUndMedidaListaMenu);
            this.pnlCadastroUndMedidaLista.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCadastroUndMedidaLista.Location = new System.Drawing.Point(0, 22);
            this.pnlCadastroUndMedidaLista.Name = "pnlCadastroUndMedidaLista";
            this.pnlCadastroUndMedidaLista.Size = new System.Drawing.Size(209, 244);
            this.pnlCadastroUndMedidaLista.TabIndex = 8;
            // 
            // dgvUndMedida
            // 
            this.dgvUndMedida.AllowUserToAddRows = false;
            this.dgvUndMedida.AllowUserToDeleteRows = false;
            this.dgvUndMedida.AutoGenerateColumns = false;
            this.dgvUndMedida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUndMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUndMedida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.ativoDataGridViewTextBoxColumn});
            this.dgvUndMedida.DataSource = this.unidademedidaBindingSource;
            this.dgvUndMedida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUndMedida.Location = new System.Drawing.Point(0, 72);
            this.dgvUndMedida.Name = "dgvUndMedida";
            this.dgvUndMedida.ReadOnly = true;
            this.dgvUndMedida.Size = new System.Drawing.Size(209, 172);
            this.dgvUndMedida.TabIndex = 8;
            this.dgvUndMedida.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvUndMedida_CellFormatting);
            this.dgvUndMedida.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvUndMedida_RowHeaderMouseClick);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 70;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Unidade Medida";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 140;
            // 
            // ativoDataGridViewTextBoxColumn
            // 
            this.ativoDataGridViewTextBoxColumn.DataPropertyName = "ativo";
            this.ativoDataGridViewTextBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewTextBoxColumn.Name = "ativoDataGridViewTextBoxColumn";
            this.ativoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ativoDataGridViewTextBoxColumn.Width = 60;
            // 
            // unidademedidaBindingSource
            // 
            this.unidademedidaBindingSource.DataSource = typeof(DAO.unidade_medida);
            // 
            // flpCadastroUndMedidaProcurar
            // 
            this.flpCadastroUndMedidaProcurar.Controls.Add(this.lblCadastroUndMedidaProcurarPor);
            this.flpCadastroUndMedidaProcurar.Controls.Add(this.txtCadastroUndMedidaProcurarPor);
            this.flpCadastroUndMedidaProcurar.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCadastroUndMedidaProcurar.Location = new System.Drawing.Point(0, 32);
            this.flpCadastroUndMedidaProcurar.Margin = new System.Windows.Forms.Padding(0);
            this.flpCadastroUndMedidaProcurar.Name = "flpCadastroUndMedidaProcurar";
            this.flpCadastroUndMedidaProcurar.Size = new System.Drawing.Size(209, 40);
            this.flpCadastroUndMedidaProcurar.TabIndex = 7;
            this.flpCadastroUndMedidaProcurar.Visible = false;
            // 
            // lblCadastroUndMedidaProcurarPor
            // 
            this.lblCadastroUndMedidaProcurarPor.AutoSize = true;
            this.lblCadastroUndMedidaProcurarPor.Location = new System.Drawing.Point(0, 15);
            this.lblCadastroUndMedidaProcurarPor.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.lblCadastroUndMedidaProcurarPor.Name = "lblCadastroUndMedidaProcurarPor";
            this.lblCadastroUndMedidaProcurarPor.Size = new System.Drawing.Size(86, 16);
            this.lblCadastroUndMedidaProcurarPor.TabIndex = 1;
            this.lblCadastroUndMedidaProcurarPor.Text = "Und Medida:";
            // 
            // txtCadastroUndMedidaProcurarPor
            // 
            this.txtCadastroUndMedidaProcurarPor.Location = new System.Drawing.Point(86, 5);
            this.txtCadastroUndMedidaProcurarPor.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.txtCadastroUndMedidaProcurarPor.Name = "txtCadastroUndMedidaProcurarPor";
            this.txtCadastroUndMedidaProcurarPor.Size = new System.Drawing.Size(101, 27);
            this.txtCadastroUndMedidaProcurarPor.TabIndex = 4;
            this.txtCadastroUndMedidaProcurarPor.TextChanged += new System.EventHandler(this.TxtCadastroUndMedidaProcurarPor_TextChanged);
            // 
            // flpCadastroUndMedidaListaMenu
            // 
            this.flpCadastroUndMedidaListaMenu.Controls.Add(this.btnCadastroUndMedidaMenuNovo);
            this.flpCadastroUndMedidaListaMenu.Controls.Add(this.btnCadastroUndMedidaMenuEditar);
            this.flpCadastroUndMedidaListaMenu.Controls.Add(this.btnCadastroUndMedidaMenuApagar);
            this.flpCadastroUndMedidaListaMenu.Controls.Add(this.btnCadastroUndMedidaMenuProcurar);
            this.flpCadastroUndMedidaListaMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCadastroUndMedidaListaMenu.Location = new System.Drawing.Point(0, 0);
            this.flpCadastroUndMedidaListaMenu.Margin = new System.Windows.Forms.Padding(0);
            this.flpCadastroUndMedidaListaMenu.Name = "flpCadastroUndMedidaListaMenu";
            this.flpCadastroUndMedidaListaMenu.Size = new System.Drawing.Size(209, 32);
            this.flpCadastroUndMedidaListaMenu.TabIndex = 6;
            // 
            // btnCadastroUndMedidaMenuNovo
            // 
            this.btnCadastroUndMedidaMenuNovo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroUndMedidaMenuNovo.FlatAppearance.BorderSize = 0;
            this.btnCadastroUndMedidaMenuNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastroUndMedidaMenuNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastroUndMedidaMenuNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroUndMedidaMenuNovo.Image = global::UI.Properties.Resources.Novopq;
            this.btnCadastroUndMedidaMenuNovo.Location = new System.Drawing.Point(0, 0);
            this.btnCadastroUndMedidaMenuNovo.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastroUndMedidaMenuNovo.Name = "btnCadastroUndMedidaMenuNovo";
            this.btnCadastroUndMedidaMenuNovo.Size = new System.Drawing.Size(30, 30);
            this.btnCadastroUndMedidaMenuNovo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnCadastroUndMedidaMenuNovo, "Novo");
            this.btnCadastroUndMedidaMenuNovo.UseVisualStyleBackColor = true;
            this.btnCadastroUndMedidaMenuNovo.Click += new System.EventHandler(this.BtnCadastroUndMedidaMenuNovo_Click);
            // 
            // btnCadastroUndMedidaMenuEditar
            // 
            this.btnCadastroUndMedidaMenuEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroUndMedidaMenuEditar.FlatAppearance.BorderSize = 0;
            this.btnCadastroUndMedidaMenuEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastroUndMedidaMenuEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastroUndMedidaMenuEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroUndMedidaMenuEditar.Image = global::UI.Properties.Resources.Alterarpq;
            this.btnCadastroUndMedidaMenuEditar.Location = new System.Drawing.Point(30, 0);
            this.btnCadastroUndMedidaMenuEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastroUndMedidaMenuEditar.Name = "btnCadastroUndMedidaMenuEditar";
            this.btnCadastroUndMedidaMenuEditar.Size = new System.Drawing.Size(30, 30);
            this.btnCadastroUndMedidaMenuEditar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCadastroUndMedidaMenuEditar, "Editar");
            this.btnCadastroUndMedidaMenuEditar.UseVisualStyleBackColor = true;
            this.btnCadastroUndMedidaMenuEditar.Visible = false;
            this.btnCadastroUndMedidaMenuEditar.Click += new System.EventHandler(this.BtnCadastroUndMedidaMenuEditar_Click);
            // 
            // btnCadastroUndMedidaMenuApagar
            // 
            this.btnCadastroUndMedidaMenuApagar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroUndMedidaMenuApagar.FlatAppearance.BorderSize = 0;
            this.btnCadastroUndMedidaMenuApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastroUndMedidaMenuApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastroUndMedidaMenuApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroUndMedidaMenuApagar.Image = global::UI.Properties.Resources.Excluirpq;
            this.btnCadastroUndMedidaMenuApagar.Location = new System.Drawing.Point(60, 0);
            this.btnCadastroUndMedidaMenuApagar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastroUndMedidaMenuApagar.Name = "btnCadastroUndMedidaMenuApagar";
            this.btnCadastroUndMedidaMenuApagar.Size = new System.Drawing.Size(30, 30);
            this.btnCadastroUndMedidaMenuApagar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnCadastroUndMedidaMenuApagar, "Excluir");
            this.btnCadastroUndMedidaMenuApagar.UseVisualStyleBackColor = true;
            this.btnCadastroUndMedidaMenuApagar.Visible = false;
            this.btnCadastroUndMedidaMenuApagar.Click += new System.EventHandler(this.BtnCadastroUndMedidaMenuApagar_Click);
            // 
            // btnCadastroUndMedidaMenuProcurar
            // 
            this.btnCadastroUndMedidaMenuProcurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroUndMedidaMenuProcurar.FlatAppearance.BorderSize = 0;
            this.btnCadastroUndMedidaMenuProcurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastroUndMedidaMenuProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastroUndMedidaMenuProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroUndMedidaMenuProcurar.Image = global::UI.Properties.Resources.procurarpq2;
            this.btnCadastroUndMedidaMenuProcurar.Location = new System.Drawing.Point(90, 0);
            this.btnCadastroUndMedidaMenuProcurar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastroUndMedidaMenuProcurar.Name = "btnCadastroUndMedidaMenuProcurar";
            this.btnCadastroUndMedidaMenuProcurar.Size = new System.Drawing.Size(30, 30);
            this.btnCadastroUndMedidaMenuProcurar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnCadastroUndMedidaMenuProcurar, "Procurar");
            this.btnCadastroUndMedidaMenuProcurar.UseVisualStyleBackColor = true;
            this.btnCadastroUndMedidaMenuProcurar.Click += new System.EventHandler(this.BtnCadastroUndMedidaMenuProcurar_Click);
            // 
            // pnlCadastrarUndMedidaCampos
            // 
            this.pnlCadastrarUndMedidaCampos.Controls.Add(this.flpCadastrarUndMedidaCampos);
            this.pnlCadastrarUndMedidaCampos.Controls.Add(this.flpCadastrarUndMedidaMenu);
            this.pnlCadastrarUndMedidaCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadastrarUndMedidaCampos.Location = new System.Drawing.Point(209, 22);
            this.pnlCadastrarUndMedidaCampos.Name = "pnlCadastrarUndMedidaCampos";
            this.pnlCadastrarUndMedidaCampos.Size = new System.Drawing.Size(298, 244);
            this.pnlCadastrarUndMedidaCampos.TabIndex = 9;
            this.pnlCadastrarUndMedidaCampos.Visible = false;
            // 
            // flpCadastrarUndMedidaCampos
            // 
            this.flpCadastrarUndMedidaCampos.Controls.Add(this.lblCadastrarUndMedidaCodigo);
            this.flpCadastrarUndMedidaCampos.Controls.Add(this.txtCadastrarUndMedidaCodigo);
            this.flpCadastrarUndMedidaCampos.Controls.Add(this.lblCadastrarUndMedidaNome);
            this.flpCadastrarUndMedidaCampos.Controls.Add(this.txtCadastrarUndMedidaNome);
            this.flpCadastrarUndMedidaCampos.Controls.Add(this.grpCadastrarUndMedidaAtivo);
            this.flpCadastrarUndMedidaCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCadastrarUndMedidaCampos.Location = new System.Drawing.Point(0, 42);
            this.flpCadastrarUndMedidaCampos.Margin = new System.Windows.Forms.Padding(0);
            this.flpCadastrarUndMedidaCampos.Name = "flpCadastrarUndMedidaCampos";
            this.flpCadastrarUndMedidaCampos.Size = new System.Drawing.Size(298, 202);
            this.flpCadastrarUndMedidaCampos.TabIndex = 6;
            // 
            // lblCadastrarUndMedidaCodigo
            // 
            this.lblCadastrarUndMedidaCodigo.AutoSize = true;
            this.flpCadastrarUndMedidaCampos.SetFlowBreak(this.lblCadastrarUndMedidaCodigo, true);
            this.lblCadastrarUndMedidaCodigo.Location = new System.Drawing.Point(30, 10);
            this.lblCadastrarUndMedidaCodigo.Margin = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.lblCadastrarUndMedidaCodigo.Name = "lblCadastrarUndMedidaCodigo";
            this.lblCadastrarUndMedidaCodigo.Size = new System.Drawing.Size(53, 16);
            this.lblCadastrarUndMedidaCodigo.TabIndex = 0;
            this.lblCadastrarUndMedidaCodigo.Text = "Código";
            // 
            // txtCadastrarUndMedidaCodigo
            // 
            this.txtCadastrarUndMedidaCodigo.Enabled = false;
            this.flpCadastrarUndMedidaCampos.SetFlowBreak(this.txtCadastrarUndMedidaCodigo, true);
            this.txtCadastrarUndMedidaCodigo.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrarUndMedidaCodigo.Location = new System.Drawing.Point(30, 31);
            this.txtCadastrarUndMedidaCodigo.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.txtCadastrarUndMedidaCodigo.Name = "txtCadastrarUndMedidaCodigo";
            this.txtCadastrarUndMedidaCodigo.Size = new System.Drawing.Size(135, 31);
            this.txtCadastrarUndMedidaCodigo.TabIndex = 1;
            // 
            // lblCadastrarUndMedidaNome
            // 
            this.lblCadastrarUndMedidaNome.AutoSize = true;
            this.flpCadastrarUndMedidaCampos.SetFlowBreak(this.lblCadastrarUndMedidaNome, true);
            this.lblCadastrarUndMedidaNome.Location = new System.Drawing.Point(30, 77);
            this.lblCadastrarUndMedidaNome.Margin = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.lblCadastrarUndMedidaNome.Name = "lblCadastrarUndMedidaNome";
            this.lblCadastrarUndMedidaNome.Size = new System.Drawing.Size(127, 16);
            this.lblCadastrarUndMedidaNome.TabIndex = 2;
            this.lblCadastrarUndMedidaNome.Text = "Unidade de Medida";
            // 
            // txtCadastrarUndMedidaNome
            // 
            this.flpCadastrarUndMedidaCampos.SetFlowBreak(this.txtCadastrarUndMedidaNome, true);
            this.txtCadastrarUndMedidaNome.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrarUndMedidaNome.Location = new System.Drawing.Point(30, 98);
            this.txtCadastrarUndMedidaNome.Margin = new System.Windows.Forms.Padding(30, 5, 45, 0);
            this.txtCadastrarUndMedidaNome.Name = "txtCadastrarUndMedidaNome";
            this.txtCadastrarUndMedidaNome.Size = new System.Drawing.Size(252, 31);
            this.txtCadastrarUndMedidaNome.TabIndex = 3;
            this.txtCadastrarUndMedidaNome.Leave += new System.EventHandler(this.TxtCadastrarUndMedidaNome_Leave);
            // 
            // grpCadastrarUndMedidaAtivo
            // 
            this.grpCadastrarUndMedidaAtivo.Controls.Add(this.rdoCadastrarUndMedidaAtivoNao);
            this.grpCadastrarUndMedidaAtivo.Controls.Add(this.rdoCadastrarUndMedidaAtivoSim);
            this.grpCadastrarUndMedidaAtivo.Location = new System.Drawing.Point(30, 144);
            this.grpCadastrarUndMedidaAtivo.Margin = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.grpCadastrarUndMedidaAtivo.Name = "grpCadastrarUndMedidaAtivo";
            this.grpCadastrarUndMedidaAtivo.Size = new System.Drawing.Size(252, 50);
            this.grpCadastrarUndMedidaAtivo.TabIndex = 4;
            this.grpCadastrarUndMedidaAtivo.TabStop = false;
            this.grpCadastrarUndMedidaAtivo.Text = "Ativo";
            // 
            // rdoCadastrarUndMedidaAtivoNao
            // 
            this.rdoCadastrarUndMedidaAtivoNao.AutoSize = true;
            this.rdoCadastrarUndMedidaAtivoNao.Location = new System.Drawing.Point(164, 24);
            this.rdoCadastrarUndMedidaAtivoNao.Name = "rdoCadastrarUndMedidaAtivoNao";
            this.rdoCadastrarUndMedidaAtivoNao.Size = new System.Drawing.Size(51, 20);
            this.rdoCadastrarUndMedidaAtivoNao.TabIndex = 0;
            this.rdoCadastrarUndMedidaAtivoNao.TabStop = true;
            this.rdoCadastrarUndMedidaAtivoNao.Text = "Não";
            this.rdoCadastrarUndMedidaAtivoNao.UseVisualStyleBackColor = true;
            // 
            // rdoCadastrarUndMedidaAtivoSim
            // 
            this.rdoCadastrarUndMedidaAtivoSim.AutoSize = true;
            this.rdoCadastrarUndMedidaAtivoSim.Location = new System.Drawing.Point(28, 24);
            this.rdoCadastrarUndMedidaAtivoSim.Name = "rdoCadastrarUndMedidaAtivoSim";
            this.rdoCadastrarUndMedidaAtivoSim.Size = new System.Drawing.Size(49, 20);
            this.rdoCadastrarUndMedidaAtivoSim.TabIndex = 0;
            this.rdoCadastrarUndMedidaAtivoSim.TabStop = true;
            this.rdoCadastrarUndMedidaAtivoSim.Text = "Sim";
            this.rdoCadastrarUndMedidaAtivoSim.UseVisualStyleBackColor = true;
            // 
            // flpCadastrarUndMedidaMenu
            // 
            this.flpCadastrarUndMedidaMenu.Controls.Add(this.btnCadastrarUndMedidaMenuSalvar);
            this.flpCadastrarUndMedidaMenu.Controls.Add(this.btnCadastrarUndMedidaMenuLimpar);
            this.flpCadastrarUndMedidaMenu.Controls.Add(this.btnCadastrarUndMedidaMenuSair);
            this.flpCadastrarUndMedidaMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCadastrarUndMedidaMenu.Location = new System.Drawing.Point(0, 0);
            this.flpCadastrarUndMedidaMenu.Margin = new System.Windows.Forms.Padding(0);
            this.flpCadastrarUndMedidaMenu.Name = "flpCadastrarUndMedidaMenu";
            this.flpCadastrarUndMedidaMenu.Size = new System.Drawing.Size(298, 42);
            this.flpCadastrarUndMedidaMenu.TabIndex = 5;
            // 
            // btnCadastrarUndMedidaMenuSalvar
            // 
            this.btnCadastrarUndMedidaMenuSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarUndMedidaMenuSalvar.FlatAppearance.BorderSize = 0;
            this.btnCadastrarUndMedidaMenuSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarUndMedidaMenuSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarUndMedidaMenuSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarUndMedidaMenuSalvar.Image = global::UI.Properties.Resources.salvarpq;
            this.btnCadastrarUndMedidaMenuSalvar.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrarUndMedidaMenuSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarUndMedidaMenuSalvar.Name = "btnCadastrarUndMedidaMenuSalvar";
            this.btnCadastrarUndMedidaMenuSalvar.Size = new System.Drawing.Size(40, 40);
            this.btnCadastrarUndMedidaMenuSalvar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnCadastrarUndMedidaMenuSalvar, "Salvar");
            this.btnCadastrarUndMedidaMenuSalvar.UseVisualStyleBackColor = true;
            this.btnCadastrarUndMedidaMenuSalvar.Click += new System.EventHandler(this.BtnCadastrarUndMedidaMenuSalvar_Click);
            // 
            // btnCadastrarUndMedidaMenuLimpar
            // 
            this.btnCadastrarUndMedidaMenuLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarUndMedidaMenuLimpar.FlatAppearance.BorderSize = 0;
            this.btnCadastrarUndMedidaMenuLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarUndMedidaMenuLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarUndMedidaMenuLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarUndMedidaMenuLimpar.Image = global::UI.Properties.Resources.Limpar;
            this.btnCadastrarUndMedidaMenuLimpar.Location = new System.Drawing.Point(40, 0);
            this.btnCadastrarUndMedidaMenuLimpar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarUndMedidaMenuLimpar.Name = "btnCadastrarUndMedidaMenuLimpar";
            this.btnCadastrarUndMedidaMenuLimpar.Size = new System.Drawing.Size(40, 40);
            this.btnCadastrarUndMedidaMenuLimpar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnCadastrarUndMedidaMenuLimpar, "Limpar");
            this.btnCadastrarUndMedidaMenuLimpar.UseVisualStyleBackColor = true;
            this.btnCadastrarUndMedidaMenuLimpar.Click += new System.EventHandler(this.BtnCadastrarUndMedidaMenuLimpar_Click);
            // 
            // btnCadastrarUndMedidaMenuSair
            // 
            this.btnCadastrarUndMedidaMenuSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarUndMedidaMenuSair.FlatAppearance.BorderSize = 0;
            this.btnCadastrarUndMedidaMenuSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarUndMedidaMenuSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarUndMedidaMenuSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarUndMedidaMenuSair.Image = global::UI.Properties.Resources.sair32x32;
            this.btnCadastrarUndMedidaMenuSair.Location = new System.Drawing.Point(80, 0);
            this.btnCadastrarUndMedidaMenuSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarUndMedidaMenuSair.Name = "btnCadastrarUndMedidaMenuSair";
            this.btnCadastrarUndMedidaMenuSair.Size = new System.Drawing.Size(40, 40);
            this.btnCadastrarUndMedidaMenuSair.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCadastrarUndMedidaMenuSair, "Sair");
            this.btnCadastrarUndMedidaMenuSair.UseVisualStyleBackColor = true;
            this.btnCadastrarUndMedidaMenuSair.Click += new System.EventHandler(this.BtnCadastrarUndMedidaMenuSair_Click);
            // 
            // frmUnidadeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 266);
            this.Controls.Add(this.pnlCadastrarUndMedidaCampos);
            this.Controls.Add(this.pnlCadastroUndMedidaLista);
            this.Controls.Add(this.pnlCadastroUndMedidaTitulo);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUnidadeMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Unidade de Medida";
            this.Load += new System.EventHandler(this.FrmUnidadeMedida_Load);
            this.pnlCadastroUndMedidaTitulo.ResumeLayout(false);
            this.pnlCadastroUndMedidaTitulo.PerformLayout();
            this.pnlCadastroUndMedidaLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUndMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidademedidaBindingSource)).EndInit();
            this.flpCadastroUndMedidaProcurar.ResumeLayout(false);
            this.flpCadastroUndMedidaProcurar.PerformLayout();
            this.flpCadastroUndMedidaListaMenu.ResumeLayout(false);
            this.pnlCadastrarUndMedidaCampos.ResumeLayout(false);
            this.flpCadastrarUndMedidaCampos.ResumeLayout(false);
            this.flpCadastrarUndMedidaCampos.PerformLayout();
            this.grpCadastrarUndMedidaAtivo.ResumeLayout(false);
            this.grpCadastrarUndMedidaAtivo.PerformLayout();
            this.flpCadastrarUndMedidaMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadastroUndMedidaTitulo;
        private System.Windows.Forms.Button btnCadastroUndMedidaFechar;
        private System.Windows.Forms.Label lblCadastroUndMedidaTitulo;
        private System.Windows.Forms.Panel pnlCadastroUndMedidaLista;
        private System.Windows.Forms.DataGridView dgvUndMedida;
        private System.Windows.Forms.FlowLayoutPanel flpCadastroUndMedidaProcurar;
        private System.Windows.Forms.Label lblCadastroUndMedidaProcurarPor;
        private System.Windows.Forms.TextBox txtCadastroUndMedidaProcurarPor;
        private System.Windows.Forms.FlowLayoutPanel flpCadastroUndMedidaListaMenu;
        private System.Windows.Forms.Button btnCadastroUndMedidaMenuNovo;
        private System.Windows.Forms.Button btnCadastroUndMedidaMenuEditar;
        private System.Windows.Forms.Button btnCadastroUndMedidaMenuApagar;
        private System.Windows.Forms.Button btnCadastroUndMedidaMenuProcurar;
        private System.Windows.Forms.Panel pnlCadastrarUndMedidaCampos;
        private System.Windows.Forms.FlowLayoutPanel flpCadastrarUndMedidaCampos;
        private System.Windows.Forms.Label lblCadastrarUndMedidaCodigo;
        private System.Windows.Forms.TextBox txtCadastrarUndMedidaCodigo;
        private System.Windows.Forms.Label lblCadastrarUndMedidaNome;
        private System.Windows.Forms.TextBox txtCadastrarUndMedidaNome;
        private System.Windows.Forms.FlowLayoutPanel flpCadastrarUndMedidaMenu;
        private System.Windows.Forms.Button btnCadastrarUndMedidaMenuSalvar;
        private System.Windows.Forms.Button btnCadastrarUndMedidaMenuLimpar;
        private System.Windows.Forms.Button btnCadastrarUndMedidaMenuSair;
        private System.Windows.Forms.BindingSource unidademedidaBindingSource;
        private System.Windows.Forms.GroupBox grpCadastrarUndMedidaAtivo;
        private System.Windows.Forms.RadioButton rdoCadastrarUndMedidaAtivoNao;
        private System.Windows.Forms.RadioButton rdoCadastrarUndMedidaAtivoSim;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCadastroUndMedidaMinimizar;
    }
}