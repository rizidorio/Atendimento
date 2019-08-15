using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public static class TratamentoCampos
    {
        public static void limpar(Control.ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Clear();
                }
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
            }
        }

        public static void bloquear(Control.ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Enabled = false;
                }

                if (control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Enabled = false;
                }

                if (control is ComboBox)
                {
                    ((ComboBox)control).Enabled = false;
                }

                if (control is GroupBox)
                {
                    ((GroupBox)control).Enabled = false;
                }

                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Enabled = false;
                }
            }
        }

        public static void desbloquear(Control.ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Enabled = true;
                }

                if (control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Enabled = true;
                }

                if (control is ComboBox)
                {
                    ((ComboBox)control).Enabled = true;
                }

                if (control is GroupBox)
                {
                    ((GroupBox)control).Enabled = true;
                }

                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Enabled = true;
                }
            }
        }

        public static bool verificarPreenchido(Control.ControlCollection controles)
        {
            foreach(Control control in controles)
            {
                if(control is TextBox)
                {
                    if(((TextBox)control).TextLength > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public static void bloquearLetras(object sender, KeyPressEventArgs e, string valor)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                int count = valor.Split(',').Length - 1;

                if (valor.Length == 0 || count > 0)
                {
                    e.Handled = true;
                }

                if (!valor.Contains("."))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }
    }
}
