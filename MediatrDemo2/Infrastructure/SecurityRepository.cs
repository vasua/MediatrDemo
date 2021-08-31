using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatrDemo2.Models;

namespace MediatrDemo2.Infrastructure
{
    public class SecurityRepository : ISecurityRepository
    {
        private Dictionary<Guid, Security> _securityRepository = new Dictionary<Guid, Security>();

        public Task<Security> Add(Security security)
        {
            security.Status = "saved";
            _securityRepository.Add(security.Ik, security);
            return Task.FromResult(security);
        }

        public Task<Security> GetById(string id)
        {
            return Task.FromResult(_securityRepository.FirstOrDefault(x => x.Value.Id == id).Value);
        }
    }
}