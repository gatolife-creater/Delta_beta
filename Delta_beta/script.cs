using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delta_beta
{
    public partial class script : Form
    {
        public string flexible_script;
        public script()
        {
            InitializeComponent();
            
        }

        private void script_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.script = scriptBox.Text;
            flexible_script=scriptBox.Text;
            Properties.Settings.Default.Save();
        }

        private void script_Load(object sender, EventArgs e)
        {
            scriptBox.Text = Properties.Settings.Default.script;
        }
    }
}
