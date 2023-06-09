using MediatorCQRS_NUnit.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatorCQRS_NUnit.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator) => _mediator = mediator;
        [HttpGet]
        public async Task<IActionResult> Get()
        {
                var result = _mediator.Send(new GetEmployeeQuery());
            return Ok(result);
        }
    }
}
