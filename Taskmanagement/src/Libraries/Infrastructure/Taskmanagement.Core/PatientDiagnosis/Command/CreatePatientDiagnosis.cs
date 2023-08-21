using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.PatientDiagnosis.Command;

public record CreatePatientDiagnosis(VmPatientDiagnosis VmPatientDiagnosis) : IRequest<VmPatientDiagnosis>;
public class CreatePatientDiagnosisHandler : IRequestHandler<CreatePatientDiagnosis, VmPatientDiagnosis>
{
    private readonly IPatientDiagnosisRepository _ipatientDiagnosisRepository;
    private readonly IMapper _imapper;
    public CreatePatientDiagnosisHandler(IPatientDiagnosisRepository ipatientDiagnosisRepository, IMapper imapper)
    {
        _ipatientDiagnosisRepository = ipatientDiagnosisRepository;

        _imapper = imapper;

    }


    public async Task<VmPatientDiagnosis> Handle(CreatePatientDiagnosis request, CancellationToken cancellationToken)
    {
        var data = _imapper.Map<Model.PatientDiagnosis>(request.VmPatientDiagnosis);
        return await _ipatientDiagnosisRepository.Add(data);
    }
}
