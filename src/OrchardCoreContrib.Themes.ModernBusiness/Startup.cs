using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Liquid;
using OrchardCore.Modules;
using OrchardCore.ResourceManagement;
using OrchardCoreContrib.Themes.ModernBusiness.Drivers;
using OrchardCoreContrib.Themes.ModernBusiness.Liquid;

namespace OrchardCoreContrib.Themes.ModernBusiness;

public class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<IConfigureOptions<ResourceManagementOptions>, ResourceManagementOptionsConfiguration>();
        serviceCollection.AddScoped<IContentDisplayDriver, RedirectAgentContentDisplayDriver>();
    }
}

[RequireFeatures("OrchardCore.Liquid")]
public class LiquidStartup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddLiquidFilter<TagBuilderFilter>("tag_builder");
    }
}
