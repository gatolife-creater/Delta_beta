using CefSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_beta.Handlers
{
    class DownloadHandler : IDownloadHandler
    {
        void IDownloadHandler.OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            // ファイル保存ダイアログを表示する。
            // 最初に表示される保存先とファイル名はCefSharpに任せる。
            callback.Continue("", true);
        }

        void IDownloadHandler.OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            //throw new NotImplementedException();
        }
    }
}

