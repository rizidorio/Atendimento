using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmCursos : Form
    {
        public frmCursos()
        {
            InitializeComponent();
        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {
            tsMenuCursos.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());
        }

        private void TsbtnCursosConsultar_Click(object sender, EventArgs e)
        {
            fecharFormAberto();
            pnlCursosConteudo.Padding = new Padding(20);
            abrirForm<frmConsultarCursos>();
        }

        private void BtnCursosMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnCursosFechar_Click(object sender, EventArgs e)
        {
            frmCadastrarCursos frmCadastrar = new frmCadastrarCursos();
            frmConsultarCursos frmConsultar = new frmConsultarCursos();
            frmCadastrar.cursoBindingSource.CancelEdit();
            frmConsultar.cursoBindingSource.CancelEdit();
            Dispose();
        }

        private void TsmiCursosCadastrarCurso_Click(object sender, EventArgs e)
        {
            fecharFormAberto();
            pnlCursosConteudo.Padding = new Padding(180, 50, 0, 0);
            abrirForm<frmCadastrarCursos>();
        }

        private void TsmiCursosCadastrarGrupoCursos_Click(object sender, EventArgs e)
        {
            fecharFormAberto();
            pnlCursosConteudo.Padding = new Padding(220, 120, 300, 210);
            abrirForm<frmGrupoCurso>();
        }

        public void abrirForm<Forms>() where Forms : Form, new()
        {
            Form formulario = pnlCursosConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                pnlCursosConteudo.Controls.Add(formulario);
                formulario.Show();
                formulario.BringToFront();
            }
        }

        private void fecharFormAberto()
        {
            foreach (Form f in pnlCursosConteudo.Controls.OfType<Form>())
            {
                f.Dispose();
            }
        }
    }
}
