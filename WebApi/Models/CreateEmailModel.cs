namespace WebApi.Models
{
    public class CreateEmailModel
    {
        public string Title { get; set; }

        public string Body { get; set; }

        public string RecipientName { get; set; }

        public string RecipientEmail { get; set; }

        public string SenderEmail { get; set; }
    }
}
