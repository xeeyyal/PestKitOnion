using AutoMapper;
using PestKitOnionAB104.Application.DTOs.Author;
using PestKitOnionAB104.Application.DTOs.Authors;
using PestKitOnionAB104.Domain.Entities;

namespace PestKitOnionAB104.Application.MappingProfiles
{
    public class AuthorProfile:Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorItemDto>().ReverseMap();
            CreateMap<Author, AuthorGetDto>().ReverseMap();
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<IncludeAuthorDto, Author>().ReverseMap();
        }
    }
}
