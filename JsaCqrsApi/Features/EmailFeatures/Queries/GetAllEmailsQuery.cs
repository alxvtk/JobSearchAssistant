using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.EmailFeatures.Queries
{
    public class GetAllEmailsQuery : IRequest<IEnumerable<Email>>
    {
        public class GetAllEmailsQureyHandler : IRequestHandler<GetAllEmailsQuery, IEnumerable<Email>>
        {
            private readonly IApplicationContext _context;
            public GetAllEmailsQureyHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Email>> Handle(GetAllEmailsQuery request, CancellationToken cancellationToken)
            {
                var emailList = await _context.Emails.ToListAsync();
                if (emailList == null)
                {
                    return null;
                }
                return emailList.AsReadOnly();
            }
        }
    }
}
