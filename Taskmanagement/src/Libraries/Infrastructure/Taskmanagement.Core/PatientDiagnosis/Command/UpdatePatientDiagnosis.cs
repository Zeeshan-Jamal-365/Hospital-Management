using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.PatientDiagnosis.Command;

public record UpdatePatientDiagnosis(int Id, VmPatientDiagnosis VmPatientDiagnosis) : IRequest<VmPatientDiagnosis>;
public class UpdatePatientDiagnosisHandler : IRequestHandler<UpdatePatientDiagnosis, VmPatientDiagnosis>
{
    private readonly IPatientDiagnosisRepository _ipatientDiagnosisRepository;
    private readonly IMapper _imapper;

    public UpdatePatientDiagnosisHandler(IPatientDiagnosisRepository ipatientDiagnosisRepository, IMapper imapper)
    {
        _ipatientDiagnosisRepository = ipatientDiagnosisRepository;
        _imapper = imapper;
    }
    public async Task<VmPatientDiagnosis> Handle(UpdatePatientDiagnosis request, CancellationToken cancellationToken)
    {
        var data = _imapper.Map<Model.PatientDiagnosis>(request.VmPatientDiagnosis);
        return await _ipatientDiagnosisRepository.Update(request.Id, data);
    }
}
