using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public class CustomProfessionalColors : ProfessionalColorTable
    {
        public override Color ToolStripGradientBegin => Color.MintCream;

        public override Color ToolStripGradientMiddle => Color.MintCream;

        public override Color ToolStripGradientEnd => Color.MintCream;

        public override Color MenuStripGradientBegin => Color.MintCream;

        public override Color MenuStripGradientEnd => Color.MintCream;

        public override Color MenuItemSelected => Color.MediumAquamarine;

        public override Color MenuItemBorder => Color.MediumAquamarine;

        public override Color ButtonSelectedBorder => Color.MediumAquamarine;

        public override Color ButtonSelectedGradientBegin => Color.MediumAquamarine;

        public override Color ButtonSelectedGradientEnd => Color.MediumAquamarine;

        public override Color ButtonSelectedGradientMiddle => Color.MediumAquamarine;
    }
}
