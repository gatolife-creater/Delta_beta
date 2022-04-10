using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_beta.Handler
{
    internal class ResourceRequestHandlerFactory : IResourceRequestHandlerFactory
    {
        bool IResourceRequestHandlerFactory.HasHandlers => throw new NotImplementedException();

        IResourceRequestHandler IResourceRequestHandlerFactory.GetResourceRequestHandler(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
        {
            throw new NotImplementedException();
        }
    }
}
