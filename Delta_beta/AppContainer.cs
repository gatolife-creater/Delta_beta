using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
using CefSharp.WinForms; // <- 追加


namespace Delta_beta
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);

        }

        //Handle the method CreateTab that allows the user to create a new Tabs
        //on your app when cliking 

        //これを開発者機能等にも活用したい

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {


                Content = new frmBrowser
                {
                    Text = "New Tab",
                }
            };


        }
    }
}
  