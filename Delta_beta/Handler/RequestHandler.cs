using CefSharp;
using Delta_beta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delta_beta.Handlers
{
    class RequestHandler : IRequestHandler
    {
        public bool GetAuthCredentials(IWebBrowser chromiumWebBrowser, IBrowser browser, string originUrl, bool isProxy, string host, int port, string realm, string scheme, IAuthCallback callback)
        {
            // コントロールのトップレベルのコントロールを取得（SimpleBrowserFrame）
            frmBrowser mainFrame = frmBrowser.getMainFrame(browser);

            if (mainFrame != null)
            {
                // 親コントロールのコンテキストで非同期にダイアログを表示する。
                mainFrame.BeginInvoke(new Action(() =>
                {
                    // ログオンダイアログを表示する
                    AuthDialog dlg = new AuthDialog();
                    DialogResult ret = dlg.ShowDialog();

                    if (ret == DialogResult.OK)
                    {
                        // 入力されたユーザ名とパスワードで認証を継続する。
                        callback.Continue(dlg.UserName, dlg.Password);
                    }
                    else
                    {
                        // 認証処理をキャンセルする。
                        callback.Cancel();
                    }
                }));
            }
            else
            {
                // 認証処理をキャンセルする。
                callback.Cancel();
            }

            return true;
        }

        public IResourceRequestHandler GetResourceRequestHandler(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
        {
            return null;
        }

        public bool OnBeforeBrowse(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool userGesture, bool isRedirect)
        {


            if (request.Url.StartsWith("                  "))
            {
                //ナビゲーションを中止する
                return true;
            }
            //else if (request.Url.StartsWith("https://www.youtube.com/watch?v="))
            //{
            //    string url = request.Url;

                //url =frmBrowser.get_video_id(url);
                //url =frmBrowser.change_to_nocookie_url(url);
                //request.Url = frmBrowser.change_to_nocookie_url(frmBrowser.get_video_id("https"));
            //}
            else
            {
                // ナビゲーションを許可する
                return false;

            }
        }

        

        public bool OnCertificateError(IWebBrowser chromiumWebBrowser, IBrowser browser, CefErrorCode errorCode, string requestUrl, ISslInfo sslInfo, IRequestCallback callback)
        {
            // 証明書エラーでも継続する
            callback.Continue(true);
            return true;
        }

        public void OnDocumentAvailableInMainFrame(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
        }

        public bool OnOpenUrlFromTab(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, string targetUrl, WindowOpenDisposition targetDisposition, bool userGesture)
        {
            // Ctrl+左クリックでの別Tab表示は許可しない。
            return false;
        }

        public void OnPluginCrashed(IWebBrowser chromiumWebBrowser, IBrowser browser, string pluginPath)
        {
        }

        public bool OnQuotaRequest(IWebBrowser chromiumWebBrowser, IBrowser browser, string originUrl, long newSize, IRequestCallback callback)
        {
            // クオータの要求は常に許可する。
            callback.Continue(true);
            return true;
        }

        public void OnRenderProcessTerminated(IWebBrowser chromiumWebBrowser, IBrowser browser, CefTerminationStatus status)
        {
        }

        public void OnRenderViewReady(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
        }

        public bool OnSelectClientCertificate(IWebBrowser chromiumWebBrowser, IBrowser browser, bool isProxy, string host, int port, X509Certificate2Collection certificates, ISelectClientCertificateCallback callback)
        {
            // デフォルトのクライアント証明書の選択方法とする。
            return false;
        }
    }
}
