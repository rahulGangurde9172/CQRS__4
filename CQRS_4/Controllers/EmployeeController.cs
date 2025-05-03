using CQRS_4.CQRS.Commands;
using CQRS_4.CQRS.Queries;
using CQRS_4.Model.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmployee()
        {
            var GetQuery = new GetAllEmployeeQuery();
           var employees= await _mediator.Send(GetQuery);
            return Ok(employees);

        }
        [HttpGet("{id}")]

        public async Task<IActionResult> GetEmployeeByID(int id)
        {
            var query = new GetEmployeeById(new GetEmployeeByIdDTO { Id = id });
            var employee = await _mediator.Send(query);
            return Ok(employee);
        }


        [HttpPost]
        public async Task<IActionResult> CreateEmploye([FromBody] CreateEmployeeDTO createDTO)
        {
            var Command = new CreateCommand(createDTO);
            var employee=await _mediator.Send(Command);
            return Ok(employee);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id ,[FromBody] UpdateEmployeeDTO updateDTO)
        {
            updateDTO.Id = id;
            var Command = new UpdateCommand(updateDTO);
            var employee = await _mediator.Send(Command);
            return Ok(employee);
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id,DeleteEmployeeDTO deleteEmployeeDTO)
        {
            deleteEmployeeDTO.Id = id;
            var command = new DeleteCommand(deleteEmployeeDTO);
            var employee = await _mediator.Send(command);
            return Ok(employee);
        }
    }
}
