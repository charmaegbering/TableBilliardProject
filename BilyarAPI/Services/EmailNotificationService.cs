using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BilyarAPI.Services
{
    public class EmailNotificationService
    {
        private readonly SmtpClient _client;

        public EmailNotificationService()
        {
            _client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("f43b1c8d6c6f74", "722679699e36d5"),
                EnableSsl = true
            };
        }

        public async Task SendNotificationAsync(string to, string subject, string body)
        {
            var mailMessage = new MailMessage("from@example.com", to, subject, body);
            await _client.SendMailAsync(mailMessage);
        }
    }
}