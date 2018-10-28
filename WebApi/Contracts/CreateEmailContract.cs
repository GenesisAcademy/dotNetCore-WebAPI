namespace WebApi.Contracts
{
    public class CreateEmailContract
    {
        public string Subject { get; set; }

        public string Body { get; set; }

        public string RecipientName { get; set; }

        public string RecipientEmail { get; set; }

        public string SenderEmail { get; set; }
    }
}
