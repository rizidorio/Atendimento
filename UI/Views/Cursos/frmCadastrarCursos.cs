using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace UI
{
    public partial class frmCadastrarCursos : Form
    {
        #region GetCursos, contrutor e load

        private curso GetCurso
        {
            get
            {
                return (curso)cursoBindingSource.Current;
            }
        }

        public frmCadastrarCursos()
        {
            InitializeComponent();
        }

        private void FrmCadastrarCursos_Load(object sender, EventArgs e)
        {
            cursoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.curso;
            grupocursoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.grupo_curso.Where(x => x.ativo == 1);
            cmbCadastrarCursoGrupo.SelectedIndex = -1;
            if(cmbCadastrarCursoGrupo.Items.Count == 0)
            {
                if(MessageBox.Show("É necessário realizar o cadastro de um grupo de cursos para prosseguir, \n gostaria de cadastrar agora?", "Cursos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AbrirGrupo();
                    return;
                }
            }
            else
            {
                cursoBindingSource.AddNew();
                pnlCadastrarCursoCampos.Visible = true;
            }
            
        }
        #endregion

        #region Tratamento campo com valor
        private void TxtCadastrarCursoInvestimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            TratamentoCampos.bloquearLetras(sender, e, txtCadastrarCursoInvestimento.Text);
        }

        private void TxtCadastrarCursoInvestimento_Leave(object sender, EventArgs e)
        {
            double valor;

            if (txtCadastrarCursoInvestimento.Text == string.Empty)
            {
                valor = 0.00;
            }
            else
            {
                valor = Convert.ToDouble(txtCadastrarCursoInvestimento.Text);
            }
            

            if (!valor.ToString().Contains(","))
            {
                txtCadastrarCursoInvestimento.Text = Math.Round(valor, 2).ToString("C2");
            }

            for (int i = 0; i < valor.ToString().Length; i++)
            {
                if (valor.ToString().IndexOf(",") == valor.ToString().Length - i)
                {
                    txtCadastrarCursoInvestimento.Text = Math.Round(valor, 2).ToString("C2");
                }
            }
        }

        private void TxtCadastrarCursoInvestimento_Enter(object sender, EventArgs e)
        {
            if (txtCadastrarCursoInvestimento.Text.Contains("R$"))
            {
                txtCadastrarCursoInvestimento.Text = txtCadastrarCursoInvestimento.Text.Remove(0, 3);
            }
        }
        #endregion

        #region botões form e Keydown

        private void BtnCadastrarCursoSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtCadastrarCursoNome.Text.Trim();

            try
            {
                if (Validacoes.validarCurso(nome))
                {
                    if (Validacoes.existeCurso(nome))
                    {
                        txtCadastrarCursoNome.Focus();
                    }
                    else
                    {
                        cursoBindingSource.EndEdit();
                        PassarDados();
                        DataContextFactory.atendimentosDataContext.SubmitChanges();
                        MessageBox.Show("Curso cadastrado com sucesso!", "Cursos");
                        TratamentoCampos.limpar(pnlCadastrarCursoCampos.Controls);
                        FecharCadastro();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void BtnCadastrarCursoLimpar_Click(object sender, EventArgs e)
        {
            TratamentoCampos.limpar(pnlCadastrarCursoCampos.Controls);
            txtCadastrarCursoNome.Focus();
        }

        private void FrmCadastrarCursos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharCadastro();
            }
        }

        private void BtnCadastrarCursoSair_Click(object sender, EventArgs e)
        {
            FecharCadastro();
        }

        private void BtnCadastrarCursoAddGrupo_Click(object sender, EventArgs e)
        {
            AbrirGrupo();
        }

        #endregion

        #region Metodos (PassarDados, FecharCadastro e AbrirGrupo)
        private void PassarDados()
        {
            GetCurso.nome = txtCadastrarCursoNome.Text.Trim();
            GetCurso.descricao = txtCadastrarCursoDescricao.Text.Trim();
            GetCurso.grupo_curso = (int)cmbCadastrarCursoGrupo.SelectedValue;
            GetCurso.carga_horaria = mtxCadastrarCursoCargaHoraria.Text;
            GetCurso.investimento = Convert.ToDecimal(txtCadastrarCursoInvestimento.Text.Remove(0, 3));
            GetCurso.ativo = 1;
        }

        private void FecharCadastro()
        {
            if (TratamentoCampos.verificarPreenchido(pnlCadastrarCursoCampos.Controls))
            {
                if (MessageBox.Show("O dados informados não serão salvos, gostaria realmente sair do cadastro?", "Cursos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    TratamentoCampos.limpar(pnlCadastrarCursoCampos.Controls);
                    cursoBindingSource.CancelEdit();
                    Dispose();
                }
                else
                {
                    txtCadastrarCursoNome.Focus();
                }
            }
            else
            {
                cursoBindingSource.CancelEdit();
                Dispose();
            }
        }

        private void AbrirGrupo()
        {
            frmGrupoCurso frm = new frmGrupoCurso();
            frm.ShowDialog();
        }

        #endregion
    }
}
