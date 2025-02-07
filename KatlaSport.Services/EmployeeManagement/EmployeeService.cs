﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using KatlaSport.DataAccess;
using KatlaSport.DataAccess.EmployeeCatalogue;

namespace KatlaSport.Services.EmployeeManagement
{
    /// <inheritdoc/>
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeCatalogueContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeService"/> class with specified <see cref="IEmployeeCatalogueContext"/>.
        /// </summary>
        /// <param name="context">A <see cref="IEmployeeCatalogueContext"/>.</param>
        /// <param name="userContext">A <see cref="IUserContext"/>.</param>
        public EmployeeService(IEmployeeCatalogueContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <inheritdoc/>
        public async Task<List<EmployeeListItem>> GetEmployeesAsync(int start, int amount)
        {
            var dbEmployees = await _context.Employees.OrderBy(c => c.Id).Skip(start).Take(amount).ToListAsync();
            return dbEmployees.Select(c => Mapper.Map<EmployeeListItem>(c)).ToList();
        }

        /// <inheritdoc/>
        public async Task<List<EmployeeListItem>> GetSubordinateEmployeesAsync(int start, int amount, int bossId)
        {
            int? boss = bossId == 0 ? null : (int?)bossId;
            var dbEmployees = await _context.Employees.Where(c => c.BossId == boss).OrderBy(c => c.Id).Skip(start).Take(amount).ToListAsync();
            return dbEmployees.Select(c => Mapper.Map<EmployeeListItem>(c)).ToList();
        }

        /// <inheritdoc/>
        public async Task<Employee> GetEmployeeAsync(int employeeId)
        {
            var dbEmployees = await _context.Employees.Where(c => c.Id == employeeId).ToArrayAsync();
            if (dbEmployees.Length == 0)
            {
                throw new RequestedResourceNotFoundException();
            }

            return Mapper.Map<StoreEmployee, Employee>(dbEmployees[0]);
        }
    }
}