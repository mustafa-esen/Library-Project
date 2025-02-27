using Microsoft.AspNetCore.Identity.UI.Services;

namespace ders1.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Buraya email gönderme işlemlerinizi yapabilirsiniz
            return Task.CompletedTask;
        }
    }
}
