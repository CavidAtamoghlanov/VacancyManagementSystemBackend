using Microsoft.Extensions.Configuration;
using System.Net.Mail;
using System.Net;
using VacancyManagementSystem.Application.Services.ExternalServices;
using VacancyManagementSystem.Domain.DTOs;

namespace VacancyManagementSystem.Infrastructure.Services.ExternalServices;

public class MailService : IMailService
{
    private readonly IConfiguration _configuration;

    public MailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<bool> SendMail(SendMailDTO sendMailDto)
    {
        //----------- SMTP ------------

        MailMessage msg = new MailMessage();

        msg.From = new MailAddress(_configuration["Smtp:Gmail"]!);

        string sbj = "Gmail Confirmation";

        msg.Subject = sbj;
        msg.To.Add(new MailAddress(sendMailDto.Email!));

        msg.Body = $@"
        <html>
        <body>
            <p>Please confirm your email by clicking the link below:</p>
            <p><a href='{sendMailDto.CallBackUrl}'>Confirm Email</a></p>
        </body>
        </html>";

        msg.IsBodyHtml = true;
        var smtpClient = new SmtpClient("smtp.gmail.com")

        {
            Port = 587,
            Credentials = new NetworkCredential(_configuration["Smtp:Gmail"], _configuration["Smtp:Password"]),
            EnableSsl = true
        };
        try
        {
            smtpClient.Send(msg);
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }


}