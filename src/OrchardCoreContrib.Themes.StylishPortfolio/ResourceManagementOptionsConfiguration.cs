using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace OrchardCoreContrib.Themes.StylishPortfolio;

public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
{
    private static readonly ResourceManifest _manifest;

    static ResourceManagementOptionsConfiguration()
    {
        _manifest = new ResourceManifest();

        _manifest
            .DefineScript("stylish-portfolio")
            .SetUrl("~/OrchardCoreContrib.Themes.StylishPortfolio/js/scripts.js")
            .SetVersion("1.0.0")
            .SetDependencies("bootstrap-bundle", "font-awesome");

        _manifest
            .DefineStyle("stylish-portfolio")
            .SetUrl("~/OrchardCoreContrib.Themes.StylishPortfolio/css/styles.css")
            .SetVersion("1.0.0");

        _manifest
            .DefineStyle("simple-line-icons")
            .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/simple-line-icons/2.5.5/css/simple-line-icons.min.css")
            .SetVersion("2.5.5");
    }

    public void Configure(ResourceManagementOptions options) => options.ResourceManifests.Add(_manifest);
}
