using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Doctor.Query;

public record GetDoctorById(int Id) : IRequest<VmDoctor>;

public class GetDoctorByIdHandler : IRequestHandler<GetDoctorById, VmDoctor>
{


    private readonly IDoctorRepository _doctorRepository;
    public GetDoctorByIdHandler(IDoctorRepository doctorRepository)
    {
        _doctorRepository = doctorRepository;

    }

    public async Task<VmDoctor> Handle(GetDoctorById request, CancellationToken cancellationToken)
    {
        return await _doctorRepository.GetById(request.Id);
    }



}
