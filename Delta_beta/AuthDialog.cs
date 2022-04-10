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
    public partial class AuthDialog : Form
    {
        /// <summary>
        /// ダイアログに入力されたユーザ名
        /// </summary>
        public String UserName { get; private set; }

        /// <summary>
        /// ダイアログに入力されたパスワード
        /// </summary>
        public String Password { get; private set; }

        public AuthDialog()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            // 確定したユーザ名とパスワードをプロパティに設定する。
            UserName = userNameTxt.Text;
            Password = passwordTxt.Text;
        }
    }
}
