using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delta_beta.Handlers;
using System.Windows.Forms;
using Delta_beta;
using EasyTabs;

namespace bartest
{
    static class Program
    {

        
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            AppContainer container = new AppContainer();


            //---最初に開かれるフォーム----------------------------------------------------------------------------------------///
            container.Tabs.Add(
                new TitleBarTab(container)
                {
                    Content = new frmBrowser
                    {
                        Text = "New Tab",


                    }
                    //Content = new setting
                    //{
                    //    Text = "Setting",

                    //}
                }
            );

            container.SelectedTabIndex = 0;

            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);

            

            Application.Run(applicationContext);

            
        }
    }
}
