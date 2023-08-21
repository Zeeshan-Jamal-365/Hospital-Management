using AutoMapper;
using Taskmanagement.Infrastructure;
using Taskmanagement.Model;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;
using Taskmanagement.Shared.CommonRepository;

namespace Taskmanagement.Repositories.Base;

public class BillRepository : RepositoryBase<Bill, VmBill, int>, IBillRepository
{
    public BillRepository(IMapper mapper, TaskmanagementDbContext dbContext) : base(mapper, dbContext)
    {
    }
}