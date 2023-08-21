﻿using Taskmanagement.Model;
using Taskmanagement.Services.Model;
using Taskmanagement.Shared.CommonRepository;

namespace Taskmanagement.Repositories.Interface
{
    public interface IBillRepository : IRepository<Bill, VmBill, int>
    {
    }
}
