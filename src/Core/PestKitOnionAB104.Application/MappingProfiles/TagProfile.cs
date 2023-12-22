using AutoMapper;
using PestKitOnionAB104.Application.DTOs.Tag;
using PestKitOnionAB104.Domain.Entities;

namespace PestKitOnionAB104.Application.MappingProfiles
{
    public class TagProfile : Profile
    {
        public TagProfile()
        {
            CreateMap<Tag, TagItemDto>();
            CreateMap<TagCreateDto, Tag>();
        }
    }
}
