using System;
using System.Collections.Generic;
using MediatrDemo1.Models;
using MediatrDemo1.Services;

namespace MediatrDemo1
{
    public class Application
    {
        private Dictionary<Guid, Security> _securityRepository = new Dictionary<Guid, Security>();
        private Dictionary<Security, Position> _positionRepository = new Dictionary<Security, Position>();

        private SecurityService _securityService;

        public Application()
        {
            _securityService = new SecurityService(_securityRepository);
        }

        public Security CreateSecurity(string id, string name, double issuePrice)
        {
            Security security = _securityService.CreateSecurity(id, name, issuePrice);
            return security;
        }

        public Security GetSecurity(string id)
        {
            return _securityService.GetSecurity(id);
        }
    }
}