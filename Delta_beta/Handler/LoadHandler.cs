using CefSharp;
using Delta_beta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delta_beta.Handlers
{
    class LoadHandler : ILoadHandler
    {
        void ILoadHandler.OnFrameLoadEnd(IWebBrowser chromiumWebBrowser, FrameLoadEndEventArgs frameLoadEndArgs)
        {
           
            //---classi自動ログイン様-------------------------------------------------------------------------------///
            frameLoadEndArgs.Browser.MainFrame.EvaluateScriptAsPromiseAsync(frmBrowser.classiLoginScript);
              
        }

        void ILoadHandler.OnFrameLoadStart(IWebBrowser chromiumWebBrowser, FrameLoadStartEventArgs frameLoadStartArgs)
        {
            frameLoadStartArgs.Browser.MainFrame.EvaluateScriptAsPromiseAsync("let videos=document.getElementsByTagName('ytd-rich-item-renderer');console.log(videos.length);for (let i = 0; i < videos.length; i++){if (videos[i].textContent.includes('Full')){console.log(videos[i].textContent);}}");
            frameLoadStartArgs.Browser.MainFrame.EvaluateScriptAsPromiseAsync(Delta_beta.Properties.Settings.Default.script);
            //frameLoadStartArgs.Browser.MainFrame.EvaluateScriptAsPromiseAsync(frmBrowser.adblockScript);
        }

        void ILoadHandler.OnLoadError(IWebBrowser chromiumWebBrowser, LoadErrorEventArgs loadErrorArgs)
        {
        }

        void ILoadHandler.OnLoadingStateChange(IWebBrowser chromiumWebBrowser, LoadingStateChangedEventArgs loadingStateChangedArgs)
        {

            if (!loadingStateChangedArgs.IsLoading)
            {
                
               

               
            }
        }
    }
}
