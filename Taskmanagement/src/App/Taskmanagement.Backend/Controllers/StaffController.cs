using MediatR;
using Microsoft.AspNetCore.Mvc;
using Taskmanagement.Core.Staff.Command;
using Taskmanagement.Core.Staff.Query;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StaffController : ControllerBase
{
    private readonly IMediator _mediator;
    public StaffController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]

    public async Task<ActionResult<VmStaff>> Get()
    {
        var data = await _mediator.Send(new GetAllStaffQuery());
        return Ok(data);
    }
    [HttpGet("id")]
    public async Task<ActionResult<VmStaff>> GetById(int id)
    {
        var data = await _mediator.Send(new GetStaffById(id));
        return Ok(data);
    }


    [HttpPost]


    public async Task<ActionResult<VmStaff>> PostAsync([FromBody] VmStaff vmStaff)
    {
        var data = await _mediator.Send(new CreateStaff(vmStaff));
        return Ok(data);
    }
    [HttpPut("id")]
    public async Task<ActionResult<VmStaff>> PutAsync(int id, [FromBody] VmStaff vmStaff)
    {
        var data = await _mediator.Send(new UpdateStaff(id, vmStaff));
        return Ok(data);
    }


    [HttpDelete("id")]
    public async Task<ActionResult<VmStaff>> DeleteAsync(int id)
    {
        var data = await _mediator.Send(new DeleteStaff(id));
        return Ok(data);
    }
}
