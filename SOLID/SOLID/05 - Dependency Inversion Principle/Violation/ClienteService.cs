using SOLID.Violation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._05___Dependency_Inversion_Principle.Violation
{
    public class ClienteService
    {

        public string AddClient(Client client)
        {            
            //// Validation
            //if (!client.IsValid())  return "Stop, Invalid Client!";

            // AddClient
            var _clientRepository = new ClientRepository();
            _clientRepository.AddClient(client);

            // SendMail
            var _mailService = new EmailService();
            _mailService.SendMail(client); 

            return "Created!";
        }

    }
}
