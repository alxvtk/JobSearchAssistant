using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.SourceFeatures.Commands
{
    public class CreateSourceCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int SourceTypeId { get; set; }
        public int? PersonId { get; set; }
        public int? UrlId { get; set; }
        public int? EmailId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }

        public class CreateSourceCommandHandler : IRequestHandler<CreateSourceCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateSourceCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateSourceCommand command, CancellationToken cancellationToken)
            {
                var source = new Source();
                source.Id = command.Id;
                source.SourceTypeId = command.SourceTypeId;
                source.PersonId = command.PersonId;
                source.UrlId = command.UrlId;
                source.EmailId = command.EmailId;
                source.Name = command.Name;
                source.Comment = command.Comment;

                _context.Sources.Add(source);
                await _context.SaveChangesAsync();
                return source.Id;
            }
        }

    }
}
