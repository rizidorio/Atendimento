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
    public partial class frmCadastrarProcedimento : Form
    {
        #region GetProcedimento, Construtor e loadform
        private procedimento GetProcedimento
        {
            get
            {
                return (procedimento)procedimentoBindingSource.Current;
            }
        }

        public frmCadastrarProcedimento()
        {
            InitializeComponent();
        }

        private void FrmCadastrarProcedimento_Load(object sender, EventArgs e)
        {
            procedimentoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.procedimento;
            grupoprocedimentoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.grupo_procedimento;
            cmbCadastrarProcedimentoGrupo.SelectedIndex = -1;
            procedimentoBindingSource.AddNew();
            pnlCadastrarProcedimentoCampos.Visible = true;
        }
        #endregion

        #region Botões do form e keydown

        private void BtnCadastrarProcedimentoSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacoes.validarProcedimento(txtCadastrarProcedimentoNome.Text))
                {
                    procedimentoBindingSource.EndEdit();
                    passarDados();
                    DataContextFactory.atendimentosDataContext.SubmitChanges();
                    MessageBox.Show("Procedimento cadastrado com sucesso!", "Procedimentos");
                    TratamentoCampos.limpar(pnlCadastrarProcedimentoCampos.Controls);
                    fecharCadastro();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void BtnCadastrarProcedimentoAddGrupo_Click(object sender, EventArgs e)
        {
            frmGrupoProcedimento frm = new frmGrupoProcedimento();
            frm.ShowDialog();
        }

        private void BtnCadastrarProcedimentoLimpar_Click(object sender, EventArgs e)
        {
            TratamentoCampos.limpar(pnlCadastrarProcedimentoCampos.Controls);
        }

        private void BtnCadastrarProcedimentoSair_Click(object sender, EventArgs e)
        {
            fecharCadastro();
        }

        private void FrmCadastrarProcedimento_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                fecharCadastro();
            }
        }
        #endregion

        #region Formatação campo com valor
        private void TxtCadastrarProcedimentoValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            TratamentoCampos.bloquearLetras(sender, e, txtCadastrarProcedimentoValor.Text);
        }

        private void TxtCadastrarProcedimentoValor_Leave(object sender, EventArgs e)
        {
            double valor;

            if (txtCadastrarProcedimentoValor.Text == string.Empty)
            {
                valor = 0.00;
            }
            else
            {
                valor = Convert.ToDouble(txtCadastrarProcedimentoValor.Text);
            }


            if (!valor.ToString().Contains(","))
            {
                txtCadastrarProcedimentoValor.Text = Math.Round(valor, 2).ToString("C2");
            }

            for (int i = 0; i < valor.ToString().Length; i++)
            {
                if (valor.ToString().IndexOf(",") == valor.ToString().Length - i)
                {
                    txtCadastrarProcedimentoValor.Text = Math.Round(valor, 2).ToString("C2");
                }
            }
        }

        private void TxtCadastrarProcedimentoValor_Enter(object sender, EventArgs e)
        {
            if (txtCadastrarProcedimentoValor.Text.Contains("R$"))
            {
                txtCadastrarProcedimentoValor.Text = txtCadastrarProcedimentoValor.Text.Remove(0, 3);
            }
        }
        #endregion

        #region Métodos passarDados e fecharCadastro
        private void passarDados()
        {
            GetProcedimento.nome = txtCadastrarProcedimentoNome.Text.Trim();
            GetProcedimento.descricao = txtCadastrarProcedimentoDescricao.Text.Trim();
            GetProcedimento.grupo_procedimento = (int)cmbCadastrarProcedimentoGrupo.SelectedValue;
            GetProcedimento.valor = Convert.ToDecimal(txtCadastrarProcedimentoValor.Text.Remove(0, 3));
            GetProcedimento.ativo = 1;
        }

        private void fecharCadastro()
        {
            if (TratamentoCampos.verificarPreenchido(pnlCadastrarProcedimentoCampos.Controls))
            {
                if (MessageBox.Show("O dados informados não serão salvos, gostaria realmente sair do cadastro?", "Cursos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    TratamentoCampos.limpar(pnlCadastrarProcedimentoCampos.Controls);
                    procedimentoBindingSource.CancelEdit();
                    Dispose();
                }
                else
                {
                    txtCadastrarProcedimentoNome.Focus();
                }
            }
            else
            {
                procedimentoBindingSource.CancelEdit();
                Dispose();
            }
        }
        #endregion

    }
}
