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
    public partial class frmInicio : Form
    {
        private static int botaoClicado = 0;

        public frmInicio()
        {
            InitializeComponent();
        }

        private void BtnInicioMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnInicioFechar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente fechar o sistema?", "Sistema de Gerenciamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void BtnMenuInicioClientes_Click(object sender, EventArgs e)
        {
            botaoClicado = 1;
            fecharFormAberto();
            abrirForm<frmClientes>();
        }

        private void BtnMenuInicioFornecedores_Click(object sender, EventArgs e)
        {
            botaoClicado = 2;
            fecharFormAberto();
            abrirForm<frmFornecedores>();
        }

        private void BtnMenuInicioProdutos_Click(object sender, EventArgs e)
        {
            botaoClicado = 3;
            fecharFormAberto();
            abrirForm<frmProdutos>();
        }

        private void BtnMenuInicioCursos_Click(object sender, EventArgs e)
        {
            botaoClicado = 4;
            fecharFormAberto();
            abrirForm<frmCursos>();
        }

        private void BtnMenuInicioProcedimentos_Click(object sender, EventArgs e)
        {
            botaoClicado = 5;
            fecharFormAberto();
            abrirForm<frmProcedimentos>();
        }

        private void PnlInicioConteudo_ControlRemoved(object sender, ControlEventArgs e)
        {
            if(pnlInicioConteudo.Controls.Count == 0)
            {
                foreach (Control control in pnlInicioMenu.Controls.OfType<Button>())
                {
                    control.Enabled = true;
                    control.BackColor = Color.MintCream;
                }
            }
        }

        private void PnlInicioConteudo_ControlAdded(object sender, ControlEventArgs e)
        {
            switch (botaoClicado)
            {
                case 1:
                    btnMenuInicioClientes.Enabled = false;
                    break;
                case 2:
                    btnMenuInicioFornecedores.Enabled = false;
                    break;
                case 3:
                    btnMenuInicioProdutos.Enabled = false;
                    break;
                case 4:
                    btnMenuInicioCursos.Enabled = false;
                    break;
                case 5:
                    btnMenuInicioProcedimentos.Enabled = false;
                    break;
            }
        }

        public void abrirForm<Forms>() where Forms : Form, new()
        {
            Form formulario = pnlInicioConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                pnlInicioConteudo.Controls.Add(formulario);
                formulario.Show();
                formulario.BringToFront();
            }
        }

        private void fecharFormAberto()
        {
            foreach (Form f in pnlInicioConteudo.Controls.OfType<Form>())
            {
                f.Dispose();
            }
        }
    }
}
