using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Correct
{

    /// <summary>
    /// It is following SRP.
    /// </summary>
    public class UserService
    {
        EmailService _emailService;
        DbContext _dbContext;

        public UserService(EmailService aEmailService, DbContext aDbContext)
        {
            _emailService = aEmailService;
            _dbContext = aDbContext;
        }

        public void Register(string email, string password)
        {
            if (!_emailService.ValidateEmail(email))
                throw new ValidationException("Email is not an email");
            var user = new User(email, password);
            _dbContext.SaveChanges();
            _emailService.SendEmail(new MailMessage("myname@mydomain.com", email) { Subject = "Hi. How are you!" });
        }

    }

    public class EmailService
    {
        SmtpClient _smtpClient;
        public EmailService(SmtpClient aSmtpClient)
        {
            _smtpClient = aSmtpClient;
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public bool SendEmail(MailMessage message)
        {
            try
            {
                _smtpClient.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
