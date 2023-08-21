using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Doctor.Command;

public record DeleteDoctor(int Id) : IRequest<VmDoctor>;
public class DeleteDoctorHandler : IRequestHandler<DeleteDoctor, VmDoctor>
{
    private readonly IDoctorRepository _idoctorRepository;

    public DeleteDoctorHandler(IDoctorRepository idoctorRepository)
    {
        _idoctorRepository = idoctorRepository;
    }


    public async Task<VmDoctor> Handle(DeleteDoctor request, CancellationToken cancellationToken)
    {

        return await _idoctorRepository.Delete(request.Id);
    }
}
