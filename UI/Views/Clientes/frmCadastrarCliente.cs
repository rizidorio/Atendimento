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
    public partial class frmCadastrarCliente : Form
    {
        #region Instancias, GetCliente, construtor e form load

        private cliente GetCliente
        {
            get
            {
                return (cliente)clienteBindingSource.Current;
            }
        }
       
        public frmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            flpCadastrarClienteTipo.Size = new Size(870, 40);
            flpCadastrarClienteTipo.Padding = new Padding(10, 10, 0, 0);
            flpCadastrarClienteCampos.Padding = new Padding(15, 30, 0, 0);
            clienteBindingSource.DataSource = DataContextFactory.atendimentosDataContext.cliente;
            clienteBindingSource.AddNew();
        }
        #endregion

        #region botões Salvar, Limpar, Sair e Buscar CEP
        private void BtnCadastrarClienteMenuSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtCadastrarClienteNome.Text.Trim();
            string cpf = mtxCadastrarClienteCPF.Text.Trim();
            string email = txtCadastrarClienteEmail.Text.Trim();

            try
            {
                if (Validacoes.validarCliente(nome))
                {
                    if (!Validacoes.existeCliente(nome, cpf))
                    {
                        if (Validacoes.validarEmail(email))
                        {
                            clienteBindingSource.EndEdit();
                            passarDados();
                            DataContextFactory.atendimentosDataContext.SubmitChanges();
                            MessageBox.Show("Cliente cadastrado com sucesso!", "Clientes");
                            TratamentoCampos.limpar(flpCadastrarClienteCampos.Controls);
                            fecharCadastro();
                        }
                        else
                        {
                            txtCadastrarClienteEmail.Focus();
                        }
                    }
                    else
                    {
                        //TODO abrir form de pesquisa e edição
                        txtCadastrarClienteNome.Focus();
                    }
                }
                else
                {
                    txtCadastrarClienteNome.Focus();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private void BtnCadastrarClienteMenuLimpar_Click(object sender, EventArgs e)
        {
            TratamentoCampos.limpar(flpCadastrarClienteCampos.Controls);
            TratamentoCampos.desbloquear(flpCadastrarClienteCampos.Controls);
            txtCadastrarClienteNome.Focus();
        }

        private void BtnCadastrarClienteMenuSair_Click(object sender, EventArgs e)
        {
            fecharCadastro();
        }

        private void BtnCadastrarClienteBuscarCep_Click(object sender, EventArgs e)
        {
            string cep = mtxCadastrarClienteCEP.Text.Remove(2, 1).Remove(5, 1);
            if (BuscarCep.BuscarEndereco(cep))
            {
                txtCadastrarClienteBairro.Text = BuscarCep.bairro;
                txtCadastrarClienteBairro.Enabled = false;
                txtCadastrarClienteCidade.Text = BuscarCep.cidade;
                txtCadastrarClienteCidade.Enabled = false;
                txtCadastrarClienteLogradouro.Text = BuscarCep.logradouro;
                txtCadastrarClienteLogradouro.Enabled = false;
                txtCadastrarClienteUF.Text = BuscarCep.uf;
                txtCadastrarClienteUF.Enabled = false;
                txtCadastrarClienteNumero.Focus();
            }
            else
            {
                mtxCadastrarClienteCEP.Focus();
            }

            
        }
        #endregion

        #region seleção combo box tipo cliente, form keyDown, mtxTelefone leave
        private void CmbCadastrarClienteTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCadastrarClienteTipo.SelectedIndex == 0)
            {
                mostrarCampos();
                lblCadastrarClienteRG.Margin = new Padding(152, 40, 0, 0);
            }
            else
            {
                mostrarCampos();
                lblCadastrarClienteCPF.Text = "CNPJ";
                lblCadastrarClienteRG.Visible = true;
                lblCadastrarClienteRG.Text = "IE";
                lblCadastrarClienteRG.Margin = new Padding(148, 40, 0, 0);
                mtxCadastrarClienteCPF.Mask = "00,000,000/0000-00";
                mtxCadastrarClienteRG.Mask = "";
                dtpCadastrarClienteNascimento.Enabled = false;
                cmbCadastrarClienteEstadoCivil.Enabled = false;
                cmbCadastrarClienteSexo.Enabled = false;
            }
        }

        private void FrmCadastroCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                fecharCadastro();
            }
        }

        private void MtxCadastrarClienteTelefone_Leave(object sender, EventArgs e)
        {
            if (mtxCadastrarClienteTelefone.Text.Length == 9)
            {
                mtxCadastrarClienteTelefone.Mask = "0000-0000";
            }
        }

        #endregion

        #region metodos (mostrarCampos, fecharCadastro e passarDados
        private void mostrarCampos()
        {
            flpCadastrarClienteTipo.Visible = false;
            flpCadastrarClienteCampos.Visible = true;
            lblCadastrarClienteNome.Visible = true;
            lblCadastrarClienteNome.Margin = new Padding(0, 40, 0, 0);
            lblCadastrarClienteCPF.Visible = true;
            lblCadastrarClienteCPF.Margin = new Padding(340, 40, 0, 0);
            lblCadastrarClienteRG.Visible = true;
            lblCadastrarClienteNascimento.Visible = true;
            lblCadastrarClienteNascimento.Margin = new Padding(111, 40, 0, 0);
            txtCadastrarClienteNome.Visible = true;
            mtxCadastrarClienteCPF.Visible = true;
            mtxCadastrarClienteRG.Visible = true;
            dtpCadastrarClienteNascimento.Visible = true;
            dtpCadastrarClienteNascimento.Margin = new Padding(20, 0, 0, 60);
            lblCadastrarClienteEstadoCivil.Visible = true;
            lblCadastrarClienteSexo.Visible = true;
            lblCadastrarClienteCEP.Visible = true;
            lblCadastrarClienteLogradouro.Visible = true;
            cmbCadastrarClienteEstadoCivil.Visible = true;
            cmbCadastrarClienteSexo.Visible = true;
            mtxCadastrarClienteCEP.Visible = true;
            btnCadastrarClienteBuscarCep.Visible = true;
            txtCadastrarClienteLogradouro.Visible = true;
            txtCadastrarClienteLogradouro.Margin = new Padding(20, 0, 0, 60);
            lblCadastrarClienteNumero.Visible = true;
            lblCadastrarClienteComplemento.Visible = true;
            lblCadastrarClienteBairro.Visible = true;
            lblCadastrarClienteCidade.Visible = true;
            lblCadastrarClienteUF.Visible = true;
            txtCadastrarClienteNumero.Visible = true;
            txtCadastrarClienteComplemento.Visible = true;
            txtCadastrarClienteBairro.Visible = true;
            txtCadastrarClienteCidade.Visible = true;
            txtCadastrarClienteUF.Visible = true;
            txtCadastrarClienteUF.Margin = new Padding(20, 0, 0, 60);
            lblCadastrarClienteDDD.Visible = true;
            lblCadastrarClienteTelefone.Visible = true;
            lblCadastrarClienteCelular.Visible = true;
            lblCadastrarClienteEmail.Visible = true;
            mtxCadastrarClienteDDD.Visible = true;
            mtxCadastrarClienteTelefone.Visible = true;
            mtxCadastrarClienteCelular.Visible = true;
            txtCadastrarClienteEmail.Visible = true;
            txtCadastrarClienteEmail.Margin = new Padding(20, 0, 0, 60);
            btnCadastrarClienteMenuSalvar.Visible = true;
            btnCadastrarClienteMenuLimpar.Visible = true;
            btnCadastrarClienteMenuSair.Visible = true;
        }

        private void fecharCadastro()
        {
            if (TratamentoCampos.verificarPreenchido(flpCadastrarClienteCampos.Controls))
            {
                if (MessageBox.Show("O dados informados não serão salvos, gostaria realmente sair do cadastro?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    TratamentoCampos.limpar(flpCadastrarClienteCampos.Controls);
                    clienteBindingSource.CancelEdit();
                    Dispose();
                }
                else
                {
                    txtCadastrarClienteNome.Focus();
                }
            }
            else
            {
                clienteBindingSource.CancelEdit();
                Dispose();
            }
        }

        private void passarDados()
        {
            GetCliente.nome = txtCadastrarClienteNome.Text;
            GetCliente.cpf_cnpj = mtxCadastrarClienteCPF.Text;
            GetCliente.rg_ie = mtxCadastrarClienteRG.Text;
            GetCliente.cep = mtxCadastrarClienteCEP.Text;
            GetCliente.logradouro = txtCadastrarClienteLogradouro.Text;
            GetCliente.numero = txtCadastrarClienteNumero.Text;
            GetCliente.complemento = txtCadastrarClienteComplemento.Text;
            GetCliente.bairro = txtCadastrarClienteBairro.Text;
            GetCliente.cidade = txtCadastrarClienteCidade.Text;
            GetCliente.estado = txtCadastrarClienteUF.Text;
            GetCliente.ddd = mtxCadastrarClienteDDD.Text;
            GetCliente.telefone = mtxCadastrarClienteTelefone.Text;
            GetCliente.celular = mtxCadastrarClienteCelular.Text;
            GetCliente.email = txtCadastrarClienteEmail.Text;
            GetCliente.data_cadastro = DateTime.Now.Date;
            GetCliente.ativo = 1;

            if (cmbCadastrarClienteTipo.SelectedIndex == 0)
            {
                GetCliente.tipo = "PF";
                GetCliente.data_nascimento = dtpCadastrarClienteNascimento.Value.Date;
                GetCliente.estado_civil = cmbCadastrarClienteEstadoCivil.SelectedItem.ToString();

                if (cmbCadastrarClienteSexo.SelectedIndex == 0)
                {
                    GetCliente.sexo = 'M';
                }
                else
                {
                    GetCliente.sexo = 'F';
                }
            }
            else
            {
                GetCliente.tipo = "PJ";
                GetCliente.data_nascimento = null;
            }
        }

        #endregion

    }
}
