using MediatR;
using Microsoft.AspNetCore.Mvc;
using Taskmanagement.Core.PatientDiagnosis.Command;
using Taskmanagement.Core.PatientDiagnosis.Query;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PatientDiagnosisController : ControllerBase
{
    private readonly IMediator _mediator;
    public PatientDiagnosisController(IMediator mediator)
    {
        _mediator = mediator;

    }

    [HttpGet]

    public async Task<ActionResult<VmPatientDiagnosis>> Get()
    {
        var data = await _mediator.Send(new GetAllPatientDiagnosisQuery());
        return Ok(data);
    }
    [HttpGet("id")]
    public async Task<ActionResult<VmPatientDiagnosis>> GetById(int id)
    {
        var data = await _mediator.Send(new GetPatientDiagnosisById(id));
        return Ok(data);
    }


    [HttpPost]


    public async Task<ActionResult<VmPatientDiagnosis>> PostAsync([FromBody] VmPatientDiagnosis vmPatientDiagnosis)
    {
        var data = await _mediator.Send(new CreatePatientDiagnosis(vmPatientDiagnosis));
        return Ok(data);
    }
    [HttpPut("id")]
    public async Task<ActionResult<VmPatientDiagnosis>> PutAsync(int id, [FromBody] VmPatientDiagnosis vmPatientDiagnosis)
    {
        var data = await _mediator.Send(new UpdatePatientDiagnosis(id, vmPatientDiagnosis));
        return Ok(data);
    }


    [HttpDelete("id")]
    public async Task<ActionResult<VmPatientDiagnosis>> DeleteAsync(int id)
    {
        var data = await _mediator.Send(new DeletePatientDiagnosis(id));
        return Ok(data);
    }
}
