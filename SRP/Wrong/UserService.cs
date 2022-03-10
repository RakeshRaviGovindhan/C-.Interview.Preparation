using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Wrong
{
    /// <summary>
    /// It looks fine, but it is not following SRP.
    /// The SendEmail and ValidateEmail methods have nothing to do within the UserService class. 
    /// You have to refract it.
    /// </summary>
    public class UserService
    {

        SmtpClient _smtpClient;
        public UserService(SmtpClient aSmtpClient)
        {
            _smtpClient = aSmtpClient;
        }

        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new ValidationException("Email is not an email");
            var user = new User(email, password);

            SendEmail(new MailMessage("mysite@nowhere.com", email) { Subject = "HEllo foo" });
        }

        public virtual bool ValidateEmail(string email)
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
