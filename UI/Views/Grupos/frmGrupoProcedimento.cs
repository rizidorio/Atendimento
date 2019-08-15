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
    public partial class frmGrupoProcedimento : Form
    {
        #region variáveis globais, load form
        private int codigo = 0;

        private grupo_procedimento GetGrupo
        {
            get
            {
                return (grupo_procedimento)grupoprocedimentoBindingSource.Current;
            }
        }

        public frmGrupoProcedimento()
        {
            InitializeComponent();
        }

        private void FrmGrupoProcedimento_Load(object sender, EventArgs e)
        {
            carregarGrupoProcedimento();
            pnlCadastroGrupoProcedimentoLista.Dock = DockStyle.Fill;
            Size = new Size(400, 320);
            dgvGrupoProcedimento.ClearSelection();
        }
        #endregion

        #region botões menu principal
        private void BtnCadastroGrupoProcedimentoMenuNovo_Click(object sender, EventArgs e)
        {
            mostrarCampos();
            lblCadastroGrupoProcedimentoTitulo.Text = "Cadastrar Grupo de Procedimentos";
            grupoprocedimentoBindingSource.AddNew();
            rdoCadastrarGrupoProcedimentoAtivoSim.Select();
            txtCadastrarGrupoProcedimentoNome.Focus();
            codigo = 0;
        }

        private void BtnCadastroGrupoProcedimentoMenuEditar_Click(object sender, EventArgs e)
        {
            carregarDados();
            mostrarCampos();
            lblCadastroGrupoProcedimentoTitulo.Text = "Editar Grupo Procedimentos";
            txtCadastrarGrupoProcedimentoNome.Focus();
        }

        private void BtnCadastroGrupoProcedimentoMenuApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente deseja excluir o grupo de procedimentos?", "Grupo de Procedimentos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (Validacoes.verificarUsoGrupoProcedimento(GetGrupo))
                {
                    MessageBox.Show("Este grupo de procedimentos está sendo utilizado em algum procedimento, portanto não pode ser excluído.", "Grupo de Procedimentos");
                }
                else
                {
                    grupoprocedimentoBindingSource.RemoveCurrent();
                    DataContextFactory.atendimentosDataContext.SubmitChanges();
                    MessageBox.Show("Grupo de procedimentos excluído com sucesso!", "Grupo de Procedimentos");
                    carregarGrupoProcedimento();
                    btnCadastroGrupoProcedimentoMenuEditar.Visible = false;
                    btnCadastroGrupoProcedimentoMenuApagar.Visible = false;
                    codigo = 0;
                }
            }
        }

        private void BtnCadastroGrupoProcedimentoMenuProcurar_Click(object sender, EventArgs e)
        {
            if (flpCadastroGrupoProcedimentoProcurar.Visible)
            {
                flpCadastroGrupoProcedimentoProcurar.Visible = false;
                txtCadastroGrupoProcedimentoProcurarPor.Text = string.Empty;
            }
            else
            {
                mostrarProcurar(string.Empty);
                txtCadastroGrupoProcedimentoProcurarPor.Text = string.Empty;
            }
        }

        private void BtnCadastroGrupoProcedimentoFechar_Click(object sender, EventArgs e)
        {
            grupoprocedimentoBindingSource.CancelEdit();
            Dispose();
        }

        private void BtnCadastroGrupoProcedimentoMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region botões menu cadastrar/editar
        private void BtnCadastrarGrupoProcedimentoMenuSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtCadastrarGrupoProcedimentoNome.Text.Trim();

            try
            {
                if (Validacoes.validarGrupoProcedimento(nome))
                {
                    if (codigo == 0)
                    {
                        if (!Validacoes.existeGrupoProcedimento(nome))
                        {
                            salvar();
                            MessageBox.Show("Grupo de procedimentos cadastrado com sucesso!", "Grupo de Procedimentos");
                        }
                        else
                        {
                            grupoprocedimentoBindingSource.CancelEdit();
                            mostrarLista();
                            mostrarProcurar(nome);
                        }
                    }
                    else
                    {
                        salvar();
                        MessageBox.Show("Grupo de procedimentos alterado com sucesso!", "Grupo de Procedimentos");
                    }
                }
                else
                {
                    txtCadastrarGrupoProcedimentoNome.Focus();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            
        }

        private void BtnCadastrarGrupoProcedimentoMenuLimpar_Click(object sender, EventArgs e)
        {
            TratamentoCampos.limpar(flpCadastrarGrupoProcedimentoCampos.Controls);
            txtCadastrarGrupoProcedimentoNome.Focus();
        }

        private void BtnCadastrarGrupoProcedimentoMenuSair_Click(object sender, EventArgs e)
        {
            grupoprocedimentoBindingSource.CancelEdit();
            mostrarLista();
        }
        #endregion

        #region carregar e configurações do dataGridView

        private void carregarGrupoProcedimento()
        {
            grupoprocedimentoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.grupo_procedimento;
        }
        private void DgvGrupoProcedimento_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                codigo = GetGrupo.codigo;
                btnCadastroGrupoProcedimentoMenuEditar.Visible = true;
                btnCadastroGrupoProcedimentoMenuApagar.Visible = true;
                flpCadastroGrupoProcedimentoProcurar.Visible = false;
            }
        }

        private void DgvGrupoProcedimento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
            {
                if (e.Value.ToString() == "0")
                    e.Value = "Não";

                else e.Value = "Sim";
            }
        }
        #endregion

        #region textChanged(procurar) e Leave(grupoProduto)
        private void TxtCadastroGrupoProcedimentoProcurarPor_TextChanged(object sender, EventArgs e)
        {
            grupoprocedimentoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.grupo_procedimento.Where(x => x.nome.Contains(txtCadastroGrupoProcedimentoProcurarPor.Text));
        }

        private void TxtCadastrarGrupoProcedimentoNome_Leave(object sender, EventArgs e)
        {
            if (txtCadastrarGrupoProcedimentoNome.Text.Trim().Length > 50)
            {
                MessageBox.Show("O campo grupo procedimentos deve conter até 50 caracteres, favor verificar!", "Grupo de Procedimentos");
                txtCadastrarGrupoProcedimentoNome.Focus();
            }
        }
        #endregion

        #region metodos (mostrarLista, mostrarCampos, mostrarProcurar, passarDados, carregarDados e salvar)

        private void mostrarLista()
        {
            pnlCadastrarGrupoProcedimentoCampos.Visible = false;
            btnCadastroGrupoProcedimentoMenuEditar.Visible = false;
            btnCadastroGrupoProcedimentoMenuApagar.Visible = false;
            flpCadastroGrupoProcedimentoProcurar.Visible = false;
            pnlCadastroGrupoProcedimentoLista.Visible = true;
            lblCadastroGrupoProcedimentoTitulo.Text = "Cadastro Grupo de Cursos";
            TratamentoCampos.limpar(flpCadastrarGrupoProcedimentoCampos.Controls);
            TratamentoCampos.limpar(flpCadastroGrupoProcedimentoProcurar.Controls);
            dgvGrupoProcedimento.ClearSelection();
        }

        private void mostrarCampos()
        {
            pnlCadastroGrupoProcedimentoLista.Visible = false;
            pnlCadastrarGrupoProcedimentoCampos.Visible = true;
        }

        private void mostrarProcurar(string nome)
        {
            flpCadastroGrupoProcedimentoProcurar.Visible = true;
            lblCadastroGrupoProcedimentoProcurarPor.Text = "Grupo Procedimentos";
            txtCadastroGrupoProcedimentoProcurarPor.Size = new Size(200, 27);
            txtCadastroGrupoProcedimentoProcurarPor.Text = nome;
        }

        private void passarDados()
        {
            GetGrupo.nome = txtCadastrarGrupoProcedimentoNome.Text;
            if (rdoCadastrarGrupoProcedimentoAtivoSim.Checked)
            {
                GetGrupo.ativo = 1;
            }
            else
            {
                GetGrupo.ativo = 0;
            }
        }

        private void carregarDados()
        {
            txtCadastrarGrupoProcedimentoCodigo.Text = GetGrupo.codigo.ToString();
            txtCadastrarGrupoProcedimentoNome.Text = GetGrupo.nome;
            if (GetGrupo.ativo == 0)
            {
                rdoCadastrarGrupoProcedimentoAtivoNao.Select();
            }
            else
            {
                rdoCadastrarGrupoProcedimentoAtivoSim.Select();
            }
        }

        private void salvar()
        {
            try
            {
                grupoprocedimentoBindingSource.EndEdit();
                passarDados();
                DataContextFactory.atendimentosDataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            carregarGrupoProcedimento();
            mostrarLista();
        }

        #endregion

    }
}
