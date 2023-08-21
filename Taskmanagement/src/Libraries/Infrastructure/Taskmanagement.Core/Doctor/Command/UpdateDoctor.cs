using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Doctor.Command;

public record UpdateDoctor(int Id, VmDoctor VmDoctor) : IRequest<VmDoctor>;
public class UpdateDoctorHandler : IRequestHandler<UpdateDoctor, VmDoctor>
{
    private readonly IDoctorRepository _idoctorRepository;
    private readonly IMapper _imapper;

    public UpdateDoctorHandler(IDoctorRepository idoctorRepository, IMapper imapper)
    {
        _idoctorRepository = idoctorRepository;
        _imapper = imapper;
    }
    public async Task<VmDoctor> Handle(UpdateDoctor request, CancellationToken cancellationToken)
    {
        var data = _imapper.Map<Model.Doctor>(request.VmDoctor);
        return await _idoctorRepository.Update(request.Id, data);
    }
}
