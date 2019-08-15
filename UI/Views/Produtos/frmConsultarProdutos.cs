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
    public partial class frmConsultarProdutos : Form
    {
        #region GetProtudo, Construtor e Formload
        private produto GetProduto
        {
            get
            {
                return (produto)produtoBindingSource.Current;
            }
        }

        public frmConsultarProdutos()
        {
            InitializeComponent();
        }

        private void FrmConsultarProdutos_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
            MostrarLista();
            fornecedorBindingSource.DataSource = DataContextFactory.atendimentosDataContext.fornecedor.Where(x => x.ativo == 1);
            grupoprodutoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.grupo_produto.Where(x => x.ativo == 1);
            unidademedidaBindingSource.DataSource = DataContextFactory.atendimentosDataContext.unidade_medida.Where(x => x.ativo == 1);
        }
        #endregion

        #region Botões Menu Lista
        private void BtnConsultarProdutosEditar_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            CarregarDados();
        }

        private void BtnConsultarProdutosDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este produto?", "Produtos ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (GetProduto.ativo == 1)
                {
                    MessageBox.Show("Este produto encontra-se ativo.\n Não foi possível excluir!", "Produtos");
                    btnConsultarProdutosDeletar.Visible = false;
                    btnConsultarProdutosEditar.Visible = false;
                }
                else
                {
                    produtoBindingSource.RemoveCurrent();
                    DataContextFactory.atendimentosDataContext.SubmitChanges();
                    MessageBox.Show("Produto excluído com sucesso!", "Produtos");
                    btnConsultarProdutosDeletar.Visible = false;
                    btnConsultarProdutosEditar.Visible = false;
                    CarregarProdutos();
                }
            }
        }

        private void BtnConsultarProdutosProcurar_Click(object sender, EventArgs e)
        {
            if (flpConsultarProdutosProcurar.Visible)
            {
                flpConsultarProdutosProcurar.Visible = false;
                mtxConsultarProdutosProcurarPor.Clear();
                CarregarProdutos();
            }
            else
            {
                flpConsultarProdutosProcurar.Visible = true;
                flpConsultarProdutosProcurar.Size = new Size(401, 48);
            }
        }

        private void BtnConsultarProdutosFechar_Click(object sender, EventArgs e)
        {
            produtoBindingSource.CancelEdit();
            Dispose();
        }
        #endregion

        #region Eventos DGV, Campos com Números e KeyDown do form
        private void DgvConsultarProdutos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnConsultarProdutosEditar.Visible = true;
                btnConsultarProdutosDeletar.Visible = true;
            }
        }

        private void DgvConsultarProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 2)
            {
                e.Value = ((unidade_medida)e.Value).nome;
            }
            if (e.Value != null && e.ColumnIndex == 6)
            {
                e.Value = ((fornecedor)e.Value).razao_social;
            }
            if (e.Value != null && e.ColumnIndex == 7)
            {
                e.Value = ((grupo_produto)e.Value).nome;
            }
        }

        private void TxtConsultarProdutosValorCompra_Leave(object sender, EventArgs e)
        {
            double valor;

            if (txtConsultarProdutosValorCompra.Text == string.Empty)
            {
                valor = 0.00;
            }
            else
            {
                valor = Convert.ToDouble(txtConsultarProdutosValorCompra.Text);
            }


            if (!valor.ToString().Contains(","))
            {
                txtConsultarProdutosValorCompra.Text = Math.Round(valor, 2).ToString("C2");
            }

            for (int i = 0; i < valor.ToString().Length; i++)
            {
                if (valor.ToString().IndexOf(",") == valor.ToString().Length - i)
                {
                    txtConsultarProdutosValorCompra.Text = Math.Round(valor, 2).ToString("C2");
                }
            }
        }

        private void TxtConsultarProdutosValorCompra_Enter(object sender, EventArgs e)
        {
            string valor = txtConsultarProdutosValorCompra.Text;
            if (valor.Contains("R$"))
            {
                txtConsultarProdutosValorCompra.Text = valor.Remove(0, 3);
            }
        }

        private void TxtConsultarProdutosValorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            TratamentoCampos.bloquearLetras(sender, e, txtConsultarProdutosValorCompra.Text);
        }

        private void TxtConsultarProdutosMargemLucro_Leave(object sender, EventArgs e)
        {
            double margem = Convert.ToDouble(txtConsultarProdutosMargemLucro.Text);
            double valorCompra = Convert.ToDouble(txtConsultarProdutosValorCompra.Text.Remove(0, 3));
            double valorVenda = (valorCompra * (margem / 100)) + valorCompra;


            txtConsultarProdutosMargemLucro.Text = margem.ToString("N2");

            txtConsultarProdutosValorVenda.Text = valorVenda.ToString("C2");
        }

        private void TxtConsultarProdutosMargemLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            TratamentoCampos.bloquearLetras(sender, e, txtConsultarProdutosMargemLucro.Text);
        }

        private void FrmConsultarProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (pnlConsultarProdutosCampos.Visible)
                {
                    produtoBindingSource.CancelEdit();
                    FecharEdição();
                }
                else
                {
                    Dispose();
                }
            }
        }

        #endregion

        #region Botões Campos
        private void BtnConsultarProdutosSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtConsultarProdutosNome.Text.Trim();
            string valor = txtConsultarProdutosValorCompra.Text;
            string margem = txtConsultarProdutosMargemLucro.Text;

            try
            {
                if (Validacoes.validarProduto(nome, valor, margem))
                {
                    produtoBindingSource.EndEdit();
                    PassarDados();
                    DataContextFactory.atendimentosDataContext.SubmitChanges();
                    MessageBox.Show("Produto alterado com sucesso!", "Produtos");
                    TratamentoCampos.limpar(pnlConsultarProdutosCampos.Controls);
                    FecharEdição();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void BtnConsultarProdutosLimpar_Click(object sender, EventArgs e)
        {
            TratamentoCampos.limpar(pnlConsultarProdutosCampos.Controls);
        }

        private void BtnConsultarProdutosSair_Click(object sender, EventArgs e)
        {
            FecharEdição();
        }

        private void BtnConsultarProdutosAddGrupo_Click(object sender, EventArgs e)
        {
            frmGrupoProduto frm = new frmGrupoProduto();
            frm.ShowDialog();
        }

        private void BtnConsultarProdutosAddUndMedida_Click(object sender, EventArgs e)
        {
            frmUnidadeMedida frm = new frmUnidadeMedida();
            frm.ShowDialog();
        }
        #endregion

        #region Procurar

        private void RdoConsultarProdutosProcurarPorNome_Click(object sender, EventArgs e)
        {
            mtxConsultarProdutosProcurarPor.Visible = true;
            btnConsultarProdutosVoltar.Visible = true;
            rdoConsultarProdutosProcurarInativo.Visible = false;
            rdoConsultarProdutosProcurarPorNome.Visible = false;
            lblConsultarProcedimentosProcurarPor.Text = "Nome:";
            lblConsultarProcedimentosProcurarPor.Padding = new Padding(0, 10, 0, 0);
            mtxConsultarProdutosProcurarPor.Size = new Size(600, 32);
            CarregarProdutos();
        }

        private void RdoConsultarProdutosProcurarInativo_Click(object sender, EventArgs e)
        {
            mtxConsultarProdutosProcurarPor.Clear();
            produtoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.produto.Where(x => x.ativo == 0);
        }

        private void MtxConsultarProdutosProcurarPor_TextChanged(object sender, EventArgs e)
        {
            produtoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.produto.Where(x => x.nome.Contains(mtxConsultarProdutosProcurarPor.Text));
        }

        private void BtnConsultarProdutosVoltar_Click(object sender, EventArgs e)
        {
            mtxConsultarProdutosProcurarPor.Visible = false;
            mtxConsultarProdutosProcurarPor.Clear();
            btnConsultarProdutosVoltar.Visible = false;
            rdoConsultarProdutosProcurarPorNome.Visible = true;
            rdoConsultarProdutosProcurarInativo.Visible = true;
            lblConsultarProcedimentosProcurarPor.Text = "Procurar Por:";
            lblConsultarProcedimentosProcurarPor.Padding = new Padding(0, 0, 10, 0);
            CarregarProdutos();
        }

        #endregion

        #region Métodos(CarregarProdutos, CarregarDados, PassarDados, MostrarLista, MostrarCampos e FecharEdição)
        private void CarregarProdutos()
        {
            produtoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.produto.Where(x => x.ativo == 1);
        }

        private void CarregarDados()
        {
            txtConsultarProdutosNome.Text = GetProduto.nome;
            txtConsultarProdutosDescricao.Text = GetProduto.descricao;
            cmbConsultarProdutosGrupo.SelectedValue = GetProduto.grupo_produto;
            cmbConsultarProdutosUndMedida.SelectedValue = GetProduto.unidade_medida;
            cmbConsultarProdutosFornecedor.SelectedValue = GetProduto.fornecedor;
            txtConsultarProdutosValorCompra.Text = GetProduto.valor_compra.ToString("C2");
            txtConsultarProdutosMargemLucro.Text = GetProduto.margem_lucro.ToString("N2");
            txtConsultarProdutosValorVenda.Text = GetProduto.valor_venda.ToString("C2");
            if (GetProduto.ativo == 0)
            {
                rdoConsultarProdutosAtivoNao.Select();
            }
            else
            {
                rdoConsultarProdutosAtivoSim.Select();
            }
        }

        private void PassarDados()
        {
            GetProduto.nome = txtConsultarProdutosNome.Text.Trim();
            GetProduto.descricao = txtConsultarProdutosDescricao.Text.Trim();
            GetProduto.grupo_produto = (int)cmbConsultarProdutosGrupo.SelectedValue;
            GetProduto.unidade_medida = (int)cmbConsultarProdutosUndMedida.SelectedValue;
            GetProduto.fornecedor = (int)cmbConsultarProdutosFornecedor.SelectedValue;
            GetProduto.valor_compra = Convert.ToDecimal(txtConsultarProdutosValorCompra.Text.Remove(0, 3));
            GetProduto.margem_lucro = Convert.ToDecimal(txtConsultarProdutosMargemLucro.Text.Trim());
            GetProduto.valor_venda = Convert.ToDecimal(txtConsultarProdutosValorVenda.Text.Remove(0, 3));
            if (rdoConsultarProdutosAtivoNao.Checked)
            {
                GetProduto.ativo = 0;
            }
            else
            {
                GetProduto.ativo = 1;
            }
        }

        private void MostrarLista()
        {
            pnlConsultarProdutosCampos.Visible = false;
            pnlConsultarProdutosLista.Dock = DockStyle.Fill;
            pnlConsultarProdutosLista.Visible = true;
            btnConsultarProdutosDeletar.Visible = false;
            btnConsultarProdutosEditar.Visible = false;
            flpConsultarProdutosProcurar.Visible = false;
            produtoBindingSource.CancelEdit();
            CarregarProdutos();
        }

        private void MostrarCampos()
        {
            lblConsultarProdutosNome.Location = new Point(139, 69);
            txtConsultarProdutosNome.Location = new Point(139, 91);
            lblConsultarProdutosDescricao.Location = new Point(139, 144);
            txtConsultarProdutosDescricao.Location = new Point(139, 166);
            lblConsultarProdutosGrupo.Location = new Point(139, 258);
            cmbConsultarProdutosGrupo.Location = new Point(139, 280);
            btnConsultarProdutosAddGrupo.Location = new Point(266, 279);
            lblConsultarProdutosUndMedida.Location = new Point(310, 258);
            cmbConsultarProdutosUndMedida.Location = new Point(310, 280);
            btnConsultarProdutosAddUndMedida.Location = new Point(415, 279);
            lblConsultarProdutosFornecedor.Location = new Point(458, 258);
            cmbConsultarProdutosFornecedor.Location = new Point(459, 280);
            lblConsultarProdutosValorCompra.Location = new Point(139, 338);
            txtConsultarProdutosValorCompra.Location = new Point(139, 360);
            lblConsultarProdutosMargemLucro.Location = new Point(296, 338);
            txtConsultarProdutosMargemLucro.Location = new Point(296, 360);
            lblConsultarProdutosPorcentagem.Location = new Point(311, 366);
            lblConsultarProdutosValorVenda.Location = new Point(447, 338);
            txtConsultarProdutosValorVenda.Location = new Point(447, 360);
            grpConsultarProdutosAtivo.Location = new Point(602, 322);
            btnConsultarProdutosSalvar.Location = new Point(139, 432);
            btnConsultarProdutosLimpar.Location = new Point(222, 432);
            btnConsultarProdutosSair.Location = new Point(312, 432);
            pnlConsultarProdutosLista.Visible = false;
            pnlConsultarProdutosCampos.Visible = true;
        }

        private void FecharEdição()
        {
            if (TratamentoCampos.verificarPreenchido(pnlConsultarProdutosCampos.Controls))
            {
                if (MessageBox.Show("O dados informados não serão salvos, gostaria realmente sair da edição?", "Produtos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    TratamentoCampos.limpar(pnlConsultarProdutosCampos.Controls);
                    produtoBindingSource.CancelEdit();
                    MostrarLista();
                }
                else
                {
                    txtConsultarProdutosNome.Focus();
                }
            }
            else
            {
                produtoBindingSource.CancelEdit();
                MostrarLista();
            }
        }
        #endregion

    }
}
