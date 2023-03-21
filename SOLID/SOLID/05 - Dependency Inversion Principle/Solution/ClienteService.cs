using SOLID.Violation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._05___Dependency_Inversion_Principle.Solution
{
    public class ClienteService
    {
        private IClientRepository _clientRepository;
        private IEmailService _emailService;

        public ClienteService(IClientRepository clientRepository, IEmailService emailService)
        {
            _clientRepository = clientRepository;
            _emailService = emailService;
        }
        public string AddClient(Client client)
        {            
            if (!client.IsValid())
            {
                return "Stop, Invalid Client!";
            } 
                        
            _clientRepository.AddClient(client);

            _emailService.SendMail(client);

            return "Created!";
        }

    }
}
