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
    public partial class frmConsultarCliente : Form
    {
        #region Variáveis, GetCliente, Construtor e Form load
        private string tipo;
        private int id;

        private cliente GetCliente
        {
            get
            {
                return (cliente)clienteBindingSource.Current;
            }
        }

        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {
            CarregarCliente();
            pnlConsultarClienteLista.Dock = DockStyle.Fill;
            dgvConsultarCliente.Visible = true;

        }
        #endregion

        #region Botões menu lista de clientes
        private void BtnConsultarClienteEditar_Click(object sender, EventArgs e)
        {
            pnlConsultarClienteLista.Visible = false;
            CarregarDados();
            flpConsultarClienteCampos.Visible = true;
            flpConsultarClienteCampos.Padding = new Padding(15, 50, 0, 0);
        }

        private void BtnConsultarClienteDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este cliente?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (GetCliente.ativo == 1)
                {
                    MessageBox.Show("Este cliente encontra-se ativo.\n Não foi possível excluir!", "Clientes");
                }
                else
                {
                    clienteBindingSource.RemoveCurrent();
                    DataContextFactory.atendimentosDataContext.SubmitChanges();
                    MessageBox.Show("Cliente excluído com sucesso!", "Cliente");
                    btnConsultarClienteDeletar.Visible = false;
                    btnConsultarClienteEditar.Visible = false;
                    CarregarCliente();
                    id = 0;

                    /*if (Validacoes.verificarUsoCliente(id))
                    {
                        MessageBox.Show("Existem produtos relacionados a este Cliente.\n Não foi possível excluir!", "Clientees");
                    }
                    else
                    {
                        
                    }*/
                }
            }
        }

        private void BtnConsultarClienteProcurar_Click(object sender, EventArgs e)
        {
            flpConsultarClienteProcurar.Visible = true;
            flpConsultarClienteProcurar.Size = new Size(419, 50);
        }

        private void BtnConsultarClienteFechar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            Dispose();
        }
        #endregion

        #region Botões menu editar
        private void BtnConsultarClienteMenuSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtConsultarClienteNome.Text.Trim();
            string email = txtConsultarClienteEmail.Text.Trim();

            try
            {
                if (Validacoes.validarCliente(nome))
                {
                    if (Validacoes.validarEmail(email))
                    {
                        clienteBindingSource.EndEdit();
                        PassarDados();
                        DataContextFactory.atendimentosDataContext.SubmitChanges();
                        MessageBox.Show("Cliente atualizado com sucesso!", "Clientes");
                        TratamentoCampos.limpar(flpConsultarClienteCampos.Controls);
                        FecharEdicao();
                    }
                    else
                    {
                        txtConsultarClienteEmail.Focus();
                    }
                }
                else
                {
                    txtConsultarClienteNome.Focus();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void BtnConsultarClienteMenuLimpar_Click(object sender, EventArgs e)
        {
            TratamentoCampos.limpar(flpConsultarClienteCampos.Controls);
        }

        private void BtnConsultarClienteBuscarCep_Click(object sender, EventArgs e)
        {
            string cep = mtxConsultarClienteCEP.Text.Remove(2, 1).Remove(5, 1);
            if (BuscarCep.BuscarEndereco(cep))
            {
                txtConsultarClienteBairro.Text = BuscarCep.bairro;
                txtConsultarClienteBairro.Enabled = false;
                txtConsultarClienteCidade.Text = BuscarCep.cidade;
                txtConsultarClienteCidade.Enabled = false;
                txtConsultarClienteLogradouro.Text = BuscarCep.logradouro;
                txtConsultarClienteLogradouro.Enabled = false;
                txtConsultarClienteUF.Text = BuscarCep.uf;
                txtConsultarClienteUF.Enabled = false;
                txtConsultarClienteNumero.Focus();
            }
            else
            {
                mtxConsultarClienteCEP.Focus();
            }
        }

        private void BtnConsultarClienteMenuSair_Click(object sender, EventArgs e)
        {
            FecharEdicao();
        }
        #endregion

        #region Opções de busca
        private void RdoConsultarClienteProcurarPorNome_Click(object sender, EventArgs e)
        {
            rdoConsultarClienteProcurarPorNome.Visible = false;
            rdoConsultarClienteProcurarPorInativo.Visible = false;
            rdoConsultarClienteProcurarPorCNPJ.Visible = false;
            rdoConsultarClienteProcurarPorCPF.Visible = false;
            lblConsultarClienteProcurarPor.Text = "Nome:";
            lblConsultarClienteProcurarPor.Margin = new Padding(0, 10, 0, 10);
            mtxConsultarClienteProcurarPor.Visible = true;
            mtxConsultarClienteProcurarPor.Size = new Size(400, 32);
            btnConsultarClienteVoltar.Visible = true;
        }

        private void RdoConsultarClienteProcurarPorInativo_Click(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = DataContextFactory.atendimentosDataContext.cliente.Where(x => x.ativo == 0);
        }

        private void RdoConsultarClienteProcurarPorCNPJ_Click(object sender, EventArgs e)
        {
            rdoConsultarClienteProcurarPorNome.Visible = false;
            rdoConsultarClienteProcurarPorInativo.Visible = false;
            rdoConsultarClienteProcurarPorCNPJ.Visible = false;
            rdoConsultarClienteProcurarPorCPF.Visible = false;
            lblConsultarClienteProcurarPor.Text = "CNPJ:";
            lblConsultarClienteProcurarPor.Margin = new Padding(0, 10, 0, 10);
            mtxConsultarClienteProcurarPor.Visible = true;
            mtxConsultarClienteProcurarPor.Size = new Size(400, 32);
            mtxConsultarClienteProcurarPor.Mask = "00,000,000/0000-00";
            clienteBindingSource.DataSource = DataContextFactory.atendimentosDataContext.cliente.Where(x => x.tipo == "PJ");
            btnConsultarClienteVoltar.Visible = true;
        }

        private void RdoConsultarClienteProcurarPorCPF_Click(object sender, EventArgs e)
        {
            rdoConsultarClienteProcurarPorNome.Visible = false;
            rdoConsultarClienteProcurarPorInativo.Visible = false;
            rdoConsultarClienteProcurarPorCNPJ.Visible = false;
            rdoConsultarClienteProcurarPorCPF.Visible = false;
            lblConsultarClienteProcurarPor.Text = "CPF:";
            lblConsultarClienteProcurarPor.Margin = new Padding(0, 10, 0, 10);
            mtxConsultarClienteProcurarPor.Visible = true;
            mtxConsultarClienteProcurarPor.Size = new Size(400, 32);
            mtxConsultarClienteProcurarPor.Mask = "000,000,000-00";
            clienteBindingSource.DataSource = DataContextFactory.atendimentosDataContext.cliente.Where(x => x.tipo == "PF");
            btnConsultarClienteVoltar.Visible = true;
        }

        private void BtnConsultarClienteVoltar_Click(object sender, EventArgs e)
        {
            rdoConsultarClienteProcurarPorNome.Visible = true;
            rdoConsultarClienteProcurarPorInativo.Visible = true;
            rdoConsultarClienteProcurarPorCNPJ.Visible = true;
            rdoConsultarClienteProcurarPorCPF.Visible = true;
            lblConsultarClienteProcurarPor.Text = "Procurar por:";
            lblConsultarClienteProcurarPor.Margin = new Padding(0, 0, 0, 0);
            mtxConsultarClienteProcurarPor.Visible = false;
            mtxConsultarClienteProcurarPor.Clear();
            mtxConsultarClienteProcurarPor.Mask = "";
            btnConsultarClienteVoltar.Visible = false;
            clienteBindingSource.DataSource = DataContextFactory.atendimentosDataContext.cliente;
        }

        private void MtxConsultarClienteProcurarPor_TextChanged(object sender, EventArgs e)
        {
            if (rdoConsultarClienteProcurarPorNome.Checked)
            {
                clienteBindingSource.DataSource = DataContextFactory.atendimentosDataContext.cliente.Where(x => x.nome.Contains(mtxConsultarClienteProcurarPor.Text));
            }
            else if (rdoConsultarClienteProcurarPorCNPJ.Checked)
            {
                if (mtxConsultarClienteProcurarPor.Text != "  .   .   /    -")
                {
                    clienteBindingSource.DataSource = DataContextFactory.atendimentosDataContext.cliente.Where(x => x.tipo == "PJ" && x.cpf_cnpj == mtxConsultarClienteProcurarPor.Text);
                }
                else
                {
                    clienteBindingSource.DataSource = DataContextFactory.atendimentosDataContext.cliente.Where(x => x.tipo == "PJ");
                }
            }
            else if (rdoConsultarClienteProcurarPorCPF.Checked)
            {
                if (mtxConsultarClienteProcurarPor.Text != "   .   .   -")
                {
                    clienteBindingSource.DataSource = DataContextFactory.atendimentosDataContext.cliente.Where(x => x.tipo == "PF" && x.cpf_cnpj == mtxConsultarClienteProcurarPor.Text);
                }
                else
                {
                    clienteBindingSource.DataSource = DataContextFactory.atendimentosDataContext.cliente.Where(x => x.tipo == "PF");
                }
            }
        }
        #endregion

        #region DataGrid e mtxTelefone
        private void MtxConsultarClienteTelefone_Leave(object sender, EventArgs e)
        {
            if (mtxConsultarClienteTelefone.Text.Length == 9)
            {
                mtxConsultarClienteTelefone.Mask = "0000-0000";
            }
        }
        private void DgvConsultarCliente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tipo = GetCliente.tipo;
            id = GetCliente.codigo;
            btnConsultarClienteEditar.Visible = true;
            btnConsultarClienteDeletar.Visible = true;
        }
        #endregion

        #region Métodos(FecharEdicao, PassarDados, CarregarDados e CarragarClientes
        private void FecharEdicao()
        {
            if (TratamentoCampos.verificarPreenchido(flpConsultarClienteCampos.Controls))
            {
                if (MessageBox.Show("O dados informados não serão salvos, gostaria realmente sair da edição?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    TratamentoCampos.limpar(flpConsultarClienteCampos.Controls);
                    clienteBindingSource.CancelEdit();
                }
                else
                {
                    txtConsultarClienteNome.Focus();
                    return;
                }
            }
            else
            {
                clienteBindingSource.CancelEdit();
            }

            flpConsultarClienteCampos.Visible = false;
            btnConsultarClienteEditar.Visible = false;
            btnConsultarClienteDeletar.Visible = false;
            pnlConsultarClienteLista.Visible = true;
        }

        private void PassarDados()
        {
            //dados Cliente
            GetCliente.nome = txtConsultarClienteNome.Text.Trim();
            GetCliente.cpf_cnpj = mtxConsultarClienteCPF.Text;
            GetCliente.rg_ie = mtxConsultarClienteRG.Text;
            GetCliente.cep = mtxConsultarClienteCEP.Text;
            GetCliente.logradouro = txtConsultarClienteLogradouro.Text.Trim();
            GetCliente.numero = txtConsultarClienteNumero.Text.Trim();
            GetCliente.complemento = txtConsultarClienteComplemento.Text.Trim();
            GetCliente.bairro = txtConsultarClienteBairro.Text.Trim();
            GetCliente.cidade = txtConsultarClienteCidade.Text.Trim();
            GetCliente.estado = txtConsultarClienteUF.Text.Trim();
            GetCliente.ddd = mtxConsultarClienteDDD.Text;
            GetCliente.telefone = mtxConsultarClienteTelefone.Text;
            GetCliente.celular = mtxConsultarClienteCelular.Text;
            GetCliente.email = txtConsultarClienteEmail.Text.Trim();
            GetCliente.tipo = tipo;

            if (rdoConsultarClienteAtivoSim.Checked)
            {
                GetCliente.ativo = 1;
            }
            else
            {
                GetCliente.ativo = 0;
            }
        }

        private void CarregarDados()
        {
            txtConsultarClienteNome.Text = GetCliente.nome;
            mtxConsultarClienteCPF.Text = GetCliente.cpf_cnpj;
            mtxConsultarClienteRG.Text = GetCliente.rg_ie;

            if (GetCliente.sexo == 'F')
            {
                cmbConsultarClienteSexo.Text = "Feminino";
            }
            else if (GetCliente.sexo == 'M')
            {
                cmbConsultarClienteSexo.Text = "Masculino";
            }
            else
            {
                cmbConsultarClienteSexo.SelectedIndex = -1;
            }

            mtxConsultarClienteCEP.Text = GetCliente.cep;
            txtConsultarClienteLogradouro.Text = GetCliente.logradouro;
            txtConsultarClienteNumero.Text = GetCliente.numero;
            txtConsultarClienteComplemento.Text = GetCliente.complemento;
            txtConsultarClienteBairro.Text = GetCliente.bairro;
            txtConsultarClienteCidade.Text = GetCliente.cidade;
            txtConsultarClienteUF.Text = GetCliente.estado;
            mtxConsultarClienteDDD.Text = GetCliente.ddd;

            if (GetCliente.telefone.Length == 9)
            {
                mtxConsultarClienteTelefone.Mask = "0000-0000";
            }

            mtxConsultarClienteTelefone.Text = GetCliente.telefone;
            mtxConsultarClienteCelular.Text = GetCliente.celular;
            txtConsultarClienteEmail.Text = GetCliente.email;

            if (GetCliente.tipo == "PJ")
            {
                lblConsultarClienteCPF.Text = "CNPJ";
                lblConsultarClienteRG.Text = "IE";
                lblConsultarClienteRG.Margin = new Padding(167, 0, 0, 0);
                lblConsultarClienteCEP.Margin = new Padding(133, 0, 0, 0);
                mtxConsultarClienteCPF.Mask = "00,000,000/0000-00";
                mtxConsultarClienteRG.Mask = "";
                dtpConsultarClienteNascimento.Value = DateTime.Now.Date;
                dtpConsultarClienteNascimento.Enabled = false;
                cmbConsultarClienteEstadoCivil.Enabled = false;
                cmbConsultarClienteEstadoCivil.SelectedIndex = -1;
                cmbConsultarClienteSexo.Enabled = false;
            }
            else
            {
                dtpConsultarClienteNascimento.Value = (DateTime)GetCliente.data_nascimento;
                cmbConsultarClienteEstadoCivil.Text = GetCliente.estado_civil;
            }

            if (GetCliente.ativo == 0)
            {
                rdoConsultarClienteAtivoNao.Select();
            }
            else
            {
                rdoConsultarClienteAtivoSim.Select();
            }
        }

        private void CarregarCliente()
        {
            clienteBindingSource.DataSource = DataContextFactory.atendimentosDataContext.cliente.Where(x => x.ativo == 1);
        }
        #endregion
    }
}
