using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Staff.Command;

public record UpdateStaff(int Id, VmStaff VmStaff) : IRequest<VmStaff>;
public class UpdateStaffHandler : IRequestHandler<UpdateStaff, VmStaff>
{
    private readonly IStaffRepository _istaffRepository;
    private readonly IMapper _imapper;

    public UpdateStaffHandler(IStaffRepository istaffRepository, IMapper imapper)
    {
        _istaffRepository = istaffRepository;
        _imapper = imapper;
    }
    public async Task<VmStaff> Handle(UpdateStaff request, CancellationToken cancellationToken)
    {
        var data = _imapper.Map<Model.Staff>(request.VmStaff);
        return await _istaffRepository.Update(request.Id, data);
    }
}
