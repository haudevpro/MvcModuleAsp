using System.Web.Routing;

namespace HauDev.MvcModule.Mvc
{
    public class HController : IController, IHWeb
    {
        public void Execute(RequestContext requestContext)
        {
            var response = requestContext.HttpContext.Response;
            response.ContentType = "text/plain";
            response.Write("Hello World");
        }
    }
}
