using AutoMapper;
using Taskmanagement.Infrastructure;
using Taskmanagement.Model;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;
using Taskmanagement.Shared.CommonRepository;

namespace Taskmanagement.Repositories.Base;

public class PatientRepository : RepositoryBase<Patient, VmPatient, int>, IPatientRepository
{
    public PatientRepository(IMapper mapper, TaskmanagementDbContext dbContext) : base(mapper, dbContext)
    {
    }
}