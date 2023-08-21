using MediatR;
using Microsoft.AspNetCore.Mvc;
using Taskmanagement.Core.Doctor.Command;
using Taskmanagement.Core.Doctor.Query;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DoctorController : ControllerBase
{
    private readonly IMediator _mediator;
    public DoctorController(IMediator mediator)
    {
        _mediator = mediator;

    }

    [HttpGet]

    public async Task<ActionResult<VmDoctor>> Get()
    {
        var data = await _mediator.Send(new GetAllDoctorQuery());
        return Ok(data);
    }
    [HttpGet("id")]
    public async Task<ActionResult<VmDoctor>> GetById(int id)
    {
        var data = await _mediator.Send(new GetDoctorById(id));
        return Ok(data);
    }


    [HttpPost]


    public async Task<ActionResult<VmDoctor>> PostAsync([FromBody] VmDoctor vmDoctor)
    {
        var data = await _mediator.Send(new CreateDoctor(vmDoctor));
        return Ok(data);
    }
    [HttpPut("id")]
    public async Task<ActionResult<VmDoctor>> PutAsync(int id, [FromBody] VmDoctor vmDoctor)
    {
        var data = await _mediator.Send(new UpdateDoctor(id, vmDoctor));
        return Ok(data);
    }


    [HttpDelete("id")]
    public async Task<ActionResult<VmDoctor>> DeleteAsync(int id)
    {
        var data = await _mediator.Send(new DeleteDoctor(id));
        return Ok(data);
    }
}
