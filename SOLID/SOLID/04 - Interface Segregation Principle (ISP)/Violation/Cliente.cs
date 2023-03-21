using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._04___Interface_Segregation_Principle__ISP_.Violation
{
    public class Cliente : IMessage
    {
        public void EnviarEmail(string destinatario, string mensagem)
        {
            //>>>> Codigo para envio de email
        }

        public void EnviarSMS(string destinatario, string mensagem)
        {
            //Não enviamos sms para clientes
            throw new NotImplementedException();
        }
    }
}
