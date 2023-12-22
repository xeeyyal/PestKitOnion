using PestKitOnionAB104.Application.DTOs.Department;

namespace PestKitOnionAB104.Application.Abstractions.Services
{
    public interface IDepartmentService
    {
        Task<ICollection<DepartmentItemDto>> GetAllAsync(int page, int take);
        //Task<GetCategoryDto> GetAsync(int id);
        Task CreateAsync(DepartmentCreateDto departmentCreateDto);
        Task UpdateAsync(int id, DepartmentUpdateDto departmentUpdateDto);
        Task DeleteAsync(int id);
    }
}
