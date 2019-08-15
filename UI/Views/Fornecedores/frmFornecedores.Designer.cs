namespace UI
{
    partial class frmFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedores));
            this.pnlFornecedoresConteudo = new System.Windows.Forms.Panel();
            this.tsMenuFornecedores = new System.Windows.Forms.ToolStrip();
            this.tsbtnFornecedoresCadastrar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFornecedoresConsultar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFornecedoresFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFornecedoresMinimizar = new System.Windows.Forms.ToolStripButton();
            this.tsMenuFornecedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFornecedoresConteudo
            // 
            this.pnlFornecedoresConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFornecedoresConteudo.Location = new System.Drawing.Point(0, 39);
            this.pnlFornecedoresConteudo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFornecedoresConteudo.Name = "pnlFornecedoresConteudo";
            this.pnlFornecedoresConteudo.Size = new System.Drawing.Size(675, 412);
            this.pnlFornecedoresConteudo.TabIndex = 2;
            // 
            // tsMenuFornecedores
            // 
            this.tsMenuFornecedores.BackColor = System.Drawing.Color.MintCream;
            this.tsMenuFornecedores.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMenuFornecedores.GripMargin = new System.Windows.Forms.Padding(0);
            this.tsMenuFornecedores.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenuFornecedores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tsMenuFornecedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnFornecedoresCadastrar,
            this.tsbtnFornecedoresConsultar,
            this.tsbtnFornecedoresFechar,
            this.tsbtnFornecedoresMinimizar});
            this.tsMenuFornecedores.Location = new System.Drawing.Point(0, 0);
            this.tsMenuFornecedores.Name = "tsMenuFornecedores";
            this.tsMenuFornecedores.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsMenuFornecedores.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsMenuFornecedores.Size = new System.Drawing.Size(675, 39);
            this.tsMenuFornecedores.TabIndex = 4;
            this.tsMenuFornecedores.Text = "Menu Fornecedores";
            // 
            // tsbtnFornecedoresCadastrar
            // 
            this.tsbtnFornecedoresCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnFornecedoresCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFornecedoresCadastrar.Image")));
            this.tsbtnFornecedoresCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFornecedoresCadastrar.Name = "tsbtnFornecedoresCadastrar";
            this.tsbtnFornecedoresCadastrar.Size = new System.Drawing.Size(89, 36);
            this.tsbtnFornecedoresCadastrar.Text = "Cadastrar";
            this.tsbtnFornecedoresCadastrar.Click += new System.EventHandler(this.TsbtnFornecedoresCadastrar_Click);
            // 
            // tsbtnFornecedoresConsultar
            // 
            this.tsbtnFornecedoresConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnFornecedoresConsultar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFornecedoresConsultar.Image")));
            this.tsbtnFornecedoresConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFornecedoresConsultar.Name = "tsbtnFornecedoresConsultar";
            this.tsbtnFornecedoresConsultar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbtnFornecedoresConsultar.Size = new System.Drawing.Size(89, 36);
            this.tsbtnFornecedoresConsultar.Text = "Consultar";
            this.tsbtnFornecedoresConsultar.Click += new System.EventHandler(this.TsbtnFornecedoresConsultar_Click);
            // 
            // tsbtnFornecedoresFechar
            // 
            this.tsbtnFornecedoresFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnFornecedoresFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFornecedoresFechar.Image = global::UI.Properties.Resources.fechar;
            this.tsbtnFornecedoresFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnFornecedoresFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFornecedoresFechar.Name = "tsbtnFornecedoresFechar";
            this.tsbtnFornecedoresFechar.Size = new System.Drawing.Size(36, 36);
            this.tsbtnFornecedoresFechar.Text = "Fechar Fornecedores";
            this.tsbtnFornecedoresFechar.Click += new System.EventHandler(this.BtnFornecedoresFechar_Click);
            // 
            // tsbtnFornecedoresMinimizar
            // 
            this.tsbtnFornecedoresMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnFornecedoresMinimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFornecedoresMinimizar.Image = global::UI.Properties.Resources.minimizar;
            this.tsbtnFornecedoresMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnFornecedoresMinimizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnFornecedoresMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFornecedoresMinimizar.Name = "tsbtnFornecedoresMinimizar";
            this.tsbtnFornecedoresMinimizar.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.tsbtnFornecedoresMinimizar.Size = new System.Drawing.Size(36, 36);
            this.tsbtnFornecedoresMinimizar.Text = "Minimizar Fornecedores";
            this.tsbtnFornecedoresMinimizar.Click += new System.EventHandler(this.BtnFornecedoresMinimizar_Click);
            // 
            // frmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.tsMenuFornecedores);
            this.Controls.Add(this.pnlFornecedoresConteudo);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFornecedores";
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.FrmFornecedores_Load);
            this.tsMenuFornecedores.ResumeLayout(false);
            this.tsMenuFornecedores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFornecedoresConteudo;
        public System.Windows.Forms.ToolStrip tsMenuFornecedores;
        private System.Windows.Forms.ToolStripButton tsbtnFornecedoresCadastrar;
        private System.Windows.Forms.ToolStripButton tsbtnFornecedoresConsultar;
        private System.Windows.Forms.ToolStripButton tsbtnFornecedoresFechar;
        private System.Windows.Forms.ToolStripButton tsbtnFornecedoresMinimizar;
    }
}