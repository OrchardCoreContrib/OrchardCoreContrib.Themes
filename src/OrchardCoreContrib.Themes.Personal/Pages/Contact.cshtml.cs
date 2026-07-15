using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using OrchardCore.Email;
using System.ComponentModel.DataAnnotations;

namespace OrchardCoreContrib.Themes.Personal.Pages
{
    public class ContactModel(IEmailService emailService, IOptions<SmtpOptions> smtpOptions) : PageModel
    {
        private readonly SmtpOptions _smtpOptions = smtpOptions.Value;

        [Required]
        [BindProperty]
        public string Name { get; set; }

        [Required]
        [OrchardCore.Email.EmailAddress]
        [BindProperty]
        public string Email { get; set; }

        [Required]
        [BindProperty]
        public string Phone { get; set; }

        [Required]
        [BindProperty]
        public string Message { get; set; }

        [TempData]
        public bool ShowMessage { get; set; }

        [TempData]
        public string SuccessMessage { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ShowMessage = false;

                return Page();
            }

            var mailMessage = new MailMessage
            {
                From = Email,
                To = _smtpOptions.DefaultSender,
                Subject = $"Contact - {Name}({Phone})",
                HtmlBody = Message.Replace(Environment.NewLine, "<br/>")
            };

            await emailService.SendAsync(mailMessage);

            await emailService.SendAsync(Email, "Thank you for contacting us", "We have received your message and will get back to you shortly.");

            ShowMessage = true;
            SuccessMessage = "Your message has been sent successfully.";

            return RedirectToPage();
        }
    }
}
