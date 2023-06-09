using MediatorCQRS_NUnit.Models;
using MediatR;

namespace MediatorCQRS_NUnit.Application.Queries
{
    
    public class GetEmployeeQuery:IRequest<List<Employee>>
    {
        
    }
}
