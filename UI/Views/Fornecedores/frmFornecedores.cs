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
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            tsMenuFornecedores.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());
        }

        public void abrirForm<Forms>() where Forms : Form, new()
        {
            Form formulario = pnlFornecedoresConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                pnlFornecedoresConteudo.Controls.Add(formulario);
                formulario.Show();
                formulario.BringToFront();
            }
        }

        private void TsbtnFornecedoresCadastrar_Click(object sender, EventArgs e)
        {
            abrirForm<frmCadastrarFornecedor>();
        }

        private void TsbtnFornecedoresConsultar_Click(object sender, EventArgs e)
        {
            pnlFornecedoresConteudo.Padding = new Padding(20);
            abrirForm<frmConsultarFornecedor>(); 
        }

        private void BtnFornecedoresMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnFornecedoresFechar_Click(object sender, EventArgs e)
        {
            frmCadastrarFornecedor frmCadastrar = new frmCadastrarFornecedor();
            frmCadastrar.fornecedorBindingSource.CancelEdit();
            frmConsultarFornecedor frmConsultar = new frmConsultarFornecedor();
            frmConsultar.fornecedorBindingSource.CancelEdit();
            Dispose();
        }
    }
}
