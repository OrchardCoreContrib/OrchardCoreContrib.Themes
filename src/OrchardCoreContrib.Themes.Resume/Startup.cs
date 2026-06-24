using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace OrchardCoreContrib.Themes.Resume;

public class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
        => services.AddResourceConfiguration<ResourceManagementOptionsConfiguration>();
}
