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
    public partial class frmCadastrarFornecedor : Form
    {
        #region GetFornecedor, Construtor e Form load
        private fornecedor GetFornecedor
        {
            get
            {
                return (fornecedor)fornecedorBindingSource.Current;
            }
        }

        public frmCadastrarFornecedor()
        {
            InitializeComponent();
        }

        private void FrmCadastrarFornecedor_Load(object sender, EventArgs e)
        {
            flpCadastrarFornecedorTipo.Size = new Size(870, 45);
            flpCadastrarFornecedorTipo.Padding = new Padding(10, 10, 0, 0);
            flpCadastrarForncedorCampos.Padding = new Padding(15, 30, 0, 0);
            fornecedorBindingSource.DataSource = DataContextFactory.atendimentosDataContext.fornecedor;
            fornecedorBindingSource.AddNew();
        }
        #endregion

        #region Botões do form (Salvar, Limpar, Sair, Add Vendedor e Buscar CEP )
        private void BtnCadastrarFornecedorSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtCadastrarFornecedorRazaoSocial.Text.Trim();
            string cnpj = mtxCadastrarFornecedorCNPJ.Text;
            string emailFornecedor = txtCadastrarFornecedorEmail.Text.Trim();
            string emailVendedor = txtCadastrarFornecedorEmailVendedor.Text.Trim();

            try
            {
                if (Validacoes.validarFornecedor(nome))
                {
                    if (!Validacoes.existeFornecedor(nome, cnpj))
                    {

                        if (Validacoes.validarEmail(emailFornecedor) || Validacoes.validarEmail(emailVendedor))
                        {
                            fornecedorBindingSource.EndEdit();
                            passarDados();
                            DataContextFactory.atendimentosDataContext.SubmitChanges();
                            MessageBox.Show("Fornecedor cadastrado com sucesso!", "Fornecedores");
                            TratamentoCampos.limpar(flpCadastrarForncedorCampos.Controls);
                            fecharCadastro();
                        }
                        else
                        {
                            txtCadastrarFornecedorEmail.Focus();
                        }
                    }
                    else
                    {
                        txtCadastrarFornecedorRazaoSocial.Focus();
                    }
                }
                else
                {
                    txtCadastrarFornecedorRazaoSocial.Focus();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void BtnCadastrarFornecedorLimpar_Click(object sender, EventArgs e)
        {
            TratamentoCampos.limpar(flpCadastrarForncedorCampos.Controls);
            TratamentoCampos.desbloquear(flpCadastrarForncedorCampos.Controls);
            txtCadastrarFornecedorRazaoSocial.Focus();
            
        }

        private void BtnCadastrarFornecedorSair_Click(object sender, EventArgs e)
        {
            fecharCadastro();
        }

        private void BtnCadastrarForncedorAddVendedor_Click(object sender, EventArgs e)
        {
            TratamentoCampos.desbloquear(grpCadastrarFornecedorVendedor.Controls);
            txtCadastrarFornecedorNomeVendedor.Focus();
        }

        private void BtnCadastrarFornecedorBuscarCep_Click(object sender, EventArgs e)
        {
            string cep = mtxCadastrarFornecedorCep.Text.Remove(2, 1).Remove(5, 1);
            if (BuscarCep.BuscarEndereco(cep))
            {
                txtCadastrarFornecedorBairro.Text = BuscarCep.bairro;
                txtCadastrarFornecedorBairro.Enabled = false;
                txtCadastrarFornecedorCidade.Text = BuscarCep.cidade;
                txtCadastrarFornecedorCidade.Enabled = false;
                txtCadastrarFornecedorLogradouro.Text = BuscarCep.logradouro;
                txtCadastrarFornecedorLogradouro.Enabled = false;
                txtCadastrarFornecedorUF.Text = BuscarCep.uf;
                txtCadastrarFornecedorUF.Enabled = false;
                txtCadastrarFornecedorNumero.Focus();
            }
            else
            {
                mtxCadastrarFornecedorCep.Focus();
            }
        }

        #endregion

        #region seleção cbm tipo fornecedor, formatações mtx e Form Key press
        private void CmbCadastrarClienteTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCadastrarFornecedorTipo.SelectedIndex == 0)
            {
                flpCadastrarFornecedorTipo.Visible = false;
                flpCadastrarForncedorCampos.Visible = true;
                lblCadastrarFornecedorRazaoSocial.Text = "Nome";
                lblCadastrarFornecedorNomeFantasia.Margin = new Padding(370, 0, 0, 0);
                txtCadastrarFornecedorNomeFantasia.Enabled = false;
                lblCadastrarFornecedorCNPJ.Text = "CPF";
                lblCadastrarFornecedorIE.Text = "RG";
                lblCadastrarFornecedorIE.Margin = new Padding(170, 0, 0, 0);
                lblCadastrarFornecedorCep.Margin = new Padding(130, 0, 0, 0);
                mtxCadastrarFornecedorCNPJ.Mask = "000,000,000-00";
                mtxCadastrarFornecedorIE.Mask = "00,000,000-0";
            }
            else if (cmbCadastrarFornecedorTipo.SelectedIndex == 1)
            {
                flpCadastrarFornecedorTipo.Visible = false;
                flpCadastrarForncedorCampos.Visible = true;
            }

        }

        private void MtxCadastrarFornecedorTelefone_Leave(object sender, EventArgs e)
        {
            if (mtxCadastrarFornecedorTelefone.Text.Length == 9)
            {
                mtxCadastrarFornecedorTelefone.Mask = "0000-0000";
            }
        }

        private void MtxCadastrarFornecedorTelefoneVendedor_Leave(object sender, EventArgs e)
        {
            if (mtxCadastrarFornecedorTelefoneVendedor.Text.Length == 9)
            {
                mtxCadastrarFornecedorTelefoneVendedor.Mask = "0000-0000";
            }
        }
        private void FrmCadastrarFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                fecharCadastro();
            }
        }

        #endregion

        #region métodos passarDados e Fecharform

        private void passarDados()
        {
            //dados fornecedor
            GetFornecedor.razao_social = txtCadastrarFornecedorRazaoSocial.Text.Trim();
            GetFornecedor.nome_fantasia = txtCadastrarFornecedorNomeFantasia.Text.Trim();
            GetFornecedor.cnpj_cpf = mtxCadastrarFornecedorCNPJ.Text;
            GetFornecedor.ie_rg = mtxCadastrarFornecedorIE.Text;
            GetFornecedor.cep = mtxCadastrarFornecedorCep.Text;
            GetFornecedor.logradouro = txtCadastrarFornecedorLogradouro.Text.Trim();
            GetFornecedor.numero = txtCadastrarFornecedorNumero.Text.Trim();
            GetFornecedor.complemento = txtCadastrarFornecedorComplemento.Text.Trim();
            GetFornecedor.bairro = txtCadastrarFornecedorBairro.Text.Trim();
            GetFornecedor.cidade = txtCadastrarFornecedorCidade.Text.Trim();
            GetFornecedor.estado = txtCadastrarFornecedorUF.Text.Trim();
            GetFornecedor.ddd = mtxCadastrarFornecedorDDD.Text;
            GetFornecedor.telefone = mtxCadastrarFornecedorTelefone.Text;
            GetFornecedor.celular = mtxCadastrarFornecedorCelular.Text;
            GetFornecedor.email = txtCadastrarFornecedorEmail.Text.Trim();
            GetFornecedor.pagina_web = txtCadastrarFornecedorWeb.Text.Trim();
            if (cmbCadastrarFornecedorTipo.SelectedIndex == 0)
            {
                GetFornecedor.tipo_fornecedor = "PF";
            }
            else
            {
                GetFornecedor.tipo_fornecedor = "PJ";
            }

            //dados vendedor
            GetFornecedor.nome_vendedor = txtCadastrarFornecedorNomeVendedor.Text.Trim();
            GetFornecedor.email_vendedor = txtCadastrarFornecedorEmailVendedor.Text.Trim();
            GetFornecedor.ddd_vendedor = mtxCadastrarFornecedorDDDVendedor.Text;
            GetFornecedor.telefone_vendedor = mtxCadastrarFornecedorTelefoneVendedor.Text;
            GetFornecedor.celular_vendedor = mtxCadastrarFornecedorCelularVendedor.Text;

            //dados fixos
            GetFornecedor.data_cadastro = DateTime.Now.Date;
            GetFornecedor.ativo = 1;
        }

        private void fecharCadastro()
        {
            if (TratamentoCampos.verificarPreenchido(flpCadastrarForncedorCampos.Controls))
            {
                if (MessageBox.Show("O dados informados não serão salvos, gostaria realmente sair do cadastro?", "Fornecedores", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    TratamentoCampos.limpar(flpCadastrarForncedorCampos.Controls);
                    fornecedorBindingSource.CancelEdit();
                    Dispose();
                }
                else
                {
                    txtCadastrarFornecedorRazaoSocial.Focus();
                }
            }
            else
            {
                fornecedorBindingSource.CancelEdit();
                Dispose();
            }
        }

        #endregion

    }
}
