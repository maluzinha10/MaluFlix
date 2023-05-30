namespace MaluFlix.Services;

    public interface IEmailSender
    {
        Task SendEmailAsync(string emal, string subject, string htmlMessagr);
    }
