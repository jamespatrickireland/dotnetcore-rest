using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Repo.Interfaces
{
    public interface IEmployeeRepo
    {
        string GetEmployeeName();
        Employee GetEmployee();
    }
}
