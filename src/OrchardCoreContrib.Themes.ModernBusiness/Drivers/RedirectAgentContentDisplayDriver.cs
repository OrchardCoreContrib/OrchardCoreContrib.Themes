using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.DisplayManagement.Views;
using OrchardCore.DisplayManagement.Handlers;

namespace OrchardCore.Themes.TheModernBusinessTheme
{
    public class RedirectAgentContentDisplayDriver : ContentDisplayDriver
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUrlHelperFactory _urlHelperFactory;

        public RedirectAgentContentDisplayDriver(IHttpContextAccessor httpContextAccessor, IUrlHelperFactory urlHelperFactory)
        {
            _httpContextAccessor = httpContextAccessor;
            _urlHelperFactory = urlHelperFactory;
        }

        public override Task<IDisplayResult> DisplayAsync(ContentItem model, BuildDisplayContext context)
        {
            if (model.ContentType == "RedirectAgent" && context.DisplayType == "Detail")
            {
                string targetUrl = model.Content.RedirectAgent.TargetUrl.Text;
                targetUrl = _urlHelperFactory.GetUrlHelper(new ActionContext(_httpContextAccessor.HttpContext, new RouteData(), new ActionDescriptor())).Content(targetUrl);
                _httpContextAccessor.HttpContext.Response.Redirect(targetUrl);
            }

            return Task.FromResult<IDisplayResult>(null);
        }
    }
}
