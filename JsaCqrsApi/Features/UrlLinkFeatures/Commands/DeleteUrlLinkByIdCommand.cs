using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Features.UrlLinkFeatures.Commands
{
    public class DeleteUrlLinkByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string Comment { get; set; }

        public class DeleteUrlLinkByIdCommandHandler : IRequestHandler<DeleteUrlLinkByIdCommand, int>
        {
            private readonly IApplicationContext _context;
            public DeleteUrlLinkByIdCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteUrlLinkByIdCommand command, CancellationToken cancellationToken)
            {
                var urlLink = _context.UrlLinks.Where(a => a.Id == command.Id).FirstOrDefault();
                if (urlLink == null) return default;
                _context.UrlLinks.Remove(urlLink);
                await _context.SaveChangesAsync();
                return urlLink.Id;
            }
        }

    }
}
