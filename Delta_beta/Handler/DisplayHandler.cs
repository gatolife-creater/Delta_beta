using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp.Structs;
using CefSharp.Enums;
using Delta_beta;

namespace Delta_beta.Handlers
{
    class DisplayHandler : IDisplayHandler
    {
        public void OnAddressChanged(IWebBrowser chromiumWebBrowser, AddressChangedEventArgs addressChangedArgs)
        {
            //frmBrowser.displaySiteInformation();
            // アドレスバーを持つフォームを取得する。
            frmBrowser mainFrame = frmBrowser.getMainFrame(addressChangedArgs.Browser);
            if (mainFrame != null)
            {
                // UIスレッドのコンテキストで、アドレスバーの表示内容を更新する。
                //mainFrame.BeginInvoke(new Action(() =>
                //{
                //    mainFrame.update
                //
                //
                //
                //
                //    (addressChangedArgs.Address);
                //}));

                
            }
        }

        public bool OnAutoResize(IWebBrowser chromiumWebBrowser, IBrowser browser, Size newSize)
        {
            // ブラウザのデフォルト処理を行う
            return true;
        }

        public bool OnConsoleMessage(IWebBrowser chromiumWebBrowser, ConsoleMessageEventArgs consoleMessageArgs)
        {
            // コンソールにメッセージを出力する
            return false;
        }

        public void OnFaviconUrlChange(IWebBrowser chromiumWebBrowser, IBrowser browser, IList<string> urls)
        {

        }

        public void OnFullscreenModeChange(IWebBrowser chromiumWebBrowser, IBrowser browser, bool fullscreen)
        {
        }

        public void OnLoadingProgressChange(IWebBrowser chromiumWebBrowser, IBrowser browser, double progress)
        {
        }

        public void OnStatusMessage(IWebBrowser chromiumWebBrowser, StatusMessageEventArgs statusMessageArgs)
        {
        }

        public void OnTitleChanged(IWebBrowser chromiumWebBrowser, TitleChangedEventArgs titleChangedArgs)
        {
            // コントロールのトップレベルのコントロールを取得（SimpleBrowserFrame）
            //frmBrowser mainFrame = frmBrowser.getMainFrame(titleChangedArgs.Browser);

            //if (mainFrame != null)
            //{
                // 親コントロールのコンテキストでタイトル文字列を変更する。
            //    mainFrame.BeginInvoke(new Action(() =>
            //    {
                // タイトル文字列を変更する
            //    mainFrame.Text = titleChangedArgs.Title;
            //    }));
            //}
        }

        public bool OnTooltipChanged(IWebBrowser chromiumWebBrowser, ref string text)
        {
            return false;
        }

        bool IDisplayHandler.OnCursorChange(IWebBrowser chromiumWebBrowser, IBrowser browser, IntPtr cursor, CursorType type, CursorInfo customCursorInfo)
        {
            return false;
        }
    }
}
