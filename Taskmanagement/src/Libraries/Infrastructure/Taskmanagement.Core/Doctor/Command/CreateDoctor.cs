using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Doctor.Command;

public record CreateDoctor(VmDoctor VmDoctor) : IRequest<VmDoctor>;
public class CreateDoctorHandler : IRequestHandler<CreateDoctor, VmDoctor>
{
    private readonly IDoctorRepository _idoctorRepository;
    private readonly IMapper _imapper;
    public CreateDoctorHandler(IDoctorRepository idoctorRepository, IMapper imapper)
    {
        _idoctorRepository = idoctorRepository;

        _imapper = imapper;

    }


    public async Task<VmDoctor> Handle(CreateDoctor request, CancellationToken cancellationToken)
    {
        var data = _imapper.Map<Model.Doctor>(request.VmDoctor);
        return await _idoctorRepository.Add(data);
    }
}
