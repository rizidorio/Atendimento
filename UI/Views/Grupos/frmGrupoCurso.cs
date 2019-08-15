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
    public partial class frmGrupoCurso : Form
    {
        #region variáveis globais, load form
        private int codigo = 0;

        private grupo_curso GetGrupo
        {
            get
            {
                return (grupo_curso)grupocursoBindingSource.Current;
            }
        }

        public frmGrupoCurso()
        {
            InitializeComponent();
        }

        private void FrmGrupoCurso_Load(object sender, EventArgs e)
        {
            carregarGrupoCursos();
            pnlCadastroGrupoCursoLista.Dock = DockStyle.Fill;
            Size = new Size(400, 340);
            dgvGrupoCurso.ClearSelection();
        }

        #endregion

        #region botões menu principal
        private void BtnCadastroGrupoCursoMenuNovo_Click(object sender, EventArgs e)
        {
            mostrarCampos();
            lblCadastroGrupoCursoTitulo.Text = "Cadastrar Grupo de Cursos";
            grupocursoBindingSource.AddNew();
            rdoCadastrarGrupoCursoAtivoSim.Select();
            rdoCadastrarGrupoCursoAtivoNao.Enabled = false;
            txtCadastrarGrupoCursoNome.Focus();
            codigo = 0;
        }

        private void BtnCadastroGrupoCursoMenuEditar_Click(object sender, EventArgs e)
        {
            carregarDados();
            mostrarCampos();
            lblCadastroGrupoCursoTitulo.Text = "Editar Grupo de Cursos";
            txtCadastrarGrupoCursoNome.Focus();
        }

        private void BtnCadastroGrupoCursoMenuApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente deseja excluir o grupo de cursos?", "Grupo de Cursos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (Validacoes.verificarUsoGrupoCurso(GetGrupo))
                {
                    MessageBox.Show("Este grupo de cursos está sendo utilizado em algum curso, portanto não pode ser excluído.", "Grupo de Cursos");
                }
                else
                {
                    grupocursoBindingSource.RemoveCurrent();
                    DataContextFactory.atendimentosDataContext.SubmitChanges();
                    MessageBox.Show("Grupo de cursos excluído com sucesso!", "Grupo de Cursos");
                    carregarGrupoCursos();
                    btnCadastroGrupoCursoMenuApagar.Visible = false;
                    btnCadastroGrupoCursoMenuEditar.Visible = false;
                    codigo = 0;
                }
            }
        }

        private void BtnCadastroGrupoCursoMenuProcurar_Click(object sender, EventArgs e)
        {
            if (flpCadastroGrupoCursoProcurar.Visible)
            {
                flpCadastroGrupoCursoProcurar.Visible = false;
                txtCadastroGrupoCursoProcurarPor.Text = string.Empty;
            }
            else
            {
                mostrarProcurar(string.Empty);
                txtCadastroGrupoCursoProcurarPor.Text = string.Empty;
            }

        }

        private void BtnCadastroGrupoCursoFechar_Click(object sender, EventArgs e)
        {
            grupocursoBindingSource.CancelEdit();
            Dispose();
        }

        private void BtnCadastroGrupoCursoMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region botões menu cadastrar/editar
        private void BtnCadastrarGrupoCursoMenuSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtCadastrarGrupoCursoNome.Text;

            try
            {
                if (Validacoes.validarGrupoCurso(nome))
                {
                    if (codigo == 0)
                    {
                        if (!Validacoes.existeGrupoCurso(nome))
                        {
                            salvar();
                            MessageBox.Show("Grupo de cursos cadastrado com sucesso!", "Grupo de Cursos");
                        }
                        else
                        {
                            grupocursoBindingSource.CancelEdit();
                            mostrarLista();
                            mostrarProcurar(nome);
                        }
                    }
                    else
                    {
                        salvar();
                        MessageBox.Show("Grupo de cursos alterado com sucesso!", "Grupo de Cursos");
                    }
                }
                else
                {
                    txtCadastrarGrupoCursoNome.Focus();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void BtnCadastrarGrupoCursoMenuLimpar_Click(object sender, EventArgs e)
        {
            TratamentoCampos.limpar(flpCadastrarGrupoCursoCampos.Controls);
            txtCadastrarGrupoCursoNome.Focus();
        }

        private void BtnCadastrarGrupoCursoMenuSair_Click(object sender, EventArgs e)
        {
            grupocursoBindingSource.CancelEdit();
            mostrarLista();
        }
        #endregion

        #region carregar e configurações do dataGridView
        private void carregarGrupoCursos()
        {
            grupocursoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.grupo_curso;
        }

        private void DgvGrupoCurso_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                codigo = GetGrupo.codigo;
                btnCadastroGrupoCursoMenuEditar.Visible = true;
                btnCadastroGrupoCursoMenuApagar.Visible = true;
                flpCadastroGrupoCursoProcurar.Visible = false;
            }
        }

        private void DgvGrupoCurso_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
            {
                if (e.Value.ToString() == "0")
                    e.Value = "Não";

                else e.Value = "Sim";
            }
        }
        #endregion

        #region textChanged(procurar), Leave(grupoProduto) e KeyDown(Form)
        private void TxtCadastroGrupoCursoProcurarPor_TextChanged(object sender, EventArgs e)
        {
            grupocursoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.grupo_curso.Where(x => x.nome.Contains(txtCadastroGrupoCursoProcurarPor.Text));
        }

        private void TxtCadastrarGrupoCursoNome_Leave(object sender, EventArgs e)
        {
            if (txtCadastrarGrupoCursoNome.Text.Trim().Length > 50)
            {
                MessageBox.Show("O campo grupo cursos deve conter até 50 caracteres, favor verificar!", "Grupo de Cursos");
                txtCadastrarGrupoCursoNome.Focus();
            }
        }

        private void FrmGrupoCurso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (pnlCadastrarGrupoCursoCampos.Visible)
                {
                    grupocursoBindingSource.CancelEdit();
                    mostrarLista();
                }
                else
                {
                    Dispose();
                }
            }
        }
        #endregion

        #region metodos (mostrarLista, mostrarCampos, mostrarProcurar, passarDados, carregarDados e salvar)
        private void mostrarLista()
        {
            pnlCadastrarGrupoCursoCampos.Visible = false;
            flpCadastroGrupoCursoProcurar.Visible = false;
            btnCadastroGrupoCursoMenuEditar.Visible = false;
            btnCadastroGrupoCursoMenuApagar.Visible = false;
            pnlCadastroGrupoCursoLista.Visible = true;
            lblCadastroGrupoCursoTitulo.Text = "Cadastro Grupo de Cursos";
            TratamentoCampos.limpar(flpCadastrarGrupoCursoCampos.Controls);
            TratamentoCampos.limpar(flpCadastroGrupoCursoProcurar.Controls);
            dgvGrupoCurso.ClearSelection();
        }

        private void mostrarCampos()
        {
            pnlCadastroGrupoCursoLista.Visible = false;
            pnlCadastrarGrupoCursoCampos.Visible = true;
        }

        private void mostrarProcurar(string nome)
        {
            flpCadastroGrupoCursoProcurar.Visible = true;
            lblCadastroGrupoCursoProcurarPor.Text = "Grupo de Cursos";
            txtCadastroGrupoCursoProcurarPor.Size = new Size(220, 27);
            txtCadastroGrupoCursoProcurarPor.Text = nome;
        }

        private void passarDados()
        {
            GetGrupo.nome = txtCadastrarGrupoCursoNome.Text.Trim();
            if (rdoCadastrarGrupoCursoAtivoSim.Checked)
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
            txtCadastrarGrupoCursoCodigo.Text = GetGrupo.codigo.ToString();
            txtCadastrarGrupoCursoNome.Text = GetGrupo.nome;
            if (GetGrupo.ativo == 0)
            {
                rdoCadastrarGrupoCursoAtivoNao.Select();
            }
            else
            {
                rdoCadastrarGrupoCursoAtivoSim.Select();
            }
        }

        private void salvar()
        {
            try
            {
                grupocursoBindingSource.EndEdit();
                passarDados();
                DataContextFactory.atendimentosDataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            carregarGrupoCursos();
            mostrarLista();
        }
        #endregion

    }
}
