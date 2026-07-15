using Microsoft.AspNetCore.Mvc.RazorPages;
using OrchardCore;
using OrchardCore.ContentManagement;
using System.Text.Json.Dynamic;

namespace OrchardCoreContrib.Themes.Personal.Pages
{
    public class ResumeModel(IOrchardHelper orchardHelper) : PageModel
    {
        public async Task OnGetAsync()
        {
            var resumeContentItem = await orchardHelper.GetContentItemByAliasAsync(Constants.ContentAliases.Resume);

            ExperienceContentItems = (resumeContentItem.Content.Experiences.ContentItems as JsonDynamicArray).ToObject<IEnumerable<ContentItem>>();
            SkillContentItems = (resumeContentItem.Content.ProfessionalSkills.ContentItems as JsonDynamicArray).ToObject<IEnumerable<ContentItem>>();
            LanguageContentItems = (resumeContentItem.Content.Languages.ContentItems as JsonDynamicArray).ToObject<IEnumerable<ContentItem>>();
            EducationContentItems = (resumeContentItem.Content.Education.ContentItems as JsonDynamicArray).ToObject<IEnumerable<ContentItem>>();
        }

        public IEnumerable<ContentItem> ExperienceContentItems { get; set; }

        public IEnumerable<ContentItem> EducationContentItems { get; set; }

        public IEnumerable<ContentItem> SkillContentItems { get; set; }

        public IEnumerable<ContentItem> LanguageContentItems { get; set; }
    }
}
