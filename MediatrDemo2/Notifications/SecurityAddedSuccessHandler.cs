using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatrDemo2.Notifications
{
    public class SecurityAddedSuccessHandler : INotificationHandler<SecurityAdded>
    {
        public Task Handle(SecurityAdded notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("Hehehe booooiiii");
            return Task.CompletedTask;
        }
    }
}