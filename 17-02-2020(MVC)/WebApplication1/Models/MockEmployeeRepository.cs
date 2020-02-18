using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees;
        public MockEmployeeRepository()
        {
            _employees = new List<Employee>()
            {
                new  Employee(){Id=1, Name="Harry", Designation="Hr", Email="harry@gmail.com"},
                new  Employee(){Id=1, Name="Marry", Designation="DEV", Email="marry@gmail.com"},
                new  Employee(){Id=1, Name="Jokey", Designation="QA", Email="jokey@gmail.com"},
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employees.FirstOrDefault<Employee>();
        }
        
    }
}
