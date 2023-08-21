using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Bill.Query;

public record GetBillById(int Id) : IRequest<VmBill>;

public class GetBillByIdHandler : IRequestHandler<GetBillById, VmBill>
{


    private readonly IBillRepository _billRepository;
    public GetBillByIdHandler(IBillRepository billRepository)
    {
        _billRepository = billRepository;

    }

    public async Task<VmBill> Handle(GetBillById request, CancellationToken cancellationToken)
    {
        return await _billRepository.GetById(request.Id);
    }



}
