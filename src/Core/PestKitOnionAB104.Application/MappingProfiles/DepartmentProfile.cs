using AutoMapper;
using PestKitOnionAB104.Application.DTOs.Department;
using PestKitOnionAB104.Application.DTOs.Departments;
using PestKitOnionAB104.Domain.Entities;

namespace PestKitOnionAB104.Application.MappingProfiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department, DepartmentItemDto>().ReverseMap();
            CreateMap<Department, DepartmentGetDto>().ReverseMap();
            CreateMap<DepartmentCreateDto, Department>().ReverseMap();
            CreateMap<Department, IncludeDepartmentDto>().ReverseMap();
        }
    }
}
