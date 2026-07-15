using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace OrchardCoreContrib.Themes.Personal;

public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
{
    private static readonly ResourceManifest _manifest;

    static ResourceManagementOptionsConfiguration()
    {
        _manifest = new ResourceManifest();

        _manifest
            .DefineStyle("BootstrapIcons")
            .SetUrl("https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.1/font/bootstrap-icons.css")
            .SetVersion("1.8.1");

        _manifest
            .DefineScript("ThePersonalTheme")
            .SetUrl("~/OrchardCoreContrib.Themes.Personal/js/scripts.js")
            .SetVersion("1.0.0");

        _manifest
            .DefineStyle("ThePersonalTheme")
            .SetUrl("~/OrchardCoreContrib.Themes.Personal/css/styles.css")
            .SetVersion("1.0.0");
    }

    public void Configure(ResourceManagementOptions options)
    {
        options.ResourceManifests.Add(_manifest);
    }
}
