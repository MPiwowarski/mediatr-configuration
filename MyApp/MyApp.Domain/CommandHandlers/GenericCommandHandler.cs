using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp.Domain.CommandHandlers
{
    public class GenericCommandHandler<TNotification> : INotificationHandler<TNotification>
    where TNotification : INotification
    {
        public Task Handle(TNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
