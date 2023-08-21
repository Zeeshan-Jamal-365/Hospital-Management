using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Patient.Query;

public record GetAllPatientQuery() : IRequest<IEnumerable<VmPatient>>;
public class GetAllPatientQueryHandler : IRequestHandler<GetAllPatientQuery, IEnumerable<VmPatient>>
{
    private readonly IPatientRepository _PatientRepository;

    public GetAllPatientQueryHandler(IPatientRepository PatientRepository, IMapper mapper)
    {
        _PatientRepository = PatientRepository;

    }
    public async Task<IEnumerable<VmPatient>> Handle(GetAllPatientQuery request, CancellationToken cancellationToken)
    {
        var result = await _PatientRepository.GetList();
        return result;
    }
}
