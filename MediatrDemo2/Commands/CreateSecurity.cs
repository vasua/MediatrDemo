using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatrDemo2.Infrastructure;
using MediatrDemo2.Models;
using MediatrDemo2.Notifications;

namespace MediatrDemo2.Commands
{
    public class CreateSecurity : IRequest<Security>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double IssuePrice { get; set; }
    }

    public class CreateSecurityHandler : IRequestHandler<CreateSecurity, Security>
    {
        private readonly ISecurityRepository _securityRepository;
        private readonly IMediator _mediator;

        public CreateSecurityHandler(ISecurityRepository securityRepository, IMediator mediator)
        {
            _securityRepository = securityRepository ?? throw new ArgumentNullException(nameof(securityRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public async Task<Security> Handle(CreateSecurity request, CancellationToken cancellationToken)
        {
            var security = new Security
            {
                Id = request.Id,
                Name = request.Name,
                IssuePrice = request.IssuePrice,
                Status = "Init"
            };
            await _mediator.Publish(new SecurityAdded(), cancellationToken);
            return await _securityRepository.Add(security);
        }
    }
}