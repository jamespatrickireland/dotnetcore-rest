using App.Models;
using App.REST.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.REST.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private IEmployeeProvider _employeeProvider;
        public EmployeeController(IEmployeeProvider empProvider)
        {
            _employeeProvider = empProvider;
        }

        [HttpGet]
        public Employee Get()
        {
            return _employeeProvider.GetEmployee();
        }



    }
}
