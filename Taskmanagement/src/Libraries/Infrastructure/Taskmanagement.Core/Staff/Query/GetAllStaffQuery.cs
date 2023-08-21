using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Staff.Query;

public record GetAllStaffQuery() : IRequest<IEnumerable<VmStaff>>;
public class GetAllStaffQueryHandler : IRequestHandler<GetAllStaffQuery, IEnumerable<VmStaff>>
{
    private readonly IStaffRepository _StaffRepository;

    public GetAllStaffQueryHandler(IStaffRepository StaffRepository, IMapper mapper)
    {
        _StaffRepository = StaffRepository;

    }
    public async Task<IEnumerable<VmStaff>> Handle(GetAllStaffQuery request, CancellationToken cancellationToken)
    {
        var result = await _StaffRepository.GetList();
        return result;
    }
}
