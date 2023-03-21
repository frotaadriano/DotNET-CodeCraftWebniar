using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Solution
{
    /*
     [static]
        
        double resultado = Math.Pow(2,3); 
        
        A palavra chave static faz com que os métodos da classe Math estejam associados a classe e 
        não com uma instância particular da classe.
     
        Algumas características das classes estáticas:

        1. Uma classe estática não pode ser instanciada;
        2. Classe estática podem ter somente membros estáticos;
        3. Um Membro estático da classe pode ser acessado pelo próprio nome da classe;
        4. Uma Classe estática é sealed. Dessa forma uma classe estática não pode ser herdada;
        5. Uma Classe estática contém apenas os construtores estáticos;
        6. Uma Classe estática não pode ter construtores de instância;
        7. Uma Classe estática só pode ser herdada a partir de objetos da classe;
        8. Uma Classe estática possui a palavra-chave static como modificador;
        9. Os Construtores estáticos da classe estática são chamados apenas uma vez;
        10. Uma Classe estática possui somente construtores privados;
     
     */
    public static class EmailService
    {

        public static void SendMail(Client client)
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
