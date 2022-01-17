using BusinessLayer;
using MailSender.Properties;
using System.Net;
using System.Net.Mail;

namespace MailSender
{
    public abstract class MailSender
    {
        private static SmtpClient smtpClient;

        public static SmtpClient GetSmtpClient()
        {
            if (smtpClient is null)
            {
                smtpClient = new SmtpClient
                {
                    Port = 587,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(Settings.Default.Correo, Settings.Default.Correo)
                };
            }

            return smtpClient;
        }

        public static void EnviarCredenciales(Usuario usuario)
        {
            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress(Settings.Default.Correo),
                Subject = "Credenciales",
                IsBodyHtml = true,
                Body = "test"
            };
            mailMessage.To.Add(usuario.Correo);

            GetSmtpClient().Send(mailMessage);
        }

    }
}
