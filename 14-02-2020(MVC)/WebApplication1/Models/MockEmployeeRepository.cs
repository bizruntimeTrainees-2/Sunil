using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {

        private List<Employee> _emploloyeeList;
        public MockEmployeeRepository()
        {
            _emploloyeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Marry", Department="Hr", Email="marry@gmail.com"},
                new Employee() {Id = 2, Name = "Harry", Department="Dev", Email="harry@gmail.com"},
                new Employee() {Id = 3, Name = "Sam", Department="QA", Email="sam@gmail.com"},
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _emploloyeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
