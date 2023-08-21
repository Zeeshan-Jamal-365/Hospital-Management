using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.PatientDiagnosis.Command;

public record DeletePatientDiagnosis(int Id) : IRequest<VmPatientDiagnosis>;
public class DeletePatientDiagnosisHandler : IRequestHandler<DeletePatientDiagnosis, VmPatientDiagnosis>
{
    private readonly IPatientDiagnosisRepository _ipatientDiagnosisRepository;

    public DeletePatientDiagnosisHandler(IPatientDiagnosisRepository ipatientDiagnosisRepository)
    {
        _ipatientDiagnosisRepository = ipatientDiagnosisRepository;
    }


    public async Task<VmPatientDiagnosis> Handle(DeletePatientDiagnosis request, CancellationToken cancellationToken)
    {

        return await _ipatientDiagnosisRepository.Delete(request.Id);
    }
}
