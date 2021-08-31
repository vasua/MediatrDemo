using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatrDemo2.Infrastructure;
using MediatrDemo2.Models;

namespace MediatrDemo2.Queries
{
    public class GetSecurityById : IRequest<Security>
    {
        public string Id { get; init; }
    }

    public class GetSecurityByIdHandler : IRequestHandler<GetSecurityById, Security>
    {
        private readonly ISecurityRepository _securityRepository;

        public GetSecurityByIdHandler(ISecurityRepository securityRepository)
        {
            _securityRepository = securityRepository ?? throw new ArgumentNullException(nameof(securityRepository));
        }

        public Task<Security> Handle(GetSecurityById request, CancellationToken cancellationToken)
        {
            return _securityRepository.GetById(request.Id);
        }
    }
}