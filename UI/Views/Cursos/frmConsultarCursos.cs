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
    public partial class frmConsultarCursos : Form
    {
        #region Variáveis, GetCurso, Construtor e Formload

        private curso GetCurso
        {
            get
            {
                return (curso)cursoBindingSource.Current;
            }
        }

        public frmConsultarCursos()
        {
            InitializeComponent();
        }

        private void FrmConsultarCursos_Load(object sender, EventArgs e)
        {
            CarregarCursos();
            grupocursoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.grupo_curso;
            pnlConsultarCursosLista.Dock = DockStyle.Fill;
        }
        #endregion

        #region Botões Menu Lista
        private void BtnConsultarCursosEditar_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            CarregarDados();
        }

        private void BtnConsultarCursosDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este curso?", "Cursos ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (GetCurso.ativo == 1)
                {
                    MessageBox.Show("Este curso encontra-se ativo.\n Não foi possível excluir!", "Cursos");
                    btnConsultarCursosDeletar.Visible = false;
                    btnConsultarCursosEditar.Visible = false;
                }
                else
                {
                    cursoBindingSource.RemoveCurrent();
                    DataContextFactory.atendimentosDataContext.SubmitChanges();
                    MessageBox.Show("Curso excluído com sucesso!", "Cursos");
                    btnConsultarCursosDeletar.Visible = false;
                    btnConsultarCursosEditar.Visible = false;
                    CarregarCursos();
                }
            }
        }

        private void BtnConsultarCursosProcurar_Click(object sender, EventArgs e)
        {
            if (flpConsultarCursosProcurar.Visible)
            {
                flpConsultarCursosProcurar.Visible = false;
                mtxConsultarCursosProcurarPor.Clear();
                CarregarCursos();
            }
            else
            {
                flpConsultarCursosProcurar.Visible = true;
                flpConsultarCursosProcurar.Size = new Size(401, 48);
            }
        }

        private void BtnConsultarCursosFechar_Click(object sender, EventArgs e)
        {
            cursoBindingSource.CancelEdit();
            Dispose();
        }
        #endregion

        #region Eventos DGV, txtInvestimento e Keydown do form
        private void DgvConsultarCursos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnConsultarCursosEditar.Visible = true;
                btnConsultarCursosDeletar.Visible = true;
            }
        }

        private void DgvConsultarCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 4)
            {
                e.Value = ((grupo_curso)e.Value).nome;
            }
        }

        private void TxtConsultarCursosInvestimento_Leave(object sender, EventArgs e)
        {
            double valor;

            if (txtConsultarCursosInvestimento.Text == string.Empty)
            {
                valor = 0.00;
            }
            else
            {
                valor = Convert.ToDouble(txtConsultarCursosInvestimento.Text);
            }


            if (!valor.ToString().Contains(","))
            {
                txtConsultarCursosInvestimento.Text = Math.Round(valor, 2).ToString("C2");
            }

            for (int i = 0; i < valor.ToString().Length; i++)
            {
                if (valor.ToString().IndexOf(",") == valor.ToString().Length - i)
                {
                    txtConsultarCursosInvestimento.Text = Math.Round(valor, 2).ToString("C2");
                }
            }
        }

        private void TxtConsultarCursosInvestimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            TratamentoCampos.bloquearLetras(sender, e, txtConsultarCursosInvestimento.Text);
        }

        private void TxtConsultarCursosInvestimento_Enter(object sender, EventArgs e)
        {
            if (txtConsultarCursosInvestimento.Text.Contains("R$"))
            {
                txtConsultarCursosInvestimento.Text = txtConsultarCursosInvestimento.Text.Remove(0, 3);
            }
        }

        private void FrmConsultarCursos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (pnlConsultarCursosCampos.Visible)
                {
                    FecharEdicao();
                }
                else
                {
                    Dispose();
                }
            }
        }
        #endregion

        #region Procurar
        private void BtnConsultarCursosVoltar_Click(object sender, EventArgs e)
        {
            mtxConsultarCursosProcurarPor.Visible = false;
            mtxConsultarCursosProcurarPor.Clear();
            btnConsultarCursosVoltar.Visible = false;
            rdoConsultarCursosProcurarPorNome.Visible = true;
            rdoConsultarCursosProcurarPorInativo.Visible = true;
            lblConsultarCursosProcurarPor.Text = "Procurar Por:";
            lblConsultarCursosProcurarPor.Padding = new Padding(0, 0, 10, 0);
            CarregarCursos();
        }

        private void RdoConsultarCursosProcurarPorNome_Click(object sender, EventArgs e)
        {
            mtxConsultarCursosProcurarPor.Visible = true;
            btnConsultarCursosVoltar.Visible = true;
            rdoConsultarCursosProcurarPorInativo.Visible = false;
            rdoConsultarCursosProcurarPorNome.Visible = false;
            lblConsultarCursosProcurarPor.Text = "Nome:";
            lblConsultarCursosProcurarPor.Padding = new Padding(0, 10, 0, 0);
            mtxConsultarCursosProcurarPor.Size = new Size(600, 32);
            CarregarCursos();
        }

        private void RdoConsultarCursosProcurarPorInativo_Click(object sender, EventArgs e)
        {
            mtxConsultarCursosProcurarPor.Clear();
            cursoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.curso.Where(x => x.ativo == 0);
        }

        private void MtxConsultarCursosProcurarPor_TextChanged(object sender, EventArgs e)
        {
            cursoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.curso.Where(x => x.nome.Contains(mtxConsultarCursosProcurarPor.Text));
        }
        #endregion

        #region Botões Campos

        private void BtnConsultarCursoSair_Click(object sender, EventArgs e)
        {
            FecharEdicao();
            btnConsultarCursosDeletar.Visible = false;
            btnConsultarCursosEditar.Visible = false;
        }

        private void BtnConsultarCursoLimpar_Click(object sender, EventArgs e)
        {
            TratamentoCampos.limpar(pnlConsultarCursosCampos.Controls);
        }

        private void BtnConsultarCursoSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacoes.validarCurso(txtConsultarCursosNome.Text))
                {
                    cursoBindingSource.EndEdit();
                    PassarDados();
                    DataContextFactory.atendimentosDataContext.SubmitChanges();
                    MessageBox.Show("Curso alterado com sucesso!", "Cursos");
                    TratamentoCampos.limpar(pnlConsultarCursosCampos.Controls);
                    FecharEdicao();
                    CarregarCursos();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void BtnConsultarCursosAddGrupo_Click(object sender, EventArgs e)
        {
            frmGrupoCurso frm = new frmGrupoCurso();
            frm.ShowDialog();
        }

        #endregion

        #region Métodos (MostrarCampos, CarregarDados, PassarDados, FecharEdicao, CarregarCursos e MostrarLista)
        private void MostrarCampos()
        {
            lblConsultarCursosNome.Padding = new Padding(180, 0, 0, 0);
            txtConsultarCursosNome.Location = new Point(193, 35);
            lblConsultarCursosDescricao.Padding = new Padding(180, 0, 0, 0);
            txtConsultarCursosDescricao.Location = new Point(193, 107);
            lblConsultarCursosGrupo.Padding = new Padding(180, 0, 0, 0);
            cmbConsultarCursosGrupo.Location = new Point(193, 217);
            btnConsultarCursosAddGrupo.Location = new Point(409, 219);
            lblConsultarCursosInvestimento.Padding = new Padding(180, 0, 0, 0);
            txtConsultarCursosInvestimento.Location = new Point(474, 217);
            lblConsultarCursosCargaHoraria.Padding = new Padding(180, 0, 0, 0);
            mtxConsultarCursosCargaHoraria.Location = new Point(193, 285);
            grpConsultarCursosAtivo.Location = new Point(409, 262);
            btnConsultarCursoSalvar.Location = new Point(193, 340);
            btnConsultarCursoLimpar.Location = new Point(283, 340);
            btnConsultarCursosSair.Location = new Point(373, 340);
            pnlConsultarCursosCampos.Visible = true;
        }

        private void CarregarDados()
        {
            txtConsultarCursosNome.Text = GetCurso.nome;
            txtConsultarCursosDescricao.Text = GetCurso.descricao;
            cmbConsultarCursosGrupo.SelectedValue = GetCurso.grupo_curso;
            mtxConsultarCursosCargaHoraria.Text = GetCurso.carga_horaria;
            txtConsultarCursosInvestimento.Text = GetCurso.investimento.ToString("C2");
            if (GetCurso.ativo == 0)
            {
                rdoConsultarCursosAtivoNao.Select();
            }
            else
            {
                rdoConsultarCursosAtivoSim.Select();
            }
        }

        private void PassarDados()
        {
            GetCurso.nome = txtConsultarCursosNome.Text;
            GetCurso.descricao = txtConsultarCursosDescricao.Text;
            GetCurso.grupo_curso = (int)cmbConsultarCursosGrupo.SelectedValue;
            GetCurso.carga_horaria = mtxConsultarCursosCargaHoraria.Text;
            GetCurso.investimento = Convert.ToDecimal(txtConsultarCursosInvestimento.Text.Remove(0, 3));
            if (rdoConsultarCursosAtivoNao.Checked)
            {
                GetCurso.ativo = 0;
            }
            else
            {
                GetCurso.ativo = 1;
            }
        }

        private void FecharEdicao()
        {
            if (TratamentoCampos.verificarPreenchido(pnlConsultarCursosCampos.Controls))
            {
                if (MessageBox.Show("O dados não serão salvos, gostaria realmente sair da edição?", "Cursos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    TratamentoCampos.limpar(pnlConsultarCursosCampos.Controls);
                    cursoBindingSource.CancelEdit();
                    MostrarLista();
                }
                else
                {
                    txtConsultarCursosNome.Focus();
                }
            }
            else
            {
                cursoBindingSource.CancelEdit();
                MostrarLista();
            }
        }

        private void CarregarCursos()
        {
            cursoBindingSource.DataSource = DataContextFactory.atendimentosDataContext.curso.Where(x => x.ativo == 1);
        }

        private void MostrarLista()
        {
            pnlConsultarCursosLista.Visible = true;
            btnConsultarCursosDeletar.Visible = false;
            btnConsultarCursosEditar.Visible = false;
            flpConsultarCursosProcurar.Visible = false;
            pnlConsultarCursosCampos.Visible = false;
        }


        #endregion


    }
}
