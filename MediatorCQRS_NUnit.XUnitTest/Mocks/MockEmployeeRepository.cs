using MediatorCQRS_NUnit.Models;
using MediatorCQRS_NUnit.Services.Interface;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorCQRS_NUnit.XUnitTest.Mocks
{
    public static class MockEmployeeRepository
    {
        public static Mock<IRepository<Employee>> GetEmployeeRepository()
        {
            var employee = new List<Employee>
            {
                new Employee { Id = 1,EmployeeName="Rajan", Address="abc", EmployeeAge=30, EmployeeCode="110056"},
                new Employee { Id = 2,EmployeeName="Manju", Address="bcd", EmployeeAge=50, EmployeeCode="110067"},
                //new Employee { Id = 3,EmployeeName="Anil", Address="bcd", EmployeeAge=46, EmployeeCode="110068"}
            };
            var mockRepo = new Mock<IRepository<Employee>>();

            mockRepo.Setup(r => r.GetALL()).Returns(employee);
            return mockRepo;
        }
    }
}
