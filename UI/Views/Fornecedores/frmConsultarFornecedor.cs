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
    public partial class frmConsultarFornecedor : Form
    {

        #region Variaveis, GetFornecedor, Construtor e FormLoad
        private int id;
        private string tipo;

        private fornecedor GetFornecedor
        {
            get
            {
                return (fornecedor)fornecedorBindingSource.Current;
            }
        }

        public frmConsultarFornecedor()
        {
            InitializeComponent();
        }

        private void FrmConsultarFornecedor_Load(object sender, EventArgs e)
        {
            CarregarFornecedor();
            pnlConsultarFornecedorLista.Dock = DockStyle.Fill;
            flpConsultarFornecedorProcurar.Visible = false;
            dgvConsultarFornecedor.Visible = true;
        }
        #endregion

        #region Botões Lista(Editar, Deletar, Procurar e Fechar)

        private void BtnConsultarFornecedorEditar_Click(object sender, EventArgs e)
        {
            CarregarDados();
            flpConsultarFornecedorCampos.Visible = true;
            flpConsultarFornecedorCampos.Padding = new Padding(15, 30, 0, 0);
            pnlConsultarFornecedorLista.Visible = false;
        }

        private void BtnConsultarFornecedorDeletar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja realmente excluir este fornecedor?", "Fornecedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (GetFornecedor.ativo == 1)
                {
                    MessageBox.Show("Este fornecedor encontra-se ativo.\n Não foi possível excluir!", "Fornecedores");
                }
                else
                {
                    if (Validacoes.verificarUsoFornecedor(id))
                    {
                        MessageBox.Show("Existem produtos relacionados a este fornecedor.\n Não foi possível excluir!", "Fornecedores");
                    }
                    else
                    {
                        fornecedorBindingSource.RemoveCurrent();
                        DataContextFactory.atendimentosDataContext.SubmitChanges();
                        MessageBox.Show("Fornecedor excluído com sucesso!", "Fornecedores");
                        btnConsultarFornecedorDeletar.Visible = false;
                        btnConsultarFornecedorEditar.Visible = false;
                        CarregarFornecedor();
                        id = 0;
                    }
                }
            }
        }

        private void BtnConsultarFornecedorProcurar_Click(object sender, EventArgs e)
        {
            flpConsultarFornecedorProcurar.Visible = true;
            flpConsultarFornecedorProcurar.Size = new Size(419, 50);
        }

        private void BtnConsultarFornecedorFechar_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.CancelEdit();
            Dispose();
        }
        #endregion

        #region Botões da Edição

        private void BtnConsultarFornecedorSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtConsultarFornecedorRazaoSocial.Text.Trim();
            string emailFornecedor = txtConsultarFornecedorEmail.Text.Trim();
            string emailVendedor = txtConsultarFornecedorEmailVendedor.Text.Trim();

            try
            {
                if (Validacoes.validarFornecedor(nome))
                {
                    if (Validacoes.validarEmail(emailFornecedor) || Validacoes.validarEmail(emailVendedor))
                    {
                        fornecedorBindingSource.EndEdit();
                        PassarDados();
                        DataContextFactory.atendimentosDataContext.SubmitChanges();
                        MessageBox.Show("Fornecedor atualizado com sucesso!", "Fornecedores");
                        TratamentoCampos.limpar(flpConsultarFornecedorCampos.Controls);
                        TratamentoCampos.limpar(grpConsultarFornecedorVendedor.Controls);
                        FecharEdicao();
                    }
                    else
                    {
                        txtConsultarFornecedorEmail.Focus();
                    }
                }
                else
                {
                    txtConsultarFornecedorRazaoSocial.Focus();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void BtnConsultarFornecedorLimpar_Click(object sender, EventArgs e)
        {
            TratamentoCampos.limpar(flpConsultarFornecedorCampos.Controls);
            TratamentoCampos.limpar(grpConsultarFornecedorAtivo.Controls);
        }

        private void BtnConsultarFornecedorSair_Click(object sender, EventArgs e)
        {
            FecharEdicao();
        }

        private void BtnConsultarForncedorAddVendedor_Click(object sender, EventArgs e)
        {
            DesblorquearVendedor();
        }

        private void BtnConsultarFornecedorBuscarCep_Click(object sender, EventArgs e)
        {
            string cep = mtxConsultarFornecedorCep.Text.Remove(2, 1).Remove(5, 1);
            if (BuscarCep.BuscarEndereco(cep))
            {
                txtConsultarFornecedorBairro.Text = BuscarCep.bairro;
                txtConsultarFornecedorBairro.Enabled = false;
                txtConsultarFornecedorCidade.Text = BuscarCep.cidade;
                txtConsultarFornecedorCidade.Enabled = false;
                txtConsultarFornecedorLogradouro.Text = BuscarCep.logradouro;
                txtConsultarFornecedorLogradouro.Enabled = false;
                txtConsultarFornecedorUF.Text = BuscarCep.uf;
                txtConsultarFornecedorUF.Enabled = false;
                txtConsultarFornecedorNumero.Focus();
            }
            else
            {
                mtxConsultarFornecedorCep.Focus();
            }
        }
        #endregion

        #region Radion Buttons e botão voltar panel procurar
        private void RdoConsultarForncedorProcurarPorNome_Click(object sender, EventArgs e)
        {
            rdoConsultarFornecedorProcurarPorNome.Visible = false;
            rdoConsultarFornecedorProcurarPorAtivo.Visible = false;
            rdoConsultarFornecedorProcurarPorCNPJ.Visible = false;
            rdoConsultarFornecedorProcurarPorCPF.Visible = false;
            lblConsultarFornecedorProcurarPor.Text = "Nome:";
            lblConsultarFornecedorProcurarPor.Margin = new Padding(0, 6, 0, 10);
            mtxConsultarFornecedorProcurarPor.Visible = true;
            mtxConsultarFornecedorProcurarPor.Size = new Size(400, 32);
            btnConsultarFornecedorVoltar.Visible = true;
        }

        private void RdoConsultarForncedorProcurarPorCNPJ_Click(object sender, EventArgs e)
        {
            rdoConsultarFornecedorProcurarPorNome.Visible = false;
            rdoConsultarFornecedorProcurarPorAtivo.Visible = false;
            rdoConsultarFornecedorProcurarPorCNPJ.Visible = false;
            rdoConsultarFornecedorProcurarPorCPF.Visible = false;
            lblConsultarFornecedorProcurarPor.Text = "CNPJ:";
            lblConsultarFornecedorProcurarPor.Margin = new Padding(0, 6, 0, 10);
            mtxConsultarFornecedorProcurarPor.Visible = true;
            mtxConsultarFornecedorProcurarPor.Size = new Size(400, 32);
            mtxConsultarFornecedorProcurarPor.Mask = "00,000,000/0000-00";
            fornecedorBindingSource.DataSource = DataContextFactory.atendimentosDataContext.fornecedor.Where(x => x.tipo_fornecedor == "PJ");
            btnConsultarFornecedorVoltar.Visible = true;
        }

        private void RdoConsultarForncedorProcurarPorAtivo_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.DataSource = DataContextFactory.atendimentosDataContext.fornecedor.Where(x => x.ativo == 1);
        }

        private void RdoConsultarForncedorProcurarPorCPF_Click(object sender, EventArgs e)
        {
            rdoConsultarFornecedorProcurarPorNome.Visible = false;
            rdoConsultarFornecedorProcurarPorAtivo.Visible = false;
            rdoConsultarFornecedorProcurarPorCNPJ.Visible = false;
            rdoConsultarFornecedorProcurarPorCPF.Visible = false;
            lblConsultarFornecedorProcurarPor.Text = "CPF:";
            lblConsultarFornecedorProcurarPor.Margin = new Padding(0, 6, 0, 10);
            mtxConsultarFornecedorProcurarPor.Visible = true;
            mtxConsultarFornecedorProcurarPor.Size = new Size(400, 32);
            mtxConsultarFornecedorProcurarPor.Mask = "000,000,000-00";
            fornecedorBindingSource.DataSource = DataContextFactory.atendimentosDataContext.fornecedor.Where(x => x.tipo_fornecedor == "PF");
            btnConsultarFornecedorVoltar.Visible = true;
        }

        private void BtnConsultarFornecedorVoltar_Click(object sender, EventArgs e)
        {
            rdoConsultarFornecedorProcurarPorNome.Visible = true;
            rdoConsultarFornecedorProcurarPorAtivo.Visible = true;
            rdoConsultarFornecedorProcurarPorCNPJ.Visible = true;
            rdoConsultarFornecedorProcurarPorCPF.Visible = true;
            lblConsultarFornecedorProcurarPor.Text = "Procurar por:";
            lblConsultarFornecedorProcurarPor.Margin = new Padding(0, 0, 0, 0);
            mtxConsultarFornecedorProcurarPor.Visible = false;
            btnConsultarFornecedorVoltar.Visible = false;
            mtxConsultarFornecedorProcurarPor.Clear();
            mtxConsultarFornecedorProcurarPor.Mask = "";
            fornecedorBindingSource.DataSource = DataContextFactory.atendimentosDataContext.fornecedor;
        }

        #endregion

        #region Eventos DGV, MTX e FORM
        private void DgvConsultarFornecedor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tipo = GetFornecedor.tipo_fornecedor;
            id = GetFornecedor.codigo;
            btnConsultarFornecedorEditar.Visible = true;
            btnConsultarFornecedorDeletar.Visible = true;
        }

        private void MtxConsultarFornecedorProcurarPor_TextChanged(object sender, EventArgs e)
        {
            if (rdoConsultarFornecedorProcurarPorNome.Checked)
            {
                fornecedorBindingSource.DataSource = DataContextFactory.atendimentosDataContext.fornecedor.Where(x => x.razao_social.Contains(mtxConsultarFornecedorProcurarPor.Text));
            }
            else if (rdoConsultarFornecedorProcurarPorCNPJ.Checked)
            {
                if (mtxConsultarFornecedorProcurarPor.Text != "  .   .   /    -")
                {
                    fornecedorBindingSource.DataSource = DataContextFactory.atendimentosDataContext.fornecedor.Where(x => x.tipo_fornecedor == "PJ" && x.cnpj_cpf == mtxConsultarFornecedorProcurarPor.Text);
                }
                else
                {
                    fornecedorBindingSource.DataSource = DataContextFactory.atendimentosDataContext.fornecedor.Where(x => x.tipo_fornecedor == "PJ");
                }

            }
            else if (rdoConsultarFornecedorProcurarPorCPF.Checked)
            {
                if (mtxConsultarFornecedorProcurarPor.Text != "   .   .   -")
                {
                    fornecedorBindingSource.DataSource = DataContextFactory.atendimentosDataContext.fornecedor.Where(x => x.tipo_fornecedor == "PF" && x.cnpj_cpf == mtxConsultarFornecedorProcurarPor.Text);
                }
                else
                {
                    fornecedorBindingSource.DataSource = DataContextFactory.atendimentosDataContext.fornecedor.Where(x => x.tipo_fornecedor == "PF");
                }
            }
        }

        private void MtxConsultarFornecedorTelefone_Leave(object sender, EventArgs e)
        {
            if (mtxConsultarFornecedorTelefone.Text.Length == 9)
            {
                mtxConsultarFornecedorTelefone.Mask = "0000-0000";
            }
        }

        private void MtxConsultarFornecedorTelefoneVendedor_Leave(object sender, EventArgs e)
        {
            if (mtxConsultarFornecedorTelefoneVendedor.Text.Length == 9)
            {
                mtxConsultarFornecedorTelefoneVendedor.Mask = "0000-0000";
            }
        }

        private void FrmConsultarFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharEdicao();
                Dispose();
            }
        }
        #endregion

        #region Métodos(FecharEdição, PassarDados, CarregarDados, CarregarFornecedor,Bloquear e Desbloquer Vendedor

        private void FecharEdicao()
        {
            if (TratamentoCampos.verificarPreenchido(flpConsultarFornecedorCampos.Controls))
            {
                if (MessageBox.Show("O dados informados não serão salvos, gostaria realmente sair da edição?", "Fornecedores", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    TratamentoCampos.limpar(flpConsultarFornecedorCampos.Controls);
                    TratamentoCampos.limpar(grpConsultarFornecedorAtivo.Controls);
                    fornecedorBindingSource.CancelEdit();
                }
                else
                {
                    txtConsultarFornecedorRazaoSocial.Focus();
                    return;
                }
            }
            else
            {
                fornecedorBindingSource.CancelEdit();
            }

            flpConsultarFornecedorCampos.Visible = false;
            btnConsultarFornecedorEditar.Visible = false;
            btnConsultarFornecedorDeletar.Visible = false;
            pnlConsultarFornecedorLista.Visible = true;
        }

        private void PassarDados()
        {
            //dados fornecedor
            GetFornecedor.razao_social = txtConsultarFornecedorRazaoSocial.Text.Trim();
            GetFornecedor.nome_fantasia = txtConsultarFornecedorNomeFantasia.Text.Trim();
            GetFornecedor.cnpj_cpf = mtxConsultarFornecedorCNPJ.Text;
            GetFornecedor.ie_rg = mtxConsultarFornecedorIE.Text;
            GetFornecedor.cep = mtxConsultarFornecedorCep.Text;
            GetFornecedor.logradouro = txtConsultarFornecedorLogradouro.Text.Trim();
            GetFornecedor.numero = txtConsultarFornecedorNumero.Text.Trim();
            GetFornecedor.complemento = txtConsultarFornecedorComplemento.Text.Trim();
            GetFornecedor.bairro = txtConsultarFornecedorBairro.Text.Trim();
            GetFornecedor.cidade = txtConsultarFornecedorCidade.Text.Trim();
            GetFornecedor.estado = txtConsultarFornecedorUF.Text.Trim();
            GetFornecedor.ddd = mtxConsultarFornecedorDDD.Text;
            GetFornecedor.telefone = mtxConsultarFornecedorTelefone.Text;
            GetFornecedor.celular = mtxConsultarFornecedorCelular.Text;
            GetFornecedor.email = txtConsultarFornecedorEmail.Text.Trim();
            GetFornecedor.pagina_web = txtConsultarFornecedorWeb.Text.Trim();
            GetFornecedor.tipo_fornecedor = tipo;

            //dados vendedor
            GetFornecedor.nome_vendedor = txtConsultarFornecedorNomeVendedor.Text.Trim();
            GetFornecedor.email_vendedor = txtConsultarFornecedorEmailVendedor.Text.Trim();
            GetFornecedor.ddd_vendedor = mtxConsultarFornecedorDDDVendedor.Text;
            GetFornecedor.telefone_vendedor = mtxConsultarFornecedorTelefoneVendedor.Text;
            GetFornecedor.celular_vendedor = mtxConsultarFornecedorCelularVendedor.Text;
            if (rdoConsultarFornecedorAtivoSim.Checked)
            {
                GetFornecedor.ativo = 1;
            }
            else
            {
                GetFornecedor.ativo = 0;
            }
        }

        private void CarregarDados()
        {
            txtConsultarFornecedorRazaoSocial.Text = GetFornecedor.razao_social;
            if (GetFornecedor.nome_fantasia == string.Empty)
            {
                txtConsultarFornecedorNomeFantasia.Enabled = false;
            }
            txtConsultarFornecedorNomeFantasia.Text = GetFornecedor.nome_fantasia;
            mtxConsultarFornecedorCNPJ.Text = GetFornecedor.cnpj_cpf;
            mtxConsultarFornecedorIE.Text = GetFornecedor.ie_rg;
            mtxConsultarFornecedorCep.Text = GetFornecedor.cep;
            txtConsultarFornecedorLogradouro.Text = GetFornecedor.logradouro;
            txtConsultarFornecedorNumero.Text = GetFornecedor.numero;
            txtConsultarFornecedorComplemento.Text = GetFornecedor.complemento;
            txtConsultarFornecedorBairro.Text = GetFornecedor.bairro;
            txtConsultarFornecedorCidade.Text = GetFornecedor.cidade;
            txtConsultarFornecedorUF.Text = GetFornecedor.estado;
            mtxConsultarFornecedorDDD.Text = GetFornecedor.ddd;
            if (GetFornecedor.telefone.Length == 9)
            {
                mtxConsultarFornecedorTelefone.Mask = "0000-0000";
            }
            mtxConsultarFornecedorTelefone.Text = GetFornecedor.telefone;
            mtxConsultarFornecedorCelular.Text = GetFornecedor.celular;
            txtConsultarFornecedorEmail.Text = GetFornecedor.email;
            txtConsultarFornecedorWeb.Text = GetFornecedor.pagina_web;

            if (GetFornecedor.tipo_fornecedor == "PF")
            {
                lblConsultarFornecedorCNPJ.Text = "CPF";
                lblConsultarFornecedorIE.Text = "RG";
                lblConsultarFornecedorIE.Margin = new Padding(167, 0, 0, 0);
                lblConsultarFornecedorCep.Margin = new Padding(133, 0, 0, 0);
                mtxConsultarFornecedorCNPJ.Mask = "000,000,000-00";
                mtxConsultarFornecedorIE.Mask = "00,000,000-0";
            }

            if (GetFornecedor.nome_vendedor != string.Empty)
            {
                txtConsultarFornecedorNomeVendedor.Text = GetFornecedor.nome_vendedor;
                txtConsultarFornecedorEmailVendedor.Text = GetFornecedor.email_vendedor;
                mtxConsultarFornecedorDDDVendedor.Text = GetFornecedor.ddd_vendedor;
                mtxConsultarFornecedorCelularVendedor.Text = GetFornecedor.celular_vendedor;
                mtxConsultarFornecedorTelefoneVendedor.Text = GetFornecedor.telefone_vendedor;

                DesblorquearVendedor();
            }
            else
            {
                txtConsultarFornecedorNomeVendedor.Clear();
                txtConsultarFornecedorEmailVendedor.Clear();
                mtxConsultarFornecedorDDDVendedor.Clear();
                mtxConsultarFornecedorCelularVendedor.Clear();
                mtxConsultarFornecedorTelefoneVendedor.Clear();

                BloquearVendedor();
            }

            if (GetFornecedor.ativo == 0)
            {
                rdoConsultarFornecedorAtivoNao.Select();
            }
            else
            {
                rdoConsultarFornecedorAtivoSim.Select();
            }
        }

        private void CarregarFornecedor()
        {
            fornecedorBindingSource.DataSource = DataContextFactory.atendimentosDataContext.fornecedor;
        }

        private void BloquearVendedor()
        {
            txtConsultarFornecedorNomeVendedor.Enabled = false;
            txtConsultarFornecedorEmailVendedor.Enabled = false;
            mtxConsultarFornecedorDDDVendedor.Enabled = false;
            mtxConsultarFornecedorCelularVendedor.Enabled = false;
            mtxConsultarFornecedorTelefoneVendedor.Enabled = false;
            btnConsultarFornecedorAddVendedor.Enabled = true;
        }

        private void DesblorquearVendedor()
        {
            txtConsultarFornecedorNomeVendedor.Enabled = true;
            txtConsultarFornecedorEmailVendedor.Enabled = true;
            mtxConsultarFornecedorDDDVendedor.Enabled = true;
            mtxConsultarFornecedorCelularVendedor.Enabled = true;
            mtxConsultarFornecedorTelefoneVendedor.Enabled = true;
            btnConsultarFornecedorAddVendedor.Enabled = false;
        }
        #endregion
    }
}
