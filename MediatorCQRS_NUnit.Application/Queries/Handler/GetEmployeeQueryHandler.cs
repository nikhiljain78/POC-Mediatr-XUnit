using MediatorCQRS_NUnit.Models;
using MediatR;
using MediatorCQRS_NUnit.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorCQRS_NUnit.Services.Interface;
using MediatorCQRS_NUnit.Services.Implementation;
using Azure.Core;

namespace MediatorCQRS_NUnit.Application.Queries.Handler
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery, List<Employee>>
    {
        private readonly IRepository<Employee> _repository;

        public GetEmployeeQueryHandler(IRepository<Employee> repository)
        {
            _repository = repository;
        }
        public async Task<List<Employee>> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            var result = _repository.GetALL();
            return result;
        }
    }
}
