using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace ViewLibrary.Helpers
{
    public static class LibViews
    {
        public static IHtmlString LibView(this HtmlHelper helper, string viewName, object viewModel)
        {
            return helper.Partial(viewName, viewModel);
        }    
    }
}