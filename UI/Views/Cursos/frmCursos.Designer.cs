namespace UI
{
    partial class frmCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCursos));
            this.pnlCursosConteudo = new System.Windows.Forms.Panel();
            this.tsMenuCursos = new System.Windows.Forms.ToolStrip();
            this.tsbtnCursosCadastrar = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiCursosCadastrarCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCursosCadastrarGrupoCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnCursosConsultar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCursosFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCursosMinimizar = new System.Windows.Forms.ToolStripButton();
            this.tsMenuCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCursosConteudo
            // 
            this.pnlCursosConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCursosConteudo.Location = new System.Drawing.Point(0, 39);
            this.pnlCursosConteudo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCursosConteudo.Name = "pnlCursosConteudo";
            this.pnlCursosConteudo.Size = new System.Drawing.Size(675, 411);
            this.pnlCursosConteudo.TabIndex = 4;
            // 
            // tsMenuCursos
            // 
            this.tsMenuCursos.BackColor = System.Drawing.Color.MintCream;
            this.tsMenuCursos.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMenuCursos.GripMargin = new System.Windows.Forms.Padding(0);
            this.tsMenuCursos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenuCursos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tsMenuCursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCursosCadastrar,
            this.tsbtnCursosConsultar,
            this.tsbtnCursosFechar,
            this.tsbtnCursosMinimizar});
            this.tsMenuCursos.Location = new System.Drawing.Point(0, 0);
            this.tsMenuCursos.Name = "tsMenuCursos";
            this.tsMenuCursos.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsMenuCursos.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsMenuCursos.Size = new System.Drawing.Size(675, 39);
            this.tsMenuCursos.TabIndex = 3;
            this.tsMenuCursos.Text = "Menu Cursos";
            // 
            // tsbtnCursosCadastrar
            // 
            this.tsbtnCursosCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnCursosCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCursosCadastrarCurso,
            this.tsmiCursosCadastrarGrupoCursos});
            this.tsbtnCursosCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCursosCadastrar.Image")));
            this.tsbtnCursosCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCursosCadastrar.Name = "tsbtnCursosCadastrar";
            this.tsbtnCursosCadastrar.Size = new System.Drawing.Size(98, 36);
            this.tsbtnCursosCadastrar.Text = "Cadastrar";
            // 
            // tsmiCursosCadastrarCurso
            // 
            this.tsmiCursosCadastrarCurso.BackColor = System.Drawing.Color.MintCream;
            this.tsmiCursosCadastrarCurso.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiCursosCadastrarCurso.Name = "tsmiCursosCadastrarCurso";
            this.tsmiCursosCadastrarCurso.Size = new System.Drawing.Size(211, 24);
            this.tsmiCursosCadastrarCurso.Text = "Curso";
            this.tsmiCursosCadastrarCurso.Click += new System.EventHandler(this.TsmiCursosCadastrarCurso_Click);
            // 
            // tsmiCursosCadastrarGrupoCursos
            // 
            this.tsmiCursosCadastrarGrupoCursos.BackColor = System.Drawing.Color.MintCream;
            this.tsmiCursosCadastrarGrupoCursos.Name = "tsmiCursosCadastrarGrupoCursos";
            this.tsmiCursosCadastrarGrupoCursos.Size = new System.Drawing.Size(211, 24);
            this.tsmiCursosCadastrarGrupoCursos.Text = "Grupo de Cursos";
            this.tsmiCursosCadastrarGrupoCursos.Click += new System.EventHandler(this.TsmiCursosCadastrarGrupoCursos_Click);
            // 
            // tsbtnCursosConsultar
            // 
            this.tsbtnCursosConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnCursosConsultar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCursosConsultar.Image")));
            this.tsbtnCursosConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCursosConsultar.Name = "tsbtnCursosConsultar";
            this.tsbtnCursosConsultar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbtnCursosConsultar.Size = new System.Drawing.Size(89, 36);
            this.tsbtnCursosConsultar.Text = "Consultar";
            this.tsbtnCursosConsultar.Click += new System.EventHandler(this.TsbtnCursosConsultar_Click);
            // 
            // tsbtnCursosFechar
            // 
            this.tsbtnCursosFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnCursosFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCursosFechar.Image = global::UI.Properties.Resources.fechar;
            this.tsbtnCursosFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCursosFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCursosFechar.Name = "tsbtnCursosFechar";
            this.tsbtnCursosFechar.Size = new System.Drawing.Size(36, 36);
            this.tsbtnCursosFechar.Text = "Fechar Cursos";
            this.tsbtnCursosFechar.Click += new System.EventHandler(this.BtnCursosFechar_Click);
            // 
            // tsbtnCursosMinimizar
            // 
            this.tsbtnCursosMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnCursosMinimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCursosMinimizar.Image = global::UI.Properties.Resources.minimizar;
            this.tsbtnCursosMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnCursosMinimizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCursosMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCursosMinimizar.Name = "tsbtnCursosMinimizar";
            this.tsbtnCursosMinimizar.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.tsbtnCursosMinimizar.Size = new System.Drawing.Size(36, 36);
            this.tsbtnCursosMinimizar.Text = "Minimizar Cursos";
            this.tsbtnCursosMinimizar.Click += new System.EventHandler(this.BtnCursosMinimizar_Click);
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.pnlCursosConteudo);
            this.Controls.Add(this.tsMenuCursos);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.FrmCursos_Load);
            this.tsMenuCursos.ResumeLayout(false);
            this.tsMenuCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlCursosConteudo;
        public System.Windows.Forms.ToolStrip tsMenuCursos;
        private System.Windows.Forms.ToolStripButton tsbtnCursosConsultar;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnCursosCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsmiCursosCadastrarCurso;
        private System.Windows.Forms.ToolStripMenuItem tsmiCursosCadastrarGrupoCursos;
        private System.Windows.Forms.ToolStripButton tsbtnCursosFechar;
        private System.Windows.Forms.ToolStripButton tsbtnCursosMinimizar;
    }
}