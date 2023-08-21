using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.PatientDiagnosis.Query;

public record GetPatientDiagnosisById(int Id) : IRequest<VmPatientDiagnosis>;

public class GetPatientDiagnosisByIdHandler : IRequestHandler<GetPatientDiagnosisById, VmPatientDiagnosis>
{


    private readonly IPatientDiagnosisRepository _billRepository;
    public GetPatientDiagnosisByIdHandler(IPatientDiagnosisRepository billRepository)
    {
        _billRepository = billRepository;

    }

    public async Task<VmPatientDiagnosis> Handle(GetPatientDiagnosisById request, CancellationToken cancellationToken)
    {
        return await _billRepository.GetById(request.Id);
    }



}
