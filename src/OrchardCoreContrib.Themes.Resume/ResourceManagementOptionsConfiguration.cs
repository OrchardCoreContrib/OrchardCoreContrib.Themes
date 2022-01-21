using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace OrchardCoreContrib.Themes.Resume
{
    public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
    {
        private static readonly ResourceManifest _manifest;

        static ResourceManagementOptionsConfiguration()
        {
            _manifest = new ResourceManifest();

            _manifest
                .DefineScript("bootstrap-bundle")
                .SetCdn("https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js", "https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.js")
                .SetCdnIntegrity("sha256-9SEPo+fwJFpMUet/KACSwO+Z/dKMReF9q4zFhU/fT9M=", "sha256-htsAUOIgN8xkootpQUzmvaCbQo6x2PNMTD7kLWI6yYQ=")
                .SetVersion("5.1.3");

            _manifest
                .DefineScript("font-awesome")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/js/all.min.js", "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/js/all.js")
                .SetCdnIntegrity("sha512-Tn2m0TIpgVyTzzvmxLNuqbSJH3JP8jm+Cy3hvHrW7ndTDcJ1w5mBiksqDBb8GpE2ksktFvDB/ykZ0mDpsZj20w==", "sha512-AsoAG+OFcSvtqlspW166UTUYg7F4GEu0yNhzTIRfOGysIQA8Dqk1WZwyoN4eX6mX4DaSk703Q1iM0M47rw25Kw==")
                .SetVersion("5.15.4");

            _manifest
                .DefineScript("resume")
                .SetUrl("~/OrchardCoreContrib.Themes.Resume/js/scripts.js")
                .SetVersion("1.0.0");

            _manifest
                .DefineStyle("resume")
                .SetUrl("~/OrchardCoreContrib.Themes.Resume/css/styles.css")
                .SetVersion("1.0.0");
        }

        public void Configure(ResourceManagementOptions options)
        {
            options.ResourceManifests.Add(_manifest);
        }
    }
}
