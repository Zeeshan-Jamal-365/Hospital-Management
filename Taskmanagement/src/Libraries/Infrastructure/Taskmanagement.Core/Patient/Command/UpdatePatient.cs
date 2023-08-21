using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Patient.Command;

public record UpdatePatient(int Id, VmPatient VmPatient) : IRequest<VmPatient>;
public class UpdatePatientHandler : IRequestHandler<UpdatePatient, VmPatient>
{
    private readonly IPatientRepository _ipatientRepository;
    private readonly IMapper _imapper;

    public UpdatePatientHandler(IPatientRepository ipatientRepository, IMapper imapper)
    {
        _ipatientRepository = ipatientRepository;
        _imapper = imapper;
    }
    public async Task<VmPatient> Handle(UpdatePatient request, CancellationToken cancellationToken)
    {
        var data = _imapper.Map<Model.Patient>(request.VmPatient);
        return await _ipatientRepository.Update(request.Id, data);
    }
}
