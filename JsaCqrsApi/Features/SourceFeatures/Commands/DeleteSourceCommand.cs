using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.SourceFeatures.Commands
{
    public class DeleteSourceByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int SourceTypeId { get; set; }
        public int? PersonId { get; set; }
        public int? UrlId { get; set; }
        public int? EmailId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }

        public class DeleteSourceByIdCommandHandler : IRequestHandler<DeleteSourceByIdCommand, int>
        {
            private readonly IApplicationContext _context;
            public DeleteSourceByIdCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteSourceByIdCommand command, CancellationToken cancellationToken)
            {
                var source = _context.Sources.Where(a => a.Id == command.Id).FirstOrDefault();
                if (source == null) return default;
                _context.Sources.Remove(source);
                await _context.SaveChangesAsync();
                return source.Id;
            }
        }

    }
}
