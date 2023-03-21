using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._04___Interface_Segregation_Principle__ISP_.Solution
{
    public class Cliente : IEnvioDeEmail
    {
        public void EnviarEmail(string destinatario, string mensagem)
        {
            //>>>> Codigo para envio de email
        }
    }
}
