using AutoMapper;
using Taskmanagement.Infrastructure;
using Taskmanagement.Model;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;
using Taskmanagement.Shared.CommonRepository;

namespace Taskmanagement.Repositories.Base;

public class StaffRepository : RepositoryBase<Staff, VmStaff, int>, IStaffRepository
{
    public StaffRepository(IMapper mapper, TaskmanagementDbContext dbContext) : base(mapper, dbContext)
    {
    }
}