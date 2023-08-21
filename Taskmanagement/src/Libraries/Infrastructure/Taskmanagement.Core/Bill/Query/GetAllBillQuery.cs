using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Bill.Query;

public record GetAllBillQuery() : IRequest<IEnumerable<VmBill>>;
public class GetAllBillQueryHandler : IRequestHandler<GetAllBillQuery, IEnumerable<VmBill>>
{
    private readonly IBillRepository _BillRepository;

    public GetAllBillQueryHandler(IBillRepository BillRepository, IMapper mapper)
    {
        _BillRepository = BillRepository;

    }
    public async Task<IEnumerable<VmBill>> Handle(GetAllBillQuery request, CancellationToken cancellationToken)
    {
        var result = await _BillRepository.GetList();
        return result;
    }
}
