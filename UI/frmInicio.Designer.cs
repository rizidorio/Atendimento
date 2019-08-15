namespace UI
{
    partial class frmInicio
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
            this.pnlInicioTitulo = new System.Windows.Forms.Panel();
            this.btnInicioMinimizar = new System.Windows.Forms.Button();
            this.btnInicioFechar = new System.Windows.Forms.Button();
            this.lblInicioTitulo = new System.Windows.Forms.Label();
            this.pnlInicioMenu = new System.Windows.Forms.Panel();
            this.btnMenuInicioCursos = new System.Windows.Forms.Button();
            this.btnMenuInicioProdutos = new System.Windows.Forms.Button();
            this.btnMenuInicioClientes = new System.Windows.Forms.Button();
            this.btnMenuInicioProcedimentos = new System.Windows.Forms.Button();
            this.btnMenuInicioFornecedores = new System.Windows.Forms.Button();
            this.pnlInicioConteudo = new System.Windows.Forms.Panel();
            this.pnlInicioInformacoes = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlInicioTitulo.SuspendLayout();
            this.pnlInicioMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInicioTitulo
            // 
            this.pnlInicioTitulo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pnlInicioTitulo.Controls.Add(this.btnInicioMinimizar);
            this.pnlInicioTitulo.Controls.Add(this.btnInicioFechar);
            this.pnlInicioTitulo.Controls.Add(this.lblInicioTitulo);
            this.pnlInicioTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInicioTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlInicioTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlInicioTitulo.Name = "pnlInicioTitulo";
            this.pnlInicioTitulo.Size = new System.Drawing.Size(966, 33);
            this.pnlInicioTitulo.TabIndex = 11;
            // 
            // btnInicioMinimizar
            // 
            this.btnInicioMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInicioMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInicioMinimizar.FlatAppearance.BorderSize = 0;
            this.btnInicioMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnInicioMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btnInicioMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioMinimizar.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnInicioMinimizar.Image = global::UI.Properties.Resources.minimizar;
            this.btnInicioMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInicioMinimizar.Location = new System.Drawing.Point(900, 0);
            this.btnInicioMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnInicioMinimizar.Name = "btnInicioMinimizar";
            this.btnInicioMinimizar.Size = new System.Drawing.Size(33, 33);
            this.btnInicioMinimizar.TabIndex = 5;
            this.btnInicioMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnInicioMinimizar, "Minimizar Sistema");
            this.btnInicioMinimizar.UseVisualStyleBackColor = true;
            this.btnInicioMinimizar.Click += new System.EventHandler(this.BtnInicioMinimizar_Click);
            // 
            // btnInicioFechar
            // 
            this.btnInicioFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInicioFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInicioFechar.FlatAppearance.BorderSize = 0;
            this.btnInicioFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnInicioFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btnInicioFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioFechar.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioFechar.ForeColor = System.Drawing.Color.White;
            this.btnInicioFechar.Image = global::UI.Properties.Resources.fechar;
            this.btnInicioFechar.Location = new System.Drawing.Point(933, 0);
            this.btnInicioFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnInicioFechar.Name = "btnInicioFechar";
            this.btnInicioFechar.Size = new System.Drawing.Size(33, 33);
            this.btnInicioFechar.TabIndex = 4;
            this.btnInicioFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnInicioFechar, "Fechar Sistema");
            this.btnInicioFechar.UseVisualStyleBackColor = true;
            this.btnInicioFechar.Click += new System.EventHandler(this.BtnInicioFechar_Click);
            // 
            // lblInicioTitulo
            // 
            this.lblInicioTitulo.AutoSize = true;
            this.lblInicioTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblInicioTitulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblInicioTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblInicioTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblInicioTitulo.Name = "lblInicioTitulo";
            this.lblInicioTitulo.Padding = new System.Windows.Forms.Padding(10, 3, 0, 0);
            this.lblInicioTitulo.Size = new System.Drawing.Size(295, 26);
            this.lblInicioTitulo.TabIndex = 0;
            this.lblInicioTitulo.Text = "Sistema de Gerenciamento";
            // 
            // pnlInicioMenu
            // 
            this.pnlInicioMenu.BackColor = System.Drawing.Color.MintCream;
            this.pnlInicioMenu.Controls.Add(this.btnMenuInicioCursos);
            this.pnlInicioMenu.Controls.Add(this.btnMenuInicioProdutos);
            this.pnlInicioMenu.Controls.Add(this.btnMenuInicioClientes);
            this.pnlInicioMenu.Controls.Add(this.btnMenuInicioProcedimentos);
            this.pnlInicioMenu.Controls.Add(this.btnMenuInicioFornecedores);
            this.pnlInicioMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInicioMenu.Location = new System.Drawing.Point(0, 33);
            this.pnlInicioMenu.Name = "pnlInicioMenu";
            this.pnlInicioMenu.Size = new System.Drawing.Size(230, 509);
            this.pnlInicioMenu.TabIndex = 14;
            // 
            // btnMenuInicioCursos
            // 
            this.btnMenuInicioCursos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenuInicioCursos.FlatAppearance.BorderSize = 0;
            this.btnMenuInicioCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMenuInicioCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnMenuInicioCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuInicioCursos.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuInicioCursos.Location = new System.Drawing.Point(3, 114);
            this.btnMenuInicioCursos.Name = "btnMenuInicioCursos";
            this.btnMenuInicioCursos.Size = new System.Drawing.Size(230, 40);
            this.btnMenuInicioCursos.TabIndex = 1;
            this.btnMenuInicioCursos.Text = "Cursos";
            this.btnMenuInicioCursos.UseVisualStyleBackColor = true;
            this.btnMenuInicioCursos.Click += new System.EventHandler(this.BtnMenuInicioCursos_Click);
            // 
            // btnMenuInicioProdutos
            // 
            this.btnMenuInicioProdutos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenuInicioProdutos.FlatAppearance.BorderSize = 0;
            this.btnMenuInicioProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMenuInicioProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnMenuInicioProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuInicioProdutos.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuInicioProdutos.Location = new System.Drawing.Point(3, 165);
            this.btnMenuInicioProdutos.Name = "btnMenuInicioProdutos";
            this.btnMenuInicioProdutos.Size = new System.Drawing.Size(230, 40);
            this.btnMenuInicioProdutos.TabIndex = 1;
            this.btnMenuInicioProdutos.Text = "Produtos";
            this.btnMenuInicioProdutos.UseVisualStyleBackColor = true;
            this.btnMenuInicioProdutos.Click += new System.EventHandler(this.BtnMenuInicioProdutos_Click);
            // 
            // btnMenuInicioClientes
            // 
            this.btnMenuInicioClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenuInicioClientes.FlatAppearance.BorderSize = 0;
            this.btnMenuInicioClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMenuInicioClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnMenuInicioClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuInicioClientes.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuInicioClientes.Location = new System.Drawing.Point(0, 12);
            this.btnMenuInicioClientes.Name = "btnMenuInicioClientes";
            this.btnMenuInicioClientes.Size = new System.Drawing.Size(230, 40);
            this.btnMenuInicioClientes.TabIndex = 0;
            this.btnMenuInicioClientes.Text = "Clientes";
            this.btnMenuInicioClientes.UseVisualStyleBackColor = true;
            this.btnMenuInicioClientes.Click += new System.EventHandler(this.BtnMenuInicioClientes_Click);
            // 
            // btnMenuInicioProcedimentos
            // 
            this.btnMenuInicioProcedimentos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenuInicioProcedimentos.FlatAppearance.BorderSize = 0;
            this.btnMenuInicioProcedimentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMenuInicioProcedimentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnMenuInicioProcedimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuInicioProcedimentos.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuInicioProcedimentos.Location = new System.Drawing.Point(3, 216);
            this.btnMenuInicioProcedimentos.Name = "btnMenuInicioProcedimentos";
            this.btnMenuInicioProcedimentos.Size = new System.Drawing.Size(230, 40);
            this.btnMenuInicioProcedimentos.TabIndex = 1;
            this.btnMenuInicioProcedimentos.Text = "Procedimentos";
            this.btnMenuInicioProcedimentos.UseVisualStyleBackColor = true;
            this.btnMenuInicioProcedimentos.Click += new System.EventHandler(this.BtnMenuInicioProcedimentos_Click);
            // 
            // btnMenuInicioFornecedores
            // 
            this.btnMenuInicioFornecedores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenuInicioFornecedores.FlatAppearance.BorderSize = 0;
            this.btnMenuInicioFornecedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMenuInicioFornecedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnMenuInicioFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuInicioFornecedores.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuInicioFornecedores.Location = new System.Drawing.Point(0, 63);
            this.btnMenuInicioFornecedores.Name = "btnMenuInicioFornecedores";
            this.btnMenuInicioFornecedores.Size = new System.Drawing.Size(230, 40);
            this.btnMenuInicioFornecedores.TabIndex = 1;
            this.btnMenuInicioFornecedores.Text = "Fornecedores";
            this.btnMenuInicioFornecedores.UseVisualStyleBackColor = true;
            this.btnMenuInicioFornecedores.Click += new System.EventHandler(this.BtnMenuInicioFornecedores_Click);
            // 
            // pnlInicioConteudo
            // 
            this.pnlInicioConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInicioConteudo.Location = new System.Drawing.Point(230, 33);
            this.pnlInicioConteudo.Name = "pnlInicioConteudo";
            this.pnlInicioConteudo.Size = new System.Drawing.Size(508, 509);
            this.pnlInicioConteudo.TabIndex = 15;
            this.pnlInicioConteudo.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PnlInicioConteudo_ControlAdded);
            this.pnlInicioConteudo.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.PnlInicioConteudo_ControlRemoved);
            // 
            // pnlInicioInformacoes
            // 
            this.pnlInicioInformacoes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInicioInformacoes.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInicioInformacoes.Location = new System.Drawing.Point(738, 33);
            this.pnlInicioInformacoes.Name = "pnlInicioInformacoes";
            this.pnlInicioInformacoes.Size = new System.Drawing.Size(228, 509);
            this.pnlInicioInformacoes.TabIndex = 16;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 542);
            this.Controls.Add(this.pnlInicioInformacoes);
            this.Controls.Add(this.pnlInicioConteudo);
            this.Controls.Add(this.pnlInicioMenu);
            this.Controls.Add(this.pnlInicioTitulo);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema de Gerenciamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlInicioTitulo.ResumeLayout(false);
            this.pnlInicioTitulo.PerformLayout();
            this.pnlInicioMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInicioTitulo;
        private System.Windows.Forms.Button btnInicioMinimizar;
        private System.Windows.Forms.Button btnInicioFechar;
        private System.Windows.Forms.Panel pnlInicioMenu;
        private System.Windows.Forms.Button btnMenuInicioCursos;
        private System.Windows.Forms.Button btnMenuInicioProdutos;
        private System.Windows.Forms.Button btnMenuInicioProcedimentos;
        private System.Windows.Forms.Button btnMenuInicioFornecedores;
        private System.Windows.Forms.Panel pnlInicioInformacoes;
        public System.Windows.Forms.Label lblInicioTitulo;
        public System.Windows.Forms.Panel pnlInicioConteudo;
        public System.Windows.Forms.Button btnMenuInicioClientes;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}