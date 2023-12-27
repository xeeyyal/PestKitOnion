using AutoMapper;
using PestKitOnionAB104.Application.DTOs.Users;
using PestKitOnionAB104.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestKitOnionAB104.Application.MappingProfiles
{
    internal class AppUserProfile:Profile
    {
        public AppUserProfile()
        {
            CreateMap<RegisterDto,AppUser>().ReverseMap();
        }
    }
}
