using AutoMapper;
using DataAccessEmployee = KatlaSport.DataAccess.EmployeeCatalogue.StoreEmployee;

namespace KatlaSport.Services.EmployeeManagement
{
    public class EmployeeManagementMappingProfile : Profile
    {
        public EmployeeManagementMappingProfile()
        {
            CreateMap<DataAccessEmployee, EmployeeListItem>()
                .ForMember(r => r.Position, opt => opt.MapFrom(p => p.EmployeePosition.Name));
            CreateMap<DataAccessEmployee, Employee>()
                .ForMember(r => r.Position, opt => opt.MapFrom(p => p.EmployeePosition.Name))
                .ForMember(r => r.WorkPlaceAddress,
                    opt => opt.MapFrom(p => $"{p.EmployeePlace.City}, {p.EmployeePlace.Street}, {p.EmployeePlace.HouseNumber}"));
        }
    }
}