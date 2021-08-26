using System.Threading.Tasks;

namespace Iaf.API.Data.Email
{
    public interface IEmailSender
    {
         void SendEmail(Message message);
         Task SendEmailAsync(Message message);
    }
}