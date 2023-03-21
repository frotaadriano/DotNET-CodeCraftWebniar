using SOLID.Violation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Solution
{
    public class ClienteService
    {
        public string AddClient(Client client)
        {            
            if (!client.IsValid())
            {
                return "Stop, Invalid Client!";
            } 

            var _clientRepository = new ClientRepository();
            _clientRepository.AddClient(client);

            EmailService.SendMail(client);

            return "Created!";
        }

    }
}
