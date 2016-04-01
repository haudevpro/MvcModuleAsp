using System.Web.Routing;

namespace HauDev.MvcModule
{
    /// <summary>
    /// IController
    /// </summary>
    public interface IController:IHWeb
    {
        void Execute(RequestContext requestContext);
    }
}
