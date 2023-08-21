using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Bill.Command;

public record DeleteBill(int Id) : IRequest<VmBill>;
public class DeleteBillHandler : IRequestHandler<DeleteBill, VmBill>
{
    private readonly IBillRepository _ibillRepository;

    public DeleteBillHandler(IBillRepository ibillRepository)
    {
        _ibillRepository = ibillRepository;
    }


    public async Task<VmBill> Handle(DeleteBill request, CancellationToken cancellationToken)
    {

        return await _ibillRepository.Delete(request.Id);
    }
}
