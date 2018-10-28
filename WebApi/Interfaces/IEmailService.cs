using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IEmailService
    {
        string SendEmail(CreateEmailModel model);
    }
}
