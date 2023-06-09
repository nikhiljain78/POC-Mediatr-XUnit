using MediatorCQRS_NUnit.Services.Interface;
using Moq;
using MediatorCQRS_NUnit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorCQRS_NUnit.XUnitTest.Mocks;
using MediatorCQRS_NUnit.Application.Queries.Handler;
using MediatorCQRS_NUnit.Application.Queries;
using Shouldly;

namespace MediatorCQRS_NUnit.XUnitTest.Employees.Queries
{
    
    public class GetEmployeesListQueryHandlerTests
    {
        private readonly Mock<IRepository<Employee>> _mockRepo;
        public GetEmployeesListQueryHandlerTests()
        {
            _mockRepo = MockEmployeeRepository.GetEmployeeRepository();
        }
        [Fact]
        public async Task GetEmployeesListTests()
        {
            var handler = new GetEmployeeQueryHandler(_mockRepo.Object);
            var result = await handler.Handle(new GetEmployeeQuery(), CancellationToken.None);
            result.ShouldBeOfType<List<Employee>>();
            result.Count.ShouldBe(2);
           
        }
    }
}
