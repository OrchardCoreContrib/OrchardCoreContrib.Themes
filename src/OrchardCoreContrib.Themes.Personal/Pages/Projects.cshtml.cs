using Microsoft.AspNetCore.Mvc.RazorPages;
using OrchardCore;
using OrchardCore.ContentManagement;

namespace OrchardCoreContrib.Themes.Personal.Pages
{
    public class ProjectsModel(IOrchardHelper orchardHelper) : PageModel
    {
        public async Task OnGetAsync()
        {
            ProjectContentItems = await orchardHelper.GetRecentContentItemsByContentTypeAsync(Constants.ContentTypes.Project, Constants.ProjectsCount);
        }

        public IEnumerable<ContentItem> ProjectContentItems { get; set; }
    }
}
