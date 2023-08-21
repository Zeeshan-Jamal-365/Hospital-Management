using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Staff.Command;

public record CreateStaff(VmStaff VmStaff) : IRequest<VmStaff>;
public class CreateStaffHandler : IRequestHandler<CreateStaff, VmStaff>
{
    private readonly IStaffRepository _istaffRepository;
    private readonly IMapper _imapper;
    public CreateStaffHandler(IStaffRepository istaffRepository, IMapper imapper)
    {
        _istaffRepository = istaffRepository;

        _imapper = imapper;

    }


    public async Task<VmStaff> Handle(CreateStaff request, CancellationToken cancellationToken)
    {
        var data = _imapper.Map<Model.Staff>(request.VmStaff);
        return await _istaffRepository.Add(data);
    }
}
