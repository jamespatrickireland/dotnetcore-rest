using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models;

namespace App.REST.Interfaces
{
    public interface IEmployeeProvider
    {
        string GetEmployeeName();
        Employee GetEmployee();
    }
}
