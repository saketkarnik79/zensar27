using Microsoft.Extensions.Options;

public class EmailService
{
    private readonly EmailSettings _settings;

    public EmailService(IOptions<EmailSettings> options)
    {
        _settings = options.Value;
    }

    public void ShowSettings()
    {
        Console.WriteLine(_settings.SmtpServer);
        Console.WriteLine(_settings.Port);
    }
}