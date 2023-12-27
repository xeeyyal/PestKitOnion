using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PestKitOnionAB104.Application.Abstractions.Services;
using PestKitOnionAB104.Application.DTOs.Users;
using PestKitOnionAB104.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestKitOnionAB104.Persistence.Implementations.Services
{
    internal class AuthenticationService:IAuthenticationService
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly UserManager<AppUser> _userManager;

        public AuthenticationService(IMapper mapper, IConfiguration configuration, UserManager<AppUser> userManager)
        {
            _mapper = mapper;
            _configuration = configuration;
            _userManager = userManager;
        }

        public async Task Register(RegisterDto registerDto)
        {
            AppUser? user = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName == registerDto.UserName || u.Email == registerDto.Email);
            if (user is not null) throw new Exception("User already exist");
            user = _mapper.Map<AppUser>(registerDto);

            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (!result.Succeeded)
            {
                StringBuilder message = new StringBuilder();
                foreach (var error in result.Errors)
                {
                    message.AppendLine(error.Description);
                }
                throw new Exception(message.ToString());
            }
        }
    }
}
