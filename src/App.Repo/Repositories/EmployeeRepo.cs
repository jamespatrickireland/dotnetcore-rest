using App.Models;
using App.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Repo
{
    public class EmployeeRepo : IEmployeeRepo
    {
        public string GetEmployeeName()
        {
            return "Ben";
        }

        public Employee GetEmployee()
        {
            Employee bob = new Employee();
            bob.id = 44;
            bob.name = "Bob";
            return bob;
        }

        public BasicMessage GetBasic()
        {
            BasicMessage mes = new BasicMessage();
            mes.Message = "repo stuff";
            return mes;
        }
    }
}
