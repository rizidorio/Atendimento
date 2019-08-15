namespace UI
{
    partial class frmProcedimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcedimentos));
            this.tsMenuProcedimentos = new System.Windows.Forms.ToolStrip();
            this.tsbtnProcedimentosCadastrar = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiProcedimentosCadastrarProcedimento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProcedimentosCadastrarGrupo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnProcedimentosConsultar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnProcedimentosFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnProcedimentosMinimizar = new System.Windows.Forms.ToolStripButton();
            this.pnlProcedimentosConteudo = new System.Windows.Forms.Panel();
            this.tsMenuProcedimentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenuProcedimentos
            // 
            this.tsMenuProcedimentos.BackColor = System.Drawing.Color.MintCream;
            this.tsMenuProcedimentos.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMenuProcedimentos.GripMargin = new System.Windows.Forms.Padding(0);
            this.tsMenuProcedimentos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenuProcedimentos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tsMenuProcedimentos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnProcedimentosCadastrar,
            this.tsbtnProcedimentosConsultar,
            this.tsbtnProcedimentosFechar,
            this.tsbtnProcedimentosMinimizar});
            this.tsMenuProcedimentos.Location = new System.Drawing.Point(0, 0);
            this.tsMenuProcedimentos.Name = "tsMenuProcedimentos";
            this.tsMenuProcedimentos.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsMenuProcedimentos.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsMenuProcedimentos.Size = new System.Drawing.Size(675, 39);
            this.tsMenuProcedimentos.TabIndex = 2;
            this.tsMenuProcedimentos.Text = "Menu Cursos";
            // 
            // tsbtnProcedimentosCadastrar
            // 
            this.tsbtnProcedimentosCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnProcedimentosCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProcedimentosCadastrarProcedimento,
            this.tsmiProcedimentosCadastrarGrupo});
            this.tsbtnProcedimentosCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnProcedimentosCadastrar.Image")));
            this.tsbtnProcedimentosCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnProcedimentosCadastrar.Name = "tsbtnProcedimentosCadastrar";
            this.tsbtnProcedimentosCadastrar.Size = new System.Drawing.Size(98, 36);
            this.tsbtnProcedimentosCadastrar.Text = "Cadastrar";
            // 
            // tsmiProcedimentosCadastrarProcedimento
            // 
            this.tsmiProcedimentosCadastrarProcedimento.BackColor = System.Drawing.Color.MintCream;
            this.tsmiProcedimentosCadastrarProcedimento.Name = "tsmiProcedimentosCadastrarProcedimento";
            this.tsmiProcedimentosCadastrarProcedimento.Size = new System.Drawing.Size(275, 24);
            this.tsmiProcedimentosCadastrarProcedimento.Text = "Procedimento";
            this.tsmiProcedimentosCadastrarProcedimento.Click += new System.EventHandler(this.ProcedimentoToolStripMenuItem_Click);
            // 
            // tsmiProcedimentosCadastrarGrupo
            // 
            this.tsmiProcedimentosCadastrarGrupo.BackColor = System.Drawing.Color.MintCream;
            this.tsmiProcedimentosCadastrarGrupo.Name = "tsmiProcedimentosCadastrarGrupo";
            this.tsmiProcedimentosCadastrarGrupo.Size = new System.Drawing.Size(275, 24);
            this.tsmiProcedimentosCadastrarGrupo.Text = "Grupo de Procedimentos";
            this.tsmiProcedimentosCadastrarGrupo.Click += new System.EventHandler(this.GrupoDeProcedimentosToolStripMenuItem_Click);
            // 
            // tsbtnProcedimentosConsultar
            // 
            this.tsbtnProcedimentosConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnProcedimentosConsultar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnProcedimentosConsultar.Image")));
            this.tsbtnProcedimentosConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnProcedimentosConsultar.Name = "tsbtnProcedimentosConsultar";
            this.tsbtnProcedimentosConsultar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbtnProcedimentosConsultar.Size = new System.Drawing.Size(89, 36);
            this.tsbtnProcedimentosConsultar.Text = "Consultar";
            this.tsbtnProcedimentosConsultar.Click += new System.EventHandler(this.TsbtnProcedimentosConsultar_Click);
            // 
            // tsbtnProcedimentosFechar
            // 
            this.tsbtnProcedimentosFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnProcedimentosFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnProcedimentosFechar.Image = global::UI.Properties.Resources.fechar;
            this.tsbtnProcedimentosFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnProcedimentosFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnProcedimentosFechar.Name = "tsbtnProcedimentosFechar";
            this.tsbtnProcedimentosFechar.Size = new System.Drawing.Size(36, 36);
            this.tsbtnProcedimentosFechar.Text = "Fechar Procedimentos";
            this.tsbtnProcedimentosFechar.Click += new System.EventHandler(this.TsbtnProcedimentosFechar_Click);
            // 
            // tsbtnProcedimentosMinimizar
            // 
            this.tsbtnProcedimentosMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnProcedimentosMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbtnProcedimentosMinimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnProcedimentosMinimizar.Image = global::UI.Properties.Resources.minimizar;
            this.tsbtnProcedimentosMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnProcedimentosMinimizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnProcedimentosMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnProcedimentosMinimizar.Name = "tsbtnProcedimentosMinimizar";
            this.tsbtnProcedimentosMinimizar.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.tsbtnProcedimentosMinimizar.Size = new System.Drawing.Size(36, 36);
            this.tsbtnProcedimentosMinimizar.Text = "Minimizar Procedimentos";
            this.tsbtnProcedimentosMinimizar.Click += new System.EventHandler(this.TsbtnProcedimentosMinimizar_Click);
            // 
            // pnlProcedimentosConteudo
            // 
            this.pnlProcedimentosConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProcedimentosConteudo.Location = new System.Drawing.Point(0, 39);
            this.pnlProcedimentosConteudo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProcedimentosConteudo.Name = "pnlProcedimentosConteudo";
            this.pnlProcedimentosConteudo.Size = new System.Drawing.Size(675, 411);
            this.pnlProcedimentosConteudo.TabIndex = 4;
            // 
            // frmProcedimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.pnlProcedimentosConteudo);
            this.Controls.Add(this.tsMenuProcedimentos);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProcedimentos";
            this.Text = "Procedimentos";
            this.Load += new System.EventHandler(this.FrmProcedimentos_Load);
            this.tsMenuProcedimentos.ResumeLayout(false);
            this.tsMenuProcedimentos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip tsMenuProcedimentos;
        private System.Windows.Forms.ToolStripButton tsbtnProcedimentosConsultar;
        private System.Windows.Forms.ToolStripButton tsbtnProcedimentosMinimizar;
        private System.Windows.Forms.Panel pnlProcedimentosConteudo;
        private System.Windows.Forms.ToolStripButton tsbtnProcedimentosFechar;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnProcedimentosCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsmiProcedimentosCadastrarProcedimento;
        private System.Windows.Forms.ToolStripMenuItem tsmiProcedimentosCadastrarGrupo;
    }
}