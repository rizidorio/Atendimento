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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        public void abrirForm<Forms>() where Forms : Form, new()
        {
            Form formulario = pnlProdutosConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                pnlProdutosConteudo.Controls.Add(formulario);
                formulario.Show();
                formulario.BringToFront();
            }
        }

        private void TsbtnProdutosCadastrar_Click(object sender, EventArgs e)
        {
            fecharFormAberto();
            pnlProdutosConteudo.Padding = new Padding(150, 80, 0, 0);
            abrirForm<frmCadastrarProduto>();
        }

        private void TsbtnProdutosFechar_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto frm = new frmCadastrarProduto();
            frm.produtoBindingSource.CancelEdit();
            Dispose();
        }

        private void TsbtnClientesMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            tsMenuProdutos.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());
        }

        private void TsbtnProdutosConsultar_Click(object sender, EventArgs e)
        {
            fecharFormAberto();
            pnlProdutosConteudo.Padding = new Padding(20);
            abrirForm<frmConsultarProdutos>();
        }

        private void fecharFormAberto()
        {
            foreach (Form f in pnlProdutosConteudo.Controls.OfType<Form>())
            {
                f.Dispose();
            }
        }
    }
}
