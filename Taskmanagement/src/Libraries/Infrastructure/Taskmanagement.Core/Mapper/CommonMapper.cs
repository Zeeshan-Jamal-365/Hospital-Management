using AutoMapper;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Mapper;
public class CommonMapper : Profile
{
    public CommonMapper()
    {
        CreateMap<VmDoctor, Model.Doctor>().ReverseMap();
        CreateMap<VmBill, Model.Bill>().ReverseMap();
        CreateMap<VmPatient, Model.Patient>().ReverseMap();
        CreateMap<VmPatientDiagnosis, Model.PatientDiagnosis>().ReverseMap();
        CreateMap<VmStaff, Model.Staff>().ReverseMap();

    }
}
