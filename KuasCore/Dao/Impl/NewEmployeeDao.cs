
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao :  IEmployeeDao
    {
        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee employees1 = new Employee();
            employees1.Id = "Four";
            employees1.Name = "托比亞";
            employees1.Age = 30;
            employees.Add(employees1);

            Employee employees2 = new Employee();
            employees2.Id = "PaulWalker";
            employees2.Name = "保羅沃克";
            employees2.Age = 40;
            employees.Add(employees2);

            return employees;
        }
        

    }
}
