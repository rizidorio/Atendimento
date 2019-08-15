namespace UI
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.pnlClientesConteudo = new System.Windows.Forms.Panel();
            this.tsMenuClientes = new System.Windows.Forms.ToolStrip();
            this.tsbtnClientesCadastrar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnClientesConsultar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnClientesFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnClientesMinimizar = new System.Windows.Forms.ToolStripButton();
            this.tsMenuClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClientesConteudo
            // 
            this.pnlClientesConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClientesConteudo.Location = new System.Drawing.Point(0, 39);
            this.pnlClientesConteudo.Name = "pnlClientesConteudo";
            this.pnlClientesConteudo.Size = new System.Drawing.Size(675, 411);
            this.pnlClientesConteudo.TabIndex = 1;
            // 
            // tsMenuClientes
            // 
            this.tsMenuClientes.BackColor = System.Drawing.Color.MintCream;
            this.tsMenuClientes.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMenuClientes.GripMargin = new System.Windows.Forms.Padding(0);
            this.tsMenuClientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenuClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tsMenuClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnClientesCadastrar,
            this.tsbtnClientesConsultar,
            this.tsbtnClientesFechar,
            this.tsbtnClientesMinimizar});
            this.tsMenuClientes.Location = new System.Drawing.Point(0, 0);
            this.tsMenuClientes.Name = "tsMenuClientes";
            this.tsMenuClientes.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsMenuClientes.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsMenuClientes.Size = new System.Drawing.Size(675, 39);
            this.tsMenuClientes.TabIndex = 3;
            this.tsMenuClientes.Text = "Menu Clientes";
            // 
            // tsbtnClientesCadastrar
            // 
            this.tsbtnClientesCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnClientesCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClientesCadastrar.Image")));
            this.tsbtnClientesCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClientesCadastrar.Name = "tsbtnClientesCadastrar";
            this.tsbtnClientesCadastrar.Size = new System.Drawing.Size(89, 36);
            this.tsbtnClientesCadastrar.Text = "Cadastrar";
            this.tsbtnClientesCadastrar.Click += new System.EventHandler(this.TsbtnClientesCadastrar_Click);
            // 
            // tsbtnClientesConsultar
            // 
            this.tsbtnClientesConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnClientesConsultar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClientesConsultar.Image")));
            this.tsbtnClientesConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClientesConsultar.Name = "tsbtnClientesConsultar";
            this.tsbtnClientesConsultar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbtnClientesConsultar.Size = new System.Drawing.Size(89, 36);
            this.tsbtnClientesConsultar.Text = "Consultar";
            this.tsbtnClientesConsultar.Click += new System.EventHandler(this.TsbtnClientesConsultar_Click);
            // 
            // tsbtnClientesFechar
            // 
            this.tsbtnClientesFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnClientesFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbtnClientesFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnClientesFechar.Image = global::UI.Properties.Resources.fechar;
            this.tsbtnClientesFechar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnClientesFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnClientesFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClientesFechar.Name = "tsbtnClientesFechar";
            this.tsbtnClientesFechar.Size = new System.Drawing.Size(36, 36);
            this.tsbtnClientesFechar.Text = "Fechar Clientes";
            this.tsbtnClientesFechar.Click += new System.EventHandler(this.BtnClientesFechar_Click);
            // 
            // tsbtnClientesMinimizar
            // 
            this.tsbtnClientesMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnClientesMinimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnClientesMinimizar.Image = global::UI.Properties.Resources.minimizar;
            this.tsbtnClientesMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnClientesMinimizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnClientesMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClientesMinimizar.Name = "tsbtnClientesMinimizar";
            this.tsbtnClientesMinimizar.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.tsbtnClientesMinimizar.Size = new System.Drawing.Size(36, 36);
            this.tsbtnClientesMinimizar.Text = "Minimizar Clientes";
            this.tsbtnClientesMinimizar.Click += new System.EventHandler(this.BtnClientesMinimizar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.tsMenuClientes);
            this.Controls.Add(this.pnlClientesConteudo);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.tsMenuClientes.ResumeLayout(false);
            this.tsMenuClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlClientesConteudo;
        public System.Windows.Forms.ToolStrip tsMenuClientes;
        private System.Windows.Forms.ToolStripButton tsbtnClientesCadastrar;
        private System.Windows.Forms.ToolStripButton tsbtnClientesConsultar;
        private System.Windows.Forms.ToolStripButton tsbtnClientesFechar;
        private System.Windows.Forms.ToolStripButton tsbtnClientesMinimizar;
    }
}