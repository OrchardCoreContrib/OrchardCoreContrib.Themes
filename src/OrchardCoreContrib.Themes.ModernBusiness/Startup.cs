using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Liquid;
using OrchardCore.Modules;
using OrchardCore.ResourceManagement;

namespace OrchardCore.Themes.TheModernBusinessTheme
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IResourceManifestProvider, ResourceManifest>();
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
}
