using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Staff.Query;

public record GetStaffById(int Id) : IRequest<VmStaff>;

public class GetStaffByIdHandler : IRequestHandler<GetStaffById, VmStaff>
{


    private readonly IStaffRepository _staffRepository;
    public GetStaffByIdHandler(IStaffRepository staffRepository)
    {
        _staffRepository = staffRepository;

    }

    public async Task<VmStaff> Handle(GetStaffById request, CancellationToken cancellationToken)
    {
        return await _staffRepository.GetById(request.Id);
    }



}
