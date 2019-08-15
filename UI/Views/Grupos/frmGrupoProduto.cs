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
    public partial class frmGrupoProduto : Form
    {
        #region variáveis globais, load form

        private int codigo = 0;

        private grupo_produto GetGrupo
        {
            get
            {
                return (grupo_produto)grupoprodutoBindingSource.Current;
            }
        }

        public frmGrupoProduto()
        {
            InitializeComponent();
        }

        private void FrmGrupoProduto_Load(object sender, EventArgs e)
        {
            carregarGrupoProduto();
            pnlCadastroGrupoProdutoLista.Dock = DockStyle.Fill;
            Size = new Size(330, 270);
            dgvGrupoProduto.ClearSelection();
        }

        #endregion

        #region botões menu principal
        private void BtnCadastroGrupoProdutoMenuNovo_Click(object sender, EventArgs e)
        {
            mostrarCampos();
            lblCadastroGrupoProdutoTitulo.Text = "Cadastrar Grupo de Produtos";
            grupoprodutoBindingSource.AddNew();
            rdoCadastrarGrupoProdutoAtivoSim.Select();
            txtCadastrarGrupoProdutoNome.Focus();
            //dgvGrupoProduto.ClearSelection();
            codigo = 0;
        }

        private void BtnCadastroGrupoProdutoMenuEditar_Click(object sender, EventArgs e)
        {
            carregarDados();
            mostrarCampos();
            lblCadastroGrupoProdutoTitulo.Text = "Editar Grupo de Produtos";
            txtCadastrarGrupoProdutoNome.Focus();
        }

        private void BtnCadastroGrupoProdutoMenuApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente deseja excluir o grupo de produtos?", "Grupo de Produtos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (Validacoes.verificarUsoGrupoProduto(GetGrupo))
                {
                    MessageBox.Show("Este grupo de produtos está sendo utilizado em algum produto, portanto não pode ser excluído.", "Grupo de Produtos");
                }
                else
                {
                    grupoprodutoBindingSource.RemoveCurrent();
                    DataContextFactory.atendimentosDataContext.SubmitChanges();
                    MessageBox.Show("Grupo de produtos excluído com sucesso!", "Grupo de Produtos");
                    carregarGrupoProduto();
                    btnCadastroGrupoProdutoMenuApagar.Visible = false;
                    btnCadastroGrupoProdutoMenuEditar.Visible = false;
                    codigo = 0;
                }
            }
        }

        private void BtnCadastroGrupoProdutoMenuProcurar_Click(object sender, EventArgs e)
        {
            mostrarProcurar("");
            txtCadastroGrupoProdutoProcurarPor.Text = string.Empty;
        }

        private void BtnCadastroGrupoProdutoMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region botões menu cadastrar/editar

        private void BtnCadastrarGrupoProdutoMenuSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtCadastrarGrupoProdutoNome.Text.Trim();

            try
            {
                if (Validacoes.validarGrupoProduto(nome))
                {
                    if (codigo == 0)
                    {
                        if (!Validacoes.existeGrupoProduto(nome))
                        {
                            salvar();
                            MessageBox.Show("Grupo de produtos cadastrado com sucesso!", "Grupo de Produtos");
                        }
                        else
                        {
                            mostrarLista();
                            mostrarProcurar(nome);
                            grupoprodutoBindingSource.CancelEdit();
                            lblCadastroGrupoProdutoTitulo.Text = "Cadastro Grupo de Produtos";
                        }
                    }
                    else
                    {
                        salvar();
                        MessageBox.Show("Grupo de produtos alterado com sucesso!", "Grupo de Produtos");
                    }
                }
                else
                {
                    txtCadastrarGrupoProdutoNome.Focus();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void BtnCadastrarGrupoProdutoMenuLimpar_Click(object sender, EventArgs e)
        {
            TratamentoCampos.limpar(flpCadastrarGrupoProdutoCampos.Controls);
            txtCadastrarGrupoProdutoNome.Focus();
        }

        private void BtnCadastrarGrupoProdutoMenuSair_Click(object sender, EventArgs e)
        {
            grupoprodutoBindingSource.CancelEdit();
            mostrarLista();
            carregarGrupoProduto();
        }

        private void BtnCadastroGrupoProdutoFechar_Click(object sender, EventArgs e)
        {
            grupoprodutoBindingSource.CancelEdit();
            Dispose();
        }
        #endregion

        #region carregar e configurações do dataGridView
        private void carregarGrupoProduto()
        {
            grupoprodutoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.grupo_produto;
        }

        private void DgvGrupoProduto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                codigo = Convert.ToInt32(dgvGrupoProduto.Rows[e.RowIndex].Cells[0].Value);
                btnCadastroGrupoProdutoMenuEditar.Visible = true;
                btnCadastroGrupoProdutoMenuApagar.Visible = true;
                flpCadastroGrupoProdutoProcurar.Visible = false;
            }
            
        }

        private void DgvGrupoProduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 2)
            {
                if (e.Value.ToString() == "0")
                    e.Value = "Não";

                else e.Value = "Sim";
            }
        }
        #endregion

        #region textChanged(procurar) e Leave(grupoProduto)
        private void TxtCadastroGrupoProdutoProcurarPor_TextChanged(object sender, EventArgs e)
        {
            grupoprodutoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.grupo_produto.Where(x => x.nome.Contains(txtCadastroGrupoProdutoProcurarPor.Text));
        }

        private void TxtCadastrarGrupoProdutoNome_Leave(object sender, EventArgs e)
        {
            if (txtCadastrarGrupoProdutoNome.Text.Trim().Length > 50)
            {
                MessageBox.Show("O campo grupo produto deve conter até 50 caracteres, favor verificar!", "Grupo de Produtos");
                txtCadastrarGrupoProdutoNome.Focus();
            }
        }

        #endregion

        #region metodos (mostrarLista, mostrarCampos, mostrarProcurar, passarDados, carregarDados e salvar)

        private void mostrarLista()
        {
            pnlCadastrarGrupoProdutoCampos.Visible = false;
            btnCadastroGrupoProdutoMenuEditar.Visible = false;
            btnCadastroGrupoProdutoMenuApagar.Visible = false;
            flpCadastroGrupoProdutoProcurar.Visible = false;
            pnlCadastroGrupoProdutoLista.Visible = true;
            lblCadastroGrupoProdutoTitulo.Text = "Cadastro Grupo de Produtos";
            TratamentoCampos.limpar(flpCadastrarGrupoProdutoCampos.Controls);
            TratamentoCampos.limpar(flpCadastroGrupoProdutoProcurar.Controls);
            dgvGrupoProduto.ClearSelection();
        }

        private void mostrarCampos()
        {
            pnlCadastroGrupoProdutoLista.Visible = false;
            pnlCadastrarGrupoProdutoCampos.Visible = true;
        }

        private void mostrarProcurar(string nome)
        {
            flpCadastroGrupoProdutoProcurar.Visible = true;
            lblCadastroGrupoProdutoProcurarPor.Text = "Grupo produtos";
            txtCadastroGrupoProdutoProcurarPor.Size = new Size(210, 27);
            txtCadastroGrupoProdutoProcurarPor.Text = nome;
        }

        private void passarDados()
        {
            GetGrupo.nome = txtCadastrarGrupoProdutoNome.Text;
            if (rdoCadastrarGrupoProdutoAtivoSim.Checked)
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
            txtCadastrarGrupoProdutoCodigo.Text = GetGrupo.codigo.ToString();
            txtCadastrarGrupoProdutoNome.Text = GetGrupo.nome;
            if (GetGrupo.ativo == 0)
            {
                rdoCadastrarGrupoProdutoAtivoNao.Select();
            }
            else
            {
                rdoCadastrarGrupoProdutoAtivoSim.Select();
            }
        }

        private void salvar()
        {
            try
            {
                grupoprodutoBindingSource.EndEdit();
                passarDados();
                DataContextFactory.atendimentosDataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            carregarGrupoProduto();
            mostrarLista();
        }

        #endregion

    }
}
