﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PestKitOnionAB104.Application.Abstractions.Repositories;
using PestKitOnionAB104.Application.Abstractions.Services;
using PestKitOnionAB104.Application.DTOs.Employee;
using PestKitOnionAB104.Domain.Entities;

namespace PestKitOnionAB104.Persistence.Implementations.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IPositionRepository _positionRepository;
        private readonly IEmployeeRepository _repository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository repository, IDepartmentRepository departmentRepository, IMapper mapper, IPositionRepository positionRepository)
        {
            _departmentRepository = departmentRepository;
            _positionRepository = positionRepository;
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<IEnumerable<EmployeeItemDto>> GetAllPaginatedAsync(int page, int take)
        {
            IEnumerable<EmployeeItemDto> dtos = _mapper.Map<IEnumerable<EmployeeItemDto>>(
                await _repository.GetAllWhere(skip: (page - 1) * take, take: take, IsTracking: false).ToArrayAsync()
                );
            return dtos;
        }
        public async Task<EmployeeGetDto> GetByIdAsync(int id)
        {
            Employee employee = await _repository.GetByIdAsync(id, includes: new string[] { nameof(Employee.Department), nameof(Employee.Position) });
            EmployeeGetDto dto = _mapper.Map<EmployeeGetDto>(employee);
            return dto;
        }
    }
}
