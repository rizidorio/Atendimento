namespace UI
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.tsMenuProdutos = new System.Windows.Forms.ToolStrip();
            this.tsbtnProdutosCadastrar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnProdutosConsultar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnProdutosFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnClientesMinimizar = new System.Windows.Forms.ToolStripButton();
            this.pnlProdutosConteudo = new System.Windows.Forms.Panel();
            this.tsMenuProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenuProdutos
            // 
            this.tsMenuProdutos.BackColor = System.Drawing.Color.MintCream;
            this.tsMenuProdutos.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMenuProdutos.GripMargin = new System.Windows.Forms.Padding(0);
            this.tsMenuProdutos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenuProdutos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tsMenuProdutos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnProdutosCadastrar,
            this.tsbtnProdutosConsultar,
            this.tsbtnProdutosFechar,
            this.tsbtnClientesMinimizar});
            this.tsMenuProdutos.Location = new System.Drawing.Point(0, 0);
            this.tsMenuProdutos.Name = "tsMenuProdutos";
            this.tsMenuProdutos.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsMenuProdutos.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsMenuProdutos.Size = new System.Drawing.Size(675, 39);
            this.tsMenuProdutos.TabIndex = 1;
            this.tsMenuProdutos.Text = "Menu Produtos";
            // 
            // tsbtnProdutosCadastrar
            // 
            this.tsbtnProdutosCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnProdutosCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnProdutosCadastrar.Image")));
            this.tsbtnProdutosCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnProdutosCadastrar.Name = "tsbtnProdutosCadastrar";
            this.tsbtnProdutosCadastrar.Size = new System.Drawing.Size(89, 36);
            this.tsbtnProdutosCadastrar.Text = "Cadastrar";
            this.tsbtnProdutosCadastrar.Click += new System.EventHandler(this.TsbtnProdutosCadastrar_Click);
            // 
            // tsbtnProdutosConsultar
            // 
            this.tsbtnProdutosConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnProdutosConsultar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnProdutosConsultar.Image")));
            this.tsbtnProdutosConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnProdutosConsultar.Name = "tsbtnProdutosConsultar";
            this.tsbtnProdutosConsultar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbtnProdutosConsultar.Size = new System.Drawing.Size(89, 36);
            this.tsbtnProdutosConsultar.Text = "Consultar";
            this.tsbtnProdutosConsultar.Click += new System.EventHandler(this.TsbtnProdutosConsultar_Click);
            // 
            // tsbtnProdutosFechar
            // 
            this.tsbtnProdutosFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnProdutosFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnProdutosFechar.Image = global::UI.Properties.Resources.fechar;
            this.tsbtnProdutosFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnProdutosFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnProdutosFechar.Name = "tsbtnProdutosFechar";
            this.tsbtnProdutosFechar.Size = new System.Drawing.Size(36, 36);
            this.tsbtnProdutosFechar.Text = "Fechar Produtos";
            this.tsbtnProdutosFechar.Click += new System.EventHandler(this.TsbtnProdutosFechar_Click);
            // 
            // tsbtnClientesMinimizar
            // 
            this.tsbtnClientesMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnClientesMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbtnClientesMinimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnClientesMinimizar.Image = global::UI.Properties.Resources.minimizar;
            this.tsbtnClientesMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnClientesMinimizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnClientesMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClientesMinimizar.Name = "tsbtnClientesMinimizar";
            this.tsbtnClientesMinimizar.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.tsbtnClientesMinimizar.Size = new System.Drawing.Size(36, 36);
            this.tsbtnClientesMinimizar.Text = "Minimizar Produtos";
            this.tsbtnClientesMinimizar.Click += new System.EventHandler(this.TsbtnClientesMinimizar_Click);
            // 
            // pnlProdutosConteudo
            // 
            this.pnlProdutosConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProdutosConteudo.Location = new System.Drawing.Point(0, 39);
            this.pnlProdutosConteudo.Name = "pnlProdutosConteudo";
            this.pnlProdutosConteudo.Size = new System.Drawing.Size(675, 411);
            this.pnlProdutosConteudo.TabIndex = 2;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.pnlProdutosConteudo);
            this.Controls.Add(this.tsMenuProdutos);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmProdutos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.tsMenuProdutos.ResumeLayout(false);
            this.tsMenuProdutos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip tsMenuProdutos;
        private System.Windows.Forms.ToolStripButton tsbtnProdutosCadastrar;
        private System.Windows.Forms.ToolStripButton tsbtnProdutosConsultar;
        private System.Windows.Forms.ToolStripButton tsbtnClientesMinimizar;
        private System.Windows.Forms.Panel pnlProdutosConteudo;
        private System.Windows.Forms.ToolStripButton tsbtnProdutosFechar;
    }
}