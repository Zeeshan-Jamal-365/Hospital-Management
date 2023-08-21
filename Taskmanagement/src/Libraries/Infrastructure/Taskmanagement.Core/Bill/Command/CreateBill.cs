﻿using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Bill.Command;

public record CreateBill(VmBill VmBill) : IRequest<VmBill>;
public class CreateBillHandler : IRequestHandler<CreateBill, VmBill>
{
    private readonly IBillRepository _ibillRepository;
    private readonly IMapper _imapper;
    public CreateBillHandler(IBillRepository ibillRepository, IMapper imapper)
    {
        _ibillRepository = ibillRepository;

        _imapper = imapper;

    }


    public async Task<VmBill> Handle(CreateBill request, CancellationToken cancellationToken)
    {
        var data = _imapper.Map<Model.Bill>(request.VmBill);
        return await _ibillRepository.Add(data);
    }
}
