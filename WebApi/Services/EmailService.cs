using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Services
{
    public class EmailService : IEmailService
    {
        public string SendEmail(CreateEmailModel model)
        {
            /* Отправляем емейлы */
            return $"Email \"{model.Title}\" sended!";
        }
    }
}
