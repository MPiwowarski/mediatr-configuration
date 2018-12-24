using MediatR;
using MyApp.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp.Domain.CommandHandlers
{
    public class EmptyCommandHandler : INotificationHandler<EmptyCommand>
    {
        public Task Handle(EmptyCommand notification, CancellationToken cancellationToken)
        {
            return Task.FromResult(string.Empty);
        }
    }



}
