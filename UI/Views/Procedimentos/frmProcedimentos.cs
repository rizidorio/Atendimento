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
    public partial class frmProcedimentos : Form
    {
        public frmProcedimentos()
        {
            InitializeComponent();
        }

        public void abrirForm<Forms>() where Forms : Form, new()
        {
            Form formulario = pnlProcedimentosConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                pnlProcedimentosConteudo.Controls.Add(formulario);
                formulario.Show();
                formulario.BringToFront();
            }
        }

        private void TsbtnProcedimentosFechar_Click(object sender, EventArgs e)
        {
            frmCadastrarProcedimento frm = new frmCadastrarProcedimento();
            frm.procedimentoBindingSource.CancelEdit();
            Dispose();
        }

        private void TsbtnProcedimentosMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmProcedimentos_Load(object sender, EventArgs e)
        {
            tsMenuProcedimentos.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());
        }

        private void TsbtnProcedimentosConsultar_Click(object sender, EventArgs e)
        {
            fecharFormAberto();
            pnlProcedimentosConteudo.Padding = new Padding(20);
            abrirForm<frmConsultarProcedimentos>();
        }

        private void fecharFormAberto()
        {
            foreach (Form f in pnlProcedimentosConteudo.Controls.OfType<Form>())
            {
                f.Dispose();
            }
        }

        private void ProcedimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fecharFormAberto();
            pnlProcedimentosConteudo.Padding = new Padding(180, 80, 0, 0);
            abrirForm<frmCadastrarProcedimento>();
        }

        private void GrupoDeProcedimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fecharFormAberto();
            pnlProcedimentosConteudo.Padding = new Padding(220, 110, 290, 240);
            abrirForm<frmGrupoProcedimento>();
        }
    }
}
