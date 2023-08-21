using MediatR;
using Microsoft.AspNetCore.Mvc;
using Taskmanagement.Core.Bill.Command;
using Taskmanagement.Core.Bill.Query;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BillController : ControllerBase
{
    private readonly IMediator _mediator;
    public BillController(IMediator mediator)
    {
        _mediator = mediator;

    }

    [HttpGet]

    public async Task<ActionResult<VmBill>> Get()
    {
        var data = await _mediator.Send(new GetAllBillQuery());
        return Ok(data);
    }
    [HttpGet("id")]
    public async Task<ActionResult<VmBill>> GetById(int id)
    {
        var data = await _mediator.Send(new GetBillById(id));
        return Ok(data);
    }


    [HttpPost]


    public async Task<ActionResult<VmBill>> PostAsync([FromBody] VmBill vmBill)
    {
        var data = await _mediator.Send(new CreateBill(vmBill));
        return Ok(data);
    }
    [HttpPut("id")]
    public async Task<ActionResult<VmBill>> PutAsync(int id, [FromBody] VmBill vmBill)
    {
        var data = await _mediator.Send(new UpdateBill(id, vmBill));
        return Ok(data);
    }


    [HttpDelete("id")]
    public async Task<ActionResult<VmBill>> DeleteAsync(int id)
    {
        var data = await _mediator.Send(new DeleteBill(id));
        return Ok(data);
    }
}
