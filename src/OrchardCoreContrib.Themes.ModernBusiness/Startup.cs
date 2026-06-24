using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Liquid;
using OrchardCore.Modules;
using OrchardCoreContrib.Themes.ModernBusiness.Drivers;
using OrchardCoreContrib.Themes.ModernBusiness.Liquid;

namespace OrchardCoreContrib.Themes.ModernBusiness;

public class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddResourceConfiguration<ResourceManagementOptionsConfiguration>();

        services.AddScoped<IContentDisplayDriver, RedirectAgentContentDisplayDriver>();
    }
}

[RequireFeatures("OrchardCore.Liquid")]
public class LiquidStartup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
        => services.AddLiquidFilter<TagBuilderFilter>("tag_builder");
}
