using MediatR;
using Microsoft.AspNetCore.Mvc;
using Taskmanagement.Core.Patient.Command;
using Taskmanagement.Core.Patient.Query;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PatientController : ControllerBase
{
    private readonly IMediator _mediator;
    public PatientController(IMediator mediator)
    {
        _mediator = mediator;

    }

    [HttpGet]

    public async Task<ActionResult<VmPatient>> Get()
    {
        var data = await _mediator.Send(new GetAllPatientQuery());
        return Ok(data);
    }
    [HttpGet("id")]
    public async Task<ActionResult<VmPatient>> GetById(int id)
    {
        var data = await _mediator.Send(new GetPatientById(id));
        return Ok(data);
    }


    [HttpPost]


    public async Task<ActionResult<VmPatient>> PostAsync([FromBody] VmPatient vmPatient)
    {
        var data = await _mediator.Send(new CreatePatient(vmPatient));
        return Ok(data);
    }
    [HttpPut("id")]
    public async Task<ActionResult<VmPatient>> PutAsync(int id, [FromBody] VmPatient vmPatient)
    {
        var data = await _mediator.Send(new UpdatePatient(id, vmPatient));
        return Ok(data);
    }


    [HttpDelete("id")]
    public async Task<ActionResult<VmPatient>> DeleteAsync(int id)
    {
        var data = await _mediator.Send(new DeletePatient(id));
        return Ok(data);
    }
}
