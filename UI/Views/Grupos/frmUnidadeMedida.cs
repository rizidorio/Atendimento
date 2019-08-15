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
    public partial class frmUnidadeMedida : Form
    {
        #region Variaveis - Loadform - Construtor

        private int codigo = 0;

        private unidade_medida GetUnidade
        {
            get
            {
                return (unidade_medida)unidademedidaBindingSource.Current;
            }
        }

        public frmUnidadeMedida()
        {
            InitializeComponent();
        }

        private void FrmUnidadeMedida_Load(object sender, EventArgs e)
        {
            carregarUnidadeMedida();
            pnlCadastroUndMedidaLista.Dock = DockStyle.Fill;
            Size = new Size(330, 270);
            dgvUndMedida.ClearSelection();
        }

        #endregion

        #region botões menu principal

        private void BtnCadastroUndMedidaMenuNovo_Click(object sender, EventArgs e)
        {
            mostrarCampos();
            lblCadastroUndMedidaTitulo.Text = "Cadastrar Unidade de Medida";
            unidademedidaBindingSource.AddNew();
            rdoCadastrarUndMedidaAtivoSim.Select();
            txtCadastrarUndMedidaNome.Focus();
            dgvUndMedida.ClearSelection();
            codigo = 0;
        }

        private void BtnCadastroUndMedidaMenuEditar_Click(object sender, EventArgs e)
        {
            lblCadastroUndMedidaTitulo.Text = "Editar Unidade de Medida";
            mostrarCampos();
            carregarDados();
            txtCadastrarUndMedidaNome.Focus();
        }

        private void BtnCadastroUndMedidaMenuApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente deseja excluir a unidade de medida?", "Unidade de Medida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (Validacoes.verificarUsoUnidadeMedida(GetUnidade))
                {
                    MessageBox.Show("Esta unidade de medida está sendo utilizada em algum produto, portanto não pode ser excluída.", "Unidade de Medida");
                }
                else
                {
                    unidademedidaBindingSource.RemoveCurrent();
                    DataContextFactory.atendimentosDataContext.SubmitChanges();
                    MessageBox.Show("Unidade de medida excluída com sucesso!", "Unidade de Medida");
                    carregarUnidadeMedida();
                    btnCadastroUndMedidaMenuEditar.Visible = false;
                    btnCadastroUndMedidaMenuApagar.Visible = false;
                    codigo = 0;
                }
            }
        }

        private void BtnCadastroUndMedidaMenuProcurar_Click(object sender, EventArgs e)
        {
            mostrarProcurar("");
            txtCadastroUndMedidaProcurarPor.Text = string.Empty;
        }

        private void BtnCadastroUndMedidaFechar_Click(object sender, EventArgs e)
        {
            unidademedidaBindingSource.CancelEdit();
            Dispose();
        }

        private void BtnCadastroUndMedidaMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region botões menu cadastrar
        private void BtnCadastrarUndMedidaMenuSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtCadastrarUndMedidaNome.Text.Trim();

            try
            {
                if (Validacoes.validarUndMedida(nome))
                {
                    if (codigo == 0)
                    {
                        if (!Validacoes.existeUnidadeMedida(nome))
                        {
                            salvar();
                            MessageBox.Show("Unidade de medida cadastrada com sucesso!", "Unidade de Medida");
                        }
                        else
                        {
                            string procurar = nome;
                            mostrarLista();
                            mostrarProcurar(procurar);
                        }
                    }
                    else
                    {
                        salvar();
                        MessageBox.Show("Unidade de medida alterada com sucesso!", "Unidade de Medida");
                    }
                }
                else
                {
                    txtCadastrarUndMedidaNome.Focus();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            
        }

        private void BtnCadastrarUndMedidaMenuLimpar_Click(object sender, EventArgs e)
        {
            TratamentoCampos.limpar(flpCadastrarUndMedidaCampos.Controls);
            txtCadastrarUndMedidaNome.Focus();
        }

        private void BtnCadastrarUndMedidaMenuSair_Click(object sender, EventArgs e)
        {
            unidademedidaBindingSource.CancelEdit();
            mostrarLista();
            dgvUndMedida.ClearSelection();
        }
        #endregion

        #region carregar e config datagridview
        private void carregarUnidadeMedida()
        {
            unidademedidaBindingSource.DataSource = DataContextFactory.atendimentosDataContext.unidade_medida;
        }

        private void DgvUndMedida_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                codigo = Convert.ToInt32(dgvUndMedida.Rows[e.RowIndex].Cells[0].Value);
                btnCadastroUndMedidaMenuEditar.Visible = true;
                btnCadastroUndMedidaMenuApagar.Visible = true;
                flpCadastroUndMedidaProcurar.Visible = false;
            }
            
        }

        private void DgvUndMedida_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.Value != null && e.ColumnIndex == 2)
            {
                if (e.Value != null && e.ColumnIndex == 2)
                {
                    if (e.Value.ToString() == "0")
                        e.Value = "Não";

                    else e.Value = "Sim";
                }
            }
        }

        #endregion

        #region textchanged e leave(txtprocurar e txtnome)
        private void TxtCadastroUndMedidaProcurarPor_TextChanged(object sender, EventArgs e)
        {
            unidademedidaBindingSource.DataSource = DataContextFactory.atendimentosDataContext.unidade_medida.Where(x => x.nome.Contains(txtCadastroUndMedidaProcurarPor.Text));
        }

        private void TxtCadastrarUndMedidaNome_Leave(object sender, EventArgs e)
        {
            if (txtCadastrarUndMedidaNome.Text.Trim().Length > 50)
            {
                MessageBox.Show("O campo unidade de medida deve conter até 50 caracteres, favor verificar!", "Unidade de Medida");
                txtCadastrarUndMedidaNome.Focus();
            }
        }

        #endregion

        #region métodos (mostrarLista, mostrarCampos, mostrarProcurar, passarDados e carregarDados)
        private void mostrarLista()
        {
            pnlCadastrarUndMedidaCampos.Visible = false;
            flpCadastroUndMedidaProcurar.Visible = false;
            btnCadastroUndMedidaMenuApagar.Visible = false;
            btnCadastroUndMedidaMenuEditar.Visible = false;
            pnlCadastroUndMedidaLista.Visible = true;
            lblCadastroUndMedidaTitulo.Text = "Cadastro de Unidades de Medida";
            TratamentoCampos.limpar(flpCadastrarUndMedidaCampos.Controls);
            TratamentoCampos.limpar(flpCadastroUndMedidaProcurar.Controls);
            dgvUndMedida.ClearSelection();
        }

        private void mostrarCampos()
        {
            pnlCadastroUndMedidaLista.Visible = false;
            pnlCadastrarUndMedidaCampos.Visible = true;
        }

        private void mostrarProcurar(string nome)
        {
            flpCadastroUndMedidaProcurar.Visible = true;
            lblCadastroUndMedidaProcurarPor.Text = "Unidade de medida:";
            txtCadastroUndMedidaProcurarPor.Size = new Size(190, 27);
            txtCadastroUndMedidaProcurarPor.Text = nome;
        }

        private void passarDados()
        {
            GetUnidade.nome = txtCadastrarUndMedidaNome.Text;
            if (rdoCadastrarUndMedidaAtivoNao.Checked)
            {
                GetUnidade.ativo = 0;
            }
            else
            {
                GetUnidade.ativo = 1;
            }
        }

        private void carregarDados()
        {
            txtCadastrarUndMedidaCodigo.Text = GetUnidade.codigo.ToString();
            txtCadastrarUndMedidaNome.Text = GetUnidade.nome;
            if (GetUnidade.ativo == 0)
            {
                rdoCadastrarUndMedidaAtivoNao.Select();
            }
            else
            {
                rdoCadastrarUndMedidaAtivoSim.Select();
            }
        }

        private void salvar()
        {
            try
            {
                unidademedidaBindingSource.EndEdit();
                passarDados();
                DataContextFactory.atendimentosDataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
           
            carregarUnidadeMedida();
            mostrarLista();
            TratamentoCampos.limpar(flpCadastrarUndMedidaCampos.Controls);
            TratamentoCampos.limpar(flpCadastroUndMedidaProcurar.Controls);
            dgvUndMedida.ClearSelection();
        }

        #endregion

    }
}
