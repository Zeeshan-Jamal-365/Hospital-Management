using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Staff.Command;

public record DeleteStaff(int Id) : IRequest<VmStaff>;
public class DeleteStaffHandler : IRequestHandler<DeleteStaff, VmStaff>
{
    private readonly IStaffRepository _istaffRepository;

    public DeleteStaffHandler(IStaffRepository istaffRepository)
    {
        _istaffRepository = istaffRepository;
    }


    public async Task<VmStaff> Handle(DeleteStaff request, CancellationToken cancellationToken)
    {

        return await _istaffRepository.Delete(request.Id);
    }
}
