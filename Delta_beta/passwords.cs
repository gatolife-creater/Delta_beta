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
    public partial class passwords : Form
    {
        //public string classi_id;
        //public string classi_password;

        public passwords()
        {
            InitializeComponent();
        }

        private void passwords_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.classi_id = ClassiIdtextBox.Text;
            Properties.Settings.Default.classi_password = ClassiPasswordtextBox.Text;
            frmBrowser.classiLoginScript = @"let input_id = document.getElementById('classi_id');input_id.value = '" + Properties.Settings.Default.classi_id + "';let input_password = document.getElementById('password');input_password.value = '" + Properties.Settings.Default.classi_password + "';let enter_button = document.getElementsByClassName('pen-mod-btn')[0];enter_button.click();";
            Properties.Settings.Default.Save();
        }

        private void passwords_Load(object sender, EventArgs e)
        {
            ClassiIdtextBox.Text = Properties.Settings.Default.classi_id;
            ClassiPasswordtextBox.Text = Properties.Settings.Default.classi_password;
        }
    }
}
