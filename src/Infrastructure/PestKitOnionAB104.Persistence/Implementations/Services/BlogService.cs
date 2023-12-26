using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PestKitOnionAB104.Application.Abstractions.Repositories;
using PestKitOnionAB104.Application.Abstractions.Services;
using PestKitOnionAB104.Application.DTOs.Blogs;
using PestKitOnionAB104.Domain.Entities;

namespace PestKitOnionAB104.Persistence.Implementations.Services
{
    internal class BlogService : IBlogService
    {
        private readonly IBlogRepository _repository;
        private readonly IMapper _mapper;

        public BlogService(IBlogRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task CreateAsync(BlogCreateDto blogCreateDto)
        {

            await _repository.AddAsync(_mapper.Map<Blog>(blogCreateDto));
            await _repository.SaveChangesAsync();
        }

        public async Task<ICollection<BlogItemDto>> GetAllAsync(int page, int take)
        {
            ICollection<Blog> blogs = await _repository.GetAllWhere(skip: (page - 1) * take, take: take, IsTracking: false, isDeleted: true,includes:new string[] {"Author" }).ToListAsync();

            ICollection<BlogItemDto> blogItemDtos = _mapper.Map<ICollection<BlogItemDto>>(blogs);

            return blogItemDtos;
        }
        public async Task UpdateAsync(int id, BlogUpdateDto blogUpdateDto)
        {
            Blog blog = await _repository.GetByIdAsync(id);

            if (blog is null) throw new Exception("Not found");

            blog.Title = blogUpdateDto.Title;

            _repository.Update(blog);
            await _repository.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            Blog blog = await _repository.GetByIdAsync(id);

            if (blog is null) throw new Exception("Not found");

            _repository.Delete(blog);
            await _repository.SaveChangesAsync();
        }
        public async Task SoftDeleteAsync(int id)
        {
            Blog blog = await _repository.GetByIdAsync(id);

            if (blog is null) throw new Exception("Not found");
            _repository.SoftDelete(blog);
            await _repository.SaveChangesAsync();
        }
        public async Task<BlogGetDto> GetAsync(int id)
        {
            Blog blog = await _repository.GetByIdAsync(id:id, isDeleted: true, includes: new string[] { "Author" });

            if (blog is null) throw new Exception("Not found");
            var dto = _mapper.Map<BlogGetDto>(blog);

            return dto;
        }
    }
}
