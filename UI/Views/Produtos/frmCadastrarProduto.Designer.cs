namespace UI
{
    partial class frmCadastrarProduto
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
            this.grupoprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidademedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlCadastrarProdutosCampos = new System.Windows.Forms.Panel();
            this.btnCadastrarProdutoAddUndMedida = new System.Windows.Forms.Button();
            this.btnCadastrarProdutoAddGrupo = new System.Windows.Forms.Button();
            this.btnCadastrarProdutoSalvar = new System.Windows.Forms.Button();
            this.btnCadastrarProdutoLimpar = new System.Windows.Forms.Button();
            this.btnCadastrarProdutoSair = new System.Windows.Forms.Button();
            this.lblCadastrarProdutoNome = new System.Windows.Forms.Label();
            this.txtCadastrarProdutoValorVenda = new System.Windows.Forms.TextBox();
            this.txtCadastrarProdutoMargemLucro = new System.Windows.Forms.TextBox();
            this.txtCadastrarProdutoValorCompra = new System.Windows.Forms.TextBox();
            this.txtCadastrarProdutoNome = new System.Windows.Forms.TextBox();
            this.lblCadastrarProdutoDescricao = new System.Windows.Forms.Label();
            this.txtCadastrarProdutoDescricao = new System.Windows.Forms.TextBox();
            this.lblProcentagem = new System.Windows.Forms.Label();
            this.lblCadastrarProdutoMargemLucro = new System.Windows.Forms.Label();
            this.lblCadastrarProdutoValorCompra = new System.Windows.Forms.Label();
            this.lblCadastrarProdutoGrupo = new System.Windows.Forms.Label();
            this.lblCadastrarProdutoUndMedida = new System.Windows.Forms.Label();
            this.lblCadastrarProdutoValorVenda = new System.Windows.Forms.Label();
            this.lblCadastrarProdutoFornecedor = new System.Windows.Forms.Label();
            this.cmbCadastrarProdutoGrupo = new System.Windows.Forms.ComboBox();
            this.cmbCadastrarProdutoUndMedida = new System.Windows.Forms.ComboBox();
            this.cmbCadastrarProdutoFornecedor = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grupoprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidademedidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.pnlCadastrarProdutosCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoprodutoBindingSource
            // 
            this.grupoprodutoBindingSource.DataSource = typeof(DAO.grupo_produto);
            // 
            // unidademedidaBindingSource
            // 
            this.unidademedidaBindingSource.DataSource = typeof(DAO.unidade_medida);
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataSource = typeof(DAO.fornecedor);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(DAO.produto);
            // 
            // pnlCadastrarProdutosCampos
            // 
            this.pnlCadastrarProdutosCampos.Controls.Add(this.btnCadastrarProdutoAddUndMedida);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.btnCadastrarProdutoAddGrupo);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.btnCadastrarProdutoSalvar);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.btnCadastrarProdutoLimpar);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.btnCadastrarProdutoSair);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.lblCadastrarProdutoNome);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.txtCadastrarProdutoValorVenda);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.txtCadastrarProdutoMargemLucro);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.txtCadastrarProdutoValorCompra);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.txtCadastrarProdutoNome);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.lblCadastrarProdutoDescricao);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.txtCadastrarProdutoDescricao);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.lblProcentagem);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.lblCadastrarProdutoMargemLucro);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.lblCadastrarProdutoValorCompra);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.lblCadastrarProdutoGrupo);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.lblCadastrarProdutoUndMedida);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.lblCadastrarProdutoValorVenda);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.lblCadastrarProdutoFornecedor);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.cmbCadastrarProdutoGrupo);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.cmbCadastrarProdutoUndMedida);
            this.pnlCadastrarProdutosCampos.Controls.Add(this.cmbCadastrarProdutoFornecedor);
            this.pnlCadastrarProdutosCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadastrarProdutosCampos.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastrarProdutosCampos.Name = "pnlCadastrarProdutosCampos";
            this.pnlCadastrarProdutosCampos.Size = new System.Drawing.Size(567, 445);
            this.pnlCadastrarProdutosCampos.TabIndex = 0;
            this.pnlCadastrarProdutosCampos.Visible = false;
            // 
            // btnCadastrarProdutoAddUndMedida
            // 
            this.btnCadastrarProdutoAddUndMedida.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarProdutoAddUndMedida.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProdutoAddUndMedida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarProdutoAddUndMedida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarProdutoAddUndMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProdutoAddUndMedida.Image = global::UI.Properties.Resources.Novopq;
            this.btnCadastrarProdutoAddUndMedida.Location = new System.Drawing.Point(287, 224);
            this.btnCadastrarProdutoAddUndMedida.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnCadastrarProdutoAddUndMedida.Name = "btnCadastrarProdutoAddUndMedida";
            this.btnCadastrarProdutoAddUndMedida.Size = new System.Drawing.Size(25, 25);
            this.btnCadastrarProdutoAddUndMedida.TabIndex = 52;
            this.toolTip1.SetToolTip(this.btnCadastrarProdutoAddUndMedida, "Adicionar Unidade de Medida");
            this.btnCadastrarProdutoAddUndMedida.UseVisualStyleBackColor = true;
            this.btnCadastrarProdutoAddUndMedida.Click += new System.EventHandler(this.BtnCadastrarProdutoAddUndMedida_Click);
            // 
            // btnCadastrarProdutoAddGrupo
            // 
            this.btnCadastrarProdutoAddGrupo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarProdutoAddGrupo.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProdutoAddGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarProdutoAddGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarProdutoAddGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProdutoAddGrupo.Image = global::UI.Properties.Resources.Novopq;
            this.btnCadastrarProdutoAddGrupo.Location = new System.Drawing.Point(140, 224);
            this.btnCadastrarProdutoAddGrupo.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnCadastrarProdutoAddGrupo.Name = "btnCadastrarProdutoAddGrupo";
            this.btnCadastrarProdutoAddGrupo.Size = new System.Drawing.Size(25, 25);
            this.btnCadastrarProdutoAddGrupo.TabIndex = 51;
            this.toolTip1.SetToolTip(this.btnCadastrarProdutoAddGrupo, "Adicionar Grupo");
            this.btnCadastrarProdutoAddGrupo.UseVisualStyleBackColor = true;
            this.btnCadastrarProdutoAddGrupo.Click += new System.EventHandler(this.BtnCadastrarProdutoAddGrupo_Click);
            // 
            // btnCadastrarProdutoSalvar
            // 
            this.btnCadastrarProdutoSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarProdutoSalvar.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProdutoSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarProdutoSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarProdutoSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProdutoSalvar.Image = global::UI.Properties.Resources.salvar;
            this.btnCadastrarProdutoSalvar.Location = new System.Drawing.Point(17, 365);
            this.btnCadastrarProdutoSalvar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnCadastrarProdutoSalvar.Name = "btnCadastrarProdutoSalvar";
            this.btnCadastrarProdutoSalvar.Size = new System.Drawing.Size(70, 70);
            this.btnCadastrarProdutoSalvar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnCadastrarProdutoSalvar, "Salvar");
            this.btnCadastrarProdutoSalvar.UseVisualStyleBackColor = true;
            this.btnCadastrarProdutoSalvar.Click += new System.EventHandler(this.BtnCadastrarProdutoSalvar_Click);
            // 
            // btnCadastrarProdutoLimpar
            // 
            this.btnCadastrarProdutoLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarProdutoLimpar.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProdutoLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarProdutoLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarProdutoLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProdutoLimpar.Image = global::UI.Properties.Resources.vassoura64;
            this.btnCadastrarProdutoLimpar.Location = new System.Drawing.Point(107, 365);
            this.btnCadastrarProdutoLimpar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnCadastrarProdutoLimpar.Name = "btnCadastrarProdutoLimpar";
            this.btnCadastrarProdutoLimpar.Size = new System.Drawing.Size(70, 70);
            this.btnCadastrarProdutoLimpar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnCadastrarProdutoLimpar, "Limpar campos");
            this.btnCadastrarProdutoLimpar.UseVisualStyleBackColor = true;
            this.btnCadastrarProdutoLimpar.Click += new System.EventHandler(this.BtnCadastrarProdutoLimpar_Click);
            // 
            // btnCadastrarProdutoSair
            // 
            this.btnCadastrarProdutoSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarProdutoSair.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProdutoSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarProdutoSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarProdutoSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProdutoSair.Image = global::UI.Properties.Resources.sair64x64;
            this.btnCadastrarProdutoSair.Location = new System.Drawing.Point(197, 365);
            this.btnCadastrarProdutoSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarProdutoSair.Name = "btnCadastrarProdutoSair";
            this.btnCadastrarProdutoSair.Size = new System.Drawing.Size(70, 70);
            this.btnCadastrarProdutoSair.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnCadastrarProdutoSair, "Fechar cadastro");
            this.btnCadastrarProdutoSair.UseVisualStyleBackColor = true;
            this.btnCadastrarProdutoSair.Click += new System.EventHandler(this.BtnCadastrarProdutoSair_Click);
            // 
            // lblCadastrarProdutoNome
            // 
            this.lblCadastrarProdutoNome.AutoSize = true;
            this.lblCadastrarProdutoNome.Location = new System.Drawing.Point(13, 10);
            this.lblCadastrarProdutoNome.Margin = new System.Windows.Forms.Padding(0);
            this.lblCadastrarProdutoNome.Name = "lblCadastrarProdutoNome";
            this.lblCadastrarProdutoNome.Size = new System.Drawing.Size(71, 20);
            this.lblCadastrarProdutoNome.TabIndex = 31;
            this.lblCadastrarProdutoNome.Text = "Produto";
            // 
            // txtCadastrarProdutoValorVenda
            // 
            this.txtCadastrarProdutoValorVenda.Location = new System.Drawing.Point(398, 304);
            this.txtCadastrarProdutoValorVenda.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.txtCadastrarProdutoValorVenda.Name = "txtCadastrarProdutoValorVenda";
            this.txtCadastrarProdutoValorVenda.ReadOnly = true;
            this.txtCadastrarProdutoValorVenda.Size = new System.Drawing.Size(149, 32);
            this.txtCadastrarProdutoValorVenda.TabIndex = 8;
            this.txtCadastrarProdutoValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCadastrarProdutoMargemLucro
            // 
            this.txtCadastrarProdutoMargemLucro.Location = new System.Drawing.Point(202, 304);
            this.txtCadastrarProdutoMargemLucro.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.txtCadastrarProdutoMargemLucro.Name = "txtCadastrarProdutoMargemLucro";
            this.txtCadastrarProdutoMargemLucro.Size = new System.Drawing.Size(134, 32);
            this.txtCadastrarProdutoMargemLucro.TabIndex = 7;
            this.txtCadastrarProdutoMargemLucro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCadastrarProdutoMargemLucro.Leave += new System.EventHandler(this.TxtCadastrarProdutoMargemLucro_Leave);
            // 
            // txtCadastrarProdutoValorCompra
            // 
            this.txtCadastrarProdutoValorCompra.Location = new System.Drawing.Point(17, 304);
            this.txtCadastrarProdutoValorCompra.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.txtCadastrarProdutoValorCompra.Name = "txtCadastrarProdutoValorCompra";
            this.txtCadastrarProdutoValorCompra.Size = new System.Drawing.Size(146, 32);
            this.txtCadastrarProdutoValorCompra.TabIndex = 6;
            this.txtCadastrarProdutoValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCadastrarProdutoValorCompra.Enter += new System.EventHandler(this.TxtCadastrarProdutoValorCompra_Enter);
            this.txtCadastrarProdutoValorCompra.Leave += new System.EventHandler(this.TxtCadastrarProdutoValorCompra_Leave);
            // 
            // txtCadastrarProdutoNome
            // 
            this.txtCadastrarProdutoNome.Location = new System.Drawing.Point(13, 33);
            this.txtCadastrarProdutoNome.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.txtCadastrarProdutoNome.Name = "txtCadastrarProdutoNome";
            this.txtCadastrarProdutoNome.Size = new System.Drawing.Size(538, 32);
            this.txtCadastrarProdutoNome.TabIndex = 1;
            // 
            // lblCadastrarProdutoDescricao
            // 
            this.lblCadastrarProdutoDescricao.AutoSize = true;
            this.lblCadastrarProdutoDescricao.Location = new System.Drawing.Point(13, 82);
            this.lblCadastrarProdutoDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.lblCadastrarProdutoDescricao.Name = "lblCadastrarProdutoDescricao";
            this.lblCadastrarProdutoDescricao.Size = new System.Drawing.Size(86, 20);
            this.lblCadastrarProdutoDescricao.TabIndex = 32;
            this.lblCadastrarProdutoDescricao.Text = "Descrição";
            // 
            // txtCadastrarProdutoDescricao
            // 
            this.txtCadastrarProdutoDescricao.Location = new System.Drawing.Point(13, 105);
            this.txtCadastrarProdutoDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.txtCadastrarProdutoDescricao.Multiline = true;
            this.txtCadastrarProdutoDescricao.Name = "txtCadastrarProdutoDescricao";
            this.txtCadastrarProdutoDescricao.Size = new System.Drawing.Size(538, 69);
            this.txtCadastrarProdutoDescricao.TabIndex = 2;
            // 
            // lblProcentagem
            // 
            this.lblProcentagem.AutoSize = true;
            this.lblProcentagem.Location = new System.Drawing.Point(335, 310);
            this.lblProcentagem.Margin = new System.Windows.Forms.Padding(238, 0, 0, 0);
            this.lblProcentagem.Name = "lblProcentagem";
            this.lblProcentagem.Size = new System.Drawing.Size(20, 20);
            this.lblProcentagem.TabIndex = 35;
            this.lblProcentagem.Text = "%";
            // 
            // lblCadastrarProdutoMargemLucro
            // 
            this.lblCadastrarProdutoMargemLucro.AutoSize = true;
            this.lblCadastrarProdutoMargemLucro.Location = new System.Drawing.Point(200, 279);
            this.lblCadastrarProdutoMargemLucro.Margin = new System.Windows.Forms.Padding(238, 0, 0, 0);
            this.lblCadastrarProdutoMargemLucro.Name = "lblCadastrarProdutoMargemLucro";
            this.lblCadastrarProdutoMargemLucro.Size = new System.Drawing.Size(123, 20);
            this.lblCadastrarProdutoMargemLucro.TabIndex = 36;
            this.lblCadastrarProdutoMargemLucro.Text = "Margem Lucro";
            // 
            // lblCadastrarProdutoValorCompra
            // 
            this.lblCadastrarProdutoValorCompra.AutoSize = true;
            this.lblCadastrarProdutoValorCompra.Location = new System.Drawing.Point(13, 279);
            this.lblCadastrarProdutoValorCompra.Margin = new System.Windows.Forms.Padding(238, 0, 0, 0);
            this.lblCadastrarProdutoValorCompra.Name = "lblCadastrarProdutoValorCompra";
            this.lblCadastrarProdutoValorCompra.Size = new System.Drawing.Size(117, 20);
            this.lblCadastrarProdutoValorCompra.TabIndex = 34;
            this.lblCadastrarProdutoValorCompra.Text = "Valor Compra";
            // 
            // lblCadastrarProdutoGrupo
            // 
            this.lblCadastrarProdutoGrupo.AutoSize = true;
            this.lblCadastrarProdutoGrupo.Location = new System.Drawing.Point(13, 196);
            this.lblCadastrarProdutoGrupo.Margin = new System.Windows.Forms.Padding(238, 0, 0, 0);
            this.lblCadastrarProdutoGrupo.Name = "lblCadastrarProdutoGrupo";
            this.lblCadastrarProdutoGrupo.Size = new System.Drawing.Size(58, 20);
            this.lblCadastrarProdutoGrupo.TabIndex = 33;
            this.lblCadastrarProdutoGrupo.Text = "Grupo";
            // 
            // lblCadastrarProdutoUndMedida
            // 
            this.lblCadastrarProdutoUndMedida.AutoSize = true;
            this.lblCadastrarProdutoUndMedida.Location = new System.Drawing.Point(182, 196);
            this.lblCadastrarProdutoUndMedida.Margin = new System.Windows.Forms.Padding(123, 0, 0, 0);
            this.lblCadastrarProdutoUndMedida.Name = "lblCadastrarProdutoUndMedida";
            this.lblCadastrarProdutoUndMedida.Size = new System.Drawing.Size(103, 20);
            this.lblCadastrarProdutoUndMedida.TabIndex = 37;
            this.lblCadastrarProdutoUndMedida.Text = "Und Medida";
            // 
            // lblCadastrarProdutoValorVenda
            // 
            this.lblCadastrarProdutoValorVenda.AutoSize = true;
            this.lblCadastrarProdutoValorVenda.Location = new System.Drawing.Point(398, 279);
            this.lblCadastrarProdutoValorVenda.Margin = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.lblCadastrarProdutoValorVenda.Name = "lblCadastrarProdutoValorVenda";
            this.lblCadastrarProdutoValorVenda.Size = new System.Drawing.Size(104, 20);
            this.lblCadastrarProdutoValorVenda.TabIndex = 39;
            this.lblCadastrarProdutoValorVenda.Text = "Valor Venda";
            // 
            // lblCadastrarProdutoFornecedor
            // 
            this.lblCadastrarProdutoFornecedor.AutoSize = true;
            this.lblCadastrarProdutoFornecedor.Location = new System.Drawing.Point(333, 196);
            this.lblCadastrarProdutoFornecedor.Margin = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.lblCadastrarProdutoFornecedor.Name = "lblCadastrarProdutoFornecedor";
            this.lblCadastrarProdutoFornecedor.Size = new System.Drawing.Size(100, 20);
            this.lblCadastrarProdutoFornecedor.TabIndex = 38;
            this.lblCadastrarProdutoFornecedor.Text = "Fornecedor";
            // 
            // cmbCadastrarProdutoGrupo
            // 
            this.cmbCadastrarProdutoGrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCadastrarProdutoGrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCadastrarProdutoGrupo.DataSource = this.grupoprodutoBindingSource;
            this.cmbCadastrarProdutoGrupo.DisplayMember = "nome";
            this.cmbCadastrarProdutoGrupo.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCadastrarProdutoGrupo.FormattingEnabled = true;
            this.cmbCadastrarProdutoGrupo.Location = new System.Drawing.Point(13, 221);
            this.cmbCadastrarProdutoGrupo.Margin = new System.Windows.Forms.Padding(0, 5, 20, 0);
            this.cmbCadastrarProdutoGrupo.Name = "cmbCadastrarProdutoGrupo";
            this.cmbCadastrarProdutoGrupo.Size = new System.Drawing.Size(125, 26);
            this.cmbCadastrarProdutoGrupo.TabIndex = 3;
            this.cmbCadastrarProdutoGrupo.ValueMember = "codigo";
            // 
            // cmbCadastrarProdutoUndMedida
            // 
            this.cmbCadastrarProdutoUndMedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCadastrarProdutoUndMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCadastrarProdutoUndMedida.DataSource = this.unidademedidaBindingSource;
            this.cmbCadastrarProdutoUndMedida.DisplayMember = "nome";
            this.cmbCadastrarProdutoUndMedida.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCadastrarProdutoUndMedida.FormattingEnabled = true;
            this.cmbCadastrarProdutoUndMedida.Location = new System.Drawing.Point(184, 221);
            this.cmbCadastrarProdutoUndMedida.Margin = new System.Windows.Forms.Padding(0, 5, 20, 0);
            this.cmbCadastrarProdutoUndMedida.Name = "cmbCadastrarProdutoUndMedida";
            this.cmbCadastrarProdutoUndMedida.Size = new System.Drawing.Size(101, 26);
            this.cmbCadastrarProdutoUndMedida.TabIndex = 4;
            this.cmbCadastrarProdutoUndMedida.ValueMember = "codigo";
            // 
            // cmbCadastrarProdutoFornecedor
            // 
            this.cmbCadastrarProdutoFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCadastrarProdutoFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCadastrarProdutoFornecedor.DataSource = this.fornecedorBindingSource;
            this.cmbCadastrarProdutoFornecedor.DisplayMember = "razao_social";
            this.cmbCadastrarProdutoFornecedor.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCadastrarProdutoFornecedor.FormattingEnabled = true;
            this.cmbCadastrarProdutoFornecedor.Location = new System.Drawing.Point(333, 221);
            this.cmbCadastrarProdutoFornecedor.Margin = new System.Windows.Forms.Padding(0, 5, 0, 30);
            this.cmbCadastrarProdutoFornecedor.Name = "cmbCadastrarProdutoFornecedor";
            this.cmbCadastrarProdutoFornecedor.Size = new System.Drawing.Size(218, 26);
            this.cmbCadastrarProdutoFornecedor.TabIndex = 5;
            this.cmbCadastrarProdutoFornecedor.ValueMember = "codigo";
            // 
            // frmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 445);
            this.Controls.Add(this.pnlCadastrarProdutosCampos);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCadastrarProduto";
            this.Text = "Cadastrar Produto";
            this.Load += new System.EventHandler(this.FrmCadastrarProduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastrarProduto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grupoprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidademedidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.pnlCadastrarProdutosCampos.ResumeLayout(false);
            this.pnlCadastrarProdutosCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource grupoprodutoBindingSource;
        private System.Windows.Forms.BindingSource unidademedidaBindingSource;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.Panel pnlCadastrarProdutosCampos;
        private System.Windows.Forms.Button btnCadastrarProdutoAddUndMedida;
        private System.Windows.Forms.Button btnCadastrarProdutoAddGrupo;
        private System.Windows.Forms.Button btnCadastrarProdutoSalvar;
        private System.Windows.Forms.Button btnCadastrarProdutoLimpar;
        private System.Windows.Forms.Button btnCadastrarProdutoSair;
        private System.Windows.Forms.Label lblCadastrarProdutoNome;
        private System.Windows.Forms.TextBox txtCadastrarProdutoValorVenda;
        private System.Windows.Forms.TextBox txtCadastrarProdutoMargemLucro;
        private System.Windows.Forms.TextBox txtCadastrarProdutoValorCompra;
        private System.Windows.Forms.TextBox txtCadastrarProdutoNome;
        private System.Windows.Forms.Label lblCadastrarProdutoDescricao;
        private System.Windows.Forms.TextBox txtCadastrarProdutoDescricao;
        private System.Windows.Forms.Label lblProcentagem;
        private System.Windows.Forms.Label lblCadastrarProdutoMargemLucro;
        private System.Windows.Forms.Label lblCadastrarProdutoValorCompra;
        private System.Windows.Forms.Label lblCadastrarProdutoGrupo;
        private System.Windows.Forms.Label lblCadastrarProdutoUndMedida;
        private System.Windows.Forms.Label lblCadastrarProdutoValorVenda;
        private System.Windows.Forms.Label lblCadastrarProdutoFornecedor;
        private System.Windows.Forms.ComboBox cmbCadastrarProdutoGrupo;
        private System.Windows.Forms.ComboBox cmbCadastrarProdutoUndMedida;
        private System.Windows.Forms.ComboBox cmbCadastrarProdutoFornecedor;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.BindingSource produtoBindingSource;
    }
}