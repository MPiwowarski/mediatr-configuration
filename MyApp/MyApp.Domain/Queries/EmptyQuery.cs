using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Domain.Queries
{
    public class EmptyQuery : IRequest<string>
    {
    }
}
