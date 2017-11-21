using App.Repo;
using App.Repo.Interfaces;
using App.REST.Interfaces;
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.REST.Providers
{
    public class EmployeeProvider : IEmployeeProvider
    {
        private IEmployeeRepo _employeeRepo;
        public EmployeeProvider(IEmployeeRepo empRepo)
        {
            _employeeRepo = empRepo;
        }

        public string GetEmployeeName()
        {
           return _employeeRepo.GetEmployeeName();
        }

        public Employee GetEmployee()
        {
            return _employeeRepo.GetEmployee();
        }
    }
}
