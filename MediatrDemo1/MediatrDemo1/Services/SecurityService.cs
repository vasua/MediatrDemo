using System;
using System.Collections.Generic;
using System.Linq;
using MediatrDemo1.Models;

namespace MediatrDemo1.Services
{
    public class SecurityService
    {
        private Dictionary<Guid, Security> _securityRepository;

        public SecurityService(Dictionary<Guid, Security> securityRepository)
        {
            _securityRepository = securityRepository;
        }

        public Security CreateSecurity(string id, string name, double issuePrice)
        {
            Security security = new Security
            {
                Id = id,
                Name = name,
                IssuePrice = issuePrice
            };
            _securityRepository.Add(security.Ik, security);
            return security;
        }

        public Security GetSecurity(string id)
        {
            return _securityRepository.FirstOrDefault(x => x.Value.Id == id).Value;
        }
    }

}