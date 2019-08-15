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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        public void abrirForm<Forms>() where Forms : Form, new()
        {
            Form formulario = pnlClientesConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                pnlClientesConteudo.Controls.Add(formulario);
                formulario.Show();
                formulario.BringToFront();
            }
        }

        private void TsbtnClientesConsultar_Click(object sender, EventArgs e)
        {
            fecharFormAberto();
            pnlClientesConteudo.Padding = new Padding(20);
            abrirForm<frmConsultarCliente>();
        }

        private void TsbtnClientesCadastrar_Click(object sender, EventArgs e)
        {
            fecharFormAberto();
            abrirForm<frmCadastrarCliente>();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            tsMenuClientes.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());
        }

        private void BtnClientesMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnClientesFechar_Click(object sender, EventArgs e)
        {
            frmCadastrarCliente frm = new frmCadastrarCliente();
            frm.clienteBindingSource.CancelEdit();
            Dispose();
        }

        private void fecharFormAberto()
        {
            foreach (Form f in pnlClientesConteudo.Controls.OfType<Form>())
            {
                f.Dispose();
            }
        }
    }
}
