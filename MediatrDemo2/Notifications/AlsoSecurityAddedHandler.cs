using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatrDemo2.Notifications
{
    public class AlsoSecurityAddedHandler : INotificationHandler<SecurityAdded>
    {
        public Task Handle(SecurityAdded notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("And me! And me!");
            return Task.CompletedTask;
        }
    }
}