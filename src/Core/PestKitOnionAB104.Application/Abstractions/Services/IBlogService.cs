using PestKitOnionAB104.Application.DTOs.Author;
using PestKitOnionAB104.Application.DTOs.Authors;
using PestKitOnionAB104.Application.DTOs.Blogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestKitOnionAB104.Application.Abstractions.Services
{
    public interface IBlogService
    {
        Task<ICollection<BlogItemDto>> GetAllAsync(int page, int take);
        Task<BlogGetDto> GetAsync(int id);
        Task CreateAsync(BlogCreateDto blogCreateDto);
        Task UpdateAsync(int id, BlogUpdateDto blogUpdateDto);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
    }
}
