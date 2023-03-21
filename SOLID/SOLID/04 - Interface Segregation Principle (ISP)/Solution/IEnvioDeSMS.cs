using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._04___Interface_Segregation_Principle__ISP_.Solution
{
    public interface IEnvioDeSMS
    {
        void EnviarSMS(string destinatario, string mensagem);
    }
}
