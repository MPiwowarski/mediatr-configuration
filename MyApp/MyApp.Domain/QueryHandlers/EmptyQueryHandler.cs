using MediatR;
using MyApp.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp.Domain.QueryHandlers
{
    public class EmptyQueryHandler : IRequestHandler<EmptyQuery, string>
    {
        public Task<string> Handle(EmptyQuery notification, CancellationToken cancellationToken)
        {
            return Task.FromResult(string.Empty);
        }
    }
}
