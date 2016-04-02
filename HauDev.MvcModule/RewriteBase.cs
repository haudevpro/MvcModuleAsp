using System;
using System.Web;
using System.Web.SessionState;

namespace HauDev.MvcModule
{
    public class RewriteBase : IHttpHandlerFactory, IRequiresSessionState
    {
        public IHttpHandler GetHandler(HttpContext context, string requestType, string url, string pathTranslated)
        {
            return context.Handler;
        }

        public void ReleaseHandler(IHttpHandler handler)
        {
           
        }
    }
}
