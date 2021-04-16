using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient HttpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.HttpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await HttpClient.GetJsonAsync<Employee[]>("api/employees");
        }
    }
}

