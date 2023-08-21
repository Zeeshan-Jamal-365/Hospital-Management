using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Doctor.Query;

public record GetAllDoctorQuery() : IRequest<IEnumerable<VmDoctor>>;
public class GetAllDoctorQueryHandler : IRequestHandler<GetAllDoctorQuery, IEnumerable<VmDoctor>>
{
    private readonly IDoctorRepository _DoctorRepository;

    public GetAllDoctorQueryHandler(IDoctorRepository DoctorRepository, IMapper mapper)
    {
        _DoctorRepository = DoctorRepository;

    }
    public async Task<IEnumerable<VmDoctor>> Handle(GetAllDoctorQuery request, CancellationToken cancellationToken)
    {
        var result = await _DoctorRepository.GetList();
        return result;
    }
}
