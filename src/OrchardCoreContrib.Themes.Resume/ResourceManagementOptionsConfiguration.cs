using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace OrchardCoreContrib.Themes.Resume;

public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
{
    private static readonly ResourceManifest _manifest;

    static ResourceManagementOptionsConfiguration()
    {
        _manifest = new ResourceManifest();

        _manifest
            .DefineScript("resume")
            .SetUrl("~/OrchardCoreContrib.Themes.Resume/js/scripts.js")
            .SetVersion("1.0.0")
            .SetDependencies("bootstrap-bundle", "font-awesome");

        _manifest
            .DefineStyle("resume")
            .SetUrl("~/OrchardCoreContrib.Themes.Resume/css/styles.css")
            .SetVersion("1.0.0");
    }

    public void Configure(ResourceManagementOptions options)
        => options.ResourceManifests.Add(_manifest);
}
