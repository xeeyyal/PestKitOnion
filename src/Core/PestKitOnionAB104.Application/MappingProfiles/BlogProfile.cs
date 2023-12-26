using AutoMapper;
using PestKitOnionAB104.Application.DTOs.Blogs;
using PestKitOnionAB104.Domain.Entities;

namespace PestKitOnionAB104.Application.MappingProfiles
{
    public class BlogProfile : Profile
    {
        public BlogProfile()
        {
            CreateMap<Blog, BlogCreateDto>().ReverseMap();
            CreateMap<Blog, BlogItemDto>().ReverseMap();
            CreateMap<Blog, BlogGetDto>().ReverseMap();
            CreateMap<Blog, BlogUpdateDto>().ReverseMap();
            CreateMap<Blog, IncludeBlogDto>().ReverseMap();
        }
    }
}
