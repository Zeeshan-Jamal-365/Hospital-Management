using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Patient.Query;

public record GetPatientById(int Id) : IRequest<VmPatient>;

public class GetPatientByIdHandler : IRequestHandler<GetPatientById, VmPatient>
{


    private readonly IPatientRepository _patientRepository;
    public GetPatientByIdHandler(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;

    }

    public async Task<VmPatient> Handle(GetPatientById request, CancellationToken cancellationToken)
    {
        return await _patientRepository.GetById(request.Id);
    }



}
