using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Bill.Command;

public record UpdateBill(int Id, VmBill VmBill) : IRequest<VmBill>;
public class UpdateBillHandler : IRequestHandler<UpdateBill, VmBill>
{
    private readonly IBillRepository _ibillRepository;
    private readonly IMapper _imapper;

    public UpdateBillHandler(IBillRepository ibillRepository, IMapper imapper)
    {
        _ibillRepository = ibillRepository;
        _imapper = imapper;
    }
    public async Task<VmBill> Handle(UpdateBill request, CancellationToken cancellationToken)
    {
        var data = _imapper.Map<Model.Bill>(request.VmBill);
        return await _ibillRepository.Update(request.Id, data);
    }
}
