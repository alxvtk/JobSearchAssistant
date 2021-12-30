using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Features.PersonFeatures.Queries
{
    public class GetPersonByIdQuery : IRequest<Person>
    {
        public int Id { get; set; }
        public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, Person>
        {
            private readonly IApplicationContext _context;
            public GetPersonByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<Person> Handle(GetPersonByIdQuery query, CancellationToken cancellationToken)
            {
                var person = _context.Persons.Where(a => a.Id == query.Id).FirstOrDefault();
                if (person == null) return null;
                return person;
            }
        }

    }
}
