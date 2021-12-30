using JsaCqrsApi.Application.Features.OpportunityActionTypeFeatures.Commands;
using JsaCqrsApi.Application.Features.OpportunityActionTypeFeatures.Queries;
//using JsaCqrsApi.Features.CountryFeatures.Commands;
using JsaCqrsApi.Infrastructure.Features.OpportunityActionTypeFeatures.Queries;
using JsaCqrsApi.Features.OpportunityActionTypeFeatures.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsaCqrsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpportunityActionTypeController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(CreateOpportunityActionTypeCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllOpportunityActionTypesQuery()));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await Mediator.Send(new GetOpportunityActionTypeByIdQuery { Id = id }));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteOpportunityActionTypeByIdCommand { Id = id }));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateOpportunityActionTypeCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }
    }

}
