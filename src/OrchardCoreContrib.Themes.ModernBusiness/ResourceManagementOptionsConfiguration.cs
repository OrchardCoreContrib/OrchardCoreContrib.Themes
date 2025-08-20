using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace OrchardCoreContrib.Themes.ModernBusiness;

public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
{
    private static readonly ResourceManifest _manifest;

    static ResourceManagementOptionsConfiguration()
    {
        _manifest = new ResourceManifest();

        _manifest
            .DefineScript("TheModernBusinessTheme-vendor-jQuery")
            .SetUrl("~/OrchardCoreContrib.Themes.ModernBusiness/vendor/jquery/jquery.min.js", "~/OrchardCoreContrib.Themes.ModernBusiness/vendor/jquery/jquery.js")
            .SetCdn("https://code.jquery.com/jquery-3.4.1.min.js", "https://code.jquery.com/jquery-3.4.1.js")
            .SetCdnIntegrity("sha384-vk5WoKIaW/vJyUAd9n/wmopsmNhiy+L2Z+SBxGYnUkunIxVxAv/UtMOhba/xskxh", "sha384-mlceH9HlqLp7GMKHrj5Ara1+LvdTZVMx4S1U43/NxCvAkzIo8WJ0FE7duLel3wVo")
            .SetVersion("3.4.1");

        _manifest
            .DefineScript("TheModernBusinessTheme-vendor-jQuery.slim")
            .SetUrl("~/OrchardCoreContrib.Themes.ModernBusiness/vendor/jquery/jquery.slim.min.js", "~/OrchardCoreContrib.Themes.ModernBusiness/vendor/jquery/jquery.slim.js")
            .SetCdn("https://code.jquery.com/jquery-3.4.1.slim.min.js", "https://code.jquery.com/jquery-3.4.1.slim.js")
            .SetCdnIntegrity("sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n", "sha384-teRaFq/YbXOM/9FZ1qTavgUgTagWUPsk6xapwcjkrkBHoWvKdZZuAeV8hhaykl+G")
            .SetVersion("3.4.1");

        _manifest
            .DefineScript("TheModernBusinessTheme-vendor-bootstrap")
            .SetDependencies("TheModernBusinessTheme-vendor-jQuery")
            .SetUrl("~/OrchardCoreContrib.Themes.ModernBusiness/vendor/bootstrap/js/bootstrap.min.js", "~/OrchardCoreContrib.Themes.ModernBusiness/vendor/bootstrap/js/bootstrap.js")
            .SetCdn("https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js", "https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.js")
            .SetCdnIntegrity("sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM", "sha384-rkSGcquOAzh5YMplX4tcXMuXXwmdF/9eRLkw/gNZG+1zYutPej7fxyVLiOgfoDgi")
            .SetVersion("4.3.1");

        _manifest
            .DefineStyle("TheModernBusinessTheme-vendor-bootstrap")
            .SetUrl("~/OrchardCoreContrib.Themes.ModernBusiness/vendor/bootstrap/css/bootstrap.min.css", "~/OrchardCoreContrib.Themes.ModernBusiness/vendor/bootstrap/css/bootstrap.css")
            .SetCdn("https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css", "https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.css")
            .SetCdnIntegrity("sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T", "sha384-t4IGnnWtvYimgcRMiXD2ZD04g28Is9vYsVaHo5LcWWJkoQGmMwGg+QS0mYlhbVv3")
            .SetVersion("4.3.1");
    }

    public void Configure(ResourceManagementOptions options)
    {
        options.ResourceManifests.Add(_manifest);
    }
}
