using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace UI
{
    public partial class frmCadastrarProduto : Form
    {

        #region GetProdutos, Construtor e Load Form
        private produto GetProduto
        {
            get
            {
                return (produto)produtoBindingSource.Current;
            }
        }

        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void FrmCadastrarProduto_Load(object sender, EventArgs e)
        {
            produtoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.produto;
            grupoprodutoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.grupo_produto;
            unidademedidaBindingSource.DataSource = DataContextFactory.atendimentosDataContext.unidade_medida;
            fornecedorBindingSource.DataSource = DataContextFactory.atendimentosDataContext.fornecedor;
            cmbCadastrarProdutoFornecedor.SelectedIndex = -1;
            cmbCadastrarProdutoGrupo.SelectedIndex = -1;
            cmbCadastrarProdutoUndMedida.SelectedIndex = -1;
            pnlCadastrarProdutosCampos.Visible = true;
            produtoBindingSource.AddNew();
        }

        #endregion

        #region Tratamento campos com formatação de casas decimais e monetária
        private void TxtCadastrarProdutoValorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            TratamentoCampos.bloquearLetras(sender, e, txtCadastrarProdutoValorCompra.Text);
        }

        private void TxtCadastrarProdutoValorCompra_Leave(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtCadastrarProdutoValorCompra.Text);

            if (!valor.ToString().Contains(","))
            {
                txtCadastrarProdutoValorCompra.Text = Math.Round(valor, 2).ToString("C2");
            }

            for (int i = 0; i < valor.ToString().Length; i++)
            {
                if (valor.ToString().IndexOf(",") == valor.ToString().Length - i)
                {
                    txtCadastrarProdutoValorCompra.Text = Math.Round(valor, 2).ToString("C2");
                }
            }
        }

        private void TxtCadastrarProdutoValorCompra_Enter(object sender, EventArgs e)
        {
            string valor = txtCadastrarProdutoValorCompra.Text;
            if (valor.Contains("R$"))
            {
                txtCadastrarProdutoValorCompra.Text = valor.Remove(0, 3);
            }
        }

        private void TxtCadastrarProdutoMargemLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            TratamentoCampos.bloquearLetras(sender, e, txtCadastrarProdutoMargemLucro.Text);
        }

        private void TxtCadastrarProdutoMargemLucro_Leave(object sender, EventArgs e)
        {
            double margem = Convert.ToDouble(txtCadastrarProdutoMargemLucro.Text);
            double valorCompra = Convert.ToDouble(txtCadastrarProdutoValorCompra.Text.Remove(0, 3));
            double valorVenda = (valorCompra * (margem / 100)) + valorCompra;


            txtCadastrarProdutoMargemLucro.Text = margem.ToString("N2");

            txtCadastrarProdutoValorVenda.Text = valorVenda.ToString("C2");

        }
        #endregion

        #region botões do form e keydown form
        private void BtnCadastrarProdutoSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtCadastrarProdutoNome.Text.Trim();
            string valor = txtCadastrarProdutoValorCompra.Text;
            string margem = txtCadastrarProdutoMargemLucro.Text;

            try
            {
                if (Validacoes.validarProduto(nome, valor, margem))
                {
                    produtoBindingSource.EndEdit();
                    passarDados();
                    DataContextFactory.atendimentosDataContext.SubmitChanges();
                    MessageBox.Show("Produto cadastrado com sucesso!", "Produtos");
                    TratamentoCampos.limpar(pnlCadastrarProdutosCampos.Controls);
                    fecharCadastro();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void BtnCadastrarProdutoLimpar_Click(object sender, EventArgs e)
        {
            TratamentoCampos.limpar(pnlCadastrarProdutosCampos.Controls);
        }

        private void BtnCadastrarProdutoSair_Click(object sender, EventArgs e)
        {
            fecharCadastro();
        }

        private void BtnCadastrarProdutoAddGrupo_Click(object sender, EventArgs e)
        {
            frmGrupoProduto frm = new frmGrupoProduto();
            frm.ShowDialog();
        }

        private void BtnCadastrarProdutoAddUndMedida_Click(object sender, EventArgs e)
        {
            frmUnidadeMedida frm = new frmUnidadeMedida();
            frm.ShowDialog();
        }

        private void FrmCadastrarProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                fecharCadastro();
            }
        }

        #endregion

        #region métodos (passarDados, fecharCadastro)
        private void passarDados()
        {
            GetProduto.nome = txtCadastrarProdutoNome.Text.Trim();
            GetProduto.descricao = txtCadastrarProdutoDescricao.Text.Trim();
            GetProduto.grupo_produto = (int)cmbCadastrarProdutoGrupo.SelectedValue;
            GetProduto.unidade_medida = (int)cmbCadastrarProdutoUndMedida.SelectedValue;
            GetProduto.fornecedor = (int)cmbCadastrarProdutoFornecedor.SelectedValue;
            GetProduto.valor_compra = Convert.ToDecimal(txtCadastrarProdutoValorCompra.Text.Remove(0, 3));
            GetProduto.margem_lucro = Convert.ToDecimal(txtCadastrarProdutoMargemLucro.Text);
            GetProduto.valor_venda = Convert.ToDecimal(txtCadastrarProdutoValorVenda.Text.Remove(0, 3));
            GetProduto.data_cadastro = DateTime.Now.Date;
            GetProduto.ativo = 1;
        }

        private void fecharCadastro()
        {
            if (TratamentoCampos.verificarPreenchido(pnlCadastrarProdutosCampos.Controls))
            {
                if (MessageBox.Show("O dados informados não serão salvos, gostaria realmente sair do cadastro?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    TratamentoCampos.limpar(pnlCadastrarProdutosCampos.Controls);
                    produtoBindingSource.CancelEdit();
                    Dispose();
                }
                else
                {
                    txtCadastrarProdutoNome.Focus();
                }
            }
            else
            {
                produtoBindingSource.CancelEdit();
                Dispose();
            }
        }

        #endregion

    }
}
