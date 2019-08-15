namespace UI
{
    partial class frmCadastrarCursos
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
            this.pnlCadastrarCursoCampos = new System.Windows.Forms.Panel();
            this.mtxCadastrarCursoCargaHoraria = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrarCursoAddGrupo = new System.Windows.Forms.Button();
            this.btnCadastrarCursoSalvar = new System.Windows.Forms.Button();
            this.btnCadastrarCursoLimpar = new System.Windows.Forms.Button();
            this.btnCadastrarCursoSair = new System.Windows.Forms.Button();
            this.lblCadastrarCursoNome = new System.Windows.Forms.Label();
            this.txtCadastrarCursoInvestimento = new System.Windows.Forms.TextBox();
            this.txtCadastrarCursoNome = new System.Windows.Forms.TextBox();
            this.lblCadastrarCursoDescricao = new System.Windows.Forms.Label();
            this.lblCadastrarCursoCargaHoraria = new System.Windows.Forms.Label();
            this.txtCadastrarCursoDescricao = new System.Windows.Forms.TextBox();
            this.lblCadastrarCursoInvestimento = new System.Windows.Forms.Label();
            this.lblCadastrarCursoGrupo = new System.Windows.Forms.Label();
            this.cmbCadastrarCursoGrupo = new System.Windows.Forms.ComboBox();
            this.grupocursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlCadastrarCursoCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupocursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadastrarCursoCampos
            // 
            this.pnlCadastrarCursoCampos.Controls.Add(this.mtxCadastrarCursoCargaHoraria);
            this.pnlCadastrarCursoCampos.Controls.Add(this.btnCadastrarCursoAddGrupo);
            this.pnlCadastrarCursoCampos.Controls.Add(this.btnCadastrarCursoSalvar);
            this.pnlCadastrarCursoCampos.Controls.Add(this.btnCadastrarCursoLimpar);
            this.pnlCadastrarCursoCampos.Controls.Add(this.btnCadastrarCursoSair);
            this.pnlCadastrarCursoCampos.Controls.Add(this.lblCadastrarCursoNome);
            this.pnlCadastrarCursoCampos.Controls.Add(this.txtCadastrarCursoInvestimento);
            this.pnlCadastrarCursoCampos.Controls.Add(this.txtCadastrarCursoNome);
            this.pnlCadastrarCursoCampos.Controls.Add(this.lblCadastrarCursoDescricao);
            this.pnlCadastrarCursoCampos.Controls.Add(this.lblCadastrarCursoCargaHoraria);
            this.pnlCadastrarCursoCampos.Controls.Add(this.txtCadastrarCursoDescricao);
            this.pnlCadastrarCursoCampos.Controls.Add(this.lblCadastrarCursoInvestimento);
            this.pnlCadastrarCursoCampos.Controls.Add(this.lblCadastrarCursoGrupo);
            this.pnlCadastrarCursoCampos.Controls.Add(this.cmbCadastrarCursoGrupo);
            this.pnlCadastrarCursoCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadastrarCursoCampos.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastrarCursoCampos.Name = "pnlCadastrarCursoCampos";
            this.pnlCadastrarCursoCampos.Size = new System.Drawing.Size(532, 356);
            this.pnlCadastrarCursoCampos.TabIndex = 0;
            this.pnlCadastrarCursoCampos.Visible = false;
            // 
            // mtxCadastrarCursoCargaHoraria
            // 
            this.mtxCadastrarCursoCargaHoraria.Location = new System.Drawing.Point(214, 215);
            this.mtxCadastrarCursoCargaHoraria.Mask = "00:00";
            this.mtxCadastrarCursoCargaHoraria.Name = "mtxCadastrarCursoCargaHoraria";
            this.mtxCadastrarCursoCargaHoraria.Size = new System.Drawing.Size(115, 32);
            this.mtxCadastrarCursoCargaHoraria.TabIndex = 5;
            this.mtxCadastrarCursoCargaHoraria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxCadastrarCursoCargaHoraria.ValidatingType = typeof(System.DateTime);
            // 
            // btnCadastrarCursoAddGrupo
            // 
            this.btnCadastrarCursoAddGrupo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarCursoAddGrupo.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCursoAddGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarCursoAddGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarCursoAddGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCursoAddGrupo.Image = global::UI.Properties.Resources.Novopq;
            this.btnCadastrarCursoAddGrupo.Location = new System.Drawing.Point(168, 219);
            this.btnCadastrarCursoAddGrupo.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnCadastrarCursoAddGrupo.Name = "btnCadastrarCursoAddGrupo";
            this.btnCadastrarCursoAddGrupo.Size = new System.Drawing.Size(25, 25);
            this.btnCadastrarCursoAddGrupo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnCadastrarCursoAddGrupo, "Adicionar grupo");
            this.btnCadastrarCursoAddGrupo.UseVisualStyleBackColor = true;
            this.btnCadastrarCursoAddGrupo.Click += new System.EventHandler(this.BtnCadastrarCursoAddGrupo_Click);
            // 
            // btnCadastrarCursoSalvar
            // 
            this.btnCadastrarCursoSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarCursoSalvar.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCursoSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarCursoSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarCursoSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCursoSalvar.Image = global::UI.Properties.Resources.salvar;
            this.btnCadastrarCursoSalvar.Location = new System.Drawing.Point(6, 270);
            this.btnCadastrarCursoSalvar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnCadastrarCursoSalvar.Name = "btnCadastrarCursoSalvar";
            this.btnCadastrarCursoSalvar.Size = new System.Drawing.Size(70, 70);
            this.btnCadastrarCursoSalvar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnCadastrarCursoSalvar, "Salvar");
            this.btnCadastrarCursoSalvar.UseVisualStyleBackColor = true;
            this.btnCadastrarCursoSalvar.Click += new System.EventHandler(this.BtnCadastrarCursoSalvar_Click);
            // 
            // btnCadastrarCursoLimpar
            // 
            this.btnCadastrarCursoLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarCursoLimpar.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCursoLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarCursoLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarCursoLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCursoLimpar.Image = global::UI.Properties.Resources.vassoura64;
            this.btnCadastrarCursoLimpar.Location = new System.Drawing.Point(96, 270);
            this.btnCadastrarCursoLimpar.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnCadastrarCursoLimpar.Name = "btnCadastrarCursoLimpar";
            this.btnCadastrarCursoLimpar.Size = new System.Drawing.Size(70, 70);
            this.btnCadastrarCursoLimpar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnCadastrarCursoLimpar, "Limpar campos");
            this.btnCadastrarCursoLimpar.UseVisualStyleBackColor = true;
            this.btnCadastrarCursoLimpar.Click += new System.EventHandler(this.BtnCadastrarCursoLimpar_Click);
            // 
            // btnCadastrarCursoSair
            // 
            this.btnCadastrarCursoSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarCursoSair.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCursoSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastrarCursoSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarCursoSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCursoSair.Image = global::UI.Properties.Resources.sair64x64;
            this.btnCadastrarCursoSair.Location = new System.Drawing.Point(186, 270);
            this.btnCadastrarCursoSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarCursoSair.Name = "btnCadastrarCursoSair";
            this.btnCadastrarCursoSair.Size = new System.Drawing.Size(70, 70);
            this.btnCadastrarCursoSair.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnCadastrarCursoSair, "Fechar cadastro");
            this.btnCadastrarCursoSair.UseVisualStyleBackColor = true;
            this.btnCadastrarCursoSair.Click += new System.EventHandler(this.BtnCadastrarCursoSair_Click);
            // 
            // lblCadastrarCursoNome
            // 
            this.lblCadastrarCursoNome.AutoSize = true;
            this.lblCadastrarCursoNome.Location = new System.Drawing.Point(13, 12);
            this.lblCadastrarCursoNome.Margin = new System.Windows.Forms.Padding(0);
            this.lblCadastrarCursoNome.Name = "lblCadastrarCursoNome";
            this.lblCadastrarCursoNome.Size = new System.Drawing.Size(55, 20);
            this.lblCadastrarCursoNome.TabIndex = 59;
            this.lblCadastrarCursoNome.Text = "Curso";
            // 
            // txtCadastrarCursoInvestimento
            // 
            this.txtCadastrarCursoInvestimento.Location = new System.Drawing.Point(362, 215);
            this.txtCadastrarCursoInvestimento.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.txtCadastrarCursoInvestimento.Name = "txtCadastrarCursoInvestimento";
            this.txtCadastrarCursoInvestimento.Size = new System.Drawing.Size(146, 32);
            this.txtCadastrarCursoInvestimento.TabIndex = 6;
            this.txtCadastrarCursoInvestimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCadastrarCursoInvestimento.Enter += new System.EventHandler(this.TxtCadastrarCursoInvestimento_Enter);
            this.txtCadastrarCursoInvestimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCadastrarCursoInvestimento_KeyPress);
            this.txtCadastrarCursoInvestimento.Leave += new System.EventHandler(this.TxtCadastrarCursoInvestimento_Leave);
            // 
            // txtCadastrarCursoNome
            // 
            this.txtCadastrarCursoNome.Location = new System.Drawing.Point(13, 35);
            this.txtCadastrarCursoNome.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.txtCadastrarCursoNome.Name = "txtCadastrarCursoNome";
            this.txtCadastrarCursoNome.Size = new System.Drawing.Size(495, 32);
            this.txtCadastrarCursoNome.TabIndex = 1;
            // 
            // lblCadastrarCursoDescricao
            // 
            this.lblCadastrarCursoDescricao.AutoSize = true;
            this.lblCadastrarCursoDescricao.Location = new System.Drawing.Point(13, 84);
            this.lblCadastrarCursoDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.lblCadastrarCursoDescricao.Name = "lblCadastrarCursoDescricao";
            this.lblCadastrarCursoDescricao.Size = new System.Drawing.Size(86, 20);
            this.lblCadastrarCursoDescricao.TabIndex = 60;
            this.lblCadastrarCursoDescricao.Text = "Descrição";
            // 
            // lblCadastrarCursoCargaHoraria
            // 
            this.lblCadastrarCursoCargaHoraria.AutoSize = true;
            this.lblCadastrarCursoCargaHoraria.Location = new System.Drawing.Point(210, 192);
            this.lblCadastrarCursoCargaHoraria.Margin = new System.Windows.Forms.Padding(238, 0, 0, 0);
            this.lblCadastrarCursoCargaHoraria.Name = "lblCadastrarCursoCargaHoraria";
            this.lblCadastrarCursoCargaHoraria.Size = new System.Drawing.Size(119, 20);
            this.lblCadastrarCursoCargaHoraria.TabIndex = 62;
            this.lblCadastrarCursoCargaHoraria.Text = "Carga Horária";
            // 
            // txtCadastrarCursoDescricao
            // 
            this.txtCadastrarCursoDescricao.Location = new System.Drawing.Point(13, 107);
            this.txtCadastrarCursoDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.txtCadastrarCursoDescricao.Multiline = true;
            this.txtCadastrarCursoDescricao.Name = "txtCadastrarCursoDescricao";
            this.txtCadastrarCursoDescricao.Size = new System.Drawing.Size(495, 69);
            this.txtCadastrarCursoDescricao.TabIndex = 2;
            // 
            // lblCadastrarCursoInvestimento
            // 
            this.lblCadastrarCursoInvestimento.AutoSize = true;
            this.lblCadastrarCursoInvestimento.Location = new System.Drawing.Point(358, 192);
            this.lblCadastrarCursoInvestimento.Margin = new System.Windows.Forms.Padding(238, 0, 0, 0);
            this.lblCadastrarCursoInvestimento.Name = "lblCadastrarCursoInvestimento";
            this.lblCadastrarCursoInvestimento.Size = new System.Drawing.Size(112, 20);
            this.lblCadastrarCursoInvestimento.TabIndex = 62;
            this.lblCadastrarCursoInvestimento.Text = "Investimento";
            // 
            // lblCadastrarCursoGrupo
            // 
            this.lblCadastrarCursoGrupo.AutoSize = true;
            this.lblCadastrarCursoGrupo.Location = new System.Drawing.Point(13, 192);
            this.lblCadastrarCursoGrupo.Margin = new System.Windows.Forms.Padding(238, 0, 0, 0);
            this.lblCadastrarCursoGrupo.Name = "lblCadastrarCursoGrupo";
            this.lblCadastrarCursoGrupo.Size = new System.Drawing.Size(58, 20);
            this.lblCadastrarCursoGrupo.TabIndex = 61;
            this.lblCadastrarCursoGrupo.Text = "Grupo";
            // 
            // cmbCadastrarCursoGrupo
            // 
            this.cmbCadastrarCursoGrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCadastrarCursoGrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCadastrarCursoGrupo.DataSource = this.grupocursoBindingSource;
            this.cmbCadastrarCursoGrupo.DisplayMember = "nome";
            this.cmbCadastrarCursoGrupo.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCadastrarCursoGrupo.FormattingEnabled = true;
            this.cmbCadastrarCursoGrupo.Location = new System.Drawing.Point(13, 217);
            this.cmbCadastrarCursoGrupo.Margin = new System.Windows.Forms.Padding(0, 5, 20, 0);
            this.cmbCadastrarCursoGrupo.Name = "cmbCadastrarCursoGrupo";
            this.cmbCadastrarCursoGrupo.Size = new System.Drawing.Size(153, 28);
            this.cmbCadastrarCursoGrupo.TabIndex = 3;
            this.cmbCadastrarCursoGrupo.ValueMember = "codigo";
            // 
            // grupocursoBindingSource
            // 
            this.grupocursoBindingSource.DataSource = typeof(DAO.grupo_curso);
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(DAO.curso);
            // 
            // frmCadastrarCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 356);
            this.Controls.Add(this.pnlCadastrarCursoCampos);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCadastrarCursos";
            this.Text = "Cadastrar Cursos";
            this.Load += new System.EventHandler(this.FrmCadastrarCursos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastrarCursos_KeyDown);
            this.pnlCadastrarCursoCampos.ResumeLayout(false);
            this.pnlCadastrarCursoCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupocursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadastrarCursoCampos;
        private System.Windows.Forms.Button btnCadastrarCursoAddGrupo;
        private System.Windows.Forms.Button btnCadastrarCursoSalvar;
        private System.Windows.Forms.Button btnCadastrarCursoLimpar;
        private System.Windows.Forms.Button btnCadastrarCursoSair;
        private System.Windows.Forms.Label lblCadastrarCursoNome;
        private System.Windows.Forms.TextBox txtCadastrarCursoInvestimento;
        private System.Windows.Forms.TextBox txtCadastrarCursoNome;
        private System.Windows.Forms.Label lblCadastrarCursoDescricao;
        private System.Windows.Forms.TextBox txtCadastrarCursoDescricao;
        private System.Windows.Forms.Label lblCadastrarCursoInvestimento;
        private System.Windows.Forms.Label lblCadastrarCursoGrupo;
        private System.Windows.Forms.ComboBox cmbCadastrarCursoGrupo;
        private System.Windows.Forms.Label lblCadastrarCursoCargaHoraria;
        private System.Windows.Forms.MaskedTextBox mtxCadastrarCursoCargaHoraria;
        private System.Windows.Forms.BindingSource grupocursoBindingSource;
        public System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}