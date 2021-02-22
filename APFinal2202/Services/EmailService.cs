using Microsoft.AspNet.Identity;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace APFinal2202.Services
{

    public class EmailService : IIdentityMessageService
    {
        public async Task SendAsync(IdentityMessage message)
        {
            var key = "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";
            var client = new SendGridClient(key);
            var from = new EmailAddress("gabymarius@hotmail.com", "Gabriel Marius Popescu");
            var to = new EmailAddress(message.Destination, "New User Creation");
            var subject = message.Subject;
            var content = message.Body;
            var htmlContent = message.Body;
            var email = MailHelper.CreateSingleEmail(from, to, subject, content, htmlContent);
            await client.SendEmailAsync(email);
        }
    }
}