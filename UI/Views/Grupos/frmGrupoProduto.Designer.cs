namespace UI
{
    partial class frmGrupoProduto
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
            this.pnlCadastroGrupoProdutoTitulo = new System.Windows.Forms.Panel();
            this.btnCadastroGrupoProdutoMinimizar = new System.Windows.Forms.Button();
            this.btnCadastroGrupoProdutoFechar = new System.Windows.Forms.Button();
            this.lblCadastroGrupoProdutoTitulo = new System.Windows.Forms.Label();
            this.pnlCadastroGrupoProdutoLista = new System.Windows.Forms.Panel();
            this.dgvGrupoProduto = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flpCadastroGrupoProdutoProcurar = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCadastroGrupoProdutoProcurarPor = new System.Windows.Forms.Label();
            this.txtCadastroGrupoProdutoProcurarPor = new System.Windows.Forms.TextBox();
            this.flpCadastroGrupoProdutoListaMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCadastroGrupoProdutoMenuNovo = new System.Windows.Forms.Button();
            this.btnCadastroGrupoProdutoMenuEditar = new System.Windows.Forms.Button();
            this.btnCadastroGrupoProdutoMenuApagar = new System.Windows.Forms.Button();
            this.btnCadastroGrupoProdutoMenuProcurar = new System.Windows.Forms.Button();
            this.pnlCadastrarGrupoProdutoCampos = new System.Windows.Forms.Panel();
            this.flpCadastrarGrupoProdutoCampos = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCadastrarGrupoProdutoCodigo = new System.Windows.Forms.Label();
            this.txtCadastrarGrupoProdutoCodigo = new System.Windows.Forms.TextBox();
            this.lblCadastrarGrupoProdutoNome = new System.Windows.Forms.Label();
            this.txtCadastrarGrupoProdutoNome = new System.Windows.Forms.TextBox();
            this.grpCadastrarGrupoProdutoAtivo = new System.Windows.Forms.GroupBox();
            this.rdoCadastrarGrupoProdutoAtivoNao = new System.Windows.Forms.RadioButton();
            this.rdoCadastrarGrupoProdutoAtivoSim = new System.Windows.Forms.RadioButton();
            this.flpCadastrarGrupoProdutoMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCadastrarGrupoProdutoMenuSalvar = new System.Windows.Forms.Button();
            this.btnCadastrarGrupoProdutoMenuLimpar = new System.Windows.Forms.Button();
            this.btnCadastrarGrupoProdutoMenuSair = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlCadastroGrupoProdutoTitulo.SuspendLayout();
            this.pnlCadastroGrupoProdutoLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoprodutoBindingSource)).BeginInit();
            this.flpCadastroGrupoProdutoProcurar.SuspendLayout();
            this.flpCadastroGrupoProdutoListaMenu.SuspendLayout();
            this.pnlCadastrarGrupoProdutoCampos.SuspendLayout();
            this.flpCadastrarGrupoProdutoCampos.SuspendLayout();
            this.grpCadastrarGrupoProdutoAtivo.SuspendLayout();
            this.flpCadastrarGrupoProdutoMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadastroGrupoProdutoTitulo
            // 
            this.pnlCadastroGrupoProdutoTitulo.BackColor = System.Drawing.Color.MintCream;
            this.pnlCadastroGrupoProdutoTitulo.Controls.Add(this.btnCadastroGrupoProdutoMinimizar);
            this.pnlCadastroGrupoProdutoTitulo.Controls.Add(this.btnCadastroGrupoProdutoFechar);
            this.pnlCadastroGrupoProdutoTitulo.Controls.Add(this.lblCadastroGrupoProdutoTitulo);
            this.pnlCadastroGrupoProdutoTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCadastroGrupoProdutoTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastroGrupoProdutoTitulo.Margin = new System.Windows.Forms.Padding(6);
            this.pnlCadastroGrupoProdutoTitulo.Name = "pnlCadastroGrupoProdutoTitulo";
            this.pnlCadastroGrupoProdutoTitulo.Size = new System.Drawing.Size(526, 22);
            this.pnlCadastroGrupoProdutoTitulo.TabIndex = 8;
            // 
            // btnCadastroGrupoProdutoMinimizar
            // 
            this.btnCadastroGrupoProdutoMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCadastroGrupoProdutoMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroGrupoProdutoMinimizar.FlatAppearance.BorderSize = 0;
            this.btnCadastroGrupoProdutoMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.btnCadastroGrupoProdutoMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCadastroGrupoProdutoMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroGrupoProdutoMinimizar.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroGrupoProdutoMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnCadastroGrupoProdutoMinimizar.Image = global::UI.Properties.Resources.minimizar;
            this.btnCadastroGrupoProdutoMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastroGrupoProdutoMinimizar.Location = new System.Drawing.Point(466, 0);
            this.btnCadastroGrupoProdutoMinimizar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCadastroGrupoProdutoMinimizar.Name = "btnCadastroGrupoProdutoMinimizar";
            this.btnCadastroGrupoProdutoMinimizar.Size = new System.Drawing.Size(30, 22);
            this.btnCadastroGrupoProdutoMinimizar.TabIndex = 5;
            this.btnCadastroGrupoProdutoMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnCadastroGrupoProdutoMinimizar, "Minimizar");
            this.btnCadastroGrupoProdutoMinimizar.UseVisualStyleBackColor = true;
            this.btnCadastroGrupoProdutoMinimizar.Click += new System.EventHandler(this.BtnCadastroGrupoProdutoMinimizar_Click);
            // 
            // btnCadastroGrupoProdutoFechar
            // 
            this.btnCadastroGrupoProdutoFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCadastroGrupoProdutoFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroGrupoProdutoFechar.FlatAppearance.BorderSize = 0;
            this.btnCadastroGrupoProdutoFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.btnCadastroGrupoProdutoFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCadastroGrupoProdutoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroGrupoProdutoFechar.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroGrupoProdutoFechar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroGrupoProdutoFechar.Image = global::UI.Properties.Resources.fechar;
            this.btnCadastroGrupoProdutoFechar.Location = new System.Drawing.Point(496, 0);
            this.btnCadastroGrupoProdutoFechar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCadastroGrupoProdutoFechar.Name = "btnCadastroGrupoProdutoFechar";
            this.btnCadastroGrupoProdutoFechar.Size = new System.Drawing.Size(30, 22);
            this.btnCadastroGrupoProdutoFechar.TabIndex = 4;
            this.btnCadastroGrupoProdutoFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnCadastroGrupoProdutoFechar, "Fechar");
            this.btnCadastroGrupoProdutoFechar.UseVisualStyleBackColor = true;
            this.btnCadastroGrupoProdutoFechar.Click += new System.EventHandler(this.BtnCadastroGrupoProdutoFechar_Click);
            // 
            // lblCadastroGrupoProdutoTitulo
            // 
            this.lblCadastroGrupoProdutoTitulo.AutoSize = true;
            this.lblCadastroGrupoProdutoTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCadastroGrupoProdutoTitulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroGrupoProdutoTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblCadastroGrupoProdutoTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblCadastroGrupoProdutoTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblCadastroGrupoProdutoTitulo.Name = "lblCadastroGrupoProdutoTitulo";
            this.lblCadastroGrupoProdutoTitulo.Size = new System.Drawing.Size(247, 18);
            this.lblCadastroGrupoProdutoTitulo.TabIndex = 0;
            this.lblCadastroGrupoProdutoTitulo.Text = "Cadastro Grupo de Produtos";
            // 
            // pnlCadastroGrupoProdutoLista
            // 
            this.pnlCadastroGrupoProdutoLista.Controls.Add(this.dgvGrupoProduto);
            this.pnlCadastroGrupoProdutoLista.Controls.Add(this.flpCadastroGrupoProdutoProcurar);
            this.pnlCadastroGrupoProdutoLista.Controls.Add(this.flpCadastroGrupoProdutoListaMenu);
            this.pnlCadastroGrupoProdutoLista.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCadastroGrupoProdutoLista.Location = new System.Drawing.Point(0, 22);
            this.pnlCadastroGrupoProdutoLista.Name = "pnlCadastroGrupoProdutoLista";
            this.pnlCadastroGrupoProdutoLista.Size = new System.Drawing.Size(209, 250);
            this.pnlCadastroGrupoProdutoLista.TabIndex = 9;
            // 
            // dgvGrupoProduto
            // 
            this.dgvGrupoProduto.AllowUserToAddRows = false;
            this.dgvGrupoProduto.AllowUserToDeleteRows = false;
            this.dgvGrupoProduto.AutoGenerateColumns = false;
            this.dgvGrupoProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrupoProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupoProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.ativoDataGridViewTextBoxColumn});
            this.dgvGrupoProduto.DataSource = this.grupoprodutoBindingSource;
            this.dgvGrupoProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrupoProduto.Location = new System.Drawing.Point(0, 72);
            this.dgvGrupoProduto.MultiSelect = false;
            this.dgvGrupoProduto.Name = "dgvGrupoProduto";
            this.dgvGrupoProduto.ReadOnly = true;
            this.dgvGrupoProduto.Size = new System.Drawing.Size(209, 178);
            this.dgvGrupoProduto.TabIndex = 8;
            this.dgvGrupoProduto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvGrupoProduto_CellFormatting);
            this.dgvGrupoProduto.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvGrupoProduto_RowHeaderMouseClick);
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
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Grupo Produto";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // ativoDataGridViewTextBoxColumn
            // 
            this.ativoDataGridViewTextBoxColumn.DataPropertyName = "ativo";
            this.ativoDataGridViewTextBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewTextBoxColumn.Name = "ativoDataGridViewTextBoxColumn";
            this.ativoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ativoDataGridViewTextBoxColumn.Width = 60;
            // 
            // grupoprodutoBindingSource
            // 
            this.grupoprodutoBindingSource.DataSource = typeof(DAO.grupo_produto);
            // 
            // flpCadastroGrupoProdutoProcurar
            // 
            this.flpCadastroGrupoProdutoProcurar.Controls.Add(this.lblCadastroGrupoProdutoProcurarPor);
            this.flpCadastroGrupoProdutoProcurar.Controls.Add(this.txtCadastroGrupoProdutoProcurarPor);
            this.flpCadastroGrupoProdutoProcurar.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCadastroGrupoProdutoProcurar.Location = new System.Drawing.Point(0, 32);
            this.flpCadastroGrupoProdutoProcurar.Margin = new System.Windows.Forms.Padding(0);
            this.flpCadastroGrupoProdutoProcurar.Name = "flpCadastroGrupoProdutoProcurar";
            this.flpCadastroGrupoProdutoProcurar.Size = new System.Drawing.Size(209, 40);
            this.flpCadastroGrupoProdutoProcurar.TabIndex = 7;
            this.flpCadastroGrupoProdutoProcurar.Visible = false;
            // 
            // lblCadastroGrupoProdutoProcurarPor
            // 
            this.lblCadastroGrupoProdutoProcurarPor.AutoSize = true;
            this.lblCadastroGrupoProdutoProcurarPor.Location = new System.Drawing.Point(0, 15);
            this.lblCadastroGrupoProdutoProcurarPor.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.lblCadastroGrupoProdutoProcurarPor.Name = "lblCadastroGrupoProdutoProcurarPor";
            this.lblCadastroGrupoProdutoProcurarPor.Size = new System.Drawing.Size(87, 16);
            this.lblCadastroGrupoProdutoProcurarPor.TabIndex = 1;
            this.lblCadastroGrupoProdutoProcurarPor.Text = "Grp Produto:";
            // 
            // txtCadastroGrupoProdutoProcurarPor
            // 
            this.txtCadastroGrupoProdutoProcurarPor.Location = new System.Drawing.Point(87, 5);
            this.txtCadastroGrupoProdutoProcurarPor.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.txtCadastroGrupoProdutoProcurarPor.Name = "txtCadastroGrupoProdutoProcurarPor";
            this.txtCadastroGrupoProdutoProcurarPor.Size = new System.Drawing.Size(101, 27);
            this.txtCadastroGrupoProdutoProcurarPor.TabIndex = 4;
            this.txtCadastroGrupoProdutoProcurarPor.TextChanged += new System.EventHandler(this.TxtCadastroGrupoProdutoProcurarPor_TextChanged);
            // 
            // flpCadastroGrupoProdutoListaMenu
            // 
            this.flpCadastroGrupoProdutoListaMenu.Controls.Add(this.btnCadastroGrupoProdutoMenuNovo);
            this.flpCadastroGrupoProdutoListaMenu.Controls.Add(this.btnCadastroGrupoProdutoMenuEditar);
            this.flpCadastroGrupoProdutoListaMenu.Controls.Add(this.btnCadastroGrupoProdutoMenuApagar);
            this.flpCadastroGrupoProdutoListaMenu.Controls.Add(this.btnCadastroGrupoProdutoMenuProcurar);
            this.flpCadastroGrupoProdutoListaMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCadastroGrupoProdutoListaMenu.Location = new System.Drawing.Point(0, 0);
            this.flpCadastroGrupoProdutoListaMenu.Margin = new System.Windows.Forms.Padding(0);
            this.flpCadastroGrupoProdutoListaMenu.Name = "flpCadastroGrupoProdutoListaMenu";
            this.flpCadastroGrupoProdutoListaMenu.Size = new System.Drawing.Size(209, 32);
            this.flpCadastroGrupoProdutoListaMenu.TabIndex = 6;
            // 
            // btnCadastroGrupoProdutoMenuNovo
            // 
            this.btnCadastroGrupoProdutoMenuNovo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroGrupoProdutoMenuNovo.FlatAppearance.BorderSize = 0;
            this.btnCadastroGrupoProdutoMenuNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastroGrupoProdutoMenuNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastroGrupoProdutoMenuNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroGrupoProdutoMenuNovo.Image = global::UI.Properties.Resources.Novopq;
            this.btnCadastroGrupoProdutoMenuNovo.Location = new System.Drawing.Point(0, 0);
            this.btnCadastroGrupoProdutoMenuNovo.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastroGrupoProdutoMenuNovo.Name = "btnCadastroGrupoProdutoMenuNovo";
            this.btnCadastroGrupoProdutoMenuNovo.Size = new System.Drawing.Size(30, 30);
            this.btnCadastroGrupoProdutoMenuNovo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnCadastroGrupoProdutoMenuNovo, "Novo");
            this.btnCadastroGrupoProdutoMenuNovo.UseVisualStyleBackColor = true;
            this.btnCadastroGrupoProdutoMenuNovo.Click += new System.EventHandler(this.BtnCadastroGrupoProdutoMenuNovo_Click);
            // 
            // btnCadastroGrupoProdutoMenuEditar
            // 
            this.btnCadastroGrupoProdutoMenuEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroGrupoProdutoMenuEditar.FlatAppearance.BorderSize = 0;
            this.btnCadastroGrupoProdutoMenuEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastroGrupoProdutoMenuEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastroGrupoProdutoMenuEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroGrupoProdutoMenuEditar.Image = global::UI.Properties.Resources.Alterarpq;
            this.btnCadastroGrupoProdutoMenuEditar.Location = new System.Drawing.Point(30, 0);
            this.btnCadastroGrupoProdutoMenuEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastroGrupoProdutoMenuEditar.Name = "btnCadastroGrupoProdutoMenuEditar";
            this.btnCadastroGrupoProdutoMenuEditar.Size = new System.Drawing.Size(30, 30);
            this.btnCadastroGrupoProdutoMenuEditar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCadastroGrupoProdutoMenuEditar, "Editar");
            this.btnCadastroGrupoProdutoMenuEditar.UseVisualStyleBackColor = true;
            this.btnCadastroGrupoProdutoMenuEditar.Visible = false;
            this.btnCadastroGrupoProdutoMenuEditar.Click += new System.EventHandler(this.BtnCadastroGrupoProdutoMenuEditar_Click);
            // 
            // btnCadastroGrupoProdutoMenuApagar
            // 
            this.btnCadastroGrupoProdutoMenuApagar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroGrupoProdutoMenuApagar.FlatAppearance.BorderSize = 0;
            this.btnCadastroGrupoProdutoMenuApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastroGrupoProdutoMenuApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastroGrupoProdutoMenuApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroGrupoProdutoMenuApagar.Image = global::UI.Properties.Resources.Excluirpq;
            this.btnCadastroGrupoProdutoMenuApagar.Location = new System.Drawing.Point(60, 0);
            this.btnCadastroGrupoProdutoMenuApagar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastroGrupoProdutoMenuApagar.Name = "btnCadastroGrupoProdutoMenuApagar";
            this.btnCadastroGrupoProdutoMenuApagar.Size = new System.Drawing.Size(30, 30);
            this.btnCadastroGrupoProdutoMenuApagar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnCadastroGrupoProdutoMenuApagar, "Excluir");
            this.btnCadastroGrupoProdutoMenuApagar.UseVisualStyleBackColor = true;
            this.btnCadastroGrupoProdutoMenuApagar.Visible = false;
            this.btnCadastroGrupoProdutoMenuApagar.Click += new System.EventHandler(this.BtnCadastroGrupoProdutoMenuApagar_Click);
            // 
            // btnCadastroGrupoProdutoMenuProcurar
            // 
            this.btnCadastroGrupoProdutoMenuProcurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastroGrupoProdutoMenuProcurar.FlatAppearance.BorderSize = 0;
            this.btnCadastroGrupoProdutoMenuProcurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastroGrupoProdutoMenuProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastroGrupoProdutoMenuProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroGrupoProdutoMenuProcurar.Image = global::UI.Properties.Resources.procurarpq2;
            this.btnCadastroGrupoProdutoMenuProcurar.Location = new System.Drawing.Point(90, 0);
            this.btnCadastroGrupoProdutoMenuProcurar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastroGrupoProdutoMenuProcurar.Name = "btnCadastroGrupoProdutoMenuProcurar";
            this.btnCadastroGrupoProdutoMenuProcurar.Size = new System.Drawing.Size(30, 30);
            this.btnCadastroGrupoProdutoMenuProcurar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnCadastroGrupoProdutoMenuProcurar, "Procurar");
            this.btnCadastroGrupoProdutoMenuProcurar.UseVisualStyleBackColor = true;
            this.btnCadastroGrupoProdutoMenuProcurar.Click += new System.EventHandler(this.BtnCadastroGrupoProdutoMenuProcurar_Click);
            // 
            // pnlCadastrarGrupoProdutoCampos
            // 
            this.pnlCadastrarGrupoProdutoCampos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCadastrarGrupoProdutoCampos.Controls.Add(this.flpCadastrarGrupoProdutoCampos);
            this.pnlCadastrarGrupoProdutoCampos.Controls.Add(this.flpCadastrarGrupoProdutoMenu);
            this.pnlCadastrarGrupoProdutoCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadastrarGrupoProdutoCampos.Location = new System.Drawing.Point(209, 22);
            this.pnlCadastrarGrupoProdutoCampos.Name = "pnlCadastrarGrupoProdutoCampos";
            this.pnlCadastrarGrupoProdutoCampos.Size = new System.Drawing.Size(317, 250);
            this.pnlCadastrarGrupoProdutoCampos.TabIndex = 10;
            this.pnlCadastrarGrupoProdutoCampos.Visible = false;
            // 
            // flpCadastrarGrupoProdutoCampos
            // 
            this.flpCadastrarGrupoProdutoCampos.Controls.Add(this.lblCadastrarGrupoProdutoCodigo);
            this.flpCadastrarGrupoProdutoCampos.Controls.Add(this.txtCadastrarGrupoProdutoCodigo);
            this.flpCadastrarGrupoProdutoCampos.Controls.Add(this.lblCadastrarGrupoProdutoNome);
            this.flpCadastrarGrupoProdutoCampos.Controls.Add(this.txtCadastrarGrupoProdutoNome);
            this.flpCadastrarGrupoProdutoCampos.Controls.Add(this.grpCadastrarGrupoProdutoAtivo);
            this.flpCadastrarGrupoProdutoCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCadastrarGrupoProdutoCampos.Location = new System.Drawing.Point(0, 42);
            this.flpCadastrarGrupoProdutoCampos.Margin = new System.Windows.Forms.Padding(0);
            this.flpCadastrarGrupoProdutoCampos.Name = "flpCadastrarGrupoProdutoCampos";
            this.flpCadastrarGrupoProdutoCampos.Size = new System.Drawing.Size(315, 206);
            this.flpCadastrarGrupoProdutoCampos.TabIndex = 6;
            // 
            // lblCadastrarGrupoProdutoCodigo
            // 
            this.lblCadastrarGrupoProdutoCodigo.AutoSize = true;
            this.flpCadastrarGrupoProdutoCampos.SetFlowBreak(this.lblCadastrarGrupoProdutoCodigo, true);
            this.lblCadastrarGrupoProdutoCodigo.Location = new System.Drawing.Point(30, 10);
            this.lblCadastrarGrupoProdutoCodigo.Margin = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.lblCadastrarGrupoProdutoCodigo.Name = "lblCadastrarGrupoProdutoCodigo";
            this.lblCadastrarGrupoProdutoCodigo.Size = new System.Drawing.Size(53, 16);
            this.lblCadastrarGrupoProdutoCodigo.TabIndex = 0;
            this.lblCadastrarGrupoProdutoCodigo.Text = "Código";
            // 
            // txtCadastrarGrupoProdutoCodigo
            // 
            this.txtCadastrarGrupoProdutoCodigo.Enabled = false;
            this.flpCadastrarGrupoProdutoCampos.SetFlowBreak(this.txtCadastrarGrupoProdutoCodigo, true);
            this.txtCadastrarGrupoProdutoCodigo.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrarGrupoProdutoCodigo.Location = new System.Drawing.Point(30, 31);
            this.txtCadastrarGrupoProdutoCodigo.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.txtCadastrarGrupoProdutoCodigo.Name = "txtCadastrarGrupoProdutoCodigo";
            this.txtCadastrarGrupoProdutoCodigo.Size = new System.Drawing.Size(135, 31);
            this.txtCadastrarGrupoProdutoCodigo.TabIndex = 1;
            // 
            // lblCadastrarGrupoProdutoNome
            // 
            this.lblCadastrarGrupoProdutoNome.AutoSize = true;
            this.flpCadastrarGrupoProdutoCampos.SetFlowBreak(this.lblCadastrarGrupoProdutoNome, true);
            this.lblCadastrarGrupoProdutoNome.Location = new System.Drawing.Point(30, 77);
            this.lblCadastrarGrupoProdutoNome.Margin = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.lblCadastrarGrupoProdutoNome.Name = "lblCadastrarGrupoProdutoNome";
            this.lblCadastrarGrupoProdutoNome.Size = new System.Drawing.Size(100, 16);
            this.lblCadastrarGrupoProdutoNome.TabIndex = 2;
            this.lblCadastrarGrupoProdutoNome.Text = "Grupo produto";
            // 
            // txtCadastrarGrupoProdutoNome
            // 
            this.flpCadastrarGrupoProdutoCampos.SetFlowBreak(this.txtCadastrarGrupoProdutoNome, true);
            this.txtCadastrarGrupoProdutoNome.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrarGrupoProdutoNome.Location = new System.Drawing.Point(30, 98);
            this.txtCadastrarGrupoProdutoNome.Margin = new System.Windows.Forms.Padding(30, 5, 45, 0);
            this.txtCadastrarGrupoProdutoNome.Name = "txtCadastrarGrupoProdutoNome";
            this.txtCadastrarGrupoProdutoNome.Size = new System.Drawing.Size(252, 31);
            this.txtCadastrarGrupoProdutoNome.TabIndex = 3;
            this.txtCadastrarGrupoProdutoNome.Leave += new System.EventHandler(this.TxtCadastrarGrupoProdutoNome_Leave);
            // 
            // grpCadastrarGrupoProdutoAtivo
            // 
            this.grpCadastrarGrupoProdutoAtivo.Controls.Add(this.rdoCadastrarGrupoProdutoAtivoNao);
            this.grpCadastrarGrupoProdutoAtivo.Controls.Add(this.rdoCadastrarGrupoProdutoAtivoSim);
            this.grpCadastrarGrupoProdutoAtivo.Location = new System.Drawing.Point(30, 144);
            this.grpCadastrarGrupoProdutoAtivo.Margin = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.grpCadastrarGrupoProdutoAtivo.Name = "grpCadastrarGrupoProdutoAtivo";
            this.grpCadastrarGrupoProdutoAtivo.Size = new System.Drawing.Size(252, 50);
            this.grpCadastrarGrupoProdutoAtivo.TabIndex = 4;
            this.grpCadastrarGrupoProdutoAtivo.TabStop = false;
            this.grpCadastrarGrupoProdutoAtivo.Text = "Ativo";
            // 
            // rdoCadastrarGrupoProdutoAtivoNao
            // 
            this.rdoCadastrarGrupoProdutoAtivoNao.AutoSize = true;
            this.rdoCadastrarGrupoProdutoAtivoNao.Location = new System.Drawing.Point(164, 24);
            this.rdoCadastrarGrupoProdutoAtivoNao.Name = "rdoCadastrarGrupoProdutoAtivoNao";
            this.rdoCadastrarGrupoProdutoAtivoNao.Size = new System.Drawing.Size(51, 20);
            this.rdoCadastrarGrupoProdutoAtivoNao.TabIndex = 0;
            this.rdoCadastrarGrupoProdutoAtivoNao.TabStop = true;
            this.rdoCadastrarGrupoProdutoAtivoNao.Text = "Não";
            this.rdoCadastrarGrupoProdutoAtivoNao.UseVisualStyleBackColor = true;
            // 
            // rdoCadastrarGrupoProdutoAtivoSim
            // 
            this.rdoCadastrarGrupoProdutoAtivoSim.AutoSize = true;
            this.rdoCadastrarGrupoProdutoAtivoSim.Location = new System.Drawing.Point(28, 24);
            this.rdoCadastrarGrupoProdutoAtivoSim.Name = "rdoCadastrarGrupoProdutoAtivoSim";
            this.rdoCadastrarGrupoProdutoAtivoSim.Size = new System.Drawing.Size(49, 20);
            this.rdoCadastrarGrupoProdutoAtivoSim.TabIndex = 0;
            this.rdoCadastrarGrupoProdutoAtivoSim.TabStop = true;
            this.rdoCadastrarGrupoProdutoAtivoSim.Text = "Sim";
            this.rdoCadastrarGrupoProdutoAtivoSim.UseVisualStyleBackColor = true;
            // 
            // flpCadastrarGrupoProdutoMenu
            // 
            this.flpCadastrarGrupoProdutoMenu.Controls.Add(this.btnCadastrarGrupoProdutoMenuSalvar);
            this.flpCadastrarGrupoProdutoMenu.Controls.Add(this.btnCadastrarGrupoProdutoMenuLimpar);
            this.flpCadastrarGrupoProdutoMenu.Controls.Add(this.btnCadastrarGrupoProdutoMenuSair);
            this.flpCadastrarGrupoProdutoMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCadastrarGrupoProdutoMenu.Location = new System.Drawing.Point(0, 0);
            this.flpCadastrarGrupoProdutoMenu.Margin = new System.Windows.Forms.Padding(0);
            this.flpCadastrarGrupoProdutoMenu.Name = "flpCadastrarGrupoProdutoMenu";
            this.flpCadastrarGrupoProdutoMenu.Size = new System.Drawing.Size(315, 42);
            this.flpCadastrarGrupoProdutoMenu.TabIndex = 5;
            // 
            // btnCadastrarGrupoProdutoMenuSalvar
            // 
            this.btnCadastrarGrupoProdutoMenuSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarGrupoProdutoMenuSalvar.FlatAppearance.BorderSize = 0;
            this.btnCadastrarGrupoProdutoMenuSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarGrupoProdutoMenuSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarGrupoProdutoMenuSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarGrupoProdutoMenuSalvar.Image = global::UI.Properties.Resources.salvarpq;
            this.btnCadastrarGrupoProdutoMenuSalvar.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrarGrupoProdutoMenuSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarGrupoProdutoMenuSalvar.Name = "btnCadastrarGrupoProdutoMenuSalvar";
            this.btnCadastrarGrupoProdutoMenuSalvar.Size = new System.Drawing.Size(40, 40);
            this.btnCadastrarGrupoProdutoMenuSalvar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnCadastrarGrupoProdutoMenuSalvar, "Salvar");
            this.btnCadastrarGrupoProdutoMenuSalvar.UseVisualStyleBackColor = true;
            this.btnCadastrarGrupoProdutoMenuSalvar.Click += new System.EventHandler(this.BtnCadastrarGrupoProdutoMenuSalvar_Click);
            // 
            // btnCadastrarGrupoProdutoMenuLimpar
            // 
            this.btnCadastrarGrupoProdutoMenuLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarGrupoProdutoMenuLimpar.FlatAppearance.BorderSize = 0;
            this.btnCadastrarGrupoProdutoMenuLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarGrupoProdutoMenuLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarGrupoProdutoMenuLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarGrupoProdutoMenuLimpar.Image = global::UI.Properties.Resources.Limpar;
            this.btnCadastrarGrupoProdutoMenuLimpar.Location = new System.Drawing.Point(40, 0);
            this.btnCadastrarGrupoProdutoMenuLimpar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarGrupoProdutoMenuLimpar.Name = "btnCadastrarGrupoProdutoMenuLimpar";
            this.btnCadastrarGrupoProdutoMenuLimpar.Size = new System.Drawing.Size(40, 40);
            this.btnCadastrarGrupoProdutoMenuLimpar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnCadastrarGrupoProdutoMenuLimpar, "Limpar");
            this.btnCadastrarGrupoProdutoMenuLimpar.UseVisualStyleBackColor = true;
            this.btnCadastrarGrupoProdutoMenuLimpar.Click += new System.EventHandler(this.BtnCadastrarGrupoProdutoMenuLimpar_Click);
            // 
            // btnCadastrarGrupoProdutoMenuSair
            // 
            this.btnCadastrarGrupoProdutoMenuSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarGrupoProdutoMenuSair.FlatAppearance.BorderSize = 0;
            this.btnCadastrarGrupoProdutoMenuSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarGrupoProdutoMenuSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarGrupoProdutoMenuSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarGrupoProdutoMenuSair.Image = global::UI.Properties.Resources.sair32x32;
            this.btnCadastrarGrupoProdutoMenuSair.Location = new System.Drawing.Point(80, 0);
            this.btnCadastrarGrupoProdutoMenuSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarGrupoProdutoMenuSair.Name = "btnCadastrarGrupoProdutoMenuSair";
            this.btnCadastrarGrupoProdutoMenuSair.Size = new System.Drawing.Size(40, 40);
            this.btnCadastrarGrupoProdutoMenuSair.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCadastrarGrupoProdutoMenuSair, "Sair");
            this.btnCadastrarGrupoProdutoMenuSair.UseVisualStyleBackColor = true;
            this.btnCadastrarGrupoProdutoMenuSair.Click += new System.EventHandler(this.BtnCadastrarGrupoProdutoMenuSair_Click);
            // 
            // frmGrupoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(526, 272);
            this.Controls.Add(this.pnlCadastrarGrupoProdutoCampos);
            this.Controls.Add(this.pnlCadastroGrupoProdutoLista);
            this.Controls.Add(this.pnlCadastroGrupoProdutoTitulo);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGrupoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo Produto";
            this.Load += new System.EventHandler(this.FrmGrupoProduto_Load);
            this.pnlCadastroGrupoProdutoTitulo.ResumeLayout(false);
            this.pnlCadastroGrupoProdutoTitulo.PerformLayout();
            this.pnlCadastroGrupoProdutoLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoprodutoBindingSource)).EndInit();
            this.flpCadastroGrupoProdutoProcurar.ResumeLayout(false);
            this.flpCadastroGrupoProdutoProcurar.PerformLayout();
            this.flpCadastroGrupoProdutoListaMenu.ResumeLayout(false);
            this.pnlCadastrarGrupoProdutoCampos.ResumeLayout(false);
            this.flpCadastrarGrupoProdutoCampos.ResumeLayout(false);
            this.flpCadastrarGrupoProdutoCampos.PerformLayout();
            this.grpCadastrarGrupoProdutoAtivo.ResumeLayout(false);
            this.grpCadastrarGrupoProdutoAtivo.PerformLayout();
            this.flpCadastrarGrupoProdutoMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadastroGrupoProdutoTitulo;
        private System.Windows.Forms.Button btnCadastroGrupoProdutoFechar;
        private System.Windows.Forms.Label lblCadastroGrupoProdutoTitulo;
        private System.Windows.Forms.Panel pnlCadastroGrupoProdutoLista;
        private System.Windows.Forms.DataGridView dgvGrupoProduto;
        private System.Windows.Forms.FlowLayoutPanel flpCadastroGrupoProdutoProcurar;
        private System.Windows.Forms.Label lblCadastroGrupoProdutoProcurarPor;
        private System.Windows.Forms.TextBox txtCadastroGrupoProdutoProcurarPor;
        private System.Windows.Forms.FlowLayoutPanel flpCadastroGrupoProdutoListaMenu;
        private System.Windows.Forms.Button btnCadastroGrupoProdutoMenuNovo;
        private System.Windows.Forms.Button btnCadastroGrupoProdutoMenuEditar;
        private System.Windows.Forms.Button btnCadastroGrupoProdutoMenuApagar;
        private System.Windows.Forms.Button btnCadastroGrupoProdutoMenuProcurar;
        private System.Windows.Forms.Panel pnlCadastrarGrupoProdutoCampos;
        private System.Windows.Forms.FlowLayoutPanel flpCadastrarGrupoProdutoCampos;
        private System.Windows.Forms.Label lblCadastrarGrupoProdutoCodigo;
        private System.Windows.Forms.TextBox txtCadastrarGrupoProdutoCodigo;
        private System.Windows.Forms.Label lblCadastrarGrupoProdutoNome;
        private System.Windows.Forms.TextBox txtCadastrarGrupoProdutoNome;
        private System.Windows.Forms.GroupBox grpCadastrarGrupoProdutoAtivo;
        private System.Windows.Forms.RadioButton rdoCadastrarGrupoProdutoAtivoNao;
        private System.Windows.Forms.RadioButton rdoCadastrarGrupoProdutoAtivoSim;
        private System.Windows.Forms.FlowLayoutPanel flpCadastrarGrupoProdutoMenu;
        private System.Windows.Forms.Button btnCadastrarGrupoProdutoMenuSalvar;
        private System.Windows.Forms.Button btnCadastrarGrupoProdutoMenuLimpar;
        private System.Windows.Forms.Button btnCadastrarGrupoProdutoMenuSair;
        private System.Windows.Forms.BindingSource grupoprodutoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCadastroGrupoProdutoMinimizar;
    }
}