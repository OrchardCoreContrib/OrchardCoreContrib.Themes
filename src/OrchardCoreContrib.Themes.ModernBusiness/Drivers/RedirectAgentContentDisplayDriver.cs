using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.DisplayManagement.Handlers;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;

namespace OrchardCoreContrib.Themes.ModernBusiness.Drivers;

public class RedirectAgentContentDisplayDriver(IHttpContextAccessor httpContextAccessor, IUrlHelperFactory urlHelperFactory) : ContentDisplayDriver
{
    public override Task<IDisplayResult> DisplayAsync(ContentItem model, BuildDisplayContext context)
    {
        if (model.ContentType == "RedirectAgent" && context.DisplayType == "Detail")
        {
            var targetUrl = model.Content.RedirectAgent.TargetUrl.Text;
            
            targetUrl = urlHelperFactory.GetUrlHelper(new ActionContext(httpContextAccessor.HttpContext, new RouteData(), new ActionDescriptor())).Content(targetUrl);
            
            httpContextAccessor.HttpContext.Response.Redirect(targetUrl);
        }

        return Task.FromResult<IDisplayResult>(null);
    }
}
