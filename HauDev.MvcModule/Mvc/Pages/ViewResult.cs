namespace HauDev.MvcModule.Mvc.Pages
{
    public class ViewResult : IHtml
    {
        public string ToHtmlString()
        {
            return this.ToString();
        }
    }
}
