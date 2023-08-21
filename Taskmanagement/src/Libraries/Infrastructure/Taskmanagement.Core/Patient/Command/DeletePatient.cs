using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Patient.Command;

public record DeletePatient(int Id) : IRequest<VmPatient>;
public class DeletePatientHandler : IRequestHandler<DeletePatient, VmPatient>
{
    private readonly IPatientRepository _ipatientRepository;

    public DeletePatientHandler(IPatientRepository ipatientRepository)
    {
        _ipatientRepository = ipatientRepository;
    }


    public async Task<VmPatient> Handle(DeletePatient request, CancellationToken cancellationToken)
    {

        return await _ipatientRepository.Delete(request.Id);
    }
}
