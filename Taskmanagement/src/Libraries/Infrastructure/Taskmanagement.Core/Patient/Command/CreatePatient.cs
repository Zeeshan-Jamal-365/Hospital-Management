using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Patient.Command;

public record CreatePatient(VmPatient VmPatient) : IRequest<VmPatient>;
public class CreatePatientHandler : IRequestHandler<CreatePatient, VmPatient>
{
    private readonly IPatientRepository _ipatientRepository;
    private readonly IMapper _imapper;
    public CreatePatientHandler(IPatientRepository ipatientRepository, IMapper imapper)
    {
        _ipatientRepository = ipatientRepository;

        _imapper = imapper;

    }


    public async Task<VmPatient> Handle(CreatePatient request, CancellationToken cancellationToken)
    {
        var data = _imapper.Map<Model.Patient>(request.VmPatient);
        return await _ipatientRepository.Add(data);
    }
}
