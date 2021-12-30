using JsaCqrsApi.Infrastructure.Context;
using JsaCqrsApi.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.PersonFeatures.Queries
{
    public class GetAllPersonsQuery : IRequest<IEnumerable<Person>>
    {
        public class GetAllPersonsQureyHandler : IRequestHandler<GetAllPersonsQuery, IEnumerable<Person>>
        {
            private readonly IApplicationContext _context;
            public GetAllPersonsQureyHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Person>> Handle(GetAllPersonsQuery request, CancellationToken cancellationToken)
            {
                var personList = await _context.Persons.ToListAsync();
                if (personList == null)
                {
                    return null;
                }
                return personList.AsReadOnly();
            }
        }
    }
}
