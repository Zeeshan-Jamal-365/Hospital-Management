using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.PatientDiagnosis.Query;

public record GetAllPatientDiagnosisQuery() : IRequest<IEnumerable<VmPatientDiagnosis>>;
public class GetAllPatientDiagnosisQueryHandler : IRequestHandler<GetAllPatientDiagnosisQuery, IEnumerable<VmPatientDiagnosis>>
{
    private readonly IPatientDiagnosisRepository _PatientDiagnosisRepository;

    public GetAllPatientDiagnosisQueryHandler(IPatientDiagnosisRepository PatientDiagnosisRepository, IMapper mapper)
    {
        _PatientDiagnosisRepository = PatientDiagnosisRepository;

    }
    public async Task<IEnumerable<VmPatientDiagnosis>> Handle(GetAllPatientDiagnosisQuery request, CancellationToken cancellationToken)
    {
        var result = await _PatientDiagnosisRepository.GetList();
        return result;
    }
}
