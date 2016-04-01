using System.Configuration;
using System.Web;

namespace HauDev.MvcModule.Mvc
{
    public class HApplication : IHttpHandler
    {
        private string preModule;
        /// <summary>
        ///  Module Path
        /// </summary>
        protected string PreModule
        {
            get
            {
                if (string.IsNullOrEmpty(preModule))
                    preModule = ConfigurationManager.AppSettings["ModulePath"];
                if (string.IsNullOrEmpty(preModule))
                    preModule = "Modules";
                return preModule;
            }
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write(string.Format("<a href='{0}'>Xin chào</a>{1}", PreModule, context.Request.Url.Query));
        }
    }
}
