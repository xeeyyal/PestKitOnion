using PestKitOnionAB104.Application.DTOs.Position;
using PestKitOnionAB104.Application.DTOs.Tag;

namespace PestKitOnionAB104.Application.Abstractions.Services
{
    public interface IPositionService
    {
        Task<ICollection<PositionItemDto>> GetAllAsync(int page, int take);
        //Task<GetCategoryDto> GetAsync(int id);
        Task CreateAsync(PositionCreateDto positionCreateDto);
        Task UpdateAsync(int id, PositionUpdateDto positionUpdateDto);
        Task DeleteAsync(int id);
    }
}
