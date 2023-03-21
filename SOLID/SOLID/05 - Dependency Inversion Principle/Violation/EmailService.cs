using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._05___Dependency_Inversion_Principle.Violation
{
    public class EmailService
    {
        public void SendMail(Client client)
        {
            #region [3] ============ [Notify new Client] ============
            var mailClient = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };
            var mailMessage = new MailMessage("subscribe@xpto.com", client.Email);
            mailMessage.Subject = $"Welcome {client.Name} {client.Surname} as our new client!";
            mailMessage.Body = "Now you can use our plataform and make ...";
            mailClient.Send(mailMessage);

            #endregion

        }

    }
}
