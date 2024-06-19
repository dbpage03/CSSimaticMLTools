using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSimaticMLTools
{
    public partial class ScriptHelp : Form
    {
        public ScriptHelp()
        {
            InitializeComponent();
        }

        private void ScriptHelp_Deactivate(object sender, EventArgs e)
        {
            Close();
        }
    }
}
