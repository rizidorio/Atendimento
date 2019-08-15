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
    public partial class frmConsultarProcedimentos : Form
    {
        #region Variáveis, GetProcedimento, Contrutor e formLoad

        private procedimento GetProcedimento
        {
            get
            {
                return (procedimento)procedimentoBindingSource.Current;
            }
        }

        public frmConsultarProcedimentos()
        {
            InitializeComponent();
        }

        private void FrmConsultarProcedimento_Load(object sender, EventArgs e)
        {
            MostrarLista();
            CarregarProcedimentos();
            grupoprocedimentoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.grupo_procedimento;
        }
        #endregion

        #region Botões Menu Lista
        private void BtnConsultarProcedimentosEditar_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            CarregarDados();
        }

        private void BtnConsultarProcedimentosDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este procedimento?", "Procedimentos ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (GetProcedimento.ativo == 1)
                {
                    MessageBox.Show("Este curso encontra-se ativo.\n Não foi possível excluir!", "Procedimentos");
                    btnConsultarProcedimentosEditar.Visible = false;
                    btnConsultarProcedimentosDeletar.Visible = false;
                }
                else
                {
                    procedimentoBindingSource.RemoveCurrent();
                    DataContextFactory.atendimentosDataContext.SubmitChanges();
                    MessageBox.Show("Procedimento excluído com sucesso!", "Procedimentos");
                    btnConsultarProcedimentosEditar.Visible = false;
                    btnConsultarProcedimentosDeletar.Visible = false;
                    CarregarProcedimentos();
                }
            }
        }

        private void BtnConsultarProcedimentosProcurar_Click(object sender, EventArgs e)
        {
            if (flpConsultarProcedimentosProcurar.Visible)
            {
                flpConsultarProcedimentosProcurar.Visible = false;
                mtxConsultarProcedimentosProcurarPor.Clear();
                CarregarProcedimentos();
            }
            else
            {
                flpConsultarProcedimentosProcurar.Visible = true;
                flpConsultarProcedimentosProcurar.Size = new Size(401, 48);
            }
        }

        private void BtnConsultarProcedimentosFechar_Click(object sender, EventArgs e)
        {
            procedimentoBindingSource.CancelEdit();
            Dispose();
        }
        #endregion

        #region Eventos DGV, txtValor e Keydown Form
        private void DgvConsultarProcedimentos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnConsultarProcedimentosEditar.Visible = true;
            btnConsultarProcedimentosDeletar.Visible = true;
        }

        private void FrmConsultarProcedimentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (pnlConsultarProcedimentosCampos.Visible)
                {
                    FecharEdicao();
                }
                else
                {
                    Dispose();
                }
            }
        }

        private void DgvConsultarProcedimentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
            {
                e.Value = ((grupo_procedimento)e.Value).nome;
            }
        }

        private void TxtConsultarProcedimentosValor_Leave(object sender, EventArgs e)
        {
            double valor;

            if (txtConsultarProcedimentosValor.Text == string.Empty)
            {
                valor = 0.00;
            }
            else
            {
                valor = Convert.ToDouble(txtConsultarProcedimentosValor.Text);
            }

            if (!valor.ToString().Contains(","))
            {
                txtConsultarProcedimentosValor.Text = Math.Round(valor, 2).ToString("C2");
            }

            for (int i = 0; i < valor.ToString().Length; i++)
            {
                if (valor.ToString().IndexOf(",") == valor.ToString().Length - i)
                {
                    txtConsultarProcedimentosValor.Text = Math.Round(valor, 2).ToString("C2");
                }
            }
        }

        private void TxtConsultarProcedimentosValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            TratamentoCampos.bloquearLetras(sender, e, txtConsultarProcedimentosValor.Text);
        }

        private void TxtConsultarProcedimentosValor_Enter(object sender, EventArgs e)
        {
            if (txtConsultarProcedimentosValor.Text.Contains("R$"))
            {
                txtConsultarProcedimentosValor.Text = txtConsultarProcedimentosValor.Text.Remove(0, 3);
            }
        }
        #endregion

        #region Procurar
        private void RdoConsultarProcedimentosProcurarPorNome_Click(object sender, EventArgs e)
        {
            mtxConsultarProcedimentosProcurarPor.Visible = true;
            btnConsultarProcedimentosVoltar.Visible = true;
            rdoConsultarProcedimentosProcurarInativo.Visible = false;
            rdoConsultarProcedimentosProcurarPorNome.Visible = false;
            lblConsultarProcedimentosProcurarPor.Text = "Nome:";
            mtxConsultarProcedimentosProcurarPor.Size = new Size(600, 32);
            CarregarProcedimentos();
        }
        private void RdoConsultarProcedimentosProcurarInativo_Click(object sender, EventArgs e)
        {
            procedimentoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.procedimento.Where(x => x.ativo == 0);
            mtxConsultarProcedimentosProcurarPor.Clear();
        }

        private void BtnConsultarProcedimentosVoltar_Click(object sender, EventArgs e)
        {
            mtxConsultarProcedimentosProcurarPor.Visible = false;
            btnConsultarProcedimentosVoltar.Visible = false;
            rdoConsultarProcedimentosProcurarPorNome.Visible = true;
            rdoConsultarProcedimentosProcurarInativo.Visible = true;
            lblConsultarProcedimentosProcurarPor.Text = "Procurar Por:";
            lblConsultarProcedimentosProcurarPor.Padding = new Padding(0, 0, 10, 0);
            CarregarProcedimentos();
        }

        private void MtxConsultarProcedimentosProcurarPor_TextChanged(object sender, EventArgs e)
        {
            procedimentoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.procedimento.Where(x => x.nome.Contains(mtxConsultarProcedimentosProcurarPor.Text));
        }
        #endregion

        #region Botões Campos Edição
        private void BtnConsultarProcedimentoSair_Click(object sender, EventArgs e)
        {
            FecharEdicao();
        }

        private void BtnConsultarProcedimentoLimpar_Click(object sender, EventArgs e)
        {
            TratamentoCampos.limpar(pnlConsultarProcedimentosCampos.Controls);
        }

        private void BtnConsultarProcedimentosSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacoes.validarProcedimento(txtConsultarProcedimentosNome.Text))
                {
                    procedimentoBindingSource.EndEdit();
                    PassarDados();
                    DataContextFactory.atendimentosDataContext.SubmitChanges();
                    MessageBox.Show("Procedimento alterado com sucesso!", "Procedimentos");
                    TratamentoCampos.limpar(pnlConsultarProcedimentosCampos.Controls);
                    FecharEdicao();
                    CarregarProcedimentos();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void BtnConsultarProcedimentosAddGrupo_Click(object sender, EventArgs e)
        {
            frmGrupoProcedimento frm = new frmGrupoProcedimento();
            frm.ShowDialog();
        }
        #endregion

        #region Métodos(CarregasDados, PassarDados, CarregarProcedimentos, MostrarLista, MostrarCampos e FecharEdição)
        private void CarregarDados()
        {
            txtConsultarProcedimentosNome.Text = GetProcedimento.nome;
            txtConsultarProcedimentosDescricao.Text = GetProcedimento.descricao;
            cmbConsultarProcedimentosGrupo.SelectedValue = GetProcedimento.grupo_procedimento;
            txtConsultarProcedimentosValor.Text = GetProcedimento.valor.ToString("C2");
            if(GetProcedimento.ativo == 0)
            {
                rdoConsultarProcedimentosAtivoNao.Select();
            }
            else
            {
                rdoConsultarProcedimentosAtivoSim.Select();
            }
        }

        private void PassarDados()
        {
            GetProcedimento.nome = txtConsultarProcedimentosNome.Text;
            GetProcedimento.descricao = txtConsultarProcedimentosDescricao.Text;
            GetProcedimento.grupo_procedimento = (int)cmbConsultarProcedimentosGrupo.SelectedValue;
            GetProcedimento.valor = Convert.ToDecimal(txtConsultarProcedimentosValor.Text.Remove(0, 3));
            if (rdoConsultarProcedimentosAtivoNao.Checked)
            {
                GetProcedimento.ativo = 0;
            }
            else
            {
                GetProcedimento.ativo = 1;
            }
        }

        private void CarregarProcedimentos()
        {
            procedimentoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.procedimento.Where(x => x.ativo == 1);
        }

        private void MostrarLista()
        {
            pnlConsultarProcedimentosLista.Visible = true;
            flpConsultarProcedimentosProcurar.Visible = false;
            pnlConsultarProcedimentosCampos.Visible = false;
            pnlConsultarProcedimentosLista.Dock = DockStyle.Fill;
            btnConsultarProcedimentosEditar.Visible = false;
            btnConsultarProcedimentosDeletar.Visible = false;
            procedimentoBindingSource.CancelEdit();
        }

        private void MostrarCampos()
        {
            lblConsultarProcedimentosNome.Padding = new Padding(190, 80, 0, 0);
            txtConsultarProcedimentosNome.Location = new Point(199, 112);
            lblConsultarProcedimentosDescricao.Padding = new Padding(190, 80, 0, 0);
            txtConsultarProcedimentosDescricao.Location = new Point(199, 184);
            lblConsultarProcedimentosGrupo.Padding = new Padding(190, 80, 0, 0);
            cmbConsultarProcedimentosGrupo.Location = new Point(199, 299);
            btnConsultarProcedimentosAddGrupo.Location = new Point(400, 302);
            lblConsultarProcedimentosValor.Padding = new Padding(190, 80, 0, 0);
            txtConsultarProcedimentosValor.Location = new Point(445, 299);
            grpConsultarProcedimentosAtivo.Location = new Point(581, 265);
            btnConsultarProcedimentosSalvar.Location = new Point(199, 347);
            btnConsultarProcedimentosLimpar.Location = new Point(282, 347);
            btnConsultarProcedimentosSair.Location = new Point(372, 347);
            pnlConsultarProcedimentosCampos.Visible = true;
        }

        private void FecharEdicao()
        {
            if (TratamentoCampos.verificarPreenchido(pnlConsultarProcedimentosCampos.Controls))
            {
                if (MessageBox.Show("O dados não serão salvos, gostaria realmente sair da edição?", "Procedimentos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    TratamentoCampos.limpar(pnlConsultarProcedimentosCampos.Controls);
                    MostrarLista();
                }
                else
                {
                    txtConsultarProcedimentosNome.Focus();
                }
            }
            else
            {
                MostrarLista();
            }
        }


        #endregion

    }
}
