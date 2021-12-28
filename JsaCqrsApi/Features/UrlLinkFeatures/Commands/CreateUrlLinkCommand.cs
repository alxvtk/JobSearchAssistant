using JsaCqrsApi.Domain.Models;
using JsaCqrsApi.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsaCqrsApi.Application.Features.UrlLinkFeatures.Commands
{
    public class CreateUrlLinkCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string Comment { get; set; }

        public class CreateUrlLinkCommandHandler : IRequestHandler<CreateUrlLinkCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateUrlLinkCommandHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateUrlLinkCommand command, CancellationToken cancellationToken)
            {
                var urlLink = new UrlLink();
                urlLink.Id = command.Id;
                urlLink.Body = command.Body;
                urlLink.Comment = command.Comment;

                _context.UrlLinks.Add(urlLink);
                await _context.SaveChangesAsync();
                return urlLink.Id;
            }
        }

    }
}
